   M S B A M L   `   `   `  ����D  @ObrazPlus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ObrazPlus.ViewObrazPlus.View  5   	   '    !ObrazPlus.View.EditMaterialWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ObrazPlus.View     5   	     � Title$  EditMaterialWindow��5   	   $	��450��6$   $	��800��61   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $1��+Наименование материала��6   $��Center=�62   $��Center=�6M   $��Constantinia)�6j   �� 5   
   -   5         ��Name$ TitleMaterial��5      $��1��6)   $��Center=�66   $��Center=�6S   $	��350��6n   $��Constantinia)�6z   �� 5   
   $1��+Минимальное количество��6   $��1��62   $��Center=�6B   $��Center=�6]   $��Constantinia)�6z   �� 5   
   -   5        $ MinQuantityTB��5      $��1��6*   $��1��6:   $��Center=�6G   $��Center=�6d   $	��350��6   $��Constantinia)�6�   �� 5   
   $��Тип материала��6   $��2��6)   $��Center=�66   $��Center=�6Q   $��Constantinia)�6n   �� 5   
   -   5         ��Name$ TypeMaterial��5      $��3��6)   $��Center=�66   $��Center=�6S   $��Constantinia)�6n   $	��200��6�    �� SelectedValuePath$ Id��6�   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�    �� DisplayMemberPath$ Title��6�    �� SelectedValue 6�   �� *Materials.MaterialTypeId+��6  �� *Material_types+�� 5    
   $,��&Количество на складе��6   $��1��60   $��2��6@   $��Center=�6M   $��Center=�6h   $��Constantinia)�6�   �� 5!   
   -   5        $ QuantityInStockTB��5!      $��1��6-   $��3��6=   $��Center=�6J   $��Center=�6g   $	��350��6�   $��Constantinia)�6�   �� 5"   
   $0��*Цена единицы материала��6   $��4��62   $��Center=�6?   $��Center=�6Z   $��Constantinia)�6w   �� 5#   
   -   5        $ PriceTB��5#      $��5��6#   $��Center=�60   $��Center=�6M   $	��350��6h   $��Constantinia)�6t   �� 5$   
   $'��!Единица измерения��6   $��1��6-   $��4��6=   $��Center=�6J   $��Center=�6e   $��Constantinia)�6�   �� 5%   
   $.��(Количество в упаковке��6   $��2��61   $��6��6E   $��Center=�6R   $��Center=�6m   $��Constantinia)�6�   �� 5&   
   -   5        $ StorageUnitTB��5&      $��5��6*   $��1��67   $��Center=�6G   $��Center=�6d   $��70��6   $ Id��6�   $
 TrueY�6�   $ Title��6�   $��Constantinia)�68   6�   �� *Materials.StorageUnitsId+��6  �� *StorageUnits+68  �� 5'   
   -   5        $ QuantityinPackage��5'      $��7��6-   $��2��6:   $��Center=�6O   $��Center=�6l   $	��350��6�   $��Constantinia)�6�   �� 5(   
   -   5        $��2��5(      $��Center=�6%   $��Добавить��6B   $��8��6U   $
��12 8q�6y   $��Center=�6�   $��Constantinia)�6�   5)      5*      