   M S B A M L   `   `   `  ����^  ZSciChart.Charting3D, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823~Rclr-namespace:SciChart.Charting3D.Modifiers.Tooltip3D;assembly=SciChart.Charting3D'SciChart.Charting3D.Modifiers.Tooltip3D  5	      J FSciChartWrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SciChartWrapperSciChartWrapper 5
      vNclr-namespace:SciChart.Charting3D.Model.ChartData;assembly=SciChart.Charting3D#SciChart.Charting3D.Model.ChartData  5         SciChartWrapper.Surface   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      e aSciChart.Examples.ExternalDependencies, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=nullDext:http://schemas.abtsoftware.co.uk/scichart/exampleExternals  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      X TSciChart.Core, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823\ XSciChart.Charting, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823X	 TSciChart.Data, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e823[
 WSciChart.Drawing, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e8237s)http://schemas.abtsoftware.co.uk/scichart   	 
 5      c _SciChart.Drawing.DirectX, Version=5.2.1.11757, Culture=neutral, PublicKeyToken=b55dd9efe817e8237s3D+http://schemas.abtsoftware.co.uk/scichart3D    5      ^t3DRclr-namespace:SciChart.Charting3D.Modifiers.Tooltip3D;assembly=SciChart.Charting3D    5	      +localclr-namespace:SciChartWrapper    5
      `	chartDataNclr-namespace:SciChart.Charting3D.Model.ChartData;assembly=SciChart.Charting3D    5        � 	Resources  5      0   *SciChart.Charting3D.Vector3StringConverter   StringFormat   Vector3StringConverter3   -SciChart.Charting3D.Vector3ComponentConverter  Vec3Converter?   9SciChart.Charting3D.RenderableSeries.GradientColorPalette  HeightColorMap   ContourColor   ContourStrokeThickness   GradientStops � Offset � Color"   SciChart.Charting3D.Camera3D  OrthogonalCamera   CameraId   
OrthoWidth	   OrthoHeight
   ZoomToFitOnAttach   ProjectionMode   Target6   0SciChart.Charting3D.StringToVector3TypeConverter   Position  PerspectiveCamera   
OrbitalYaw   OrbitalPitch  TooltipStyle �� 
TargetType?  9SciChart.Charting.Visuals.RenderableSeries.TooltipControl �� Property �� Value �� 
TargetType J� Opacity �� Padding � DataContext   surfaceSeriesTooltipTemplate �� DataType �� Orientation �� 	Converter �� ConverterParameter��%t  &	        &	 !     &	 4     &	 6    &	 �    &	     &	     7  7  7    5   
   $ n1��6%   67     5   
   6(     5   
   $ BlackX�6:   $	 2.0Q�6O    5      � $ 1Q�6   $ #FF0DD1��6*   � 5      $
 0.95Q�6   $ #E80C50��6-   � 5      $	 0.9Q�6   $ #FF0E00��6,   � 5      $
 0.85Q�6   $ #E8380C��6-   � 5      $	 0.8Q�6   $ #FF610D��6,   � 5      $
 0.75Q�6   $ #FF7D0D��6-   � 5      $	 0.7Q�6   $ #E8900C��6,   � 5      $
 0.65Q�6   $ #FFB300��6-   � 5      $	 0.6Q�6   $ #E8BD0C��6,   � 5      $
 0.55Q�6   $ #FFE80D��6-   � 5      $	 0.5Q�6   $ #C5FF0D��6,   � 5      $
 0.45Q�6   $ #67E80C��6-   � 5      $	 0.4Q�6   $ #10FF00��6,   � 5       $
 0.35Q�6   $ #0CE83F��6-   � 5!      $	 0.3Q�6   $ #0DFF89��6,   � 5"      $
 0.25Q�6   $ #09C2FF��6-   � 5#      $	 0.2Q�6   $ #0876E8��6,   � 5$      $
 0.15Q�6   $ #033CFF��6-   � 5%      $	 0.1Q�6   $ #1108E8��6,   � 5&      $	 0.0Q�6   $ #5609FF��6,   5(        5*   
   $ Ortho Camera��60   $	 600��6I   $		 400��6Z   
 . $ 
Orthogonal=�6�   $ 0,0,0 6�   $ -1000,1000,-1000 6�     5+   
   $ Perspective Camera��61   
 . $ 45��6h   $ 30��6x   �� 5,   
   "  6%   .�5-      ��  � �� 5.      �� 5/      "  6&   .R�50      �� ���	#ff6495ed���	#ff4d81dd$��2q�51   !   $	 0.9Q�65   $ 5q�6C   ._�52      �� #��z 6/   #��z��53   /   54      55      57      58      �� 5:   
   $# chartData:BaseXyzSeriesInfo3D��6<   .R�5;      �� .+�5<      �� $ Vertical=�6   .+�5=      �� �� 5>      $
��Bold"�6   $	�X: ��60    �� 5?      �6   �� *	HitVertex+8   $ Z��5@      �� 5A      �� 5B      $
��Bold"�6   $	�Y: ��60    �� 5C      �6   �� *	HitVertex+8  $ X��5D      �� 5E      �� 5F      $
��Bold"�6   $	�Z: ��60    �� 5G      �6   �� *	HitVertex+8  $ Y��5H      5I      5J      5K      5L      .��5N      � ���	#001C1C1E � ColumnDefinitions 5O   
   �� 5P      $��* �6   �� 5Q      $��50 �6   .+�5S   
   � $��1��6    � RowDefinitions 5T      �� 5U      $��50 �6    �� 5V      $��50 �6    �� 5W      $��50 �6    �� 5X      $��50 �6    �� 5Y      $��50 �6    �� 5Z      $��50 �6    �� 5[      $��50 �6    �� 5\      $��50 �6    �� 5]      $��50 �6    �� 5^      $��* �6    �� 5_      $��50 �6    .+�5b      �� -   5         ��Name$ uiZoomInBtn��5b      $��0��6*   $��1q�67   ��5c      �� 5d      " ��6&   .R�5e      ��  ��Name$ image��6    $"��hmlib_icon/viewer_zoomin.png��5f   	   $
��None=�5g   	    �� Triggers 5h      P� 5i        P� Property  �@J�IsMouseOver! P� Value! . . �5j   "   ��  �@�Cursor$
 Hand��6;   �� 5k   "   " �� 
TargetName$" image��6)    � ��$$ hmlib_icon/viewer_zoomin_c.png��5l   )   5m      P� 5n        � ��! . . �5o   "   ��  �@�Cursor$  ��6;   �� 5p   "   $" image��6)    � ��$$ hmlib_icon/viewer_zoomin_c.png��5q   )   5r      5t      # � ToolTip# 5v      _� 5w      $��Zoom In��6   5y      �� 5z      -   5        $ uiZoomOutBtn��5z      $��1��6+   $��1q�68   ��5{      �� 5|      " ��6&   .R�5}      �� $ image��6    $#��hmlib_icon/viewer_zoomout.png��5~   	   $
��None=�5   	    5�      P� 5�        �@J�IsMouseOver! . . �5�   "   ��  �@�Cursor$
 Hand��6;   �� 5�   "   $" image��6)    � ��$% hmlib_icon/viewer_zoomout_c.png��5�   )   5�      P� 5�        � ��! . . �5�   "   ��  �@�Cursor$  ��6;   �� 5�   "   $" image��6)    � ��$% hmlib_icon/viewer_zoomout_c.png��5�   )   5�      5�      # 5�      _� 5�      $��Zoom Out��6   5�      �� 5�      -   5        $ uiZoomFitBtn��5�      $��2��6+   $��1q�68   ��5�      �� 5�      " ��6&   .R�5�      �� $ image��6    $��hmlib_icon/viewer_fit.png��5�   	   $
��None=�5�   	    5�      P� 5�        �@J�IsMouseOver! . . �5�   "   ��  �@�Cursor$
 Hand��6;   �� 5�   "   $" image��6)    � ��$! hmlib_icon/viewer_fit_c.png��5�   )   5�      P� 5�        � ��! . . �5�   "   ��  �@�Cursor$  ��6;   �� 5�   "   $" image��6)    � ��$! hmlib_icon/viewer_fit_c.png��5�   )   5�      5�      # 5�      _� 5�      $��Zoom Fit��6   5�      �� 5�      -   5        $ uiTopViewBtn��5�      $��3��6+   $��1q�68   ��5�      �� 5�      " ��6&   .R�5�      �� $ image��6    $��hmlib_icon/viewer_top.png��5�   	   $
��None=�5�   	    5�      P� 5�        �@J�IsMouseOver! . . �5�   "   ��  �@�Cursor$
 Hand��6;   �� 5�   "   $" image��6)    � ��$! hmlib_icon/viewer_top_c.png��5�   )   5�      P� 5�        � ��! . . �5�   "   ��  �@�Cursor$  ��6;   �� 5�   "   $" image��6)    � ��$! hmlib_icon/viewer_top_c.png��5�   )   5�      5�      # 5�      _� 5�      $��Top View��6   5�      �� 5�      -   5        $ uiROIBtn��5�      $��4��6'   $��1q�64   ��5�      �� 5�      " ��6&   .R�5�      �� $ image��6    $��hmlib_icon/viewer_roi.png��5�   	   $
��None=�5�   	    5�      P� 5�        �@J�IsMouseOver! . . �5�   "   ��  �@�Cursor$
 Hand��6;   �� 5�   "   $" image��6)    � ��$! hmlib_icon/viewer_roi_c.png��5�   )   5�      P� 5�        � ��! . . �5�   "   ��  �@�Cursor$  ��6;   �� 5�   "   $" image��6)    � ��$! hmlib_icon/viewer_roi_c.png��5�   )   5�      5�      # 5�      _� 5�      $	��ROI��6   5�      �� 5�      -   5        $ 	uiLineBtn��5�      $��5��6(   $��1q�65   ��5�      �� 5�      " ��6&   .R�5�      �� $ image��6    $%��hmlib_icon/viewer_crossline.png��5�   	   $
��None=�5�   	    5�      P� 5�        �@J�IsMouseOver! . . �5�   "   ��  �@�Cursor$
 Hand��6;   �� 5�   "   $" image��6)    � ��$' !hmlib_icon/viewer_crossline_c.png��5�   )   5�      P� 5�        � ��! . . �5�   "   ��  �@�Cursor$  ��6;   �� 5�   "   $" image��6)    � ��$' !hmlib_icon/viewer_crossline_c.png��5�   )   5�      5�      # 5�      _� 5�      $��ROI Line��6   5�      �� 5�      -   5        $ 
uiClearBtn��5�      $��6��6)   $��1q�66   ��5�      �� 5�      " ��6&   .R�5�      �� $ image��6    $!��hmlib_icon/viewer_clear.png��5�   	   $
��None=�5�   	    5�      P� 5�        �@J�IsMouseOver! . . �5�   "   ��  �@�Cursor$
 Hand��6;   �� 5�   "   $" image��6)    � ��$# hmlib_icon/viewer_clear_c.png��5�   )   5�      P� 5�        � ��! . . �5�   "   ��  �@�Cursor$  ��6;   �� 5   "   $" image��6)    � ��$# hmlib_icon/viewer_clear_c.png��5  )   5     5     # 5     _� 5     $��
ROI Delete��6   5	     �� 5
     -   5        $ uiHColorBtn��5
     $��7��6*   $��1q�67   ��5     �� 5     " ��6&   .R�5     �� $ image��6    $"��hmlib_icon/viewer_hcolor.png��5  	   $
��None=�5  	    5     P� 5       �@J�IsMouseOver! . . �5  "   ��  �@�Cursor$
 Hand��6;   �� 5  "   $" image��6)    � ��$$ hmlib_icon/viewer_hcolor_c.png��5  )   5     P� 5       � ��! . . �5  "   ��  �@�Cursor$  ��6;   �� 5  "   $" image��6)    � ��$$ hmlib_icon/viewer_hcolor_c.png��5  )   5     5     # 5     _� 5     $��Height Color��6   5!     �� 5"     -	   5        $ 
uiRulerBtn��5"     $��8��6)   $��1q�66   ��5#     �� 5$     " ��6&   .R�5%     �� $ image��6    $!��hmlib_icon/viewer_ruler.png��5&  	   $
��None=�5'  	    5(     P� 5)       �@J�IsMouseOver! . . �5*  "   ��  �@�Cursor$
 Hand��6;   �� 5+  "   $" image��6)    � ��$# hmlib_icon/viewer_ruler_c.png��5,  )   5-     P� 5.       � ��! . . �5/  "   ��  �@�Cursor$  ��6;   �� 50  "   $" image��6)    � ��$# hmlib_icon/viewer_ruler_c.png��51  )   52     54     # 56     _� 57     $��Ruler��6   59     �� 5:     -
   5        $ uiSetBtn��5:     $��10��6'   $��1q�65   ��5;     �� 5<     " ��6&   .R�5=     �� $ image��6    $��hmlib_icon/viewer_set.png��5>  	   $
��None=�5?  	    5@     P� 5A       �@J�IsMouseOver! . . �5B  "   ��  �@�Cursor$
 Hand��6;   �� 5C  "   $" image��6)    � ��$! hmlib_icon/viewer_set_c.png��5D  )   5E     P� 5F       � ��! . . �5G  "   ��  �@�Cursor$  ��6;   �� 5H  "   $" image��6)    � ��$# hmlib_icon/viewer_ruler_c.png��5I  )   5J     5L     # 5N     _� 5O     $��Setting��6   5Q     5R     +   %SciChart.Charting3D.SciChart3DSurface  5X  
   -   5        $  Name$$ sciChart��5X      $��0��62   $��0q�6B   %   WorldDimensions$% 1000,1000,1000 6V   
������ &   Camera#& [ 5Y  _   '   RenderableSeries' 5[     H   BSciChart.Charting3D.RenderableSeries.SurfaceMeshRenderableSeries3D  -   5        (  Name$( backgroundSurfaceMesh��5[  4     5\     -   5        $!( surfaceMeshRenderableSeries��5\  4   )   
DrawMeshAs$) 	SolidMesh=�5]  4   *   	DrawSkirt* .  +   MeshColorPalette#+ [ 5`  4   ?	   9SciChart.Charting3D.Modifiers.Tooltip3D.TooltipModifier3D, 	  TooltipContainerStyle#, [ 5a  4   - 	  TooltipTemplate#- [ 5b  4   A
   ;SciChart.Charting3D.RenderableSeries.BaseRenderableSeries3D. 
  
DataSeries. 5_  4   �� *MeshDataSeries+5b  4   D   >SciChart.Charting3D.RenderableSeries.ScatterRenderableSeries3D  5c     -   5        /  Name$/ scatterRenderableSeries��5c  0   0   XAxis0 5f     ,   &SciChart.Charting3D.Axis.NumericAxis3D  5g     -   5        1  Name$1 XAx3D��5g  $   $��10(�63   -  'SciChart.Charting.Visuals.Axes.AxisCore2   	AxisTitle$2 X��5h  $   3   TextFormatting$3 n2��5i  $   4   	AutoRange$4 Always=�5j  $   5   VisibleRange5 5k  $   �� *
XAxisRange+6   YAxis6 5n       5o     -   5        $1 YAx3D��5o  $   $��10(�63   $2 Z��5p  $   $3 n2��5q  $   $4 Never=�5r  $   5 5s  $   �� *
YAxisRange+7   ZAxis7 5v       5w     -   5        $1 ZAx3D��5w  $   $��10(�63   $2 Y��5x  $   $3 n2��5y  $   $4 Always=�5z  $   5 5{  $   �� *
ZAxisRange+8   ChartModifier8 5~     3   -SciChart.Charting3D.Modifiers.ModifierGroup3D  5     9   ChildModifiers.9 5�     3   -SciChart.Charting3D.Modifiers.OrbitModifier3D  7   1SciChart.Charting3D.Modifiers.ChartModifierBase3D:   	ExecuteOn$: MouseLeftButton=�6*   =   7SciChart.Charting3D.Modifiers.VertexSelectionModifier3D  5�     $: MouseRightButton=�64   ;   ExecuteWhen$
; Ctrl=�6Q   6   0SciChart.Charting3D.Modifiers.FreeLookModifier3D  5�     <   MovementSpeed$	< 100��6-   =   
ForwardKey$= W��5�  %   >   BackKey$> S��64   ?   RightKey$? D��6@   @   LeftKey$@ A��6M   A   UpKey$A E��5�  %   B   DownKey$B C��6/   C   	IsEnabledC .  5�  %   <   6SciChart.Charting3D.Modifiers.MouseWheelZoomModifier3D  5�     	  5�     -   5        $��tooltip��5�  ,   9   3SciChart.Charting3D.Modifiers.ZoomExtentsModifier3D  5�     D   ResetPosition$D -1000,500,1000 60   E   ResetTarget$E 0,100,0 6O   F   AnimateDurationMs$	F 500X�6f   5�     5�     �� 5�  
   ���#555$��0��6#   $��Right=�63   $	��Top=�6O   $��10q�6g   $��1q�5�     
�������G �� CornerRadius$G 2��69   $	 0.4Q�6J   $	��300��5�     ._�5�     � ���#FFF  5�     ��%S   '��       �� 5�     " ��6   .�5�     ��  � ��$	 3,5q�63   5�     5�      5�     �� 5�     $
��Auto �6'   �� 5�     $
��Auto �6'    5�     �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   �� 5�     $
��Auto �6$   .+�5�     �� $��Bound Camera��6   $
��Bold"�60   �� 5�     ���#FFF$��1��6+   $��1��66   $	��3,5q�6C   $��2��6P   �� 5�     $��	Position:��6   $��2��6-   $
��Bold"�6:   �� 5�     $��Target:��6   $��3��6+   $
��Bold"�68   �� 5�     $��Pitch:��6   $��4��6*   $
��Bold"�67   �� 5�     $
��Yaw:��6   $��5��6(   $
��Bold"�65   �� 5�     $��Radius:��6   $��6��6+   $
��Bold"�68   �� 5�     $��Projection Mode:��6   $��7��64   $
��Bold"�6A   �� 5�     $��Field Of View:��6   $��8��62   $
��Bold"�6?   �� 5�     $��Orthographic:��6   $��9��61   $
��Bold"�6>   �� 5�     $��0��6   $��1��6)   �� 5�     $�'��6   �� 6%   �6)   �� H �� SourceH %  System.Windows.Markup.Reference  I   Name$I sciChart��J �� Path$J Camera.CameraId�K �� FallbackValue$K NA���� 6�   $�'��6�   5�     �� 5�     $��2��6�   $��1��6�   ��6   �� H   $I sciChart��$J Camera.Position�$K NA��# [  6�   �� 5�     $��3��6�   $��1��6�   ��6   �� H   $I sciChart��$J Camera.Target�$K NA��# [  6�   �� 5�     $��4��6~   $��1��6�   ��6   �� H   $I sciChart��$J Camera.OrbitalPitch�$K NA��6�   �� 5�     $��5��6|   $��1��6�   ��6   �� H   $I sciChart��$J Camera.OrbitalYaw�$K NA��6�   �� 5�     $��6��6x   $��1��6�   ��6   �� H   $I sciChart��$J Camera.Radius�$K NA��6�   �� 5�     $��7��6�   $��1��6�   ��6   �� H   $I sciChart��$J Camera.ProjectionMode�$K NA��6�   �� 5�     $��8��6}   $��1��6�   ��6   �� H   $I sciChart��$J Camera.FieldOfView�$K NA��6�   �� 5�     $��9��6   $��1��6)   �� 5�     $�Width=��6    �� 5�     �6   �� H   $I sciChart��$J Camera.OrthoWidth�$K NA�� �� 5�     $�	, Height=��6    �� 5�     �6   �� H   $I sciChart��$J Camera.OrthoHeight�$K NA��5�     5�     5�     /  )SciChart.Charting.Visuals.HeatmapColorMap  5�  
   $��1��6   $��0��6*   $	��200��5�     $��15q�5�     $��Right=�5�     $��Bottom=�5�     ���#777$��1q�5�     $	 0.8Q�5�     L   Orientation$L Vertical=�5�     M   TextFormatting$
M 0.00��5�     ��5�     �� N �� ElementName$N sciChart��$J 
Background���5�     �� $N sciChart��$J 
Foreground�O   MaximumO 5�     �� $!N surfaceMeshRenderableSeries��$J Maximum�P   MinimumP 5�     �� $!N surfaceMeshRenderableSeries��$J Minimum�Q   ColorMapQ 5�     �� 5�     .��5�     � $ 1Q�6#   $ #FF0DD1��6.   � 5�     $
 0.95Q�6#   $ #E80C50��61   � 5�     $	 0.9Q�6#   $ #FF0E00��60   � 5�     $
 0.85Q�6#   $ #E8380C��61   � 5�     $	 0.8Q�6#   $ #FF610D��60   � 5�     $
 0.75Q�6#   $ #FF7D0D��61   � 5�     $	 0.7Q�6#   $ #E8900C��60   � 5�     $
 0.65Q�6#   $ #FFB300��61   � 5�     $	 0.6Q�6#   $ #E8BD0C��60   � 5�     $
 0.55Q�6#   $ #FFE80D��61   � 5�     $	 0.5Q�6#   $ #C5FF0D��60   � 5�     $
 0.45Q�6#   $ #67E80C��61   � 5�     $	 0.4Q�6#   $ #10FF00��60   � 5�     $
 0.35Q�6#   $ #0CE83F��61   � 5�     $	 0.3Q�6#   $ #0DFF89��60   � 5�     $
 0.25Q�6#   $ #09C2FF��61   � 5�     $	 0.2Q�6#   $ #0876E8��60   � 5�     $
 0.15Q�6#   $ #033CFF��61   � 5�     $	 0.1Q�6#   $ #1108E8��60   � 5�     $	 0.0Q�6#   $ #5609FF��60   5�     5     5     5     