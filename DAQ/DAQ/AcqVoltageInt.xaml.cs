using NationalInstruments;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ni=NationalInstruments.DAQmx;

namespace DAQ
{
    /// <summary>
    /// AcqVoltageInt.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AcqVoltageInt : Page
    {
        private ni.AnalogMultiChannelReader reader;
        private DataTable dataTable;
        private DataColumn[] _dataColumns;
        private AnalogWaveform<double>[] data;
        private float[] _profile;

        private const int _limit = 100;

        public AcqVoltageInt()
        {
            InitializeComponent();

            dataTable = new DataTable();

            physicalChannelComboBox.Items.Add(ni.DaqSystem.Local.GetPhysicalChannels(ni.PhysicalChannelTypes.AI, ni.PhysicalChannelAccess.External));
            if (physicalChannelComboBox.Items.Count > 0)
                physicalChannelComboBox.SelectedIndex = 0;

            _profile = new float[_limit];

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = false;
            ni.Task myTask = new ni.Task();
            try
            {
                // Create a new task
                

                // Initialize local variables
                double sampleRate = Convert.ToDouble(edRate.Text);
                double rangeMinimum = Convert.ToDouble(edMin.Text);
                double rangeMaximum = Convert.ToDouble(edMax.Text);
                int samplesPerChannel = Convert.ToInt32(edchannel.Text);

                // Create a channel
                myTask.AIChannels.CreateVoltageChannel(physicalChannelComboBox.Text, "",
                    (ni.AITerminalConfiguration)(-1), rangeMinimum, rangeMaximum, ni.AIVoltageUnits.Volts);

                // Configure timing specs    
                myTask.Timing.ConfigureSampleClock("", sampleRate, ni.SampleClockActiveEdge.Rising,
                    ni.SampleQuantityMode.FiniteSamples, samplesPerChannel);

                // Verify the task
                myTask.Control(ni.TaskAction.Verify);

                // Prepare the table for data
                InitializeDataTable(myTask.AIChannels, ref dataTable);
                //acquisitionDataGrid.DataContext = dataTable.DefaultView;
                //acquisitionDataGrid.ItemsSource = dataTable.DefaultView;

                // Read the data
                reader = new ni.AnalogMultiChannelReader(myTask.Stream);

                data = reader.ReadWaveform(samplesPerChannel);

                dataToDataTable(data, ref dataTable);

                myTask.Dispose();
            }
            catch (ni.DaqException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                myTask.Dispose();
                Start.IsEnabled = true;
            }
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
                    //listview.Items.Add(waveform.Samples[sample].Value);

                    //dataTable.Rows[sample][currentLineIndex] = waveform.Samples[sample].Value;
                }

                currentLineIndex++;
            }

            //acquisitionDataGrid.ItemsSource = dataTable.DefaultView;
            profileChart.SetData(_profile);
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
    }
}
