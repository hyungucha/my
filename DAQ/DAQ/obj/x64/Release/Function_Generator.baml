   M S B A M L   `   `   `  ���� >  :DAQ, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DAQDAQ      DAQ.Function_Generator   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     #localclr-namespace:DAQ       N� Title$  Function_Generator��.��� 
�������.+��  � ColumnDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* � � RowDefinitions �� $��* ��� $��* ��� $��* ��� $��* ��� $��10 �.+��� $��4��$��Setting��$
��Left=�$��70��$��15q�$��3��$��Center=�$	��490��.���  �� $��* ��� $��* ��� $��* ��� $��* �.+��� -    ��Name$ tbIP_Address��$(��"TCPIP0::169.254.5.21::inst0::INSTR��$��3��$
��Left=�$��10q�$��26�� �� TextWrapping$
 Wrap=�$��Center=�$	��320���� -    ��Name$ 
btnConnect��$��Connect��$��3��$
��Left=�$��30��$��Center=�$	��110���� -   $ btnStart��$��Start��$��4��$��Center=�$��45��$��3��$��Center=�$	��100���� -   $ btnReset��$��Reset��$��5��$��Center=�$��45��$��3��$��Center=�$	��100���� $��4��$	��CH1��$
��Left=�$	��300��$��	27,20,0,0q�$��3��$	��Top=�$	��350��.���  �� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� -   $ tbch1_Frequency��$��2��$	��300��$��2��$
��Left=�$��10q�$��30��$
 Wrap=�$��Center=�$	��130���� -   $ tbch1_Amplitude��$��2��$	��3.3��$��1��$��2��$
��Left=�$��10q�$��30��$
 Wrap=�$��Center=�$	��130���� -   $ tbch1_Pulse_w��$��2��$��3��$��2��$��2��$
��Left=�$��10q�$��30��$
 Wrap=�$��Center=�$	��130���� $��2��$��Frequency :��$
��Left=�$��30��$��10q�$��Center=�$	��110���� $��2��$��1��$��Amplitude :��$
��Left=�$��30��$��10q�$��Center=�$	��110���� $��2��$��2��$��Pulse Width : :��$
��Left=�$��30��$��10q�$��Center=�$	��110���� -   $ btnCh1_SetData��$��2��$��Set Data��$��2��$��Center=�$��32��$��3��$��Center=�$	��107���� $��3��$��4��$	��CH1��$
��Left=�$	��300��$��	27,20,0,0q�$��3��$	��Top=�$	��350��.���  �� $��* ��� $��* ��� $��* ��� $��* � �� $��* ��� $��* ��� $��* ��� $��* �.+��� -	   $ tbCh2_Frequency��$��2��$	��300��$��2��$
��Left=�$��10q�$��30��$
 Wrap=�$��Center=�$	��130���� -
   $ tbCh2_Amplitude��$��2��$	��3.3��$��1��$��2��$
��Left=�$��10q�$��30��$
 Wrap=�$��Center=�$	��130���� -   $ tbCh2_Pulse_w��$��2��$��3��$��2��$��2��$
��Left=�$��10q�$��30��$
 Wrap=�$��Center=�$	��130���� $��2��$��Frequency :��$
��Left=�$��30��$��10q�$��Center=�$	��110���� $��2��$��1��$��Amplitude :��$
��Left=�$��30��$��10q�$��Center=�$	��110���� $��2��$��2��$��Pulse Width : :��$
��Left=�$��30��$��10q�$��Center=�$	��110���� -   $ btnCh2_SetData��$��2��$��Set Data��$��2��$��Center=�$��32��$��3��$��Center=�$	��108��