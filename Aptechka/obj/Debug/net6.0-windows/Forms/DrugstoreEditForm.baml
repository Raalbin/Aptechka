   M S B A M L   `   `   `  ����C  ?Aptechka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AptechkaWPFAptechkaWPF  5   	   #    AptechkaWPF.DrugstoreEditForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AptechkaWPF     5   	   -   5          N�Name$  fmDrugstoreEdit��5       N� Title$/ )Редактирование Аптеки��5   	   .��5
      � -   5         �Name$ fmGrid��5
      $��0,0,0,0q�6   ���	#FFE7F0FB � ColumnDefinitions 5   
   �� 5      $	��69* �6   �� 5      $	��52* �6   �� 5      $	��78* �6   .+�5   
   �� -   5         ��Name$ fmLabel��5      $/��)Редактирование Аптеки��6!   $
��Left=�6A   $��0,0,0,0q�6\   $	��Top=�6m   $��16(�6�   $
��Bold"�6�   $��3��6�   ���	#FF768FB06�   �� 5   
   -   5        $��Записать��5      $��0,6,0,0q�6$   $	��Top=�65   $��Right=�6M   $��80��6i   $��2��6�   � 5   
   $	��Top=�6   $��0,40,0,0q�6'   $��3��69    5      �� 5      $	��.5* �6#   61   �� 5      $��2* �6#   60    � RowDefinitions 5      �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   �� 5      6"   .+�5!      �� $��0��6   $��0��6$   $��id��61   ���	#00000000���	#FF768FB0$
��Bold"�6l   �� 5"      $��1��6   $��0��6&    �� 
IsReadOnly$
 True��6H   ${�False��6Z   ��63   �� *Id+6Z   �� 5$      $��0��6   $��1��6$   $��Аптека��61   $
��Bold"�6B   ���	#FF768FB06T   �� 5%      -   5        $��fmName��5%      $��1��6$   $��1��64   ��6A   �� *Name+�� 5'      $��0��6   $��2��6$   $��Телефон��61   ���	#FF768FB0$
��Bold"�6Z   �� 5(      -   5        $��fmPhone��5(      $��1��6%   $��2��65   ��6B   �� *	Telephone+�� 5*      $��0��6   $��3��6$   $��ИНН��61   $
��Bold"�6?   ���	#FF768FB06Q   �� 5+      -   5        $��fmINN��5+      $��1��6#   $��3��63   ��6@   �� *PharmacyInn+�� 5-      $��0��6   $��4��6$   $��
Адрес��61   ���	#FF768FB0$
��Bold"�6X   �� 5.      -   5        $��fmAddr��5.      $��1��6$   $��4��64   6A   5/      50      51      