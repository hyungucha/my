using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Ivi.Visa.Interop;

namespace DAQ
{
    /// <summary>
    /// FunctionGenerator.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Function_Generator : Page
    {
		private FormattedIO488 inst = null;

		public Function_Generator()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
			try
			{
				this.IsEnabled = false;

				if (Connect(tbIP_Address.Text))
				{
					inst.WriteString("*IDN?");
					String strIdn = inst.ReadString();
					MessageBox.Show("Connected" + Environment.NewLine + strIdn);
					
					btnReset.IsEnabled = true;
					//SetAutoScale.Enabled = true;
					//GetError.Enabled = true;
					btnStart.IsEnabled = true;

				}

			}
			catch (Exception ex)
			{
				//Reset.Enabled = false;
				btnStart.IsEnabled = false;
				MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
			}
			finally
			{
				this.IsEnabled = true;
			}
		}
		private void DestroyInst()
		{
			if (inst != null)
			{
				try
				{
					if (inst.IO != null)
						inst.IO.Close();    
				}
				catch
				{
				}
				inst = null;
			}
		}

		private Boolean Connect(String VisaAdd)
		{
			Boolean connected = false;
			if (String.IsNullOrEmpty(VisaAdd))
			{
				MessageBox.Show("IP Address 가 입력되지 않았습니다.");
				return connected;
			}

			ResourceManager rm = new ResourceManager(); 
			DestroyInst();  
			inst = new FormattedIO488();    
			try
			{
				inst.IO = rm.Open(VisaAdd) as IMessage;
				inst.InstrumentBigEndian = false;
				connected = true;
			}
			catch
			{
				DestroyInst();
			}
			return connected;
		}

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
			int a = 11;
			int b = 12;
			int c = 13;
			int d = 14;
			int dadsf = 24;
			
			//ChannelSetting("a", "a");
            //ParamSetting(tbch1_Frequency.Text, tbch1_Amplitude.Text, tbch1_Pulse_w.Text, "");
		      	//ParamSetting(tbch1_Frequency.Text, tbch1_Amplitude.Text, tbch1_Pulse_w.Text, "1");

			
	    	}

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
			try
			{
				this.IsEnabled = false;
				inst.WriteString("*RST");
				Thread.Sleep(3000);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
			}
			finally
			{
				this.IsEnabled = true;
			}
		}

		void ParamSetting(String ch, String frq, String amp, string pulse)
		{
			inst.WriteString("SOURce" + ch + ":FREQuency" + " " +frq);

			inst.WriteString("SOURce" + ch + ":VOLTage" + " " +amp); //Set
			inst.WriteString("SOURce" + ch + ":PHASe" + " " +pulse);
		}

        private void btnCh2_SetData_Click(object sender, RoutedEventArgs e)
        {
			inst.WriteString("DISP:FOCus CH2");   //채널 설정

			ParamSetting("2", tbCh2_Frequency.Text, tbCh2_Amplitude.Text, tbCh2_Pulse_w.Text);  //Data설정

			inst.WriteString("OUTPut2 ON");   //OUT PUT ON
		}

        private void btnCh_1SetData_Click(object sender, RoutedEventArgs e)
        {
			inst.WriteString("DISP:FOCus CH1");   //채널 설정

			ParamSetting("1",tbch1_Frequency.Text, tbch1_Amplitude.Text, tbch1_Pulse_w.Text);  //Data설정

			inst.WriteString("OUTPut1 ON");   //OUT PUT ON
		}
    }
}
