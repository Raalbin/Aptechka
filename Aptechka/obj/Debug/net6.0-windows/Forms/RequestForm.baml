   M S B A M L   `   `   `  ����C  ?Aptechka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AptechkaWPFAptechkaWPF  5   	       AptechkaWPF.RequestForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AptechkaWPF     5   	   -   5          N�Name$  	fmRequest��5       N� Title$ Жрунал Заявок��5   	   .��5
      � $��0,0,0,0q�6   ���	#FFE7F0FB � 	Resources 5   
    
  DateIn �� StringFormat  
DateFinish��%�   &	        &	 n     �� 5      .R�5      �� $��Center=�6T   ��6   �� *DateIn+$ {0:dd MMM yyyy}��6T   5      �� 5      .R�5      �� $��Center=�6X   ��6   �� *
DateFinish+$ {0:dd MMM yyyy}��6X   5      5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ fmLabel��5      $��Журнал заявок��6!   $
��Left=�69   $��0,0,0,0q�6T   $	��Top=�6e   $��16(�6}   $
��Bold"�6�   ���	#FF768FB06�   �� 5   
   -   5        $��Добавить��5      $��0,6,0,0q�6$   $	��Top=�65   $��Right=�6M   $��80��6i   6t   �� 5   
   $��Right=�6   $��17��6,   $��	0,8,210,0q�68   $	��Top=�6K   $��17��6c   $��/Image/search_ico.png��6n   $��UniformToFill=�6�    J� RenderTransformOrigin$ 0.961,0.549&�6�   z�5      V� 5      .~�5      ��  �� ScaleX$ -1Q�6%   �� 5      �� 5      T� 5       T� X$ -15.674Q�6)   5       5"      �� 5#   
   -   5        	 ��Name$	 tbSearch��5#      $��0,7,85,0q�6$   
 �� TextWrapping$

 Wrap=�66   $	��Top=�6J   $��Right=�6b   $	��120��6~    � ToolTip$3 -Введите текст для поиска��6�   &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ 	fDataGrid��5$      $��0,32,0,0q�6&      FrozenColumnCount$ 1��68    �� IsTextSearchEnabled$
 True��6N      AutoGenerateColumns$ False��6i      
IsReadOnly$
 True��5%       J� IsManipulationEnabled$
 True��6%   $��Stretch=�5&         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 68   ���	#FFE7F0FB���	#FF768FB0$
��Bold"�6v      Columns 5'      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%      MaxWidth$ 40Q�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5)      $ Аптека��6%      MinWidth$	 200Q�6Y    66   �� *Drugstore.Name+6Y   4  .System.Windows.Controls.DataGridTemplateColumn  5*      $ Дата Закрытия��6)      CellTemplate# [  6@   $ 80Q�6g     5+      $ Дата Открытия��6)   # [ 6@   $ 80Q�6k     5,      $ Статус��6%    66   �� *Status.Name+5.      5/      50      