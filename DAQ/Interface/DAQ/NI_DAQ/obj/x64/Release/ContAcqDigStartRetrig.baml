   M S B A M L   `   `   `  ���� A  =NI_DAQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NI_DAQNI_DAQ  J FSciChartWrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapperSciChartWrapper.Views "    NI_DAQ.ContAcqDigStartRetrig   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     &localclr-namespace:NI_DAQ     Xscichartwrapper<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapper       � Title$  ContAcqDigStartRetrig��$	��450��$	��800��.��� 
������� � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Timing parameters��$
��Left=�$��Center=�$��2��$��2��$��0��$��10q�$��3��$	��340��.���  �� $��* ��� $��* � �� $��* ��� $��* �.+��� $��Samples / Channel:��$
��Left=�$��5q�$��30��$	��150��$��0��$��0���� $��
Rate (Hz):��$
��Left=�$��30��$	��150��$��5q�$��1��$��0���� -    ��Name$ 	edchannel��$
��Left=�$��23�� �� TextWrapping$
 Wrap=�$��85��$
��1000��$��5q�$��0��$��1���� -   $ edRate��$
��Left=�$��23��$
 Wrap=�$��85��$��10000��$��5q�$��1��$��1��1  +SciChartWrapper.Views.SciChartProfile2DView  -     Name$ profileChart��$��3��$��3��$��0��$��5��$��10q��� $��3��$��Channel Parameters��$
��Left=�$��10q�$	��150��$��3��$	��Top=�$	��341��.���  �� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Physical Channel:��$��2��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� $��Minimum Value (V):��$��2��$��1��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� $��Maximum Value (V):��$��2��$��2��$
��Left=�$��33��$��5q�$	��Top=�$	��150���� -   $ 	edminimum��$��2��$��2��$��1��$��Center=�$��23��$��5q�$
 Wrap=�$��Center=�$	��120��$��-5���� -   $ 	edmaximum��$��2��$��2��$��2��$��Center=�$��23��$��5q�$
 Wrap=�$��Center=�$	��120��$��5���� -    ��Name$ physicalChannelComboBox��$��2��$��2��$��Center=�$��23��$��5q�$	��Top=�$	��120��.@��� $��Dev1/ao0���� -    ��Name$ btnStart��$��2��$��Start��$
��Left=�$��50��$��	40,20,0,0q�$��0��$��4��$	��Top=�$	��120���� -   $ btnStop��$��2��$
��Stop��$
��Left=�$��50��$��	50,20,0,0q�$��1��$��4��$	��Top=�$	��120��