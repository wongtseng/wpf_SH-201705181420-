   M S B A M L   `   `   `  ����Y  UMitov.PlotLabBasic, Version=7.6.0.0, Culture=neutral, PublicKeyToken=1bb0b8a97236ac2eI7clr-namespace:Mitov.PlotLab;assembly=Mitov.PlotLabBasicMitov.PlotLab  5      A =MyPlot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:MyPlot;assembly=MyPlotMyPlot 5   	   A =wpf_SH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:wpf_SHwpf_SH 5         wpf_SH.Page_SignalAnal   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Kplotlab7clr-namespace:Mitov.PlotLab;assembly=Mitov.PlotLabBasic     5      2v$clr-namespace:MyPlot;assembly=MyPlot     5   	   &localclr-namespace:wpf_SH     5        N� 
Background  �#262626 N� Title$ Page_SignalAnal��5       � 	Resources 5       �� Source�� 5   
   $ ../style.xaml?�6   %    66   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $
��103* �6   �� 5      $	��160 �6   .+�5   
   �� $��0��6   6    �� 5   
   $��1��6   ._�5      � ���#2e2e2e 5      �� 5      $	��50* �6$   �� 5      $	��50* �6$   �� 5      $	��50* �6$    � ColumnDefinitions 5       �� 5!      $	��50* �6'   �� 5"      $	��50* �6'   .+�5%      7  1System.Windows.Forms.Integration.WindowsFormsHost  $��5q�6%   $��1��61   $��0��6@      Child. 5&        MyPlot.uc_Scope  [ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"  System.Windows.Forms.Control   Name$ scope1��6!   5'        5(      -   5          Name$
 Host��5(   .   $��5q�6#   $��0��6=   $��0��6L   . 5*        MyPlot.uc_waterfall  $ 
waterfall2��6%   5+        5,      $��5q�6&   $��2��61   $��0��6@   . 5-        $ scope2��6!   5.      �� 52      $��0��6   $��1��6&   
���   �$��5q�6I   ._�53      �  54      �� 55      $	��50* �6(   �� 56      $��30 �6(    59      �� 5:      $	��50* �6+   �� 5;      $	��50* �6+   .+�5>      �� $��0��6    $��..\images/xz.png��6-   $��10q�6G   6U   �� 5?      $��0��6    $��1��6-   $��..\images/xz.png��6=   $��10q�6X   6f   �� 5@      $��1��6!   $��Center=�6.   
�������$��Center=�6]   $��14(�6z   .��6�   绝对星座图6�   �� 5A      $��1��6!   $��1��6/   
�������$��Center=�6R   $��Center=�6m   $��14(�6�   .��6�   查分星座图6�   5B      5E      �� 5F      $��1��6   $��1��6&   
���   �$��5q�6I   ._�5G      �� $��Center=�6   $��Center=�67   $��14(�6T   .��6b   眼图6f   5H      �� 5J      $��2��6   $��1��6&   
���   �$��5q�6I   5L      5O      5S      �� 5T   
   $��4��6   ._�5U      &   System.Windows.Controls.DataGrid  -   5        $��dg_user��5U      $��6��6&   $��1��6:   $��3��6J   ���#222125���#666666	   RowBackground	 �#1c1c1d
   RowHeaderWidth$
 0Q�6�      HorizontalGridLinesBrush �#303037   VerticalGridLinesBrush �#303037$��Center=�5V   W      AutoGenerateColumns .     ColumnHeaderStyle 5Z      �� 5[       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5\      ��  �� Property � �� �� Value �#46474967   �� 5]       � �� �#ffffff67   �� 5^       � ��$ 12(�65   �� 5_       � ��$ 25��63   �� 5`       � ��$ Center=�6G   5a         Columns 5c      0  *System.Windows.Controls.DataGridTextColumn  5d      ,  &System.Windows.Controls.DataGridColumn   Header$ 序号��6)      Width5	  /System.Windows.Controls.DataGridLengthConverter$ 30	 66      
Foreground
 �����1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6T   ��  �� Mode$ OneWay=� �� XPath$ ID��  5e      $ 中心频率��6)   $ 70	 67   
 ����� 6W   �� $ OneWay=�$ D1��  5f      $ 带宽��6)   $ 70	 65   
 ����� 6T   �� $ OneWay=�$ D2��  5g      $ 	信噪比��6*   $ 80	 67   
 ����� 6V   �� $ OneWay=�$ D3��  5h      $ 调制方式��6*   $ 90	 68   
 ����� 6W   �� $ OneWay=�$ D4��  5i      $ 调制速率��6)   $
 Auto	 67   
 ����� 6Y   �� $ OneWay=�$ D5��  5j      $ 通信体制��6)   $ 70	 67   
 ����� 6W   �� $ OneWay=�$ D6��4  .System.Windows.Controls.DataGridTemplateColumn  5k      $ 人工研判��6.   $
 300*	 6<      CellTemplate 5l      �� 5m      .R�5n   "   �� 6,   5o      5q      .@�5s      �� �� 5t      �� 5u      �� 5v      �� 5w      �� 5x      �� 5y      5z      5|      5      5�      