   M S B A M L   `   `   `  ����M  IVideoGameCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:VideoGameCollectorVideoGameCollector  5   	   #    VideoGameCollector.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:VideoGameCollector     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	    � Title$ 	Dashboard��5   	   $	��720��6   $
��1280��6(   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��280 �6   �� 5      $
��Auto �6   .+�5   
    �   � Source$% UserControls/DashboardView.xaml?�6   $��1��5      $	��980��5      $��Center=�5      �� 5   
   
���   �$��0 0 0 0q�5      
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Opacity$	 0.5Q�5   #   ._�5!      � -   5        	 �Name$	 
LeftNavBar��5"      $��0��5!      
 � RowDefinitions
 5#      �� 5%      $
��Auto �6    �� 5'      $
��Auto �6    �� 5)      $
��Auto �6    �� 5+      $
��Auto �6    �� 5-      $
��Auto �6    �� 5/      $
��Auto �6    �� 51      $
��Auto �6    .+�55      �� $��Username Placeholder��6   $��20(�56      $��Center=�57      $��0 20 0 0q�58      $��0 0 0 30q�59      �� 5<      
������� J� Opacity$	 0.5Q�5=      	 �� X1$	 250��5>      $��1��5?      $��Center=�5@      $��Bottom=�5A      �� 5D      -   5         ��Name$ DashboardButton��5H      $��1��5D      $	��250��5E      $��50��5F      $��0 15 0 0q�5G         MaterialDesignFlatButton#��[  5I       �� 	IsDefault . .��5L      ��  �� Orientation$ 
Horizontal=�6   $	��200��5M      .+�5N      �� $��Assets/view-dashboard.png��6   $��Center=�5O      $��30��5P      $��30��5Q      $��0 0 21 0q�5R      �� 5S      $��	Dashboard��6    $��Center=�5T       5U      5V      �� 5Y      -   5        $ GamesButton��5]      $��2��5Y      $	��250��5Z      $��50��5[      $��0 15 0 0q�5\      #��[  5^      .��5`      �� $ 
Horizontal=�6   $	��200��5a      .+�5b      �� $��Assets/disc.png��6   $��Center=�5c      $��30��5d      $��30��5e      $��0 0 21 0q�5f      �� 5g      $��Games��6    $��Center=�5h       5i      5j      �� 5l      -   5        $ ConsolesButton��5p      $��3��5l      $	��250��5m      $��50��5n      $��0 15 0 0q�5o      #��[  5q      .��5s      �� $ 
Horizontal=�6   $	��200��5t      .+�5u      �� $��Assets/xboxbutton.png��6    $��Center=�5v      $��30��5w      $��30��5x      $��0 0 21 0q�5y      �� 5z      $��Console��6    $��Center=�5{       5|      5}      �� 5      -   5        $ PeripheralsButton��5�      $��4��5      $	��250��5�      $��50��5�      $��0 15 0 0q�5�      #��[  5�      .��5�      �� $ 
Horizontal=�6   $	��200��5�      .+�5�      �� $��Assets/gamepad-square.png��6   $��Center=�5�      $��30��5�      $��30��5�      $��0 0 21 0q�5�      �� 5�      $��Peripherals��6    $��Center=�5�       5�      5�      �� 5�      -   5        $ ExportButton��5�      $��5��5�      $	��250��5�      $��50��5�      $��0 15 0 0q�5�      #��[  5�      .��5�      �� $ 
Horizontal=�6   $	��200��5�      .+�5�      �� $��Assets/Export.png��6   $��Center=�5�      $��30��5�      $��30��5�      $��0 0 21 0q�5�      �� 5�      $��Export��6    $��Center=�5�       5�      5�      �� 5�      -   5        $ SettingsButton��5�      $��6��5�      $	��250��5�      $��50��5�      $��0 15 0 0q�5�      #��[  5�      .��5�      �� $ 
Horizontal=�6!   $	��200��5�   !   .+�5�      �� $��Assets/settings.png��6    $��Center=�5�       $��30��5�       $��30��5�       $��0 0 21 0q�5�       �� 5�      $��Settings��6$   $��Center=�5�   $   5�      5�      5�      5�      5�      5�      