   M S B A M L   `   `   `  ����J  FSciChartWrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SciChartWrapper.ViewModelsSciChartWrapper.ViewModels  5      =#clr-namespace:SciChartWrapper.ViewsSciChartWrapper.Views  5      1    +SciChartWrapper.Views.SciChartProfile2DView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >	viewModel(clr-namespace:SciChartWrapper.ViewModels     5      X TSciChart.Core, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823\ XSciChart.Charting, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823X TSciChart.Data, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823[ WSciChart.Drawing, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e8237s)http://schemas.abtsoftware.co.uk/scichart     5      Tinteractivity:http://schemas.microsoft.com/expression/2010/interactivity     5	      Rinteractinos9http://schemas.microsoft.com/expression/2010/interactions     5
      _	 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a;	behaviors+http://schemas.microsoft.com/xaml/behaviors 	 5      .view#clr-namespace:SciChartWrapper.Views 	 5        � 	Resources  5         	FontColor �� Color  
BrushColor  HMWhite  Trasparente  DefBackColor  MsgBackColor  AutoRunColor  WarringColor  SelectColor 	 NotSelectColor 
 Selected  	MouseOver  RunColor  	StopColor  	GoodColor  DefectColor  CriticalErrorColor  
ErrorColor  	MenuColor  TitleBarColor  HMBlack  MenuColorBright  LineColorGray  LineSeparator  LineColorDark  LineColorBright  ScrollRepeatBtn  ScrollBackColor  	TextColor  TextColorBright  TextColorYellow  ControlPressedColor   DisabledForegroundColor ! ScrollArrowColor " 	ComboBack # ComboBackSelect $ ComboBotton % HMTextBlockStyle �� 
TargetType �� Property �� Value & HMSimpleLabel ' SciChartSurfaceStyle/  )SciChart.Charting.Visuals.SciChartSurface ( GridLinesPanelStyle3  -SciChart.Charting.Visuals.Axes.GridLinesPanel ) 	AxisStyle-  'SciChart.Charting.Visuals.Axes.AxisBase-  'SciChart.Charting.Visuals.Axes.AxisCore * CursorLineStyle + CursorTooltipStyleC  =SciChart.Charting.Visuals.RenderableSeries.CursorLabelControl �� 
TargetType J� Opacity �� Padding �� RelativeSource	 �� DataType , SeriesInfoTemplate - HMCheckBoxStyle . 	HMTextBox
 ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 #     &	 F     &	 i     &	 �     &	 �     &	 �     &	 �     &	     &		 ;    &	
 ^    &	 �    &	 �    &	 �    &	 �    &	 	    &	 ,    &	 M    &	 n    &	 �    &	 �    &	 �    &	 �    &	     &	 @    &	 c    &	 �    &	 �    &	 �    &	 �    &	     &	 3    &	  T    &	! u    &	" �    &	# �    &	$ �    &	% �    7   &	& �    7  &	' H    &	( �    &	) %    &	* �	    &	+ 	
    7 , &	- �    7  7  7  &	.     7  7  7  7  7  7  7  �� 5   
   $ 	#FFF0EBD0��6,   �� 5   
   $ 	#FF737579��6-   �� 5   
   $ 	#FFC8C8C8��6*   �� 5   
   $ 	#00000000��6.   �� 5   
   $ 	#FF2C2E32��6/   �� 5   
   $ 	#FF6F778A��6/   �� 5   
   $ 	#FF003300��6/   �� 5   
   $ 	#FFFFFF66��6/   �� 5   
   $ 	#FF2C2E32��6.   �� 5   
   $ 	#FF606268��61   �� 5   
   $ 	#FFEEAF06��6+   �� 5   
   $ 	#80FFA500��6,   �� 5   
   $ #003300��6+   �� 5   
   $ #F2F2F2��6,   �� 5   
   $ 	#FF00F200��6,   �� 5    
   $ 	#FFCC0000��6.   �� 5!   
   $ #CC0000��65   �� 5"   
   $ #FFFF66��6-   �� 5$   
   $ 	#FF37393f��6,   �� 5%   
   $ 	#FF2C2E32��60   �� 5&   
   $ 	#FF000000��6*   �� 5'   
   $ 	#FF606268��62   �� 5(   
   $ 	#FF2C3037��60   �� 5)   
   $ 	#FF2C3037��60   �� 5*   
   $ 	#FF222528��60   �� 5+   
   $ 	#FF545557��62   �� 5-   
   $ 	#FF4E5158��62   �� 5.   
   $ 	#FF616267��62   �� 50   
   $ #969799��6,   �� 51   
   $ 	#FFAFB0B2��62   �� 52   
   $ 	#FFFABA0C��62   ��54   
   	#FF211AA9��67   ��55   
   	#FF888888��6;   ��56   
   	#FF8D9095��64   ��58   
   	#FF37393f��6-   ��59   
   	#FF606268��63   ��5:   
   	#FFAFB0B2��6/   �� 5=   
   " ��6)   .�5>      ��  � ��$ Tahoma)�6+   �� 5?       � ��$ Center=�64   �� 5@       � ��$ Center=�62   �� 5A       � ��8   6+   5B      �� 5F   
   " ��6&   .�5G      ��  � ��$ Tahoma)�6+   �� 5H       �@�FocusVisualStyle 61   Z� �� 5I       � �� �#37393F6+   �� 5J       � ��8   6,   �� 5K       � ��$ 2q�60   �� 5L       � �� �#7375796+   �� 5M       � ��$ Center=�6;   �� 5N       � ��$ Center=�69   �� 5O       � ��$ 	16,3,16,3q�6(   5P      �� 5R   
   "  6-   .�5S      ��  � ��
 ���� 6+   �� 5T       � ��
 �����6+   5U      �� 5V   
   "  6,   .�5W      ��  � ��
 ���� 6+   �� 5X       � ��$ 1q�60   5Y      �� 5Z   
   "  6"   .�5[      ��  �@ AxisBandsFill$ Transparent��6.   �� 5\       �@ MajorGridLineStyle 5]      �� 5^      " ��6   .�5_      ��  � ��
 ���� 63   5`      5b      �� 5c       �@ MinorGridLineStyle 5d      �� 5e      " ��6   .�5f      ��  � ��
 ���� 63   5g      5i      5j      �� 5l   
   " ��6(   .�5m      ��  � ��$ 2��60   �� 5n       � �� �	#AAFF66006'   5o      �� 5q   
   "  6+   .�5r      ��  � �� 5s      �� 5t      "  6&   .R�5u      �� ���	#AAFF6600���	#FFFF6600$��2q�5w   !   $	 0.7Q�5x   !   $	 2.5q�5y   !   ._�5z      �� ��6+   �� *#!DataContext.SeriesData.SeriesInfo+ �� *TemplatedParent+��5{   "   �� 5|   &   (��       63   *s:SeriesInfo+)$	 s:SeriesInfo��.R�5}   *   �� 8��  ��69   �� 6M   5~   '   5�      5�      5�      5�      5�      �� 5�   
   " ��6(   .�5�      ��  �@�Cursor$
 Hand��6'   �� 5�       � ��8   6+   �� 5�       � ��$ Tahoma)�6+   �� 5�       � ��8  6,   �� 5�       � ��8  6+   �� 5�       � ��$ Center=�64   �� 5�       � ��$ Center=�62   5�      �� 5�   
   " ��6   .�5�      ��  � ��8   6+   �� 5�       � ��$ Center=�69   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $
 border��6!   8�� $��1q�5�      8�� ._�5�      �� $ PART_ContentHost��6+   |�.  $��Hidden=�5�      $��Hidden=�5�      5�       5�      P� 5�       �@J�IsMouseOver . . �5�   "   �� $ border��6@   8   � ��6T   �� 5�   "   8   � ��6?   �� 5�   "    � ��$
 Bold"�6?   5�      P� 5�       �@J�	IsFocused . . �5�   "   �� $ border��6@   8   � ��6T   �� 5�   "   8   � ��6?   �� 5�   "    � ��$
 Bold"�6?   5�      5�      5�      5�      5�      .��5�      � 
������   5�   
    / TextBoxStyle 0 AxisLabelStyleD  >SciChart.Charting.Visuals.Axes.LabelProviders.DefaultTickLabel��%�  &	/       &	0     �� 5�      " ��6)   .�5�      ��  � ��$ 12(�6-   �� 5�       � ��$ Segoe UI Semibold)�6/   �� 5�       � �� �#FFF6/   �� 5�       � �� �	#FF3235396/   �� 5�       � �� �	#FF5B5B5B60   �� 5�       � ��$ 1q�64   5�      �� 5�      "  6+   .�5�      ��  �@��ContentStringFormat$ 
######.###��68   �� 5�       �@��TextAlignment$ Right=�6<   �� 5�       � ��$ 80��64   5�      5�       � ColumnDefinitions 5�   
   �� 5�      $��* �6   �� 5�      $��50 �6    � RowDefinitions 5�   
   �� 5�      $��* �6   �� 5�      $��26 �6   .+�5�   
     -   5          Name$ sciChartSurface��5�      $��0��5�      $��0��5�      3  -SciChart.Charting.Visuals.SciChartSurfaceBase   
ChartTitle$ Profile Test��5�      $��10(�5�      #��[' 5�         GridLinesPanelStyle# [( 5�         RenderableSeries 5�      =  7SciChart.Charting.Common.MarkupExtensions.SeriesBinding  *,*SciChartProfile2DModelObj.RenderableSeries+   XAxis 5�      0	  *SciChart.Charting.Visuals.Axes.NumericAxis	  5�       �� ContentStringFormat$ 0��5�          TextFormatting$ #####0��5�       #��[) 5�          VisibleRange 5�       �� *!SciChartProfile2DModelObj.XAxis+ �� Mode$ TwoWay=�5�         YAxis 5�      	  5�      $ 
#####0.###��5�       #��[) 5�        5�       �� *!SciChartProfile2DModelObj.YAxis+$ TwoWay=�  5�      ��%R   '��       �� 5�      " ��6    .�5�      ��  � ��$ 80��66   5�      5�      5�         ChartModifier 5�      4
  .SciChart.Charting.ChartModifiers.ModifierGroup
  5�       
  ChildModifiers. 5�      ?  9SciChart.Charting.ChartModifiers.RubberBandXyZoomModifier  8  2SciChart.Charting.ChartModifiers.ChartModifierBase   	IsEnabled 61   �� *&$SciChartProfile2DModelObj.EnableZoom+6  0SciChart.Charting.ChartModifiers.ZoomPanModifier  5�      :  4SciChart.Charting.ChartModifiers.ZoomPanModifierBase   	ClipModeX$
 None=�6b    6(   �� *%#SciChartProfile2DModelObj.EnablePan+6b   :  4SciChart.Charting.ChartModifiers.ZoomExtentsModifier  5�      5�      5�      ]� 5�   
   -   5          ]�Name$  	uiXMinMax��5�   1   $��1��6   $��0��6!   .+�5�      �� -   5        ! ��Name$! uiXMin��5�      $��50��6&   $��3q�61   #��[. 5�      $
��Left=�5�      $
��Left=�5�      $��Center=�5�      ��5�      �� *XMin+$ TwoWay=�.��69   * 	 $Microsoft.Xaml.Behaviors.Interaction"   	Behaviors" 5�      9   3SciChartWrapper.Views.TextBoxEnterKeyUpdateBehavior  5�      .��5�   3   5�      �� 5�      -   5        $! uiXMax��5�      $��50��6&   $��3q�61   #��[. 5�      $��Right=�5      $��Right=�5     ��5     �� *XMax+$ TwoWay=�.��69   " 5       5     .��5  3   5     5     ]� 5	  
   -   5        $  	uiYMinMax��5	  1   $��0��6   $��1��6!   .+�5
     �� -   5        $! uiYMin��5
     $��3q�6'   #��[. 5     $��Bottom=�5     $��Bottom=�5     ��5     �� *YMin+$ TwoWay=�.��69   " 5       5     .��5  3   5     �� 5     -   5        $! uiYMax��5     $��3q�6'   #��[. 5     $	��Top=�5     $	��Top=�5     ��5     �� *YMax+$ TwoWay=�.��69   " 5       5     .��5  3   5     5     �� 5  
   $��1��6   $��1��6    $��3q�60   #��[- 5     $��Center=�5      $��Center=�60   # d� 	IsChecked# 5!     �� *IsAutoScaled+$ TwoWay=�5"     5#     