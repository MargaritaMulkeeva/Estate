   M S B A M L   `   `   `  ����F  BReal_estate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Real_estateReal_estate  5          Real_estate.DealPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Real_estate     5        N� Title$  DealPage��5	      $	��900��6   $
��1440��6%   .��5      � ���#b0bec5 � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6   �� 5      $��1* �6   .+�5   
   ]� .+�5      �� ���#FFF6a5$��0��6.   $	��Top=�6;   $��Bottom=�6S   .+�5      �� $��logo.png��6   $	��113��6*   5      5      �� 5   
   $#��Таблица 'Сделки'��6   $��32(�6,   $��1��6:   $��Medium"�5      $��Center=�6(   ���#37474f$��420,23,419,602q�6Z   �� 5   
   $��1��6   $��16,98,900,537q�6   .��66    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 15��65   5      5      .��6!   5      �� 5!   
   -   5        $��
Поиск��5!      $
��Left=�6!   $��1��6<   $	��Top=�6I   $��40��6a   $	��150��6m   $��20(�5"      ���#263238���#04A0FF$��
572,98,0,0q�6^    5#      ��%_   '��       �� 5$      " ��6   .�5%      ��  �@��CornerRadius$ 15��65   5&      5'      5(      &   System.Windows.Controls.DataGrid  5*   
   -   5        $��
DGridDeals��5*      $��1��6%      
IsReadOnly .     AutoGenerateColumns .  $��391,180,388,0q�6a      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 30 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5-      $	 Потребность��6%   $
 * 6X    6:   �� *	Demand_Id+6X     5.      $	 Предложение��6%   $
 * 6X    6:   �� *	Supply_Id+6X   50      �� 52   
   -   5        $��
Назад��52      $��Right=�6!   $��2��6=   $��Center=�6J   $��40��6e   $	��150��6q   $��20(�53      ���#263238���#04A0FF$��0 0 16 0q�6I    54      ��%_   '��       �� 55      " ��6   .�56      ��  �@��CornerRadius$ 15��65   57      58      59      �� 5;   
   -   5        $��Добавить��5;      $��Right=�6$   $��2��6@   $��Center=�6M   $��40��6h   $	��150��6t   $��20(�5<      ���#263238���#04A0FF$��0,36,208,36q�6I    5=      ��%_   '��       �� 5>      " ��6   .�5?      ��  �@��CornerRadius$ 15��65   5@      5A      5B      5C      5D      