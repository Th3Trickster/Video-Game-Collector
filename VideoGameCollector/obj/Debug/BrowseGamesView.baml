   M S B A M L   `   `   `  ����M  IVideoGameCollector, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:VideoGameCollectorVideoGameCollector  5   	   X TVideoGameCollector.ViewModels, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulltRclr-namespace:VideoGameCollector.ViewModels;assembly=VideoGameCollector.ViewModelsVideoGameCollector.ViewModels 5   	   Q-clr-namespace:VideoGameCollector.UserControlsVideoGameCollector.UserControls  5	   	   X TVideoGameCollector.Converters, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulltRclr-namespace:VideoGameCollector.Converters;assembly=VideoGameCollector.ConvertersVideoGameCollector.Converters 5
   	   (    "VideoGameCollector.BrowseGamesView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:VideoGameCollector     5   	   avmRclr-namespace:VideoGameCollector.ViewModels;assembly=VideoGameCollector.ViewModels     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   @usercontrols-clr-namespace:VideoGameCollector.UserControls  5	   	   b	covertersRclr-namespace:VideoGameCollector.Converters;assembly=VideoGameCollector.Converters  5
   	   -   5        $��BrowseGames��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ BrowseGamesView��5   	   $	��750��6!   $	��480��6.    � 	Resources 5       �� MergedDictionaries �� Source8  2VideoGameCollector.ViewModels.BrowseGamesViewModel   vm:  4VideoGameCollector.Converters.StringToImageConverter  stringToImage7  1VideoGameCollector.Converters.NullRatingConverter  nullRatingConverterD  >VideoGameCollector.Converters.UnixTimestampToDateTimeConverter $  unixTimestampToDateTimeConverter�� 5   
    5      �� 5      $5 //ResourceDictionaries/ListBoxItemCardStyle.xaml?�6%   �� 5      $< 6/ResourceDictionaries/ListBoxDeveloperGenresStyle.xaml?�6%   %t   &	        &	      &	 &     &	 9       5      6&     5      6/     5      6,     5      69   5       � DataContext 5        5   
   .��5!      � # [  6    � RowDefinitions 5"   
   �� 5$      $
��Auto �6   �� 5&      $
��Auto �6   �� 5(      $
��Auto �6   �� 5*      $
��Auto �6   �� 5,      $
��Auto �6   �� 5.      $
��Auto �6   .+�51   
   ��  * &MaterialDesignOutlinedTextFieldTextBox#��[ 6   $	��350��52      $��0 20 0 0q�53      " �� VerticalScrollBarVisibility$ Disabled=�54      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Search��55      $��Center=�56      ��57      �� *Query+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�� 5:   
   $��1��6   $��0 10 0 0q�5;      $��Center=�5<       � ColumnDefinitions 5=      �� 5>      $
��Auto �6#   �� 5?      $
��Auto �6#   .+�5C      ��   MaterialDesignFlatButton#��[ 6   $��0��5D      $��Right=�5E      $��0 0 0 0q�5F      .��5G      ��  �� Orientation$ 
Horizontal=�6   .+�5H      �� $ ��/Assets/filter-variant.png��6   $��Center=�5I      $��0 0 5 0q�5J      �� 5K      $��Filter��6    $��Center=�5L       5M      5N      �� 5Q      $��All Platforms��6   $��1��5R      $��Center=�5S      $��Center=�5T      $
��Bold"�5U      5V      �� 5Y   
   $��Ordered by Title��6   $��2��5Z      $��Center=�5[      $
��Bold"�5\      � 5_   
   $��3��6   $��5 0 0 0q�5`       5a      �� 5b      $
��Auto �6#   �� 5c      $
��Auto �6#   .+�5e      �� $��Games Shown:��6   �� 5f      $��1��5g      $
��Left=�5h      $��0 0 3 0q�5i      ��5f      �� *
GamesCount+5i      5j      �� 5m   
     ListBoxItemStyle1#���  5n      $	��480��5p      $	��500��5q      $��4��5r      ��5m      �� *Games+ �� SelectedItem 5o      �� *SelectedGame+$ PropertyChanged=���5s      �� 5t      .R�5u      �  5v      �� 5w      $
��Auto �6/   �� 5x      $��* �6/   .+�5z      �� $
��Fill=�5{       $	��100��5|       $	��130��5}       ��5z       �� *cover.image_id+ �� 	Converter# [ 5}       � 5~      $��1��6    5      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   �� 5�   "   $��* �60   .+�5�      �  5�   "   �� 5�   &   $	��310 �67   �� 5�   &   $��30 �67   .+�5�   "   �� 
�������$
��Bold"�5�   ,   $��16(�5�   ,   $��15 2 0 0q�5�   ,   $
��Wrap=�5�   ,   ��5�   ,   �� *name+5�   ,   �� 5�   "   $��1��5�   ,   $
��Bold"�5�   ,   $��16(�5�   ,   $��Center=�5�   ,   ��5�   ,   �� *aggregated_rating+ �� StringFormat$ {0:F0}��# [ ��5�   ,   �� *AggregatedRatingColor+5�   ,   5�      �� 5�      $��1��6+   $��15 2 0 0q�5�   +   ��5�   +   �� *DeveloperCompanies+��5�   "   �� 5�   &   .R�5�   *   �  K� IsItemsHost . 64   5�   '   ��5�   "   �� 5�   &   .R�5�   *   �� $ 
Horizontal=�65   .+�5�   .   ��  ��Name$ commaTextBlock��68   $��, ��5�   8   
�������5�   8   �� 5�   .   
�������$
��Wrap=�5�   8   ��5�   8   �� *company.name+5�   8   5�   +    �� Triggers 5�   *   �� 5�   .    �� Binding 6:   ��  �� RelativeSource �� *PreviousData+ �� Value 6{   Z� .a�5�   2   ��  �� 
TargetName$ commaTextBlock��6O    �� Property � y� �� Value$ 	Collapsed=�6k   5�   /   5�   '   5�      � 5�      $��2��6#   $��Bottom=�5�   #   $��0 0 0 4q�5�   #    5�   "   �� 5�   &   $
��Auto �67   �� 5�   &   $
��Auto �67   .+�5�   "   �� $��Release Date:��6,   
�������$��	15 20 0 0q�5�   ,   �� 5�   "   
�������$��	10 20 0 0q�5�   ,   $��1��5�   ,   ��5�   ,   �� *first_release_date+# [ 5�   ,   5�      5�      5�      5�      5�      �� 5�   
   $��5��6   $��Center=�5�      $��0 8 0 0q�5�      $	��100��5�      $��30��5�      $��Search��5�      ��5�      �� *SearchGamesCommand+5�      5�      