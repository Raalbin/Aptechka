   M S B A M L   `   `   `  ����C  ?Aptechka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AptechkaWPFAptechkaWPF  5   	       AptechkaWPF.AddressForm   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AptechkaWPF     5   	   -   5          �Name$  	fmAddress��5   	    � Title$) #Справочник адресов��5   	   $	��300��6>   $	��200��6M    � Icon$* $/Image/аптека_иконка.png��6]    � SizeToContent$ Manual=�6}    � WindowStartupLocation$ CenterOwner=�6�    � Topmost$
 True��6�   $	��600��6�   $	��500��6�   .��5
      � $��0,0,0,0q�6   ���	#FFE7F0FB.+�5   
   �� $)��#Справочник адресов��6   $
��Left=�6-   $��0,0,0,0q�6H   $	��Top=�6Y   $��16(�6q   $
��Bold"�6   ���	#FF768FB06�   �� 5   
   -   5        $��Записать��5      $��0,6,0,0q�6$   $	��Top=�65   $��Right=�6M   $��80��6i   6t   �� 5   
   $��Right=�6   $��17��6,   $��	0,8,210,0q�68   $	��Top=�6K   $��17��6c   $��/Image/search_ico.png��6n   $��UniformToFill=�6�    J� RenderTransformOrigin$ 1.072,0.585&�6�   z�5      V� 5      .~�5      ��  �� ScaleX$ -1Q�6%   �� 5      �� 5      T� 5       T� X$ -19.448Q�6)   5      5      �� 5   
   -   5        	 ��Name$	 tbSearch��5      $��0,8,85,0q�6$   
 �� TextWrapping$

 Wrap=�66   $	��Top=�6J   $��Right=�6b   $	��120��6~    � ToolTip$3 -Введите текст для поиска��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	fDataGrid��5      $��0,32,0,0q�6&      FrozenColumnCount$ 1��68    �� IsTextSearchEnabled$
 True��6N      AutoGenerateColumns$ False��6i      
IsReadOnly$ False��5       J� IsManipulationEnabled$
 True��6&   $��Stretch=�6C   $��Stretch=�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 68   ���	#FF768FB0$
��Bold"�6�   ���	#FFE7F0FB   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      MaxWidth$ 40Q�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $ 
Город��6%      MinWidth$ 50Q�6[    65   �� *City+ �� Mode$ TwoWay=�6[     5      $ 
Улица��6%   $ 10Q�6]    65   �� *Street+$ TwoWay=�6]     5      $ Дом��6%   $ 40Q�6Y    63   �� *Home+$ TwoWay=�6Y   5!      5"      5#      