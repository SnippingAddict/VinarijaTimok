   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5          WpfApp3.POPDodaj   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp3     5      V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   ���	#FF300281  MaterialDesignFont#���  5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $	��13* �6   �� 5      $
��182* �6   �� 5      $
��184* �6   �� 5      $	��21* �6   .+�5"   
   �� $��1��6   $��56,38,56,10q�6    $��0��65   .��6B   Vrsta vina:6O   �� 5#   
   $��1��6   $��56,38,56,15q�6    $��1��65   .��6B   
Količina:6M   �� 5$   
   $��1��6   $��56,38,56,15q�6    $��2��65   .��6B   Datum:6J   �� 5%   
   $��1��6   $��56,38,56,10q�6    $��3��65   .��6B   	Lokacija:6M   �� 5&   
   -   5         ��Name$ addIng3��5&      $��Dodaj��6"   $��1��62   $
��Left=�6B   $��	32,23,0,0q�6]   $��5��6p   $	��Top=�6}   $	��100��6�   $��42��6�   
������ ���	#FF6323BF6�   �� 5'   
   -   5        $ giveUp3��5'      $��Odustani��6"   $��2��65   $
��Left=�6E   $��	56,23,0,0q�6`   $��5��6s   $	��Top=�6�   $	��100��6�   $��42��6�   
������ ���	#FFB617176�   �� 5)   
   -   5         ��Name$ 	vrstavinA��5)      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Unesi vrstu vina��5*      $��2��6A   $��0��6Q   $��0,3,0,28q�6^   �� 5+   
   -   5        $ 	kolicina2��5+      $" Unesi kol. proizvedenog vina��5,      $��2��6M   $��1��6]   $��0,3,0,28q�6j   6|   �� 5-   
   -   5        $ datum2��5-      $ Unesi datum proizvodnje��5.      $��2��6H   $��2��6X   $��0,3,0,28q�6e   �� 5/   
   -   5        $ 	lokacija2��5/      $  Unesi lokaciju proizvodnje��50      $��2��6K   $��3��6[   $��0,3,0,28q�6h   54      55      