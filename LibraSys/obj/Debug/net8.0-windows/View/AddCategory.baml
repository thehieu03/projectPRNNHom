   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LibraSys.ViewLibraSys.View  5   	       LibraSys.View.AddCategory   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LibraSys.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ AddCategory��5	      $	��250��6!   $	��400��6.   ���	#FF2C3E50.��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Add New Category��6   $��24(�6,   
�������$��0��6M   $��2��6Z   $��Center=�6n   $��0,0,0,20q�6�   �� 5   
   $��Category Name��6   
�������$��1��6<   $��Center=�6I   �� 5   
   -   5         ��Name$ txtCategoryName��5   0   $	��250��6I   $��30��6U   $	��0,5q�6a   $��14(�6n   $��0q�6|   ���	#FF34495E
�������$��1��6�   $��1��6�   ��6   �� *CategoryName+6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��2��6;   $��Center=�6O   $
��0,10q�6l   .+�5      �� $��Cancel��67   $��80��6I   $��30��6T   $��10q�6`   ���	#FF7F8C8D
�������$��12(�6�   $
��Bold"�6�   ��6   �� *CancelCommand+6�   �� 5      $	��Add��6=   $��80��6K   $��30��6V   $��10q�6b   ���	#FF2980B9
�������$��12(�6�   $
��Bold"�6�   ��6   �� *SaveCategoryCommand+6�   5      5      5      