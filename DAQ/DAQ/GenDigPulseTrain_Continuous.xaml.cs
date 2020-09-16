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
    /// Page2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page2 : Page
    {
        private ni.COPulseIdleState idleState;
        private DispatcherTimer timer = new DispatcherTimer();
        ni.Task myTask = new ni.Task();

        public Page2()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += new EventHandler(statusCheckTimer1_Tick);

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            // This example uses the default source (or gate) terminal for 
            // the counter of your device.  To determine what the default 
            // counter pins for your device are or to set a different source 
            // (or gate) pin, refer to the Connecting Counter Signals topic
            // in the NI-DAQmx Help (search for "Connecting Counter Signals").

            try
            {
                myTask.COChannels.CreatePulseChannelFrequency(counterComboBox.Text,
                    "ContinuousPulseTrain", ni.COPulseFrequencyUnits.Hertz, idleState, 0.0,
                    Convert.ToDouble(frequencyTextBox.Text),
                    Convert.ToDouble(dutyCycleTextBox.Text));

                myTask.Timing.ConfigureImplicit(ni.SampleQuantityMode.ContinuousSamples, 1000);

                myTask.Start();

                btnStart.IsEnabled = false;
                btnStop.IsEnabled = true;

                timer.IsEnabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                myTask.Dispose();
                btnStart.IsEnabled = true;
                btnStop.IsEnabled = false;
                timer.IsEnabled = false;
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = false;
            myTask.Stop();
            myTask.Dispose();
            btnStart.IsEnabled = true;
            btnStop.IsEnabled = false;
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
                System.Windows.MessageBox.Show(ex.Message);
                timer.IsEnabled = false;
                myTask.Stop();
                myTask.Dispose();
                btnStart.IsEnabled = true;
                btnStop.IsEnabled = false;
            }
        }

        private void btn_checkedlow(object sender, RoutedEventArgs e)
        {
            idleState = ni.COPulseIdleState.Low;
        }

        private void btn_checkedhigh(object sender, RoutedEventArgs e)
        {
            idleState = ni.COPulseIdleState.High;
        }

        private void statusCheckTimer1_Tick(object sender, System.EventArgs e)
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
                System.Windows.MessageBox.Show(ex.Message);
                timer.IsEnabled = false;
                myTask.Stop();
                myTask.Dispose();
                btnStart.IsEnabled = true;
                btnStop.IsEnabled = false;
            }
        }
    }
}
