   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LibraSys.ViewLibraSys.View  5   	   7 clr-namespace:LibraSys.ViewModelLibraSys.ViewModel  5   	       LibraSys.View.AddAuthor   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:LibraSys.View     5   	   /vm clr-namespace:LibraSys.ViewModel     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ 	AddAuthor��5
   	   $	��250��6   $	��400��6(   ���	#FF2C3E50.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Add New Author��6   $��24(�6*   
�������$��0��6K   $��2��6X   $��Center=�6l   $��0,0,0,20q�6�   �� 5   
   $��Author Name��6   
�������$��1��6:   $��Center=�6G   �� 5   
   -   5         ��Name$ txtAuthorName��5   .   $	��250��6E   $��30��6Q   $	��0,5q�6]   $��14(�6j   $��0q�6x   ���	#FF34495E
�������$��1��6�   $��1��6�   ��6   �� *
AuthorName+6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��2��6;   $��Center=�6O   $
��0,10q�6l   .+�5      �� -   5        $��Cancel��5   6   $��80��6H   $��30��6S   $��10q�6_   ���	#FF7F8C8D
�������$��12(�6�   $
��Bold"�6�   ��6   �� *CloseCommand+6�   �� 5      $	��Add��6:   $��80��6H   $��30��6S   $��10q�6_   ���	#FF2980B9
�������$��12(�6�   $
��Bold"�6�   ��6   �� *AddAuthorCommand+6�   5      5      5       