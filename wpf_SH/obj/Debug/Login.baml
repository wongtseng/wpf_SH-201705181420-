   M S B A M L   `   `   `  ����A  =wpf_SH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:wpf_SHwpf_SH  5   	       wpf_SH.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:wpf_SH     5   	   H DMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=null@MetroControls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � Title$  Login��5	   	   $	��241��5
   	   $��506.977��5   	    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�6   ���#2279d6$��1q�5   	   ���#2d2c31 � TaskbarItemInfo 5      *  $System.Windows.Shell.TaskbarItemInfo  5   
    � 	Resources 5       �� Source�� 5   
   $ 
style.xaml?�6   %    63   .��5      0  *MahApps.Metro.Controls.MetroContentControl  .��5   
   �  � ColumnDefinitions 5   
   �� 5      $
��186* �6   �� 5      $��9* �6   �� 5      $��80 �6   �� 5       $��5* �6   �� 5!      $��78.531 �6   �� 5"      $
��43.9 �6   	 � RowDefinitions	 5$   
   �� 5%      $	��69* �6   �� 5&      $	��15* �6   �� 5'      $��30 �6   �� 5(      $��30 �6   �� 5)      $��28.246 �6   �� 5*      $	��38* �6   �� 5+      $	��28* �6   .+�5-   
   �� -   5        $��tb_username��5-   *   ���#666666���#ffffff���#3f3f47$��2��6i   $
��Left=�6y   $��20��6�   $��2��6�   
 �� TextWrapping$

 Wrap=�6�   $��Center=�6�   $	��163��6�   $	��0,5q�6�   $��3��6�   �� 5.   
   $��	用户名��6   ���#ffffff$��115,2.5,8.5,0q�66   $��2��6M   $	��Top=�6Z   $��Right=�6r   $��26��6�   $��2��6�   �� 5/   
   $��	密   码��6   ���#ffffff$��115,0,8.5,0q�65   $��3��6J   $	��Top=�6W   $��25��6o   $��2��6{   $��Right=�6�   �� 50   
   $��工作模式��6   ���#ffffff$��115,1,8.5,0q�65   $��4��6J   $	��Top=�6W   $��Right=�6o   $��26��6�   $��2��6�   G� 51   
   ���#666666���#ffffff���#3f3f47$��2��6[   $
��Left=�6k   $	��0,5q�6�   $��3��6�   $��Center=�6�   $	��163��6�   $��20��6�   $��3��6�   �� 52   
   $��2��6   $
��Left=�6&   $��0,4.123q�6A   $��4��6R   $��Center=�6_   $	��163��6z   $��20��6�   $��3��6�   .@�53      �� $��自检模式��6   $��Center=�6-   $	��163��6J   $��Center=�6V   �� 54      $��检查模式��6   $��Center=�6,   $	��163��6I   $��Center=�6U   �� 55      $��组网模式��6   $��Center=�6-   $	��163��6J   $��Center=�6V   56      �� 57   
   -   5        $��登录��57      $��2��6   ���#666666���#333237���#999999$
��Left=�6r   $��0q�6�   $��5��6�   $	��Top=�6�   $��80��6�   $��20��6�   $��Center=�6�   6�   �� 58   
   -   5        $��取消��58      $��4��6   ���#666666���#333237���#999999$
��Left=�6q   $��0q�6�   $��5��6�   $	��Top=�6�   $��78��6�   $��20��6�   $��0q�6�   5;      5<      5=      