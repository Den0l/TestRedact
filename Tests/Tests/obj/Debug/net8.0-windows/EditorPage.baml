   M S B A M L   `   `   `  ����@  <Tests, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TestsTests  5      W SNewtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeedJ6clr-namespace:Newtonsoft.Json;assembly=Newtonsoft.JsonNewtonsoft.Json 5          Tests.EditorPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:Tests     5      GJson6clr-namespace:Newtonsoft.Json;assembly=Newtonsoft.Json     5        N� Title$  
EditorPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��0.11* �6   �� 5      $
��0.1* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
EditorGrid��5      $��7��6'   �� 5   
   $��0��6   $��Center=�6$   $��1��6A   $
��Wrap=�6N   $��Имя��6b   �� 5   
   $��1��6   $��Center=�6$   $��1��6A   $
��Wrap=�6N   $��Описание��6b   �� 5    
   $��2��6   $��Center=�6$   $��1��6A   $
��Wrap=�6N   $��Первый вопрос��6b   �� 5!   
   $��3��6   $��Center=�6$   $��1��6A   $
��Wrap=�6N   $��Второй вопрос��6b   �� 5"   
   $��4��6   $��Center=�6$   $��1��6A   $
��Wrap=�6N   $!��Третьей вопрос��6b   �� 5#   
   $��5��6   $��Center=�6$   $��1��6A   $
��Wrap=�6N   $,��&Ответ (Номер вопроса)��6b   �� 5$   
   -   5         ��Name$ TextName��5$      $��0��6$   $��2��64    �� TextWrapping$
 Wrap=�6A   �� 5%   
   -   5        $ TextDesk��5%      $��1��6$   $��2��64   $
 Wrap=�6A   �� 5&   
   -   5        $ TextFirs��5&      $��2��6$   $��2��64   $
 Wrap=�6A   �� 5'   
   -   5        $ TextSeco��5'      $��3��6$   $��2��64   $
 Wrap=�6A   �� 5(   
   -   5        $ TextThri��5(      $��4��6$   $��2��64   $
 Wrap=�6A   �� 5)   
   -   5        $ TextAnsw��5)      $��5��6$   $��2��64   $
 Wrap=�6A   �� 5*   
   -   5         ��Name$ 
SaveButton��5*      $��6��6%   $'��!Сохранить/Удалить��65   $��2��6Q   6^   �� 5+   
   -	   5         ��Name$ 	ComboText��5+      $��6��6&   $��1��66   5-      5.      