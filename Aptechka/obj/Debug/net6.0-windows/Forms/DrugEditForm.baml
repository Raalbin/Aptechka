   M S B A M L   `   `   `  ����C  ?Aptechka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AptechkaWPFAptechkaWPF  5   	       AptechkaWPF.DrugEditForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AptechkaWPF     5   	   -   5          N�Name$  
fmDrugEdit��5       N� Title$9 3Редактирование медикамента��5   	   .��5
      � -   5         �Name$ fmGrid��5
      $��0,0,0,0q�6   ���	#FFE7F0FB.+�5   
   �� -   5         ��Name$ fmLabel��5      $9��3Редактирование медикамента��6!   $
��Left=�6F   $��0,0,0,0q�6a   $	��Top=�6r   $��16(�6�   $
��Bold"�6�   ���	#FF768FB06�   �� 5   
   -   5        $��Записать��5      $��0,6,0,0q�6$   $	��Top=�65   $��Right=�6M   $��80��6i   6t   � 5   
   $	��Top=�6   $��0,40,0,0q�6'    � 	Resources 5         DateOfManufacture �� StringFormat  
BestBefore��%�   &	        &	 y     �� 5      .R�5      �� $��Center=�6c   ��6    �� *DateOfManufacture+$ {0:dd MMM yyyy}��6c   5      �� 5      .R�5      �� $��Center=�6\   ��6    �� *
BestBefore+$ {0:dd MMM yyyy}��6\   5      5       � ColumnDefinitions 5      �� 5      $	��.5* �6#   61   �� 5      $��2* �6#   60    � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5       6"   �� 5!      6"   �� 5"      6"   �� 5#      6"   .+�5&      �� $��0��6   $��0��6$   $��id��61   ���	#FF768FB0$
��Bold"�6U   �� 5'      $��1��6   $��0��6&    �� 
IsReadOnly$
 True��6H   ${�False��6Z   ��63   �� *Id+6Z   �� 5)      $��0��6   $��1��6$   $��Наименование��61   $
��Bold"�6H   ���	#FF768FB06Z   �� 5*      -   5        $��fmName��5*      $��1��6$   $��1��64   ��6A   �� *Name+�� 5,      $��0��6   $��2��6$   $��Цена��61   $
��Bold"�6@   ���	#FF768FB06R   �� 5-      -   5        $��fmPrice��5-      $��1��6%   $��2��65   ��6B   �� *Price+�� 5/      $��0��6   $��3��6$   $'��!Дата изготовления��61   ���	#FF768FB0$
��Bold"�6d   (  "System.Windows.Controls.DatePicker  50      -   5        $��fmDateOfMan��50      $��1��6,   $��3��6<   	   Text	 6I   �� *DateOfManufacture+
 �� Mode$
 TwoWay=��� 52      $��0��6   $��4��6$   $��Годен до��61   $
��Bold"�6D   ���	#FF768FB06V     53      -   5        $��fmBestBefore��53      $��1��6-   $��4��6=   	 6J   �� *
BestBefore+$
 TwoWay=��� 55      $��0��6   $��5��6$   $��Поставщик��61   ���	#FF768FB0$
��Bold"�6\   �� 56      -	   5        $��
fmProducer��56      $��1��6)   $��5��69    �� 
IsEditable$
 True��6F    �� 
IsReadOnly$
 True��6X   57      58      59      