   M S B A M L   `   `   `  ����A  =wpf_SH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:wpf_SHwpf_SH  5   	       wpf_SH.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:wpf_SH     5   	     � Title$  系统��5   	   $	��600��6   $	��960��6!   ���#2d2c31 � WindowStyle$
 None=�5	       � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � WindowState$ 	Maximized=�6m    � 	Resources 5       �� Source�� 5   
   $ 
style.xaml?�6   %    63   .��5      �  � ColumnDefinitions 5   
    � RowDefinitions 5   
   �� 5      $��28 �6   �� 5      $��2 �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $5��/便携式反窃密检查系统-原型系统v0.2��6   60   �� 5   
   -   5        $��0��5      $��X��6!   $��Right=�6-   $��Center=�6K   $��0,4,5,4q�6f   $��23��6x   $��20��6�   �� 5   
   -   5        $��-��5      $��Right=�6   $��0,4,30,4q�69   $��Center=�6K   $��23��6f   	 J� RenderTransformOrigin$	 -0.978,0.605&�6q   $��20��6�   �� 5   
   ���#3f3f47$��1,1,1,1q�6'   $��2��6B   ._�5       �� 
 �� Orientation$
 
Horizontal=�6   $��1��63   .+�5!         wpf_SH.uc_pluginbtn  -   5          Name$ UCrwgh��5!   3   $	��100��6'      p_type$ 任务管理��6E   $��5q�6T   6�     5"      -   5        $ UCdata��5"   3   $	��100��6&   $ 数据录入��6E   $��5q�6T   6�     5#      -   5        $ 
UCwireless��5#   3   $	��100��6&   $ 无线检查��6I   $��5q�6X   6�     5$      -   5        $ UCwire��5$   3   $	��100��6&   $ 有线检查��6E   $��5q�6T   6�     5%      -   5        $ UCphy��5%   3   $	��100��6&   $ 物理检查��6D   $��5q�6S   6�     5&      -   5        $ UCAssessment��5&   3   $	��100��6&   $ 综合评估��6K   $��5q�6Z   6�     5'      -	   5        $ 	UCoffline��5'   3   $	��100��6&   $ 离线分析��6H   $��5q�6W   6�     5(      -
   5        $ UCsbjk��5(   3   $	��100��6&   $ 设备监控��6E   $��5q�6T   6�     5)      -   5        $ UCdatemanage��5)   3   $	��100��6&   $ 数据管理��6K   $��5q�6Z   6�     5+      -   5        $ UCsystem��5+   3   $	��100��6&   $ 系统管理��6G   $��5q�6V   6�   5,      5-      �� 5.   
   -   5         ��Name$ MyContentControl��5.   &   $��4��6   ���#2d2c316W   �� 5/   
   -   5        $��lb_user��5/      $$��目前登录用户：wongtseng��6   $��Right=�6:   $��Center=�6W   $��	0,2,170,2q�6r   ���#ffffff$��24��6�   $	��186��6�   $��Right=�6�   $��Center=�6�   �� 50   
   $��注销��6   $��Right=�6   $��	0,2,122,2q�69   $��Center=�6L   ���#ffffff$��24��6}   $��34��6�   53      54      