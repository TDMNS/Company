   M S B A M L   `   `   `  ���� E  AKolbasaLos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KolbasaLos.ViewKolbasaLos.View  $    KolbasaLos.View.WindowEmployee   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:KolbasaLos.View       � Title$  Сотрудники��$	��300��$	��500��.���� .+���  �� Orientation$ 
Horizontal=����	#FFE4E0E0.+���    
ButtonMenu#��[  $��Добавить��$��25��$��
10,10,5,10q����� *	AddPerson+�� #��[  $��
10,10,5,10q�$ ��Редактировать��$��25������ *
EditPerson+�� #��[  $��Удалить��$��25��$��
10,10,5,10q����� *DeletePerson+�� ���� *ListPersonDpo+ �� SelectedItem �� *SelectedPersonDpo+ �� View �� P��� $��Код�� �� Width$ 50�� �� DisplayMemberBinding �� *Id+�� $��Фамилия�� �� *
LastName+�� $��Имя�� �� *	FirstName+�� $��Должность��$	 100�� �� *
RoleName+�� $��Дата рождения�� �� *
Birthday+