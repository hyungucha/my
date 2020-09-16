using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BaseFunctionGenerator;
using System.Windows;
using Ivi.Visa.Interop;


namespace NI_FG
{
	public class FunctionGeneratorCtrl : BaseDAQ.BasePropertyChanged ,IFunctionGenerator
    {
		public static readonly FunctionGeneratorCtrl _instance = new FunctionGeneratorCtrl();

		public static FunctionGeneratorCtrl Instance
        {
			get => _instance;
        }


		#region Private Member Variables

		private string _ip_Address;

		private FormattedIO488 _inst = null;

		private string _functionGenerator_Ch1Frequency;
		private string _functionGenerator_Ch2Frequency;
		
		private string _functionGenerator_Ch1Amplitude;
		private string _functionGenerator_Ch2Amplitude;
		
		private string _functionGenerator_Ch1PulseWidth;
		private string _functionGenerator_Ch2PulseWidth;

		private const int ch1 = 0;
		private const int ch2 = 1;

		#endregion Private Member Variables

		#region Constructors

		#endregion Constructors

		#region Public Properties

		public FunctionGeneratorCtrl()
        {
			SetParam();

			Instance.ParamSet(1);
        }

		public void SetParam()
        {
			FunctionGenerator_Ch1Frequency = "300";
			FunctionGenerator_Ch2Frequency = "300";
			FunctionGenerator_Ch1Amplitude = "3.3";
			FunctionGenerator_Ch2Amplitude = "3.3";
			FunctionGenerator_Ch1PulseWidth = "3";
			FunctionGenerator_Ch2PulseWidth = "3";
		}

		public FormattedIO488 Inst 
		{ 
			get => _inst; 
			set => _inst = value; 
		}
        
		public string Ip_Address 
		{ 
			get => _ip_Address; 
			set => _ip_Address = value; 
		}
        
		public string FunctionGenerator_Ch1Frequency 
		{ 
			get => _functionGenerator_Ch1Frequency; 
			set
            {
                _functionGenerator_Ch1Frequency = value;
				OnPropertyChanged("FunctionGenerator_Ch1Frequency");
            }
		}
        
		public string FunctionGenerator_Ch2Frequency 
		{ 
			get => _functionGenerator_Ch2Frequency; 
			set
            {
				_functionGenerator_Ch2Frequency = value;
				OnPropertyChanged("FunctionGenerator_Ch2Frequency");
			}
		}
        
		public string FunctionGenerator_Ch1Amplitude 
		{ 
			get => _functionGenerator_Ch1Amplitude; 
			set
            {
				_functionGenerator_Ch1Amplitude = value;
				OnPropertyChanged("FunctionGenerator_Ch1Amplitude");
			}
		}
        
		public string FunctionGenerator_Ch2Amplitude 
		{ 
			get => _functionGenerator_Ch2Amplitude; 
			set
            {
				_functionGenerator_Ch2Amplitude = value;
				OnPropertyChanged("FunctionGenerator_Ch2Amplitude");
			}
		}
        
		public string FunctionGenerator_Ch1PulseWidth 
		{ 
			get => _functionGenerator_Ch1PulseWidth; 
			set
            {
				_functionGenerator_Ch1PulseWidth = value;
				OnPropertyChanged("FunctionGenerator_Ch1PulseWidth");
			}
		}
        
		public string FunctionGenerator_Ch2PulseWidth 
		{ 
			get => _functionGenerator_Ch2PulseWidth; 
			set
            {
				_functionGenerator_Ch2PulseWidth = value;
				OnPropertyChanged("FunctionGenerator_Ch2PulseWidth");
			}
		}

        #endregion Public Properties

        #region Public Methods

		protected void ParamSetting(int ch)
        {
			if (ch == 1)
			{
				Inst.WriteString("SOURce" + "1" + ":FREQuency" + " " + FunctionGenerator_Ch1Frequency);
				Inst.WriteString("SOURce" + "1" + ":VOLTage" + " " + FunctionGenerator_Ch1Amplitude); //Set
				Inst.WriteString("SOURce" + "1" + ":PHASe" + " " + FunctionGenerator_Ch1PulseWidth);
			}
			else
			{
				Inst.WriteString("SOURce" + "2" + ":FREQuency" + " " + FunctionGenerator_Ch2Frequency);
				Inst.WriteString("SOURce" + "2" + ":VOLTage" + " " + FunctionGenerator_Ch2Amplitude); //Set
				Inst.WriteString("SOURce" + "2" + ":PHASe" + " " + FunctionGenerator_Ch2PulseWidth);
			}
		}

		public bool Connect(String IP_Address)
		{
			bool connected = false;

			if (String.IsNullOrEmpty(IP_Address))
			{
				MessageBox.Show("IP Address 가 입력되지 않았습니다.");
				return connected;
			}

			ResourceManager rm = new ResourceManager();
			DestroyInst();
			Inst = new FormattedIO488();
			try
			{
				Inst.IO = rm.Open(IP_Address) as IMessage;
				Inst.InstrumentBigEndian = false;
				connected = true;
			}
			catch
			{
				DestroyInst();
			}
			return connected;
		}

		public void DestroyInst()
		{
			if (Inst != null)
			{
				try
				{
					if (Inst.IO != null)
						Inst.IO.Close();
				}
				catch
				{
				}
				Inst = null;
			}
		}

        public void Reset()
        {
			try
			{
				//this.IsEnabled = false;
				Inst.WriteString("*RST");
				Thread.Sleep(3000);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
			}
			finally
			{
				//this.IsEnabled = true;
			}
		}

        public void ParamSet(int ch)
        {
			ParamSetting(ch);
        }

		#endregion Public Methods

		~FunctionGeneratorCtrl()
        {
			DestroyInst();

		}

	}
}
