   M S B A M L   `   `   `  ���� J  FSciChartWrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapperSciChartWrapper.Views  > :DAQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DAQDAQ    	DAQ.Page1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Xscichartwrapper<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapper     #localclr-namespace:DAQ       N� Title$  Page1��.��� 
������� � RowDefinitions �� $	��22* ��� $	��22* ��� $	��22* ��� $	��19* ��� $��3* ��� $��10 � � ColumnDefinitions �� �� $
��113* ��� $
��115* ��� $
��115* ��� $
��114* ��� $
��114* ��� $
��114* ��� $
��114* �.+��� -    ��Name$ btnStart��$��2��$��Start��$��Center=�$��3��$	��100��$��
63,80,65,0q�$��2��$��1���� -   $ btnStop��$��2��$
��Stop��$��Center=�$��30��$��3��$��Bottom=�$	��100��$��2��$��	64,0,66,0q�$��2���� $��3��$��Channel Parameters��$��Center=�$	��127��$��20.505,10,22,0q�$��2��$	��Top=�$	��300��$��1��.���  �� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Physical Channel:��$��2��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� $��Minimum Value (V):��$��2��$��1��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� $��Maximum Value (V):��$��2��$��2��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� -    ��Name$ minimumTextBox��$��2��$��2��$��1��$��Center=�$��23��$��5q� �� TextWrapping$
 Wrap=�$��Center=�$	��120��$��-5���� -   $ maximumTextBox��$��2��$��2��$��2��$��Center=�$��23��$��5q�$
 Wrap=�$��Center=�$	��120��$��5���� -    ��Name$ physicalChannelComboBox��$��2��$��2��$��Center=�$��23��$��5q�$	��Top=�$	��120��.@��� $��Dev1/ao0���� $��3��$��Timing Parameters��$��Center=�$��55��$��1��$��20.505,30,22,25q�$��1��$��Center=�$	��300��$��1��.���  �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Frequency (Hz):��$
��Left=�$��30��$��5q�$��Center=�$	��120���� -   $ edfrequency��$��2��$��2��$��2��$��Center=�$��22��$��5q�$
 Wrap=�$��Center=�$	��120��$��1���� $��3��$#��Function Generator Parameters��$��Center=�$	��200��$��1��$��20.505,0,22,25q�$��3��$��Bottom=�$	��300��$��1��.���  �� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� -   $ signalTypeComboBox��$��2��$��2��$��Center=�$��23��$��5q�$��Center=�$	��120���� -   $ edcyclesPerBuffer��$��Center=�$��2��$��2��$��1��$��27��$
 Wrap=�$��Center=�$	��120��$��0���� -	   $ edsamplesPerBuffer��$��Center=�$��2��$��2��$��2��$��27��$
 Wrap=�$��Center=�$	��120��$��0���� -
   $ edamplitude��$��Center=�$��2��$��2��$��3��$��27��$
 Wrap=�$��Center=�$	��120��$��1���� $��Waveform Type:��$��2��$��0��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� $��Cycles Per Buffer:��$��2��$��1��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� $��Samples Per Buffer:��$��2��$��2��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� $��
Amplitude:��$��2��$��3��$
��Left=�$��33��$��5q�$	��Top=�$	��150��1   +SciChartWrapper.Views.SciChartProfile2DView  -     Name$ profilechart��$��4��$��4��$��
20,20,20,5q�$��0��$��4��