   M S B A M L   `   `   `  ����A  =Lab_11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab_11Lab_11  5          Lab_11.Element   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Lab_11     5      .��5	      �� $	��170��6   $��20q�6   
�������  J� Effect  5
   
   -  'System.Windows.Media.Effects.BlurEffect  5      -   5        
blur_1��5   +    � Triggers 5   
   :� 5       :� RoutedEvent$ 
MouseLeave��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ blur_1��6*    �� TargetProperty$ Radius�6I   	 W� To 56l    g� Duration$ 0:0:1D�6s   W� 5      $ scale_1��6*   $ ScaleX�6J    16m   $ 0:0:1D�6t   W� 5      $ scale_1��6*   $ ScaleY�6J    16m   $ 0:0:1D�6t   5      5      5      .+�5   
   �� -   5         ��Name$ textbox��5      .��6$   75https://ejin.ru/wp-content/uploads/2017/09/20-416.jpg6[   �� 5   
   -   5         ��Name$ image��5   )   $	��170��6   $	��190��6   $��Images/1.jpg��68    5      :� 5      $ 
MouseEnter��6   .[�5      �� .��5      �� .��5      W� $ blur_1��6.   $ Radius�6M    06p   $ 0:0:1D�6w   W� 5      $ scale_1��6.   $ ScaleX�6N    1.756q   $ 0:0:1D�6{   W� 5       $ scale_1��6.   $ ScaleY�6N    1.756q   $ 0:0:1D�6{   5!      5"      5#      z�5%      �� 5&      -   5        
rotate��	 �� CenterX$	 85Q�5&   3   
 �� CenterY$
 55Q�6@   5(      �� 5)   
    �� Orientation$ 
Horizontal=�6   .+�5*      �� 
�������$��30��6)   $��30��64   $
��35 0q�6@   .��5+      �� $��Images/left.png��6    5,      :� 5-      $ MouseLeftButtonDown��6'   .[�5.      �� .��5/   "   �� .��50   &   W� $ rotate��66   $ Angle�6U   	 W� By -906w   $ 0:0:0.1D�6�   51   #   52      53      55      56      �� 57      
�������$��30��6(   $��30��63   .��58      �� $��Images/right.png��6    59      :� 5:      $ MouseLeftButtonDown��6'   .[�5;      �� .��5<   "   �� .��5=   &   W� $ rotate��66   $ Angle�6U    906w   $ 0:0:0.1D�6   5>   #   5?      5@      5B      5D      5E      z�5F   
   V� 5G      .~�5H      �� -   5        scale_1�� �� ScaleX$ 1Q�5H   2    �� ScaleY$ 1Q�6=   5I      5K      5L      