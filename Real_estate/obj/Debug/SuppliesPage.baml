   M S B A M L   `   `   `  ����F  BReal_estate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Real_estateReal_estate  5          Real_estate.SuppliesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Real_estate     5        N� Title$  SuppliesPage��5	      $	��900��6   $
��1440��6)   .��5      � ���#b0bec5 � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6   �� 5      $��1* �6   .+�5   
   ]� .+�5      �� ���#FFF6a5$��0��6.   $	��Top=�6;   $��Bottom=�6S   .+�5      �� $��logo.png��6   $	��113��6*   5      5      �� 5   
   $-��'Таблица 'Предложение'��6   $��32(�61   $��1��6?   $��Medium"�5      $��Center=�6(   ���#37474f$��420,23,419,602q�6Z   �� 5   
   $��1��6   $��16,98,900,537q�6   .��66    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 15��65   5      5      .��6!   5      �� 5!   
   -   5        $��
Поиск��5!      $
��Left=�6!   $��1��6<   $	��Top=�6I   $��40��6a   $	��150��6m   $��20(�5"      ���#263238���#04A0FF$��
572,98,0,0q�6^    5#      ��%_   '��       �� 5$      " ��6   .�5%      ��  �@��CornerRadius$ 15��65   5&      5'      5(      &   System.Windows.Controls.DataGrid  5*   
   -   5        $��DGridSupplies��5*      $��1��6(      
IsReadOnly .     AutoGenerateColumns .  $��484,180,489,0q�6d      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 30 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5-      $	 Цена��6%   $
 * 6M    63   �� *Price+6M     5.      $	 
Агент��6%   $
 * 6Y    64   �� *Agents.FirstName+6Y     5/      $	 Клиент��6%   $
 * 6[    65   �� *Clients.FirstName+6[   51      �� 53   
   -   5        $��
Назад��53      $��Right=�6!   $��2��6=   $��Center=�6J   $��40��6e   $	��150��6q   $��20(�54      ���#263238���#04A0FF$��0 0 16 0q�6I    55      ��%_   '��       �� 56      " ��6   .�57      ��  �@��CornerRadius$ 15��65   58      59      5:      5;      5<      