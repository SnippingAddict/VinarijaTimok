   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5          WpfApp3.Dodaj1   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp3     5      V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
         MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   ���	#FF300281  MaterialDesignFont#���  5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $	��13* �6   �� 5      $
��182* �6   �� 5      $
��184* �6   �� 5      $	��21* �6   .+�5"   
   �� $��1��6   $��56,21,56,10q�6    $��0��65   .��6B   Sorta:6J   �� 5#   
   $��1��6   $��56,16,56,15q�6    $��1��65   .��6B   	Lokacija:6M   �� 5$   
   $��1��6   $��56,16,56,15q�6    $��2��65   .��6B   Datum:6J   �� 5%   
   $��1��6   $��56,16,56,15q�6    $��3��65   .��6B   
Prevoznik:6N   �� 5&   
   $��1��6   $��56,16,43,15q�6    $��4��65   .��6B   	Vinograd:6M   �� 5'   
   -   5         ��Name$ addIng��5'      $��Dodaj��6!   $��1��61   $
��Left=�6A   $��	32,23,0,0q�6\   $��5��6o   $	��Top=�6|   $	��100��6�   $��42��6�   
������ ���	#FF6323BF6�   �� 5(   
   -   5        $ giveUp��5(      $��Odustani��6!   $��2��64   $
��Left=�6D   $��	56,23,0,0q�6_   $��5��6r   $	��Top=�6   $	��100��6�   $��42��6�   
������ ���	#FFB617176�   �� 5*   
   -   5         ��Name$ soRta��5*      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Unesi sortu grožđa��5+      $��2��6A   $��0��6Q   $��0,3,0,28q�6^   6p   �� 5,   
   -   5        $ lokaCija��5,      $ Unesi lokaciju dostave��5-      $��2��6F   $��1��6V   $��0,3,0,28q�6c   6u   �� 5.   
   -   5        $ daTum��5.      $ Unesi datum dostave��5/      $��2��6C   $��2��6S   $��0,3,0,28q�6`   6r   �� 50   
   -   5        $ 	prevoZnik��50      $$ Unesi ime i prezime prevoznika��51      $��2��6N   $��3��6^   $��0,3,0,28q�6k   6}   �� 52   
   -   5        $ vinoGrad��52      $ Unesi lokaciju vinograda��53      $��2��6H   $��4��6X   $��0,3,0,28q�6e   6w   54      55      