   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.PSPIzmeni   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	   ���	#FF300281  MaterialDesignFont#���  5   	    � Title$ 	PSPIzmeni��5   	   $	��450��6   $	��400��6(    � WindowStartupLocation$ CenterScreen=�64    � WindowStyle$
 None=�6Y    � AllowsTransparency .  � 
ResizeMode$ CanResizeWithGrip=�6�   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $	��13* �6   �� 5      $
��182* �6   �� 5       $
��184* �6   �� 5!      $	��21* �6   .+�5$   
   �� $��1��6   $��56,21,56,10q�6    $��0��65   .��6B   Sorta:6J   �� 5%   
   $��1��6   $��56,16,56,15q�6    $��1��65   .��6B   
Količina:6M   �� 5&   
   $��1��6   $��56,16,56,15q�6    $��2��65   .��6B   Datum:6J   �� 5'   
   $��1��6   $��56,16,56,15q�6    $��3��65   .��6B   
Prevoznik:6N   �� 5(   
   $��1��6   $��56,16,43,15q�6    $��4��65   .��6B   	Vinograd:6M   �� 5)   
   -   5        	 ��Name$	 adddIng2��5)      $��Izmeni��6#   $��1��64   $
��Left=�6D   $��	32,23,0,0q�6_   $��5��6r   $	��Top=�6   $	��100��6�   $��42��6�   
������ ���	#FF6323BF6�   �� 5*   
   -   5        $	 giveeUp2��5*      $��Odustani��6#   $��2��66   $
��Left=�6F   $��	56,23,0,0q�6a   $��5��6t   $	��Top=�6�   $	��100��6�   $��42��6�   
������ ���	#FFB617176�   �� 5,   
   -   5        
 ��Name$
 sortA��5,      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Unesi sortu grožđa��5-      $��2��6C   $��0��6S   $��0,3,0,28q�6`   6r   �� 5.   
   -   5        $
 kolicinA��5.      $ Unesi količinu grožđa��5/      $��2��6F   $��1��6V   $��0,3,0,28q�6c   6u   �� 50   
   -   5        $
 datuM��50      $ Unesi datum dostave��51      $��2��6D   $��2��6T   $��0,3,0,28q�6a   6s   �� 52   
   -   5        $
 	prevozniK��52      $$ Unesi ime i prezime prevoznika��53      $��2��6O   $��3��6_   $��0,3,0,28q�6l   6~   �� 54   
   -   5        $
 vinograD��54      $ Unesi lokaciju vinograda��55      $��2��6I   $��4��6Y   $��0,3,0,28q�6f   6x   56      57      