   M S B A M L   `   `   `  ����A  =wpf_SH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:wpf_SHwpf_SH  5          wpf_SH.page_place   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:wpf_SH     5      H DMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=null@MetroControls,http://metro.mahapps.com/winfx/xaml/controls  5        N� Title$  
page_place��5
       N� 
Background �#1c1c1d � 	Resources 5         DataSample_place �� 
TargetType �� Property �� Value��%�  &	        '�� z    '��     � 5   
   .��5      �
�
<Places xmlns="">
                    <place>
                        <ID>1</ID>
                        <D1>办公室</D1>
                        <D2>大成路22号</D2>
                        <D3>微软</D3>
                        <D4>联系人：18063222346</D4>
                        <D5>无</D5>
                    </place>
                    <place>
                        <ID>2</ID>
                        <D1>办公室</D1>
                        <D2>大明路2号</D2>
                        <D3>微软</D3>
                        <D4>联系人：18063222346</D4>
                        <D5>无</D5>
                    </place>
                    <place>
                        <ID>3</ID>
                        <D1>办公室</D1>
                        <D2>光华路22号</D2>
                        <D3>微软</D3>
                        <D4>联系人：18063222346</D4>
                        <D5>无</D5> &gt;
                        <Age>103</Age>
                    </place>
                    <place>
                        <ID>4</ID>
                        <D1>办公室</D1>
                        <D2>御道街11号</D2>
                        <D3>微软</D3>
                        <D4>联系人：18063222346</D4>
                        <D5>无</D5>
                    </place>
                </Places>        54      �� 59   
   " ��6   .�5:      ��  � �� �#1818186+   �� 5;       � �� �#9999996+   �� 5<       � ��$ 12(�6)   5=      �� 5>   
   " ��6   .�5?      ��  � �� �#2d2c316+   �� 5@       � �� �#6666666,   �� 5A       � �� �#9999996+   �� 5B       � ��$ 11(�6)   5C      5D      .��5E      0  *MahApps.Metro.Controls.MetroContentControl  .��5F   
   �  � ColumnDefinitions 5G   
   �� 5H      $
��10.5 �6   �� 5I      $
��57.5 �6   �� 5J      $	��150 �6   �� 5K      $��10 �6   �� 5L      $��65 �6   �� 5M      $��* �6   �� 5N      $��65 �6   �� 5O      $��10 �6    � RowDefinitions 5Q   
   �� 5R      $��5 �6   �� 5S      $��20 �6   �� 5T      $��5 �6   �� 5U      $��* �6   .+�5X   
   �� $��地点名称��6   $
��Left=�6   $��1��6;   $��Center=�6K   ���#7d7b80$��3��6{   $��12(�6�   �� 5Y   
   $��2��6   $��1��6#    �� TextWrapping$
 Wrap=�60   $�� ��6D   $��Center=�6L   ���#26252A6h   �� 5Z   
   $��搜索��6   $��4��6   $��1��6/   $	��Top=�6<   �� 5[      -   5        $��添加��5[      $��6��6#   $��1��63   $	��Top=�6@   6Y   &   System.Windows.Controls.DataGrid  5^      -   5        $��dg_user��5^      $��6��6&   $��1��6:   $��3��6J   ���#222125���#666666	   RowBackground	 �#1c1c1d
   RowHeaderWidth$
 0Q�6�      HorizontalGridLinesBrush �#303037   VerticalGridLinesBrush �#303037$��Center=�5_   W   $��Center=�6{      AutoGenerateColumns .  ��5`      ��  �� Source# [   �� XPath$ /Places/place��   ColumnHeaderStyle 5c      �� 5d      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5e      ��  � �� �#46474963   �� 5f       � �� �#ffffff63   �� 5g       � ��$ 12(�61   �� 5h       � ��$ 20��6/   �� 5i       � ��$ Center=�6C   5j         Columns 5l      0  *System.Windows.Controls.DataGridTextColumn  5m      ,  &System.Windows.Controls.DataGridColumn   Header$ 序号��6)      
Foreground
 �����1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   ��  �� Mode$ OneWay=�$ ID��  5n      $ 地点名称��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 67   
 ����� 6X   �� $ OneWay=�$ D1��  5o      $ 详细地址��6)   $	 100 67   
 ����� 6W   �� $ OneWay=�$ D2��  5p      $ 所属单位��6*   $	 100 68   
 ����� 6X   �� $ OneWay=�$ D3��  5q      $ 联系方式��6*   $	 150 68   
 ����� 6X   �� $ OneWay=�$ D4��  5r      $ 备注��6)   $ * 65    6A   �� $ OneWay=�$ D5��4  .System.Windows.Controls.DataGridTemplateColumn  5s      $ 操作��6-   $ 70 6:      CellTemplate 5t      �� 5u      .R�5v   "   ��  �� Orientation$ 
Horizontal=�6-   $��Center=�6F   .+�5w   &   �� -   5        $��编辑��5w   .   $��40��6;   $��5,0,5,0q�6F   ���#3030336l   �� 5x   &   $��X��6.   $��20��6:   $��0,0,5,0q�6E   ���#3030336V   5y   #   5z      5|      5~      5      5�      5�      