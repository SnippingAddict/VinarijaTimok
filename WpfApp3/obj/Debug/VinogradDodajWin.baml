   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.VinogradDodajWin   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   ���	#FF300281  MaterialDesignFont#���  5   	    � Title$ VinogradDodajWin��5   	   $	��450��6"   $	��400��6/    � WindowStartupLocation$ CenterScreen=�6;    � WindowStyle$
 None=�6`    � AllowsTransparency . .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $	��13* �6   �� 5      $
��182* �6   �� 5      $
��184* �6   �� 5       $	��21* �6   .+�5#   
   �� $��1��6   $��56,21,56,10q�6    $��0��65   .��6B   Sorta:6J   �� 5$   
   $��1��6   $��56,16,56,15q�6    $��1��65   .��6B   	Lokacija:6M   �� 5%   
   $��1��6   $��56,16,56,15q�6    $��2��65   .��6B   Datum:6J   �� 5&   
   $��1��6   $��56,16,56,15q�6    $��3��65   .��6B   
Prevoznik:6N   �� 5'   
   $��1��6   $��56,16,43,15q�6    $��4��65   .��6B   	Vinograd:6M   �� 5(   
   -   5         ��Name$ adddIng��5(      $��Izmeni��6"   $��1��63   $
��Left=�6C   $��	32,23,0,0q�6^   $��5��6q   $	��Top=�6~   $	��100��6�   $��42��6�   
������ ���	#FF6323BF6�   �� 5)   
   -   5        $ giveeUp��5)      $��Odustani��6"   $��2��65   $
��Left=�6E   $��	56,23,0,0q�6`   $��5��6s   $	��Top=�6�   $	��100��6�   $��42��6�   
������ ���	#FFB617176�   �� 5+   
   -   5        	 ��Name$	 soRta��5+      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Unesi sortu grožđa��5,      $��2��6C   $��0��6S   $��0,3,0,28q�6`   6r   �� 5-   
   -   5        $	 lokaCija��5-      $
 Unesi lokaciju dostave��5.      $��2��6G   $��1��6W   $��0,3,0,28q�6d   6v   �� 5/   
   -   5        $	 daTum��5/      $
 Unesi datum dostave��50      $��2��6D   $��2��6T   $��0,3,0,28q�6a   6s   �� 51   
   -   5        $	 	prevoZnik��51      $$
 Unesi ime i prezime prevoznika��52      $��2��6O   $��3��6_   $��0,3,0,28q�6l   6~   �� 53   
   -   5        $	 vinoGrad��53      $
 Unesi lokaciju vinograda��54      $��2��6I   $��4��6Y   $��0,3,0,28q�6f   6x   55      56      