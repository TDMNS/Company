   M S B A M L   `   `   `  ����  
KolbasaLos'    !KolbasaLos.View.WindowNewEmployee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $	��270��5      $	��300��6   .��5      �   � RowDefinitions  5	   
   �� 5
      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��50* �6    � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��75* �6   .+�5   
   �� $��1��6   $��0��6!   $��Должность:��61   $��Right=�6C   $��Center=�6_   $��5q�6z   �� 5   
   $��2��6   $��0��6!   $��Фамилия:��61   $��Right=�6A   $��Center=�6]   $��5q�6x   �� 5   
   $��3��6   $��0��6!   $��Имя:��61   $��Right=�6=   $��Center=�6Y   $��5q�6t   �� 5   
   $��4��6   $��0��6!   $ ��Дата рождения:��61   $��Right=�6G   $��Center=�6c   $��5q�6~   �� 5   
   -   5         ��Name$ 
TbLastName��5      $��2��6&   $��1��63   $��20��6]   $	��130��6i   $
��Left=�6u   $��Center=�6�   $��5q�6�   ��6C   �� *
LastName+6�   �� 5   
   -   5        $ TbFirstName��5      $��3��6'   $��1��64   $��20��6_   $	��130��6k   $
��Left=�6w   $��Center=�6�   $��5q�6�   ��6D   �� *	FirstName+6�   �� 5   
   -   5         ��Name$ CbRole��5      $��1��6#   $��1��60   $��20��6Z   $	��130��6f   $
��Left=�6r   $��Center=�6�   $��5q�6�    �� DisplayMemberPath$ NameRole��6�    �� SelectedValuePath$ Id��6)   �� Text 6@   �� *
RoleName+ �� SelectedValue 6�   ��  �� Path$ RoleId�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�6)  (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
ClBirthday��5      $��4��6)   $��1��66   $��5,8,0,7q�6�   $
��Left=�6�   $��Center=�6�   $	��130��6�      SelectedDate 6F   �� *
Birthday+$	 TwoWay=�$
 PropertyChanged=�6�   �� 5   
   $��0��6   $��2��6%   $��5��69    �� Orientation$ 
Horizontal=�6F   $��Right=�6_   .+�5      �� -   5         ��Name$ BtSave��5      $��Сохранить��6%   $��25��69   $��Right=�6E   $	��Top=�6a   $��	5,10,10,5q�6y   6�   �� 5      -   5        $ BtCancel��5      $��Отменить��6'   $��25��6:   $��Right=�6F   $	��Top=�6b   $��	5,10,10,5q�6z    �� IsCancel . 6�   5       5!      5"      