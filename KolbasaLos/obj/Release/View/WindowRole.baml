   M S B A M L   `   `   `  ���� E  AKolbasaLos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KolbasaLos.ViewKolbasaLos.View       KolbasaLos.View.WindowRole   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:KolbasaLos.View       � Title$  Должности��$	��300��$	��300��.���� ���	#FFD8D8D8.+���  �� Orientation$ 
Horizontal=����	#FFE4E0E0.+���    
ButtonMenu#��[  $��Добавить��$��25��$��
10,10,5,10q����� *	AddRole+�� #��[  $ ��Редактировать��$��25��$��
10,10,5,10q����� *
EditRole+�� #��[  $��Удалить��$��25��$��
10,10,5,10q����� *
DeleteRole+�� $��5q�$��Center=�.��:8Список должностей сотрудников�� ���	#FFD3CDCD���� *
ListRole+ �� SelectedItem �� *SelectedRole+ �� View �� P��� $��Код�� �� Width$ 50�� �� DisplayMemberBinding �� *Id+�� $1��+Наименование должности�� �� *
NameRole+