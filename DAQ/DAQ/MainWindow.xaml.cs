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
using DAQ;
using NI_FG;
using SciChartWrapper.Views;
using ni = NationalInstruments.DAQmx;



namespace NI_DAQ
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private AcqVoltageInt _acqVolt;
        private GenVoltageUpdate _genVolUp;
        private ContGenVoltageWfm _conGentVolWfm;
        private GenDigPulseTrain_Continuous _genDigPulseTrainContinuos;

        

        private FunctionGeneratorCtrl _fGeneratorctrl;

        private const int ch1 = 1;
        private const int ch2 = 2;

        public string genVoltageUpdate_channels;

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();

            //FunctionGenerator.InitComboBox(ConGenVotageWfm_signalType);

            // Analog In
            AcqVolt = new AcqVoltageInt();
            AcqVolt.Acqchart = profileChart;

            // Analog out volt
            GenVolUp = new GenVoltageUpdate();

            // Analog out wfm
            ConGentVolWfm = new ContGenVoltageWfm();
            ConGentVolWfm.ConGenVotageWfmChart = conGenvotageWfmChart;

            GenDigPulseTrainContinuos = new GenDigPulseTrain_Continuous();

            // Function Generator
            FGeneratorctrl = new FunctionGeneratorCtrl();

            this.gbAcqVoltageInt.DataContext = AcqVolt;
            this.gbGenVoltageUpdate.DataContext = GenVolUp;
            this.gbConGenVotageWfm.DataContext = ConGentVolWfm;
            this.gbGenDigPulseContinuous.DataContext = GenDigPulseTrainContinuos;
            this.gbFunctionGenerator.DataContext = FGeneratorctrl;
        }

        #endregion Constructors

        #region Public Properties

        public AcqVoltageInt AcqVolt
        {
            get => _acqVolt;
            set => _acqVolt = value;
        }
       
        public SciChartProfile2DView Profilechart 
        {
            get
            {
                SciChartProfile2DView view = null;

                if (Profilechart != null)
                {
                    view = Profilechart;
                }
                else
                {
                    view = null;
                }
                return view;
            }
        }

        public GenVoltageUpdate GenVolUp 
        { 
            get => _genVolUp; 
            set => _genVolUp = value; 
        }
        
        public ContGenVoltageWfm ConGentVolWfm 
        { 
            get => _conGentVolWfm; 
            set => _conGentVolWfm = value; 
        }
        public GenDigPulseTrain_Continuous GenDigPulseTrainContinuos 
        { 
            get => _genDigPulseTrainContinuos; 
            set => _genDigPulseTrainContinuos = value; 
        }

        public FunctionGeneratorCtrl FGeneratorctrl 
        { 
            get => _fGeneratorctrl; 
            set => _fGeneratorctrl = value; 
        }

        #endregion Public Properties

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = false;

            try
            {
                AcqVolt.Start();
            }
            catch (ni.DaqException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                //myTask.Dispose();
                Start.IsEnabled = true;
            }
        }

        private void aov_Start_Click(object sender, RoutedEventArgs e)
        {
            aov_Start.IsEnabled = false;

            try
            {
                GenVolUp.Start();
            }
            catch (ni.DaqException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                //myTask.Dispose();
                aov_Start.IsEnabled = true;
            }
        }

        private void btnConGenVotageWfm_Start_Click(object sender, RoutedEventArgs e)
        {
            ConGentVolWfm.Start();
        }

        private void btnConGenVotageWfm_Stop_Click(object sender, RoutedEventArgs e)
        {
            ConGentVolWfm.Stop();
        }

        private void btnGenDigPulseTrainContinuousStart_Click(object sender, RoutedEventArgs e)
        {
            GenDigPulseTrainContinuos.Start();
        }

        private void btnGenDigPulseTrainContinuousStop_Click(object sender, RoutedEventArgs e)
        {
            GenDigPulseTrainContinuos.Stop();
        }

        private void btnCheckdLow_Checked(object sender, RoutedEventArgs e)
        {
            GenDigPulseTrainContinuos.ChageLowIdleState();
        }

        private void btnCheckdhigh_Checked(object sender, RoutedEventArgs e)
        {
            GenDigPulseTrainContinuos.ChageHighIdleState();
        }

        private void btnFunctionGeneratorConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;

                if (FGeneratorctrl.Connect(tbIP_Address.Text))
                {
                    FGeneratorctrl.Inst.WriteString("*IDN?");
                    String strIdn = FGeneratorctrl.Inst.ReadString();
                    MessageBox.Show("Connected" + Environment.NewLine + strIdn);

                    btnFunctionGeneratorReset.IsEnabled = true;
                    //SetAutoScale.Enabled = true;
                    //GetError.Enabled = true;
                    btnFunctionGeneratorStart.IsEnabled = true;
                }
            }

            catch (Exception ex)
            {
                //Reset.Enabled = false;
                btnFunctionGeneratorStart.IsEnabled = false;
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally
            {
                this.IsEnabled = true;
            }
        }

        private void btnFunctionGeneratorReset_Click(object sender, RoutedEventArgs e)
        {
            FGeneratorctrl.Reset();
        }

        private void ch1SetData_Click(object sender, RoutedEventArgs e)
        {
            FGeneratorctrl.Inst.WriteString("DISP:FOCus CH1");

            FGeneratorctrl.ParamSet(ch1);

            //ParamSetting("1", tbch1_Frequency.Text, tbch1_Amplitude.Text, tbch1_Pulse_w.Text);  //Data설정

            FGeneratorctrl.Inst.WriteString("OUTPut1 ON");   //OUT PUT ON
        }

        private void ch2SetData_Click(object sender, RoutedEventArgs e)
        {
            FGeneratorctrl.Inst.WriteString("DISP:FOCus CH2");   //채널 설정

            FGeneratorctrl.ParamSet(ch2);

            //ParamSetting("2", tbCh2_Frequency.Text, tbCh2_Amplitude.Text, tbCh2_Pulse_w.Text);  //Data설정

            FGeneratorctrl.Inst.WriteString("OUTPut2 ON");   //OUT PUT ON
        }

        private void btnContAcqDigStartRetrig_Click(object sender, RoutedEventArgs e)
        {
            ContAcqDigStartRetrig acqDigStartRetrig = new ContAcqDigStartRetrig();

            acqDigStartRetrig.Show();
        }

        private void btnShowViewer_Click(object sender, RoutedEventArgs e)
        {
            var app = (Application.Current as App);

            if(app.ImageViewerTestView != null)
            {
                app.ImageViewerTestView.Show();
            }

        }
    }
}
