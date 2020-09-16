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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ni = NationalInstruments.DAQmx;
using System.Windows.Threading;
using System.Threading;

namespace DAQ
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page1 : Page
    {
        ni.Task myTask = new ni.Task();
        private DispatcherTimer timer = new DispatcherTimer();

        public Page1()
        {
            InitializeComponent();

            

            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += new EventHandler(statusCheckTimer_Tick);

            FunctionGenerator.InitComboBox(signalTypeComboBox);

            physicalChannelComboBox.Items.Add(ni.DaqSystem.Local.GetPhysicalChannels(ni.PhysicalChannelTypes.AO, ni.PhysicalChannelAccess.External));
            if (physicalChannelComboBox.Items.Count > 0)
                physicalChannelComboBox.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {    
                // create the task and channel
                myTask.AOChannels.CreateVoltageChannel(physicalChannelComboBox.Text,
                    "",
                    Convert.ToDouble(minimumTextBox.Text),
                    Convert.ToDouble(maximumTextBox.Text),
                    ni.AOVoltageUnits.Volts);

                // verify the task before doing the waveform calculations
                myTask.Control(ni.TaskAction.Verify);

                // calculate some waveform parameters and generate data
                FunctionGenerator fGen = new FunctionGenerator(
                    myTask.Timing,
                    edfrequency.Text,
                    edsamplesPerBuffer.Text,
                    edcyclesPerBuffer.Text,
                    signalTypeComboBox.Text,
                    edamplitude.Text);

                // configure the sample clock with the calculated rate
                myTask.Timing.ConfigureSampleClock("",
                    fGen.ResultingSampleClockRate,
                    ni.SampleClockActiveEdge.Rising,
                    ni.SampleQuantityMode.ContinuousSamples, 1000);


                ni.AnalogSingleChannelWriter writer =
                    new ni.AnalogSingleChannelWriter(myTask.Stream);

                //write data to buffer
                writer.WriteMultiSample(false, fGen.Data);

                profilechart.SetData(fGen.Data);

                //start writing out data
                myTask.Start();

                btnStart.IsEnabled = false;
                btnStop.IsEnabled = true;


                timer.IsEnabled = true;
            }
            catch (ni.DaqException err)
            {
                timer.IsEnabled = false;
                MessageBox.Show(err.Message);
                myTask.Dispose();
            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private void stopButton_Click(object sender, System.EventArgs e)
        {
            timer.IsEnabled = false;
            if (myTask != null)
            {
                try
                {
                    myTask.Stop();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                myTask.Dispose();
                myTask = null;
                btnStart.IsEnabled = true;
                btnStop.IsEnabled = false;
            }
        }
        private void statusCheckTimer_Tick(object sender, System.EventArgs e)
        {
            try
            {
                // Getting myTask.IsDone also checks for errors that would prematurely
                // halt the continuous generation.
                if (myTask.IsDone)
                {
                    timer.IsEnabled = false;
                    myTask.Stop();
                    myTask.Dispose();
                    btnStart.IsEnabled = true;
                    btnStop.IsEnabled = false;
                }
            }
            catch (ni.DaqException ex)
            {
                timer.IsEnabled = false;
                System.Windows.MessageBox.Show(ex.Message);
                myTask.Dispose();
                btnStart.IsEnabled = true;
                btnStop.IsEnabled = false;
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = false;
            if (myTask != null)
            {
                try
                {
                    myTask.Stop();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                myTask.Dispose();
                myTask = null;
                btnStart.IsEnabled = true;
                btnStop.IsEnabled = false;
            }
        }
    }
}
