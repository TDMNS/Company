   M S B A M L   `   `   `  ����   
KolbasaLos'    !KolbasaLos.View.WindowNewEmployee   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $	��270��$	��300��.���   � RowDefinitions  �� $	��40* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��50* � � ColumnDefinitions �� $	��40* ��� $	��75* �.+��� $��0��$��0��$��Код:��$��Right=�$��Center=�$��5q��� $��1��$��0��$��Должность:��$��Right=�$��Center=�$��5q��� $��2��$��0��$��Фамилия:��$��Right=�$��Center=�$��5q��� $��3��$��0��$��Имя:��$��Right=�$��Center=�$��5q��� $��4��$��0��$ ��Дата рождения:��$��Right=�$��Center=�$��5q��� -    ��Name$
 TbId��$��0��$��1��$��20��$��50��$
��Left=�$��Center=�$��5q�{�.  ���� *Id+�� -   $ 
TbLastName��$��2��$��1��$��20��$	��130��$
��Left=�$��Center=�$��5q����� *
LastName+�� -   $ TbFirstName��$��3��$��1��$��20��$	��130��$
��Left=�$��Center=�$��5q����� *	FirstName+�� -    ��Name$ CbRole��$��1��$��1��$��20��$	��130��$
��Left=�$��Center=�$��5q� �� DisplayMemberPath$ NameRole�� �� Text �� *
RoleName+(  "System.Windows.Controls.DatePicker  -     Name$ 
ClBirthday��$��4��$��1��$��5,8,0,7q�$
��Left=�$��Center=�$	��130��   SelectedDate �� *
Birthday+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� $��0��$��2��$��5��
 �� Orientation$
 
Horizontal=�$��Right=�.+��� -    ��Name$ BtSave��$��Сохранить��$��25��$��Right=�$	��Top=�$��	5,10,10,5q��� -   $ BtCancel��$��Отменить��$��25��$��Right=�$	��Top=�$��	5,10,10,5q� �� IsCancel . 