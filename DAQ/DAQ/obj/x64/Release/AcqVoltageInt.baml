   M S B A M L   `   `   `  ���� >  :DAQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DAQDAQ  J FSciChartWrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapperSciChartWrapper.Views     DAQ.AcqVoltageInt   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:DAQ     Xscichartwrapper<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapper       N� Title$  AcqVoltageInt��.��� 
������� � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��11 � � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -    ��Name$ Start��$��Start��$��Center=�$��54��$��Center=�$	��100��$��3��$��1��$��5q��� $��Channel Parameters��$��Stretch=�$��5q�$��Stretch=�$��0��$��0��$��2��$��3��.���  �� $��* ��� $��* ��� $��* � �� $��* ��� $��* �.+��� $��physicalChannelLabel��$
��Left=�$��30��$	��150��$��0��$��0���� -    ��Name$ physicalChannelComboBox��$
��Left=�$��30��$	��130��$��0��$��1��.@��� $��Dev1/ai0���� $��minimumLabel��$
��Left=�$��30��$	��150��$��1��$��0���� $��maximumLabel��$
��Left=�$��30��$	��150��$��2��$��0���� -    ��Name$ edMin��$
��Left=�$��23�� �� TextWrapping$
 Wrap=�$��85��$	��-10��$��1��$��1���� -   $ edMax��$
��Left=�$��23��$
 Wrap=�$��85��$��10��$��2��$��1���� $��GroupBox��$��Stretch=�$��Stretch=�$��2��$��0��$��3��.���  �� $��* ��� $��* � �� $��* ��� $��* �.+��� $��Samples / Channel:��$
��Left=�$��5q�$��30��$	��150��$��0��$��0���� $��
Rate (Hz):��$
��Left=�$��30��$	��150��$��5q�$��1��$��0���� -   $ 	edchannel��$
��Left=�$��23��$
 Wrap=�$��85��$	��100��$��5q�$��0��$��1���� -   $ edRate��$
��Left=�$��23��$
 Wrap=�$��85��$
��1000��$��5q�$��1��$��1��1  +SciChartWrapper.Views.SciChartProfile2DView  -     Name$ profileChart��$��3��$��0��$��4��$��4��$��10q�