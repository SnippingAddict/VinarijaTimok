   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5          WpfApp3.PSP   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp3     5      ���	#FF0B021B$��Stretch=�5   N   $��Stretch=�6j   .��5
      � $��Stretch=�6   $��Stretch=�6'     � RowDefinitions  5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $��0.17* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��0.17* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridPSP��5         
IsReadOnly .    AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�5   d      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $��1��6#   $��3��63   $��5��6G   $��0,22,0,0q�6X   ���	#FF0B021B��5      ��  �� Path$ lista�   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5!      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Sorta��6)   
   Width$
 * 68      CellTemplate 5"      �� 5#      .R�5$      ��  �� Orientation$ 
Horizontal=�6)   .+�5%   "   �� ��6,   �� *Sorta+5&      5'      5)      0  *System.Windows.Controls.DataGridTextColumn  5+      $	 Kolicina��6%   $
 * 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *
Kolicina+6`     5,      $	 Datum��6%   $
 * 64    6>   �� *Datum+6Z     5-      $	 	Prevoznik��6%   $
 * 68    6B   �� *	Prevoznik+6b     5.      $	 Vinograd��6%   $
 * 67    6A   �� *
Vinograd+6`   51      �� 53   
   -   5         ��Name$ dodaj2��53      $��Dodaj��6!   $��1��61   $
��Left=�6A   $��	65,20,0,0q�6\   $��5��6o   
������ $	��Top=�6�   $	��117��6�   $��47��6�   ���	#FF6323BF6�   �� 54   
   -   5        $ izmeni2��54      $��Izmeni��6"   $��2��63   $
��Left=�6C   $��	75,20,0,0q�6^   $��5��6q   $	��Top=�6~   $	��117��6�   $��47��6�   ���	#FF6323BF
������ 6�   �� 55   
   -   5        $ 	odustani2��55      $��Izbriši��6$   $��3��66   $
��Left=�6F   $��	80,20,0,0q�6a   $��5��6t   $	��Top=�6�   $	��117��6�   $��47��6�   ���	#FFE80505
������ 6�   � 57   
   $��1��6   $��187,-15,176,0q�6   $��7��66   $	��450��6G   $	��400��6T   $��3��6`   .+�58         WpfApp3.PSPDodaj  -   5          Name$ PSPDodaj��58      $��Stretch=�6/   $��Stretch=�6M   $y�	Collapsed=�6i   59      5;      5<      