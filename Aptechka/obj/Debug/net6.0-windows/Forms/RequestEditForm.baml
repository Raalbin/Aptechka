   M S B A M L   `   `   `  ����C  ?Aptechka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AptechkaWPFAptechkaWPF  5   	   !    AptechkaWPF.RequestEditForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AptechkaWPF     5   	   -   5          N�Name$  fmRequestEdit��5       N� Title$ Жрунал Заявок��5   	   .��5
      � -   5         �Name$ fmGrid��5
      $��0,0,0,0q�6   ���	#FFE7F0FB � 	Resources 5   
    
  DateIn �� StringFormat  
DateFinish��%�   &	        &	 n     �� 5      .R�5      �� $��Center=�6T   ��6   �� *DateIn+$ {0:dd MMM yyyy}��6T   5      �� 5      .R�5      �� $��Center=�6X   ��6   �� *
DateFinish+$ {0:dd MMM yyyy}��6X   5      5      .+�5   
   �� -   5         ��Name$ fmLabel��5      $��Журнал заявок��6!   $
��Left=�69   $��0,0,0,0q�6T   $	��Top=�6e   $��16(�6}   $
��Bold"�6�   ���	#FF768FB06�   �� 5   
   -   5        $��Записать��5      $��0,6,0,0q�6$   $	��Top=�65   $��Right=�6M   $��80                 ��6i   5      � 5   
   $	��Top=�6   $��0,40,0,0q�6'    � ColumnDefinitions 5      �� 5      $	��.5* �6#   61   �� 5      $��1* �6#   60   �� 5      $	��.5* �6#   61   �� 5      $��1* �6#   60    � RowDefinitions 5      �� 5       6"   �� 5!      6"   �� 5"      6"   �� 5#      6"   .+�5%      �� $��0��6   $��0��6$   $��id��61   ���	#FF768FB0$
��Bold"�6U   �� 5&      $��1��6   $��0��6&    �� 
IsReadOnly$
 True��6H   ${�False��6Z   ��63   �� *Id+6Z   �� 5'      $��2��6   $��0��6$   $��Аптека��61   ���	#FF768FB0$
��Bold"�6Y   �� 5(      -   5        $��fmDrugstore��5(      $��3��6*   $��0��6:   	 �� 
IsEditable$
	 True��6G   
 �� 
IsReadOnly$

 True��6Y   �� 5)      $��0��6   $��1��6$   $��Дата открытия��61   ���	#FF768FB0$
��Bold"�6`   (  "System.Windows.Controls.DatePicker  5*      $��1��6   $��1��6)      Text 66   �� *DateIn+ �� Mode$ TwoWay=��� 5+      $��2��6   $��1��6$   $��Дата закрытия��61   ���	#FF768FB0$
��Bold"�6`     5,      $��3��6   $��1��6)    66   �� *
DateFinish+$ TwoWay=��� 5-      $��0��6   $��2��6$   $��Статус��61   ���	#FF768FB0$
��Bold"�6Y   �� 5.      -   5        $��fmStatus��5.      $��1��6'   $��2��67   $
	 True��6D   $

 True��6V   5/      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ 	fDataGrid��50      $��	0,128,0,0q�6&      FrozenColumnCount$ 1��69    �� IsTextSearchEnabled$
 True��6O      AutoGenerateColumns$ False��6j      
IsReadOnly$ False��51       J� IsManipulationEnabled$
 True��6&   $��Stretch=�6C   $��Stretch=�52         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 68      SelectionMode$ Single=�6H      EnableRowVirtualization$ False��6_      SelectionUnit$
 Cell=�6�   ���	#FFE7F0FB���	#FF768FB0$
��Bold"�6     Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      MaxWidth$ 40Q�6N      
IsReadOnly$
 True��6\   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
purch.Id+6\   4  .System.Windows.Controls.DataGridComboBoxColumn  56      -   5        fDataGridDrug��$ Препарат��56   e   $ False��6w      MinWidth$	 200Q�6�      SelectedItemBinding 6@   �� *drug+6�     58      $ Количество��6%   $ 80Q�6`   $ False��6n    69   �� *count+$ TwoWay=�   ElementStyle 59      �� 5:       �� 
TargetType" ��6    .�5;      ��   �� Property  � ��! �� Value$! Right=�6D   5<      "   EditingElementStyle" 5>      �� 5?      " ��6    .�5@      ��   � ��$! Right=�6D   5A      5C        5E      $ Цена��6%   $ 80Q�6R   $
 True��6`    63   �� *
drug.Price+ 5F      �� 5G      " ��6    .�5H      ��   � ��$! Right=�6D   5I      " 5K      �� 5L      " ��6    .�5M      ��   � ��$! Right=�6D   5N      5P        5R      $ 
Сумма��6%   $ 80Q�6Z   $
 True��6h    64   �� *summ+$ OneWay=� 5S      �� 5T      " ��6    .�5U      ��   � ��$! Right=�6D   5V      5X      5Z      5[      5\      