   M S B A M L   `   `   `  ����E  AKolbasaLos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KolbasaLos.ViewKolbasaLos.View  5      $    KolbasaLos.View.WindowEmployee   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      /localclr-namespace:KolbasaLos.View     5        � Title$  Сотрудники��5      $	��300��6   $	��500��6"   .��5	      �� .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   ���	#FFE4E0E0.+�5      ��    
ButtonMenu#��[  6   $��Добавить��69   $��25��6L   $��
10,10,5,10q�6X   ��6l   �� *	AddPerson+�� 5      #��[  6   $��
10,10,5,10q�69   $ ��Редактировать��6M   $��25��6e   ��6q   �� *
EditPerson+�� 5      #��[  6   $��Удалить��69   $��25��6K   $��
10,10,5,10q�6W   ��6k   �� *DeletePerson+5      �� 5   
   ��6   �� *
ListPerson+ �� SelectedItem 66   �� *SelectedPerson+ �� View 5      �� 5      P�5      �� 5      $��Фамилия��6)    �� DisplayMemberBinding 6:   �� *
LastName+�� 5      $��Имя��6)    66   �� *	FirstName+�� 5      $��Должность��6)    �� Width$	 100��6<    6H   �� *Role.NameRole+�� 5      $��Дата рождения��6)    6@   �� *
Birthday+5      5      5      5      