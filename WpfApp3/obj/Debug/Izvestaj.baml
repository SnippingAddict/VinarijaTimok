   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5          WpfApp3.Izvestaj   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp3     5      V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Open��5      6<     5   
   -   5        $ ApplicationCommands.Save��5      6<   .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��854* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��56 �6   �� 5      .+�5!   
   `� $��Stretch=�6   $��Stretch=�64   $��2��6P   $��3��6a   $��0��6u   .�5"      c�   MaterialDesignToolBar#���  6   }�.  $��	10,0,-2,1q�6[   .@�5$      �� $��Font:��6   $��Center=�6(   �� 5%      -   5        $��cmbFontFamily��5%      $	��150��60   6<   �� 5&      $��
Veličina:��6   $��Center=�6,   �� 5'      -   5        $��cmbFontSize��5'      $��50��6.    �� 
IsEditable . 6~   �� 5)      �� 5*      $	��Cut��6    � ToolTip$ Iseci��6'    c� OverflowMode$ AsNeeded=�67   .��5+      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]	   Kind$	 
ContentCut=�6.   5,      �� 5-      $
��Copy��6   $ Kopiraj��6(   $ AsNeeded=�6:   .��5.        $	 ContentCopy=�6.   5/      �� 50      $��Paste��6   $ Nalepi��6)   $ AsNeeded=�6:   .��51        $	 ContentPaste=�6.   52      �� 53      �� 55      $��	AlignLeft��6   $$ Proravnaj tekst sa leve strane��6-   $ AsNeeded=�6V   .��56        $	 FormatAlignLeft=�6.   57      �� 58      $��AlignCenter��6   $ Centriraj tekst��6/   $ AsNeeded=�6I   .��59        $	 FormatAlignCenter=�6.   5:      �� 5;      $��
AlignRight��6   $% Proravnaj tekst sa desne strane��6.   $ AsNeeded=�6X   .��5<        $	 FormatAlignRight=�6.   5=      �� 5>      $��AlignJustify��6   $# Proravnaj tekst sa obe strane��60   $ AsNeeded=�6X   .��5?        $	 FormatAlignJustify=�6.   5@      �� 5A      �� 5B      -   5        
 ��Name$

 bold��5B      $��
ToggleBold��6'   $ Podebljaj tekst��6<   $ AsNeeded=�6V   .��5C        $	 
FormatBold=�6.   5D      �� 5E      -   5        $
 italic��5E      $��ToggleItalic��6)   $ Iskosi tekst��6@   $ AsNeeded=�6W   .��5F        $	 FormatItalic=�6.   5G      �� 5H      -   5        $
 	underline��5H      $��ToggleUnderline��6,   $ Podvuci tekst��6F   $ AsNeeded=�6^   .��5I        $	 FormatUnderline=�6.   5J      �� 5K      �� 5N      $
��Undo��6   $ Unazad��6(   $ AsNeeded=�69   .��5O        $
	 Undo=�6.   5P      �� 5Q      $
��Redo��6   $ Unapred��6(   $ AsNeeded=�6:   .��5R        $
	 Redo=�6.   5S      �� 5T      �� 5U      $��ToggleNumbering��6   $ Dodaj brojeve��63   $ AsNeeded=�6K   .��5V        $	 FormatListNumbers=�6.   5W      �� 5X      $��ToggleBullets��6   $ Dodaj brojeve��61   $ AsNeeded=�6I   .��5Y        $	 FormatListBulleted=�6.   5Z      5[      5\      �� 5]   
   -   5         ��Name$ editor��5]      $��0��6?   $��1��6P   $��3��6]   $��3��6n   $��Stretch=�6�   $��Stretch=�6�   $��Roboto)�6�   $��13(�6�    � ContextMenu 5^      �� 5_      .@�5`      m� $��Iseci��6    m� InputGestureText$ Ctrl+X��6.    m� Command$	 Cut��6H    m� Icon 5a        5b      $	 
ContentCut=�66   5d      m� 5e      $��Kopiraj��6   $ Ctrl+C��60   $
 Copy��6J    5f        5g      $	 ContentCopy=�66   5i      m� 5j      $��Nalepi��6   $ Ctrl+V��6/   $ Paste��6I    5k        5l      $	 ContentPaste=�66   5n      5o      . �5q      /� .T�5r      J� .*�6   5s      5t      5u      5v      5w      