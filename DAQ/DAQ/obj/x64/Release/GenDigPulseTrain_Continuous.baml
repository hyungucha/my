   M S B A M L   `   `   `  ���� >  :DAQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DAQDAQ  J FSciChartWrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapperSciChartWrapper.Views     	DAQ.Page2   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:DAQ     NViews<clr-namespace:SciChartWrapper.Views;assembly=SciChartWrapper       N� Title$  Page2��.��� 
�������.+��  � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��10 �.+��� $��2��$��GroupBox��$
��Left=�$	��330��$��	22,10,0,0q�$��4��$	��Top=�$	��368��.���  �� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��Counter(s):��$��0��$
��Left=�$��10q�$��64��$	��150���� $��Frequency (Hz):��$��1��$��2��$
��Left=�$��10q�$��64��$	��150���� $��Duty Cycle:��$��2��$��1��$
��Left=�$��10q�$��64��$	��150���� -    ��Name$ frequencyTextBox��$��2��$��2��$
��Left=�$��30��$��10q� �� TextWrapping$
 Wrap=�$	��Top=�$	��150��$��1���� -   $ dutyCycleTextBox��$��2��$��2��$
��Left=�$��30��$��10q�$
 Wrap=�$	��Top=�$	��150��$��2���� -    ��Name$ counterComboBox��$��2��$��2��$
��Left=�$��30��$��10q�$	��Top=�$	��150�� �� SelectedIndex$ 0��.@��� $��	Dev1/ctr0���� $��4��$��Idle State:��$��Center=�$	��120��$��3��$��2��$	��Top=�$	��330��.���  �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+�	� -    	�Name$ btnlow��$��3��$��1��$	��low��$
��Left=�$��40��$��Center=�$	��200��	� -   $ btnhigh��$��3��$��3��$
��high��$
��Left=�$��40��$��Center=�$	��200���� -    ��Name$ btnStart��$��Start��$��Center=�$��50��$��5q�$��0��$��4��$��Center=�$	��130���� -   $ btnStop��$
��Stop��$��Center=�$��50��$��5q�$��1��$��4��$��Center=�$	��130��