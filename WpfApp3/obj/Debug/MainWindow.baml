   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Vinarija Timok��5	   	   $	��550��6    $	��900��6-    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�6^    � 
ResizeMode$ NoResize=�6q    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 50Q�63     5      $ 0:0:0.5��6'   $	 150Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 150Q�63     5      $ 0:0:0.5��6'   $ 50Q�69   5      5      5      	 � Triggers	 5      :� 5   
   
 :� RoutedEvent$
 ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[  6   5      :� 5   
   $
 ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5       �� #��[ 6   5!      .��5#      � .+�5$   
   � -   5         �Name$ GridMain��5$      $��Right=�6!   $��Bottom=�6=   $	��540��6X   $
��1010��6e    � ColumnDefinitions 5%      �� 5&      $
��161* �6#   �� 5'      $
��344* �6#   5*      � 5+   
   $��60��6   $	��Top=�6   ���	#FF1380EE J� Effect 5,      3  -System.Windows.Media.Effects.DropShadowEffect  5-         
BlurRadius$ 1Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFACACAC��6B   .+�5/      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�50      '  !MaterialDesignThemes.Wpf.PopupBox     PlacementMode$ BottomAndAlignRightEdges=�6*      	StaysOpen .  $��10q�6e   
�������   PopupContent. 51      �� $	��150��6!   .+�52      �� $��Pomoc��6!   �� 53      -   5        $��Odjavljivanje��53   !   69   �� 54      �� 55      -   5        $��
popUpIzlaz��55   1   $��Izlaz��6!   6C   56      57      58      �� 59      $��Center=�6   $��Center=�65   $��22(�6P   
�������Vinarija Timok6�   5:      � 5;   
   -   5        $ GridMenu��5;      $��50��6!   $
��Left=�6,   ���	#FF1380EE J� RenderTransformOrigin$ 0.5,0.5&�6^    5<        5=      $ 2Q�6#   $ 1Q�62   $ 	#FFAEAEAE��6B   .+�5?      �� .+�5@      � $	��150��6   ���	#FF1380EE$ 0.5,0.5&�6;   z�5A      V� 5B      .~�5C      �� �� 5D      �� 5E      T� 5F      5G      .+�5I      �� -   5         ��Name$ ButtonOpenMenu��5I      $��60��65   $��60��6A   $
��-4,5q�6L   $��Right=�6Z   $	��Top=�6v    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   
���������6�   Z� ��6�   Z� .��5J      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$
 Menu=�62   $��25��6>   $��25��6I   5K      �� 5L      -   5        $ ButtonCloseMenu��5L      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $��Right=�6o   $	��Top=�6�   #��[ 6�   
���������6�   Z� ��6�   Z� .��5M        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5N      � 5P      5R      5T      �� 5U      $ 
Horizontal=�6   .+�5V      o� .@�5W      m� $��         Vinograd��6#   $	��220��6>   ���	#FF1380EE.@�5X      m� $��E.K.L��6'    � ToolTip$% Eksterna Kontorlna Laboratorija��66   m� 5Y      $��Za logistiku��6'   m� 5Z      $��Podaci o dostavi��6'   5[      5\      5]      �� 5^      $ 
Horizontal=�6   .+�5_      o� .@�5`      m� $��          P.V.D��6#   $$ Prozivodnja vina i destilacija��6<   $	��220��6e   ���	#FF1380EE.@�5a      m� $��Podaci o dostavi vina��6'   m� 5b      $#��Podaci o snabdevu proizvodnje��6'   5c      5d      5e      �� 5f      $ 
Horizontal=�6   .+�5g      o� .@�5h      m� $��          Podrum��6#   $	��220��6=   ���	#FF1380EE.@�5i      m� $��Laboratorija vinarije��6'   m� 5j      $"��Podaci ostvarene prozivodnje��6'   5k      5l      5m      �� 5n      $ 
Horizontal=�6   .+�5o      o� .@�5p      m� $��          HACCP��6#   $	��220��6<   ���	#FF1380EE6H   5q      5r      5s      5t      � 5v   
   .+�5w         WpfApp3.Vinograd  -   5          Name$ vinograd��5w      $��Stretch=�6/   $��Stretch=�6M   $y�	Collapsed=�6i   $��	50,60,0,0q�6�   5x      5z      5{      