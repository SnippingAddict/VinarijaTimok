   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5          WpfApp3.POP   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp3     5      ���	#FF0B021B$��Stretch=�5   N   $��Stretch=�6j   .��5
      � $��Stretch=�6   $��Stretch=�6'     � RowDefinitions  5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $��0.17* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��0.17* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridPOP��5         
IsReadOnly .    AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�5   d      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      $��1��6#   $��2��63   $��5��6G   $��0,22,0,0q�6X   ���	#FF0B021B��5      ��  �� Path$ lista�   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Vrsta vina��6)   
   Width$
 * 6=      CellTemplate 5!      �� 5"      .R�5#      ��  �� Orientation$ 
Horizontal=�6)   .+�5$   "   �� ��6,   �� *
Vrsta_Vina+5%      5&      5(      0  *System.Windows.Controls.DataGridTextColumn  5*      $	 	Količina��6%   $
 * 67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *
Kolicina+6`     5+      $	 Lokacija��6%   $
 * 67    6A   �� *
Lokacija+6`     5,      $	 Datum��6%   $
 * 64    6>   �� *Datum+6Z   5/      �� 51   
   -   5         ��Name$ dodaj3��51      $��Dodaj��6!   $��1��61   $
��Left=�6A   $��0,20,0,0q�6\   $��5��6n   
������ $	��Top=�6�   $	��117��6�   $��47��6�   ���	#FF7E3FDA6�   �� 52   
   -   5        $ izmeni3��52      $��Izmeni��6"   $��1��63   $
��Left=�6C   $��
290,20,0,0q�6^   $��5��6r   $	��Top=�6   $	��117��6�   $��47��6�   ���	#FF7E40D6
������ $��2��6�   �� 53   
   -   5        $ 	odustani3��53      $��Izbriši��6$   $��2��66   $
��Left=�6F   $��
225,20,0,0q�6a   $��5��6u   $	��Top=�6�   $	��117��6�   $��47��6�   ���	#FFE80505
������ 6�   � 55   
   $��1��6   $��187,-15,176,0q�6   $��7��66   $	��450��6G   $	��400��6T   $��3��6`   .+�56         WpfApp3.POPDodaj  -   5          Name$ POPDodaj��56      $��Stretch=�6/   $��Stretch=�6M   $y�	Collapsed=�6i   57      59      5:      