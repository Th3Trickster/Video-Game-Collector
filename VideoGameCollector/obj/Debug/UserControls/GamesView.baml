   M S B A M L   `   `   `  ����M  IVideoGameCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:VideoGameCollector.UserControlsVideoGameCollector.UserControls  5      /    )VideoGameCollector.UserControls.GamesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:VideoGameCollector.UserControls     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������  � 	Resources  5      ��%    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   ��  *  &MaterialDesignOutlinedTextFieldTextBox#��[  6   $	��500��5       $��0 20 0 0q�5!      " �� VerticalScrollBarVisibility$ Disabled=�5"      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5#      $��Center=�5$      � 5'   
   $��1��6   $��0 10 0 0q�5(      $��Center=�5)       � ColumnDefinitions 5*      �� 5+      $	��200 �6#   �� 5,      $
��Auto �6#   �� 5-      $	��200 �6#   .+�51      ��   MaterialDesignFlatButton#��[ 6   $��0��52      $��Right=�53      $��0 0 60 0q�54      .��55      ��  �� Orientation$ 
Horizontal=�6   .+�56      �� $ ��/Assets/filter-variant.png��6   $��Center=�57      $��0 0 5 0q�58      �� 59      $��Filter��6    $��Center=�5:       5;      5<      �� 5?      $��All Platforms��6   $��1��5@      $��Center=�5A      $��Center=�5B      $
��Bold"�5C      �� 5F      #��[ 6   $��2��5G      $
��Left=�5H      $��60 0 0 0q�5I      .��5J      �� $ 
Horizontal=�6   .+�5K      �� $��/Assets/pencil.png��6   $��Center=�5L      $��0 0 5 0q�5M      �� 5N      $
��Edit��6    $��Center=�5O       5P      5Q      5R      �� 5U   
   $��Ordered By Title��6   $��2��5V      $��Center=�5W      $
��Bold"�5X      �� 5[   
   -   5         ��Name$
 List��5\      $��3��5[      $��Center=�5]      $	��700��5^      $	��400��5_      $��0 30 0 0q�5`        listBoxStyleWithImage#���  5a        ListBoxItemItemStyle#��[ 5b      �� 5e   
   $ 
Horizontal=�6   $��4��5f      $��Center=�5g      $��0 10 0 0q�5h      .+�5j      �� $	��Add��6   $	��100��5k      $��	0 0 200 0q�5l      �� 5n      $��Remove��6   $	��100��5o      5p      � 5s   
   $��5��6   $��Center=�5t      $��0 25 0 0q�5u       5v      �� 5w      $	��150 �6#   �� 5x      $	��150 �6#   �� 5y      $	��150 �6#   �� 5z      $	��150 �6#   �� 5{      $	��150 �6#   .+�5~      �� $��Browse Games��6   $��0��5      $	��135��5�      �� 5�      $��Detailed Report��6   $��1��5�      $	��135��5�      �� 5�      $��Upcoming��6   $��2��5�      $	��135��5�      �� 5�      $��Wishlist��6   $��3��5�      $	��135��5�      �� 5�      $��
Trade/Sell��6   $��4��5�      $	��135��5�      5�      5�      5�      