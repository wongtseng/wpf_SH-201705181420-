   M S B A M L   `   `   `  ����A  =wpf_SH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:wpf_SH.evaluatewpf_SH.evaluate  5          wpf_SH.evaluate.Page_Eval   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:wpf_SH.evaluate     5        N� 
Background  �#2d2c31 N� Title$ 	Page_Eval��5
       � 	Resources 5         userinfo � Source � XPath �� 
TargetType �� Property �� Value��%�  &	        '�� A     '�� �     � 5   
   $ datesource.xml?�6+   $ userInfo/user��6C   �� 5   
   " ��6   .�5      ��  � �� �#1818186+   �� 5       � �� �#9999996+   �� 5       � ��$ 12(�6)   5      �� 5   
   " ��6   .�5      ��  � �� �#2221256+   �� 5       � �� �#6666666,   �� 5       � �� �#ffffff6+   �� 5       � ��$ 11(�6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��73* �6   �� 5      $	��50* �6   �� 5       $��40 �6   .+�5"   
   �� ���#252527$��0��6&   $��5q�63   ._�5#      &   System.Windows.Controls.DataGrid  -   5        $��dg_user��5#      ���#222125���#666666	   RowBackground	 �#1c1c1d
   RowHeaderWidth$
 0Q�6k      HorizontalGridLinesBrush �#303037   VerticalGridLinesBrush �#303037$��Center=�5$   W   $��Center=�6{      AutoGenerateColumns .     ColumnHeaderStyle 5&      �� 5'      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5(      ��  � �� �#46474967   �� 5)       � �� �#ffffff67   �� 5*       � ��$ 12(�65   �� 5+       � ��$ 20��63   �� 5,       � ��$ Center=�6G   5-         Columns 5/      4  .System.Windows.Controls.DataGridTemplateColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ 状态��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6:      CellTemplate 51      �� 52      .R�53   "   �� $��../images/check.png��6(   $��20��6E   6R   54      56      0  *System.Windows.Controls.DataGridTextColumn  57      $ 序号��6)   $ 70 65      
Foreground
 �����6A     58      $ 检查对象��6)   $	 150 67   
 �����6C     59      $ 检查手段��6*   $ 70 68   
 �����6C     5:      $ 	执行人��6*   $ 70 67   
 �����6B     5;      $ 执行状态��6)   $
 Auto 67   
 �����6E     5<      $ 开始时间��6)   $ 70 67   
 �����6D     5=      $ 上报时间��6)   $ * 67   
 �����6B     5>      $ 评估说明��6)   $ * 67   
 �����6B   .@�5@      �� 5A      5B      �� 5C   
   ���#252527$��1��6(   $��5q�65   ._�5D      �� $����整体评估结果【符合规范】【不符合规范】-【列出不符合的内容，未完成、时间不符合、顺序错误】��6   6N   5G      �� 5I   
   ���#2d2c31$��2��6)   ._�5J      �� $��评估结果上报��6   $	��100��6*   $��Right=�66   $��5q�6R   6_   5K      5O      5P      