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
using ni=NationalInstruments.DAQmx;


namespace DAQ
{
    /// <summary>
    /// GenVoltageUpdate.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GenVoltageUpdate : Page
    {
        public GenVoltageUpdate()
        {
            InitializeComponent();

            physicalChannelComboBox.Items.Add(ni.DaqSystem.Local.GetPhysicalChannels(ni.PhysicalChannelTypes.AO, ni.PhysicalChannelAccess.External));
            if (physicalChannelComboBox.Items.Count > 0)
                physicalChannelComboBox.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                using (ni.Task myTask = new ni.Task())
                {
                    myTask.AOChannels.CreateVoltageChannel(physicalChannelComboBox.Text, "aoChannel",
                        Convert.ToDouble(minimumValue.Text), Convert.ToDouble(maximumValue.Text),
                        ni.AOVoltageUnits.Volts);
                    ni.AnalogSingleChannelWriter writer = new ni.AnalogSingleChannelWriter(myTask.Stream);
                    writer.WriteSingleSample(true, Convert.ToDouble(voltageOutput.Text));
                }
            }
            catch (ni.DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }
    }
}
