   M S B A M L   `   `   `  ����D  @Lab_3_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Lab_3_WPF	Lab_3_WPF  5   	       Lab_3_WPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   )localclr-namespace:Lab_3_WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5       �� 
TargetType   ToolBarButtonStyle �� Property �� Value  MenuItemStyle��%�   &	        &	 k     �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5	       � �� 61   �� 5
      �� 5   
   " m�6   .�5      ��  �@m�CommandParameter 61   �� 5      5      .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $��Меню��6   #��[ 6%   .@�5      m� $(��"Изменить цвет фона��6    m� Command 67   �� *ChangeColorCommand+m� 5      $G��AПолучить информацию о разработчике��6    6G   �� *AboutDeveloperCommand+m� 5      $��
Выход��6    6*   �� *ExitCommand+5      5      c� 5   
   $	��Top=�6   .@�5      �� $(��"Изменить цвет фона��6   #��[  6Y   ��62   �� *ChangeColorCommand+6Y   �� 5      $G��AПолучить информацию о разработчике��6   #��[  6l   ��6B   �� *AboutDeveloperCommand+6l   �� 5      $��
Выход��6   #��[  6E   ��6%   �� *ExitCommand+6E   5      �� 5   
   $��Bottom=�6   .@�5      �� ��6   �� *StatusBarText+5      � 5   
   ��6   �� *BackgroundColor+5       5!      