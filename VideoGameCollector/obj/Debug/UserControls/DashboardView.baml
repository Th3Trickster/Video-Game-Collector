   M S B A M L   `   `   `  ����M  IVideoGameCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:VideoGameCollector.UserControlsVideoGameCollector.UserControls  5      3    -VideoGameCollector.UserControls.DashboardView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:VideoGameCollector.UserControls     5      
�������.��5
      �   � ColumnDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   *   $VideoGameCollector.UserControls.Card  $��	60 40 0 0q�6      	CardImage$ /Assets/currency-usd.png��5         
CardHeader$ Total Collection Value��5         CardDescription$ $1,000��5         
CardFooter$$ Check Your Most Valuable Items��5         CardButtonIcon$ 
ArrowRight��5         CardLeadingTextIcon$ /Assets/eye.png��5         CardImageBackground$ #56af5a��5        5   
   $��	30 40 0 0q�6   $��1��5      $ /Assets/nes-cartridge.png��5       $ #eb4945��5!      $ Number Of Games Owned��5"      $	 500��5#      $$ Check Your Most Valuable Games��5$      $ 
ArrowRight��5%      $ /Assets/eye.png��5&        5(   
   $��	60 40 0 0q�6   $��1��5)      $ /Assets/nes-console.png��5*      $ #19bdd1��5+      $ Number Of Consoles Owned��5,      $ 10��5-      $' !Check Your Most Valuable Consoles��5.      $ 
ArrowRight��5/      $ /Assets/eye.png��50        52   
   $��	30 40 0 0q�6   $��1��53      $��1��54      $  /Assets/n64-controller.png��55      $ #fd9a13��56      $! Number Of Peripherals Owned��57      $ 15��58      $* $Check Your Most Valuable Peripherals��59      $ 
ArrowRight��5:      $ /Assets/eye.png��5;      �� 5=   
   $��Recently Added Items��6   $��2��5>      $��2��5?      $��Center=�5@      $��16(�5A      �� 5C   
   $��3��6   $��2��5D      $��Center=�5E      $	��500��5F      $	��200��5G      	 �� View	 5H      �� 5I      .P�5J      �� $��#��6%   �� 5K      $
��Item��6%   �� 5L      $
��Paid��6%   �� 5M      $��Value��6%   �� 5N      $��Category��6%   5O      5Q      5R      5S      