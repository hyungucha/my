   M S B A M L   `   `   `  ���� A  =NI_DAQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NI_DAQNI_DAQ  J FSciChartWrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapperSciChartWrapper.Views     NI_DAQ.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:NI_DAQ     Xscichartwrapper<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapper       � 
ResizeMode$  NoResize=� � WindowState$ 	Maximized=� � Title$ 
MainWindow��$
��1080��$
��1900��.���  � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* �.+��� -    ��Name$ gbAcqVoltageInt��$��2��$��AnalogIn��$
��Left=�$	��500��$��	10,10,0,0q�$	��Top=�$	��925��.���  �� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��채널 :��$��0��$��15q�$��Center=�$��30��$	��Top=�$	��146��$��16(��� $��Min :��$��1��$��Center=�$��30��$	��Top=�$	��146��$��16(��� $��Max :��$��2��$��Center=�$��30��$	��Top=�$	��146��$��16(��� $��	Smp/cnl :��$��3��$��Center=�$��30��$	��Top=�$	��146��$��16(��� $��Rate :��$��4��$��Center=�$��30��$	��Top=�$	��146��$��16(��� $��1��$��0��$��Center=�$��15q�$��40��$	��top=�$	��150������  �� Path$% AcqVoltageInt__PhysicalChannels� �� SelectedItem �� $, &AcqVoltageInt__SelectedPhysicalChannel��� -    ��Name$ 
edMinvalue��$��1��$��Center=�$��40��$��1��	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��130������ $  AcqVoltageInt_RangeMinimum�
 �� Mode$
 TwoWay=��� -   $ 
edMaxvalue��$��1��$��Center=�$��40��$��2��$
	 Wrap=�$	��Top=�$	��130������ $  AcqVoltageInt_RangeMaximum�$
 TwoWay=��� -   $ edSamplerate��$��1��$��Center=�$��40��$��3��$
	 Wrap=�$	��Top=�$	��130������ $ AcqVoltageInt_SampleRate�$
 TwoWay=��� -   $ SamplesPerCnl��$��1��$��Center=�$��40��$��4��$
	 Wrap=�$	��Top=�$	��130������ $% AcqVoltageInt_SamplesPerChannel�$
 TwoWay=��� -    ��Name$ Start��$��Start��$��Center=�$��34��$��4��$��Bottom=�$	��366��$��2��1  +SciChartWrapper.Views.SciChartProfile2DView  -     Name$ profileChart��$��2��$��5q�$��2��$��0��$��5���� -   $ gbGenVoltageUpdate��$��2��$��Analog out vot��$
��Left=�$	��500��$��	10,10,0,0q�$	��Top=�$	��453��.���  �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��채널��$��0��$��Center=�$��46��$��15q�$	��Top=�$	��147���� $	��Min��$��1��$��Center=�$��46��$��15q�$	��Top=�$	��147���� $	��Max��$��2��$��Center=�$��46��$��15q�$	��Top=�$	��147���� $��Vot out��$��3��$��Center=�$��46��$��15q�$	��Top=�$	��147���� -	    ��Name$' !GenVoltageUpdate_PhysicalChannels��$��1��$��0��$��Center=�$��15q�$��40��$	��top=�$	��150������ $' !GenVoltageUpdate_PhysicalChannels� �� $. (GenVoltageUpdate_SelectedPhysicalChannel��� $��1��$��Center=�$��40��$��1��$��15q�$
	 Wrap=�$	��Top=�$	��130������ $# GenVoltageUpdate_MinimumValue�$
 TwoWay=��� $��1��$��Center=�$��40��$��2��$��15q�$
	 Wrap=�$	��Top=�$	��130������ $# GenVoltageUpdate_MaximumValue�$
 TwoWay=��� $��1��$��Center=�$��40��$��3��$��15q�$
	 Wrap=�$	��Top=�$	��130������ $$ GenVoltageUpdate_VoltageOutput�$
 TwoWay=��� -
   $ 	aov_Start��$��2��$��Start��$��Center=�$��35��$��15q�$��3��$��Bottom=�$	��336���� -   $ gbConGenVotageWfm��$��2��$��Analog out wfm��$
��Left=�$	��505��$��11,5,0,0q�$��1��$	��Top=�$	��925��.���  �� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��2��$��3��$��0��$��Channel Parameters��$��Center=�$	��150��$��0q�$	��Top=�$	��430��.���  �� $��* ��� $��* � �� $��* ��� $��* ��� $��* �.+��� $��채널 :��$��0��$
��Left=�$��30��$��	10,10,0,0q�$	��Top=�$	��168���� $��Min :��$��1��$
��Left=�$��30��$��	10,10,0,0q�$	��Top=�$	��168���� $��Max :��$��2��$
��Left=�$��30��$��	10,10,0,0q�$	��Top=�$	��168���� $��1��$��1��$��Center=�$��25��$
	 Wrap=�$��Center=�$	��156������ $ ConGenVotageWfm_Minimum�$
 TwoWay=��� $��1��$��2��$��Center=�$��25��$
	 Wrap=�$��Center=�$	��156������ $ ConGenVotageWfm_Maximum�$
 TwoWay=��� -   $&  ConGenVotageWfm_physicalChannels��$��1��$��Center=�$��25��$��Center=�$	��156������ $&  ConGenVotageWfm_physicalChannels� �� $- 'ConGenVotageWfm_selectedPhysicalChannel��� $��2��$��1��$��2��$��Timing Parameters��$��Center=�$��45��$��Center=�$	��430��.���  �� $��* ��� $��* �.+��� $��Frequency (Hz): :��$��0��$
��Left=�$��30��$��10,0,0,0q�$��Center=�$	��168���� $��1��$��0��$��Center=�$��20��$
	 Wrap=�$��Center=�$	��156������ $ ConGenVotageWfm_Frequency�$
 TwoWay=��� $��2��$��3��$��3��$#��Function Generator Parameters��$��Center=�$	��210��$	��-10q�$	��Top=�$	��430��.���  �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Wave Type :��$��0��$
��Left=�$��30��$��10,0,0,0q�$��Center=�$	��168���� $��Cycle Buffer :��$��1��$
��Left=�$��30��$��10,0,0,0q�$��Center=�$	��168���� $��Sample Buffer :��$��2��$
��Left=�$��30��$��10,0,0,0q�$��Center=�$	��168���� $��Amplitude :��$��3��$
��Left=�$��30��$��10,0,0,0q�$��Center=�$	��168���� -   $  ConGenVotageWfm_signalType��$��1��$��Center=�$��25��$��Center=�$	��156������ $  ConGenVotageWfm_signalType� �� $( "ConGenVotageWfm_selectedSignalType��� $��1��$��1��$��Center=�$��25��$
	 Wrap=�$��Center=�$	��156������ $% ConGenVotageWfm_CyclesPerBuffer�$
 TwoWay=��� $��1��$��2��$��Center=�$��25��$
	 Wrap=�$��Center=�$	��156������ $&  ConGenVotageWfm_SamplesPerBuffer�$
 TwoWay=��� $��1��$��3��$��Center=�$��25��$
	 Wrap=�$��Center=�$	��156������ $ ConGenVotageWfm_Amplitude�$
 TwoWay=��� -   $ btnConGenVotageWfm_Start��$��Start��$��Center=�$��35��$��5q�$��6��$��Center=�$	��180���� -   $ btnConGenVotageWfm_Stop��$
��Stop��$��1��$��Center=�$��35��$��5q�$��6��$��Center=�$	��180��  -   $ conGenvotageWfmChart��$��7��$��2��$��2��$��10q��� $��3��$��Counter��$
��Left=�$	��500��$��	10,10,0,0q�$	��Top=�$	��453��.���  �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��2��$��3��$��Idle State:��$��Center=�$	��100��$��5��$	��Top=�$	��410��.���  �� $��* ��� $��* �.+�	� -    	�Name$ btnCheckdLow��$	��Low��$��Center=�$��24��$��Center=�$	��118��$��15q�	� -   $ btnCheckdhigh��$
��high��$��1��$��Center=�$��24��$��Center=�$	��118��$��15q��� $��1��$��Center=�$��40��$��center=�$	��150������ $1 +GenDigPulseTrainContinuous_physicalChannels�$
 TwoWay=� �� $8 2GenDigPulseTrainContinuous_selectedPhysicalChannel�$
 TwoWay=��� $��Counter(s):��$��0��$��Center=�$��28��$��Center=�$	��144���� $��Frequency (Hz):��$��1��$��Center=�$��28��$��Center=�$	��144���� $��Duty Cycle:��$��2��$��Center=�$��28��$��center=�$	��144���� $��1��$��Center=�$��40��$��1��$
	 Wrap=�$��Center=�$	��130������ $* $GenDigPulseTrainContinuous_Frequency�$
 TwoWay=��� $��1��$��Center=�$��40��$��2��$
	 Wrap=�$��Center=�$	��130������ $* $GenDigPulseTrainContinuousDuty_Cycle�$
 TwoWay=��� -   $( "btnGenDigPulseTrainContinuousStart��$��Start��$��0��$��Center=�$��41��$��4��$��Center=�$	��155���� -   $' !btnGenDigPulseTrainContinuousStop��$
��Stop��$��1��$��Center=�$��41��$��4��$��Center=�$	��155���� -   $ gbFunctionGenerator��$��2��$��2��$��Fuction Generator��$
��Left=�$	��505��$��11,5,0,0q�$��1��$	��Top=�$	��925��.���  �� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��2��$	��CH1��$��Center=�$	��320��$��5��$	��Top=�$	��440��.���  �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Frequency :��$��0��$��Center=�$��40��$��Center=�$	��146���� $��Amplitude :��$��1��$��Center=�$��40��$��Center=�$	��146���� $��Pulse Width :��$��2��$��Center=�$��40��$��Center=�$	��146���� $��1��$��0��$��Center=�$��40��$
	 Wrap=�$��Center=�$	��130������ $$ FunctionGenerator_Ch1Frequency�$
 TwoWay=��� $��1��$��1��$��Center=�$��40��$
	 Wrap=�$��Center=�$	��130������ $$ FunctionGenerator_Ch1Amplitude�$
 TwoWay=��� $��1��$��2��$��Center=�$��40��$
	 Wrap=�$��Center=�$	��130������ $% FunctionGenerator_Ch1PulseWidth�$
 TwoWay=��� -   $ 
ch1SetData��$��Set Data��$��1��$��Center=�$��40��$��3��$��Center=�$	��130���� $��2��$��2��$	��CH2��$��Center=�$	��320��$��5��$	��Top=�$	��440��.���  �� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Frequency :��$��0��$��Center=�$��40��$��Center=�$	��146���� $��Amplitude :��$��1��$��Center=�$��40��$��Center=�$	��146���� $��Pulse Width :��$��2��$��Center=�$��40��$��Center=�$	��146���� $��1��$��0��$��Center=�$��40��$
	 Wrap=�$��Center=�$	��130������ $$ FunctionGenerator_Ch2Frequency�$
 TwoWay=��� $��1��$��1��$��Center=�$��40��$
	 Wrap=�$��Center=�$	��130������ $$ FunctionGenerator_Ch2Amplitude�$
 TwoWay=��� $��1��$��2��$��Center=�$��40��$
	 Wrap=�$��Center=�$	��130������ $% FunctionGenerator_Ch2PulseWidth�$
 TwoWay=��� -   $ 
ch2SetData��$��Set Data��$��1��$��Center=�$��40��$��3��$��Center=�$	��130���� $��3��$��2��$��Setting��$
��Left=�$	��100��$��20q�$��4��$��Center=�$	��550��.���  �� $��* ��� $��* ��� $��* ��� $��* �.+��� -   $ tbIP_Address��$(��"TCPIP0::169.254.5.21::inst0::INSTR��$��3��$
��Left=�$��10q�$��40��$
	 Wrap=�$��Center=�$	��320���� -   $! btnFunctionGeneratorConnect��$��Connect��$��3��$
��Left=�$��30��$��Center=�$	��110���� -   $ btnFunctionGeneratorStart��$��2��$��Start��$��2��$
��Left=�$��40��$��4��$	��Top=�$	��136��$��
145,28,0,0q��� -   $ btnFunctionGeneratorReset��$��Reset��$��3��$��Center=�$��40��$��4��$	��Top=�$	��134��$��
77,28,17,0q��� -   $ btnContAcqDigStartRetrig��$��	AcqRetrig��$��3��$��Center=�$��40��$��5��$	��Top=�$	��134��$��	60,20,0,0q�