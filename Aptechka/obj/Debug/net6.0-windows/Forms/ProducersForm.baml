   M S B A M L   `   `   `  ����C  ?Aptechka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AptechkaWPFAptechkaWPF  5   	       AptechkaWPF.ProducersForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AptechkaWPF     5   	   -   5          N�Name$  fmProducers��5       N� Title$7 1Справочник Производителей��5   	   .��5
   
   � $��0,0,0,0q�6   ���	#FFE7F0FB � 	Resources 5      ��%    5      .+�5      �� $ ��Производители��6   $
��Left=�6,   $��0,0,0,0q�6G   $	��Top=�6X   $��16(�6p   $
��Bold"�6~   ���	#FF768FB06�   �� 5      -   5        $��Добавить��5      $��0,6,0,0q�6(   $	��Top=�69   $��Right=�6Q   $��80��6m   6x   �� 5   
   $��Right=�6   $��17��6,   $��	0,8,210,0q�68   $	��Top=�6K   $��17��6c   $��/Image/search_ico.png��6n   $��UniformToFill=�6�    J� RenderTransformOrigin$ 0.961,0.549&�6�   z�5      V� 5      .~�5      ��  �� ScaleX$ -1Q�6%   �� 5      �� 5      T� 5       T� X$ -15.674Q�6)   5      5      �� 5   
   -   5         ��Name$ tbSearch��5      $��0,7,85,0q�6$    �� TextWrapping$
 Wrap=�66   $	��Top=�6J   $��Right=�6b   $	��120��6~    � ToolTip$3 -Введите текст для поиска��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        	  Name$	 	fDataGrid��5      $��0,32,0,0q�6&   
   FrozenColumnCount$
 1��68    �� IsTextSearchEnabled$
 True��6N      AutoGenerateColumns$ False��6i      
IsReadOnly$
 True��5       J� IsManipulationEnabled$
 True��6%   $��Stretch=�6q   $��Stretch=�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 68   ���	#FF768FB0$
��Bold"�6_      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      MaxWidth$ 40Q�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $ Название��6%      MinWidth$	 100Q�6Q    68   �� *Name+6Q     5       $ 
Адрес��6%    64   �� *Address.Name+  5!      $ Телефон��6%   $	 100Q�6T    66   �� *	Telephone+6T     5"      $ Лицензия��6%   $ 60Q�6Z    68   �� *LicanceNumber+6Z     5#      $ 
Почта��6%   $	 100Q�6O    65   �� *Email+6O   5%      5&      5'      