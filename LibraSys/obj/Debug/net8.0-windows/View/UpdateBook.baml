   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LibraSys.ViewLibraSys.View  5   	       LibraSys.View.UpdateBook   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LibraSys.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
UpdateBook��5	   	   $	��500��6   $	��400��6)   ���	#FF2C3E50.��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Add New Book��6   $��24(�6(   
�������$��0��6I   $��2��6V   $��Center=�6j   $��0,0,0,20q�6�   �� 5   
   $��Descriptions:��6   
�������$��1��6<   $��Center=�6I   �� 5   
   $	��250��6:   $��30��6F   $	��0,5q�6R   $��14(�6_   $��0q�6m   ���	#FF34495E
�������$��1��6�   $��1��6�   ��6   �� *Books.BookDescription+6�   �� 5    
   $��
Book Name:��6   
�������$��2��69   $��Center=�6F   �� 5!   
   $	��250��63   $��30��6?   $	��0,5q�6K   $��14(�6X   $��0q�6f   ���	#FF34495E
�������$��2��6�   $��1��6�   ��6   �� *Books.BookName+6�   �� 5"   
   $��Author��6   
�������$��3��65   $��Center=�6B   �� 5#   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��1��6;   .+�5$      ��  �� SelectedValuePath$ AuthorId��6:    �� DisplayMemberPath$ 
AuthorName��6�   $	��200��6�   $��30��6�   $	��0,5q�6�   $��14(�6�   ���	#FF34495E��6   �� *
AuthorList+ �� SelectedValue 6W   �� *
AuthorID+ �� Mode$ TwoWay=�6�   �� 5%      $	��Add��6=   $��50��6K   $��23��6V   $��5,0,0,5q�6b   ���	#FF2980B9
�������$��12(�6�   ��6   �� *AddNewAuthorCommand+6�   5&      �� 5'   
   $��Category��6   
�������$��4��67   $��Center=�6D   �� 5(   
   $ 
Horizontal=�6   $��4��6.   $��1��6;   .+�5)      �� $	��200��6   $��30��6#   $	��0,5q�6/   $��14(�6<   ���	#FF34495E$ 
CategoryId��6�   $ CategoryName��6�    6a   �� *
CategoryID+$ TwoWay=���6�   �� *CategoryList+6�   �� 5+      $	��Add��6<   $��50��6J   $��22��6U   $��5,0,0,5q�6a   ���	#FF2980B9
�������$��12(�6�   ��6   �� *AddCategoryCommand+6�   5,      �� 5-   
   $��Quantity��6   
�������$��5��67   $��Center=�6D   �� 5.   
   $	��250��6,   $��30��68   $	��0,5q�6D   $��14(�6Q   $��0q�6_   ���	#FF34495E
�������$��5��6�   $��1��6�   ��6   �� *
Quantity+6�   �� 50   
   $��Image��6   
�������$��6��64   $��Center=�6A   �� 51   
   $ 
Horizontal=�6   $��6��6.   $��1��6;   .+�52      �� $��	Browse...��67   $��80��6K   $��30��6V   $	��0,5q�6b   ���	#FF2980B9
���������6   �� *BrowseCommand+6�   �� 53      $��Center=�6/   
�������$��10,0,0,0q�6]   ��6   �� *Link+6]   54      �� 55   
   $ 
Horizontal=�6   $��8��6.   $��2��6;   $��Center=�6O   $
��0,10q�6l   .+�56      �� $��Close��66   $��80��6F   $��30��6Q   $��10q�6]   ���	#FF7F8C8D
�������$��12(�6�   $
��Bold"�6�   ��6   �� *CloseCommand+6�   �� 57      $	��Add��68   $��80��6F   $��30��6Q   $��10q�6]   ���	#FF2980B9
�������$��12(�6�   $
��Bold"�6�   ��6   �� *AddBookCommand+6�   58      59      5:      