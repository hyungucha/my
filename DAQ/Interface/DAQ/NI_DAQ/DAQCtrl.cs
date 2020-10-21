using NationalInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Data;
using System.Windows;
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.Threading;
using BaseDAQ;
using ni = NationalInstruments.DAQmx;
using SciChartWrapper.Views;
using NationalInstruments.DAQmx;

namespace NI_DAQ
{
    public class AcqVoltageInt : BaseDAQ.BasePropertyChanged, IDAQ  //Analog In
    {
        #region Private Member Variables

        // Create a new task
        private ni.Task _acqTask;

        private ObservableCollection<string> _acqVoltageInt_physicalChannels;
        private string _acqVoltageInt_selectedPhysicalChannel;
        private SciChartWrapper.Views.SciChartProfile2DView acqchart;

        private double _acqVoltageInt_SampleRate;
        private double _acqVoltageInt_RangeMinimum;
        private double _acqVoltageInt_RangeMaximum; 
        private int _acqVoltageInt_SamplesPerChannel;

        private ni.AnalogMultiChannelReader reader;
        private DataTable dataTable;
        private DataColumn[] _dataColumns;
        private AnalogWaveform<double>[] data;
        private float[] _profile;

        private const int _limit = 100;

        #endregion Private Member Variables

        #region Constructors

        public AcqVoltageInt()
        {
            AcqVoltageInt_physicalChannels = new ObservableCollection<string>();

            foreach (string channel in ni.DaqSystem.Local.GetPhysicalChannels(ni.PhysicalChannelTypes.AI, ni.PhysicalChannelAccess.External))
            {
                AcqVoltageInt_physicalChannels.Add(channel);
            }

            if (AcqVoltageInt_physicalChannels.Count > 0)
            {
                AcqVoltageInt_selectedPhysicalChannel = AcqVoltageInt_physicalChannels[0];
            }

            dataTable = new DataTable();

            _profile = new float[_limit];

            SetParam();
        }

        public void Initialize()
        {
        }

        #endregion Constructors

        #region Public Properties
        
        public void SetParam()
        {
            AcqVoltageInt_RangeMinimum = -10;
            AcqVoltageInt_RangeMaximum = 10;
            AcqVoltageInt_SamplesPerChannel = 100;
            AcqVoltageInt_SampleRate = 1000;
        }

        public ObservableCollection<string> AcqVoltageInt_physicalChannels 
        { 
            get => _acqVoltageInt_physicalChannels; 
            set => _acqVoltageInt_physicalChannels = value; 
        }

        public string AcqVoltageInt_selectedPhysicalChannel
        { 
            get => _acqVoltageInt_selectedPhysicalChannel; 
            set
            {
                _acqVoltageInt_selectedPhysicalChannel = value;
                OnPropertyChanged("GenVoltageUpdate_SelectedPhysicalChannel");
            }
        }

        public double AcqVoltageInt_RangeMinimum
        { 
            get => _acqVoltageInt_RangeMinimum;
            set
            {
                _acqVoltageInt_RangeMinimum = value;
                OnPropertyChanged("AcqVoltageInt_RangeMinimum");
            }
        }

        public double AcqVoltageInt_RangeMaximum
        { 
            get => _acqVoltageInt_RangeMaximum; 
            set
            {
                _acqVoltageInt_RangeMaximum = value;
                OnPropertyChanged("AcqVoltageInt_RangeMaximum");
            }
        }

        public double AcqVoltageInt_SampleRate
        {
            get => _acqVoltageInt_SampleRate;
            set
            {
                _acqVoltageInt_SampleRate = value;
                OnPropertyChanged("AcqVoltageInt_SampleRate");
            }
        }

        public int AcqVoltageInt_SamplesPerChannel
        { 
            get => _acqVoltageInt_SamplesPerChannel; 
            set
            {
                _acqVoltageInt_SamplesPerChannel = value;
                OnPropertyChanged("AcqVoltageInt_SamplesPerChannel");
            }
        }

        public SciChartProfile2DView Acqchart { get => acqchart; set => acqchart = value; }
        

        #endregion Public Properties

        #region Public Methods

        public void Start()
        {
            try
            {
                _acqTask = new ni.Task();

                // Create a channel
                _acqTask.AIChannels.CreateVoltageChannel(AcqVoltageInt_selectedPhysicalChannel, "",
                    (ni.AITerminalConfiguration)(-1), AcqVoltageInt_RangeMinimum, AcqVoltageInt_RangeMaximum, ni.AIVoltageUnits.Volts);

                // Configure timing specs    
                _acqTask.Timing.ConfigureSampleClock("", AcqVoltageInt_SampleRate, ni.SampleClockActiveEdge.Rising,
                    ni.SampleQuantityMode.FiniteSamples, AcqVoltageInt_SamplesPerChannel);

                // Verify the task
                _acqTask.Control(ni.TaskAction.Verify);

                // Prepare the table for data
                InitializeDataTable(_acqTask.AIChannels, ref dataTable);

                // Read the data
                reader = new ni.AnalogMultiChannelReader(_acqTask.Stream);

                data = reader.ReadWaveform(AcqVoltageInt_SamplesPerChannel);

                dataToDataTable(data, ref dataTable);
            }
            catch (ni.DaqException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                _acqTask.Dispose();
            }
        }

        public void Stop()
            {

            }

        private void dataToDataTable(AnalogWaveform<double>[] sourceArray, ref DataTable dataTable)
        {
            // Iterate over channels
            int currentLineIndex = 0;
            foreach (AnalogWaveform<double> waveform in sourceArray)
            {
                for (int sample = 0; sample < waveform.Samples.Count; ++sample)
                {
                    if (sample == _limit)
                        break;

                    _profile[sample] = (float)waveform.Samples[sample].Value;
                }
                currentLineIndex++;
            }
            Acqchart.SetData(_profile);
        }

        public void InitializeDataTable(ni.AIChannelCollection channelCollection, ref DataTable data)
        {
            int numOfChannels = channelCollection.Count;
            data.Rows.Clear();
            data.Columns.Clear();
            _dataColumns = new DataColumn[numOfChannels];
            int numOfRows = 10;

            for (int currentChannelIndex = 0; currentChannelIndex < numOfChannels; currentChannelIndex++)
            {
                _dataColumns[currentChannelIndex] = new DataColumn();
                _dataColumns[currentChannelIndex].DataType = typeof(double);
                _dataColumns[currentChannelIndex].ColumnName = channelCollection[currentChannelIndex].PhysicalName;
            }

            data.Columns.AddRange(_dataColumns);

            for (int currentDataIndex = 0; currentDataIndex < numOfRows; currentDataIndex++)
            {
                object[] rowArr = new object[numOfChannels];
                data.Rows.Add(rowArr);
            }
        }
        #endregion Public Methods
    }

    public class GenVoltageUpdate : BaseDAQ.BasePropertyChanged ,IDAQ //Analog Out Volt
    {
        #region Private Member Variables

        ni.Task _genVolUpdateTask;

        private ObservableCollection<string> _genVoltageUpdate_physicalChannels;
        private string _genVoltageUpdate_selectedPhysicalChannel;

        private double _genVoltageUpdate_MinimumValue;
        private double _genVoltageUpdate_MaximumValue;
        private double _genVoltageUpdate_VoltageOutput;

        #endregion Private Member Variables

        #region Constructors

        public GenVoltageUpdate()
        {
            GenVoltageUpdate_physicalChannels = new ObservableCollection<string>();

            foreach (string channel in ni.DaqSystem.Local.GetPhysicalChannels(ni.PhysicalChannelTypes.AI, ni.PhysicalChannelAccess.External))
            {
                GenVoltageUpdate_physicalChannels.Add(channel);
            }

            if (GenVoltageUpdate_physicalChannels.Count > 0)
            {
                GenVoltageUpdate_selectedPhysicalChannel = GenVoltageUpdate_physicalChannels[0];
            }

            SetParam();
        }
        
        public void Initialize()
        {

        }

        #endregion Constructors

        #region Public Properties
        public void SetParam()
        {
            GenVoltageUpdate_MinimumValue = 1;
            GenVoltageUpdate_MaximumValue = 2;
            GenVoltageUpdate_VoltageOutput = 3;
        }

        public ObservableCollection<string> GenVoltageUpdate_physicalChannels 
        { 
            get => _genVoltageUpdate_physicalChannels; 
            set => _genVoltageUpdate_physicalChannels = value; 
        }

        public string GenVoltageUpdate_selectedPhysicalChannel
        {
            get => _genVoltageUpdate_selectedPhysicalChannel;
            set
            {
                _genVoltageUpdate_selectedPhysicalChannel = value;
                OnPropertyChanged("GenVoltageUpdate_SelectedPhysicalChannel");
            }
        }

        public double GenVoltageUpdate_MinimumValue
        { 
            get => _genVoltageUpdate_MinimumValue; 
            set
            {
                _genVoltageUpdate_MinimumValue = value;
                OnPropertyChanged("GenVoltageUpdate_MinimumValue");
            }                      
        }
        
        public double GenVoltageUpdate_MaximumValue
        { 
            get => _genVoltageUpdate_MaximumValue; 
            set
            {
                _genVoltageUpdate_MaximumValue = value;
                OnPropertyChanged("GenVoltageUpdate_MaximumValue");
            }
        }
        
        public double GenVoltageUpdate_VoltageOutput
        { 
            get => _genVoltageUpdate_VoltageOutput; 
            set
            {
                _genVoltageUpdate_VoltageOutput = value;
                OnPropertyChanged("GenVoltageUpdate_VoltageOutput");
            }
        }



        #endregion Public Properties

        #region Public Methods
        public void Start()
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                using (_genVolUpdateTask = new ni.Task())   
                {
                    _genVolUpdateTask.AOChannels.CreateVoltageChannel(Convert.ToString(GenVoltageUpdate_physicalChannels), "aoChannel",
                        GenVoltageUpdate_MinimumValue, GenVoltageUpdate_MaximumValue, ni.AOVoltageUnits.Volts);

                    ni.AnalogSingleChannelWriter writer = new ni.AnalogSingleChannelWriter(_genVolUpdateTask.Stream);
                    writer.WriteSingleSample(true, GenVoltageUpdate_VoltageOutput);
                }
            }
            catch (ni.DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        public void Stop()
        {

        }

        #endregion Public Methods
    }

    public class ContGenVoltageWfm : BaseDAQ.BasePropertyChanged, IDAQ //Analog Out 
    {
        #region Private Member Variables

        private ni.Task _conGenVotageWfmTask;

        private ObservableCollection<string> _conGenVotageWfm_physicalChannels;
        private string _conGenVotageWfm_selectedPhysicalChannel;

        private ObservableCollection<string> _conGenVotageWfm_signalType;
        private string _conGenVotageWfm_selectedSignalType;


        private SciChartWrapper.Views.SciChartProfile2DView conGenVotageWfmChart;

        private double _conGenVotageWfm_Minimum;
        private double _conGenVotageWfm_Maximum;

        private string _conGenVotageWfm_Frequency;
        private string _conGenVotageWfm_SamplesPerBuffer;
        private string _conGenVotageWfm_CyclesPerBuffer;
        private string _conGenVotageWfm_SignalType;
        private string _conGenVotageWfm_Amplitude;

        private DispatcherTimer timer = new DispatcherTimer();

        #endregion Private Member Variables

        #region Constructors
        public ContGenVoltageWfm()
        {
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += new EventHandler(statusCheckTimer_Tick);

            //FunctionGenerator.InitComboBox( );

            ConGenVotageWfm_physicalChannels = new ObservableCollection<string>();

            foreach (string channel in ni.DaqSystem.Local.GetPhysicalChannels(ni.PhysicalChannelTypes.AI, ni.PhysicalChannelAccess.External))
            {
                ConGenVotageWfm_physicalChannels.Add(channel);
            }

            if (ConGenVotageWfm_physicalChannels.Count > 0)
            {
                ConGenVotageWfm_selectedPhysicalChannel = ConGenVotageWfm_physicalChannels[0];
            }

            SetParam();
        }
        #endregion Constructors

        #region Public Properties

        public void SetParam()
        {
            ConGenVotageWfm_Minimum = -10;
            ConGenVotageWfm_Maximum = 10;
            ConGenVotageWfm_Frequency = "1";
            ConGenVotageWfm_SamplesPerBuffer = "100";
            ConGenVotageWfm_CyclesPerBuffer = "100";
            ConGenVotageWfm_Amplitude = "10";
        }

        public ObservableCollection<string> ConGenVotageWfm_physicalChannels 
        { 
            get => _conGenVotageWfm_physicalChannels; 
            set => _conGenVotageWfm_physicalChannels = value;
        }
        
        public string ConGenVotageWfm_selectedPhysicalChannel 
        { 
            get => _conGenVotageWfm_selectedPhysicalChannel; 
            set
            {
                _conGenVotageWfm_selectedPhysicalChannel = value;
                OnPropertyChanged("ConGenVotageWfm_selectedPhysicalChannel");
            }
        }

        public ObservableCollection<string> ConGenVotageWfm_signalType 
        { 
            get => _conGenVotageWfm_signalType; 
            set => _conGenVotageWfm_signalType = value; 
        }
 
        public string ConGenVotageWfm_selectedSignalType 
        { 
            get => _conGenVotageWfm_selectedSignalType; 
            set
            {
                _conGenVotageWfm_selectedSignalType = value;
                OnPropertyChanged("ConGenVotageWfm_selectedSignalType");
            }
        }
                      
        public double ConGenVotageWfm_Minimum 
        { 
            get => _conGenVotageWfm_Minimum; 
            set  
            {
                _conGenVotageWfm_Minimum = value;
                OnPropertyChanged("ConGenVotageWfm_Minimum");
            }
        }
        
        public double ConGenVotageWfm_Maximum 
        { 
            get => _conGenVotageWfm_Maximum; 
            set 
            {
                _conGenVotageWfm_Maximum = value;
                OnPropertyChanged("ConGenVotageWfm_Maximum");
            }
        }

        public string ConGenVotageWfm_Frequency 
        { 
            get => _conGenVotageWfm_Frequency; 
            set 
            {
                _conGenVotageWfm_Frequency = value;
                OnPropertyChanged("ConGenVotageWfm_Frequency");
            }
        }

        public string ConGenVotageWfm_SamplesPerBuffer 
        { 
            get => _conGenVotageWfm_SamplesPerBuffer; 
            set 
            {
                _conGenVotageWfm_SamplesPerBuffer = value;
                OnPropertyChanged("ConGenVotageWfm_SamplesPerBuffer");
            }
        }

        public string ConGenVotageWfm_CyclesPerBuffer 
        { 
            get => _conGenVotageWfm_CyclesPerBuffer; 
            set  
            {
                _conGenVotageWfm_CyclesPerBuffer = value;
                OnPropertyChanged("ConGenVotageWfm_CyclesPerBuffer");
            }
        }

        public string ConGenVotageWfm_Amplitude 
        { 
            get => _conGenVotageWfm_Amplitude; 
            set  
            {
                _conGenVotageWfm_Amplitude = value;
                OnPropertyChanged("ConGenVotageWfm_Amplitude");
            }
        }

        public string ConGenVotageWfm_SignalType 
        { 
            get => _conGenVotageWfm_SignalType; 
            set 
            {
                _conGenVotageWfm_SignalType = value;
                OnPropertyChanged("ConGenVotageWfm_SignalType");
            }
        
        }

        public SciChartProfile2DView ConGenVotageWfmChart { get => conGenVotageWfmChart; set => conGenVotageWfmChart = value; }

        #endregion Public Properties

        #region Public Methods

        public void Start()
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                _conGenVotageWfmTask = new ni.Task();

                // create the task and channel
                _conGenVotageWfmTask.AOChannels.CreateVoltageChannel(ConGenVotageWfm_physicalChannels[0],
                    "",
                    ConGenVotageWfm_Minimum,
                    ConGenVotageWfm_Maximum,
                    ni.AOVoltageUnits.Volts);

                // verify the task before doing the waveform calculations
                _conGenVotageWfmTask.Control(ni.TaskAction.Verify);

                // calculate some waveform parameters and generate data
                FunctionGenerator fGen = new FunctionGenerator(
                    _conGenVotageWfmTask.Timing,
                    ConGenVotageWfm_Frequency,
                    ConGenVotageWfm_SamplesPerBuffer,
                    ConGenVotageWfm_CyclesPerBuffer,
                    ConGenVotageWfm_SignalType,
                    ConGenVotageWfm_Amplitude);

                // configure the sample clock with the calculated rate
                _conGenVotageWfmTask.Timing.ConfigureSampleClock("",
                    fGen.ResultingSampleClockRate,
                    ni.SampleClockActiveEdge.Rising,
                    ni.SampleQuantityMode.ContinuousSamples, 1000);


                ni.AnalogSingleChannelWriter writer =
                    new ni.AnalogSingleChannelWriter(_conGenVotageWfmTask.Stream);

                //write data to buffer
                writer.WriteMultiSample(false, fGen.Data);

                conGenVotageWfmChart.SetData(fGen.Data);

                //start writing out data
                _conGenVotageWfmTask.Start();

                //  btnStart.IsEnabled = false;
                //  btnStop.IsEnabled = true;


                timer.IsEnabled = true;
            }
            catch (ni.DaqException err)
            {
                timer.IsEnabled = false;
                MessageBox.Show(err.Message);
                _conGenVotageWfmTask.Dispose();
            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        public void Stop()
        {
            timer.IsEnabled = false;
            if (_conGenVotageWfmTask != null)
            {
                try
                {
                    _conGenVotageWfmTask.Stop();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                _conGenVotageWfmTask.Dispose();
                _conGenVotageWfmTask = null;
                //btnStart.IsEnabled = true;
                //btnStop.IsEnabled = false;
            }
        }

        private void statusCheckTimer_Tick(object sender, System.EventArgs e)
        {
            try
            {
                // Getting myTask.IsDone also checks for errors that would prematurely
                // halt the continuous generation.
                if (_conGenVotageWfmTask.IsDone)
                {
                    timer.IsEnabled = false;
                    _conGenVotageWfmTask.Stop();
                    _conGenVotageWfmTask.Dispose();
                    //btnStart.IsEnabled = true;
                    //btnStop.IsEnabled = false;
                }
            }
            catch (ni.DaqException ex)
            {
                timer.IsEnabled = false;
                System.Windows.MessageBox.Show(ex.Message);
                _conGenVotageWfmTask.Dispose();
                //btnStart.IsEnabled = true;
                //btnStop.IsEnabled = false;
            }
        }

        #endregion Public Methods
    }

    public class GenDigPulseTrain_Continuous : BaseDAQ.BasePropertyChanged, IDAQ //Counter
    {
        #region Private Member Variables

        private ni.Task _genDigPulseTrainContinuousTask; 

        private ObservableCollection<string> _genDigPulseTrainContinuous_physicalChannels;
        private string _genDigPulseTrainContinuous_selectedPhysicalChannel;

        private double _genDigPulseTrainContinuous_Frequency;
        private double _genDigPulseTrainContinuousDuty_Cycle;

        private ni.COPulseIdleState _idleState;
        private DispatcherTimer timer = new DispatcherTimer();

        #endregion Private Member Variables

        #region Constructors

        public GenDigPulseTrain_Continuous()
        {
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += new EventHandler(statusCheckTimer_Tick);

            GenDigPulseTrainContinuous_physicalChannels = new ObservableCollection<string>();

            foreach ( string channel in ni.DaqSystem.Local.GetPhysicalChannels( ni.PhysicalChannelTypes.AI, ni.PhysicalChannelAccess.External ) )
            {
                GenDigPulseTrainContinuous_physicalChannels.Add( channel );
            //GenDigPulseTrainContinuous_physicalChannels.Add("Dev1/PFI12");
            }

            if (GenDigPulseTrainContinuous_physicalChannels.Count > 0)
            {
                GenDigPulseTrainContinuous_selectedPhysicalChannel = GenDigPulseTrainContinuous_physicalChannels[0];
            }

            SetParam();
        }

        #endregion Constructors

        #region Public Properties

        public void SetParam()
        {
            GenDigPulseTrainContinuous_Frequency = 0;
            GenDigPulseTrainContinuousDuty_Cycle = 0;
        }

        public COPulseIdleState IdleState 
        { 
            get => _idleState; 
            set => _idleState = value; 
        }
        
        public double GenDigPulseTrainContinuous_Frequency 
        { 
            get => _genDigPulseTrainContinuous_Frequency; 
            set
            {
                _genDigPulseTrainContinuous_Frequency = value;
                OnPropertyChanged("GenDigPulseTrainContinuous_Frequency");
            }
        }
        
        public double GenDigPulseTrainContinuousDuty_Cycle
        {
            get => _genDigPulseTrainContinuousDuty_Cycle;
            set
            {
                _genDigPulseTrainContinuousDuty_Cycle = value;
                OnPropertyChanged("GenDigPulseTrainContinuousDuty_Cycle");
            }
        }
        
        public ObservableCollection<string> GenDigPulseTrainContinuous_physicalChannels 
        { 
            get => _genDigPulseTrainContinuous_physicalChannels; 
            set => _genDigPulseTrainContinuous_physicalChannels = value; 
        }
        
        public string GenDigPulseTrainContinuous_selectedPhysicalChannel 
        { 
            get => _genDigPulseTrainContinuous_selectedPhysicalChannel; 
            set
            {
                _genDigPulseTrainContinuous_selectedPhysicalChannel = value;
                OnPropertyChanged("GenDigPulseTrainContinuous_selectedPhysicalChannel");
            }
        }


        #endregion Public Properties

        #region Public Methods

        public void ChageLowIdleState()
        {
            IdleState = ni.COPulseIdleState.Low;
        }

        public void ChageHighIdleState()
        {
            IdleState = ni.COPulseIdleState.High;
        }

        public void Start()
        {
            try
            {
                _genDigPulseTrainContinuousTask = new ni.Task();

                //_genDigPulseTrainContinuousTask.COChannels.CreatePulseChannelFrequency(GenDigPulseTrainContinuous_selectedPhysicalChannel,
                //    "ContinuousPulseTrain", ni.COPulseFrequencyUnits.Hertz, IdleState, 0.0,
                //    GenDigPulseTrainContinuous_Frequency,
                //    GenDigPulseTrainContinuousDuty_Cycle);

                _genDigPulseTrainContinuousTask.COChannels.CreatePulseChannelFrequency( "Dev4/ctr0",
                     "ContinuousPulseTrain", ni.COPulseFrequencyUnits.Hertz, IdleState, 0.0,
                     GenDigPulseTrainContinuous_Frequency,
                     GenDigPulseTrainContinuousDuty_Cycle );

                _genDigPulseTrainContinuousTask.Timing.ConfigureImplicit(ni.SampleQuantityMode.ContinuousSamples, 1000);

                _genDigPulseTrainContinuousTask.Start();

                timer.IsEnabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                _genDigPulseTrainContinuousTask.Dispose();
                timer.IsEnabled = false;
            }
        }

        public void Stop()
        {
            timer.IsEnabled = false;
            _genDigPulseTrainContinuousTask.Stop();
            _genDigPulseTrainContinuousTask.Dispose();
        }

        private void statusCheckTimer_Tick(object sender, System.EventArgs e)
        {
            try
            {
                // Getting myTask.IsDone also checks for errors that would prematurely
                // halt the continuous generation.
                if (_genDigPulseTrainContinuousTask.IsDone)
                {
                    timer.IsEnabled = false;
                    _genDigPulseTrainContinuousTask.Stop();
                    _genDigPulseTrainContinuousTask.Dispose();
                }
            }
            catch (ni.DaqException ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                timer.IsEnabled = false;
                _genDigPulseTrainContinuousTask.Stop();
                _genDigPulseTrainContinuousTask.Dispose();
            }
        }

        #endregion Public Methods
    }
}
