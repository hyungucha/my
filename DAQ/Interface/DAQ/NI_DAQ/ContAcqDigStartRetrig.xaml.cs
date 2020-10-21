using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ni = NationalInstruments.DAQmx;
using NationalInstruments;
using System.Data;
using NationalInstruments.DAQmx;

namespace NI_DAQ
{
    /// <summary>
    /// ContAcqDigStartRetrig.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ContAcqDigStartRetrig : Window
    {
        private ni.AnalogMultiChannelReader analogInReader;
        private ni.Task myTask;
        private ni.Task runningTask;

        

        private AnalogWaveform<double>[] data;

        private DataColumn[] dataColumn = null;
        private DataTable dataTable = null;

        private float[] _profile;

        public ContAcqDigStartRetrig()
        {
            InitializeComponent();

            dataTable = new DataTable();

            _profile = new float[2500];

            physicalChannelComboBox.Items.Add(ni.DaqSystem.Local.GetPhysicalChannels(ni.PhysicalChannelTypes.AI, ni.PhysicalChannelAccess.External));
            if (physicalChannelComboBox.Items.Count > 0)
                physicalChannelComboBox.SelectedIndex = 0;

        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (runningTask != null)
            {
                runningTask.Stop();
                // Dispose of the task
                runningTask = null;
                btnStop.IsEnabled = false;
                btnStart.IsEnabled = true;
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            if (runningTask == null)
            {
                try
                {

                    btnStop.IsEnabled = true;
                    btnStart.IsEnabled = false;

                    double rangeMinimum = Convert.ToDouble(edminimum.Text);
                    double rangeMaximum = Convert.ToDouble(edmaximum.Text);
                    double sampleRate = Convert.ToDouble(edRate.Text);
                    int samplePerChannel = Convert.ToInt32(edchannel.Text);

                    // Create a new task
                    ni.Task myTask = new ni.Task();

                    // Create a virtual channel
                    myTask.AIChannels.CreateVoltageChannel(physicalChannelComboBox.Text, "",
                        (ni.AITerminalConfiguration)(-1), rangeMinimum,
                        rangeMaximum, ni.AIVoltageUnits.Volts);

                    // Configure the timing parameters
                    myTask.Timing.ConfigureSampleClock("", sampleRate,
                        ni.SampleClockActiveEdge.Rising, ni.SampleQuantityMode.FiniteSamples, samplePerChannel * 10);

                    myTask.Triggers.StartTrigger.ConfigureDigitalEdgeTrigger("/Dev1/PFI0", ni.DigitalEdgeStartTriggerEdge.Rising);

                    myTask.Triggers.StartTrigger.Retriggerable = true;

                    // Configure the Every N Samples Event
                    myTask.EveryNSamplesReadEventInterval = samplePerChannel;

                    myTask.EveryNSamplesRead += new EveryNSamplesReadEventHandler(myTask_EveryNSamplesRead);

                    // Verify the Task
                    myTask.Control(TaskAction.Verify);

                    // Prepare the table for Data
                    InitializeDataTable(myTask.AIChannels, ref dataTable);

                    runningTask = myTask;
                    analogInReader = new AnalogMultiChannelReader(myTask.Stream);
                    runningTask.SynchronizeCallbacks = true;

                    runningTask.Start();
                }
                catch (DaqException exception)
                {
                    // Display Errors
                    MessageBox.Show(exception.Message);
                    runningTask = null;
                    btnStop.IsEnabled = false;
                    btnStart.IsEnabled = true;
                }
            }
        }

        void myTask_EveryNSamplesRead(object sender, EveryNSamplesReadEventArgs e)
        {
            try
            {
                int samplePerChannel = Convert.ToInt32(edchannel.Text);

                // Read the available data from the channels
                data = analogInReader.ReadWaveform(samplePerChannel);

                // Plot your data here
                dataToDataTable(data, ref dataTable);

            }
            catch (DaqException exception)
            {
                // Display Errors
                MessageBox.Show(exception.Message);
                runningTask = null;
                myTask.Dispose();
                btnStop.IsEnabled = false;
                btnStart.IsEnabled = true;
            }
        }

        private void dataToDataTable(AnalogWaveform<double>[] sourceArray, ref DataTable dataTable)
        {
            // Iterate over channels
            string textvalue = "";

            

            int currentLineIndex = 0;
            foreach (AnalogWaveform<double> waveform in sourceArray)
            {
                for (int sample = 0; sample < waveform.Samples.Count; ++sample)
                {
                    if (sample == 2500)
                        break;

                    _profile[sample] = (float)waveform.Samples[sample].Value;

                    //savetest.Items.Add(Convert.ToString(_profile[sample]));

                    textvalue = textvalue + "\t" + Convert.ToString(_profile[sample]) ; 




                }
                currentLineIndex++;
            }

            string savepath = string.Format("D:/DAQC#/1/{0}test.text", count.Text);

            count.Text = Convert.ToString(Convert.ToInt32(count.Text) + 1);

            System.IO.File.WriteAllText(savepath, textvalue);

            //savetest.Items.Add(Convert.ToString(_profile));

            profileChart.SetData(_profile);
        }

        public void InitializeDataTable(AIChannelCollection channelCollection, ref DataTable data)
        {
            int numOfChannels = channelCollection.Count;
            data.Rows.Clear();
            data.Columns.Clear();
            dataColumn = new DataColumn[numOfChannels];
            int numOfRows = 10;

            for (int currentChannelIndex = 0; currentChannelIndex < numOfChannels; currentChannelIndex++)
            {
                dataColumn[currentChannelIndex] = new DataColumn();
                dataColumn[currentChannelIndex].DataType = typeof(double);
                dataColumn[currentChannelIndex].ColumnName = channelCollection[currentChannelIndex].PhysicalName;
            }

            data.Columns.AddRange(dataColumn);

            for (int currentDataIndex = 0; currentDataIndex < numOfRows; currentDataIndex++)
            {
                object[] rowArr = new object[numOfChannels];
                data.Rows.Add(rowArr);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int samplePerChannel = Convert.ToInt32(edchannel.Text);

            data = analogInReader.ReadWaveform(samplePerChannel);

            // Plot your data here
            dataToDataTable(data, ref dataTable);
        }
    }
}
