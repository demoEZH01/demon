   M S B A M L   `   `   `  ����D  @ObrazPlus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ObrazPlus.ViewObrazPlus.View  5   	       ObrazPlus.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ObrazPlus.View     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��800��6)   $	��800��65    � WindowStartupLocation$ CenterScreen=�6D   .��5	      �  � RowDefinitions 5
   
   �� 5      $��70 �6   �� 5      �� 5      $	��100 �6   .+�5   
   �� $$��/Asset/Образ плюс.png��6   $��Center=�6/   �� 5   
   -   5         ��Name$ MaterialListBox��5       �� SelectedValuePath$ Id��6P   $��1��6h   ��6+   �� *MaterialList+��5      �� 5      .R�5      �  � Orientation$ Vertical=�6    5      ��5      �� 5      .R�5      ��  �� Padding$ 10q�6    �� CornerRadius$ 2��6*   
�������$��1q�5   )   $	��750��6>   ._�5      �  � ColumnDefinitions 5      �� 5   "   �� 5   "    5      �� 5    "   �� 5!   "   �� 5"   "   �� 5#   "   .+�5%      �� 	 �� Orientation$	 
Horizontal=�6)   .+�5&   "   �� $��
Constantia)�6J   ��6,   �� *materialType+6J   �� 5'   "   $	�� | ��6,   $��
Constantia)�67   �� 5(   "   $��
Constantia)�6C   ��6,   �� *Title+6C   5)      �� 5*      $	 
Horizontal=�6)   $��Right=�6B   $��1��6^   .+�5+   "   �� $��0 0 40 0q�6N   $��
Constantia)�6`   ��6,   �� *requiredQuantity+6`   5,      �� 5-      $	 
Horizontal=�6)   $��1��6B   .+�5.   "   �� $��
Constantia)�6I   ��6,   �� *minQuantity+6I   5/      �� 50      $	 
Horizontal=�6)   $��2��6B   .+�51   "   �� $��
Constantia)�6M   ��6,   �� *quantityInStock+6M   52      �� 53      $	 
Horizontal=�6)   $��3��6B   .+�54   "   �� $��
Constantia)�6G   ��6,   �� *	unitPrice+6G   55      56      57      58      5:      �� 5;   
   -   5        $��
Constantia)�5;      $��2��6)   $��Center=�66   $��Center=�6S   $��Добавить��6n   $
��12 5q�6�   6�   5<      5=      