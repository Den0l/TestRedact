   M S B A M L   `   `   `  ����@  <Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestsTests  5   	       Tests.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Tests     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��0.2* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��0.14* �6   �� 5      $��1* �6   .+�5   
   �� -   5         ��Name$ Editor_Button��5      $��1��6)   $"��Редактирование��69   6R   �� 5   
   -   5        $ Test_Button��5      $��2��6&   $��Прохождение��66   6L   �� 5   
   -   5        $ Exit_Button��5      $��
Выход��6&   66    � 5   
   -   5          �Name$ 	PageFrame��5        � NavigationUIVisibility$ Hidden=�6#   $��1��6C   $��3��6P   5      5      