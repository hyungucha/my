   M S B A M L   `   `   `  ���� >  :DAQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DAQDAQ  J FSciChartWrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapperSciChartWrapper.Views     DAQ.GenVoltageUpdate   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:DAQ     NViews<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapper       N� Title$  GenVoltageUpdate��.��� 
������� � ColumnDefinitions �� $
��133* ��� $
��134* ��� $
��144* ��� $
��123* ��� $
��133* ��� $
��133* ��� $��0 � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* �.+��� $��4��$��Channel Parameters��$��Stretch=�$��15,15,112,13q�$��3��$��0��.���  �� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Physical Channel:��$
��Left=�$��2��$��0��$��0��$��5q�$��40��$	��120���� $��Minimum Value (V):��$
��Left=�$��2��$��0��$��2��$��5q�$��40��$	��120���� $��Maximum Value (V):��$
��Left=�$��2��$��0��$��4��$��5q�$��40��$	��120���� -    ��Name$ minimumValue��$��3��$��1��$��2��$��Stretch=�$��25��$��
30,-10,0,0q� �� TextWrapping$
 Wrap=�$	��200��$��-5���� -   $ maximumValue��$��3��$��1��$��4��$��Stretch=�$��25��$��
30,-10,0,0q�$
 Wrap=�$	��200��$��5���� -    ��Name$ physicalChannelComboBox��$��3��$��1��$��0��$��Stretch=�$��25��$��
30,-10,0,0q�$	��200�� �� SelectedIndex$ 0��.@��� $��Dev1/ao0���� -    ��Name$ btnStart��$��2��$��Start��$��1��$
��Left=�$��
10,56,0,26q�$��3��$	��150���� $��2��$��Voltage Output (V):��$��Stretch=�$��35��$��	25,5,65,0q�$��3��$	��Top=��� -   $ voltageOutput��$��2��$��1��$��3��$��Stretch=�$��25��$��20,6,3,0q�$	��Top=�$
 Wrap=�$	��200��$��1��1  +SciChartWrapper.Views.SciChartProfile2DView  -     Name$ profilechart��$��4��$��4��$��97,20,20,30q�$��0��$��2��