   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraSys.ViewModelLibraSys.ViewModel  5      7 clr-namespace:LibraSys.UtilitiesLibraSys.Utilities  5          LibraSys.View.Products   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /vm clr-namespace:LibraSys.ViewModel     5      2utils clr-namespace:LibraSys.Utilities     5        � 	Resources  5      2   ,LibraSys.Utilities.ByteArrayToImageConverter   ByteArrayToImageConverter&   System.Windows.Controls.DataGrid �� 
TargetType �� Property �� Value��%q   &	        '         5   
   6*   �� 5   
   "  6   .�5      ��  � ��
 �����6+   5      5      .��5      � ��5   
   �� 5       �� ImageSource$` ZD:\TheHieuPRN\LibraSys\IMG\pngtree-book-light-read-blue-book-light-photo-image_1253738.jpg��6    j� Stretch$ UniformToFill=�5       � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $
��7.5* �6   6,   �� 5      $
��0.5* �6   6,   .+�5   
   ��   TextBox_Styte#��[ 6   $	��360��69   $��	25,63,0,0q�6E   .��6X   
 � Tag$ 	Book Name��5   1   .��5       �� 5!   
   $	��100��6   $��431,64,91,24q�6   .��63   Search6;   �� 5"   
   $��1��62   $��0,10,0,0q�6?   ���	#FF34495E$��1q�6i   ��6   �� *Books+��5#      �� 5$      .R�5%      A�  A� Columns$ 3��6"   	 A� Rows$	 2��6.   5&      ��5(      �� 5)      .R�5*      �� ���	#FF34495E
 �� CornerRadius$
 5��64   $��10q�6E   ._�5+      �� $	��160��6%   $	��260��61   $��10q�6>   .+�5,      �� $	��100��6u   $��0,0,0,10q�6�   ��6$   �� *	BookImg+ �� 	Converter# [   � ToolTip 6�   �� *
BookName+6�   �� 5-      $
��Bold"�6?   
�������$
��Wrap=�6d   $��Center=�6x   $��0,0,0,5q�6�   ��6(   �� *Title+6�   �� 5.       �� Orientation$ 
Horizontal=�6)   $��Center=�6B   $��0,0,0,5q�6_   .+�5/   "   �� $��Tác giả: ��6,   $
��Bold"�6=   
�������6O   �� 50   "   
���������6,   �� *Author.AuthorName+6O   51      �� 52      $ 
Horizontal=�6)   $��Center=�6B   $��0,0,0,5q�6_   .+�53   "   �� $��Thể loại: ��6,   $
��Bold"�6>   
�������6P   �� 54   "   
���������6,   �� *Category.CategoryName+6S   55      �� 56      $ 
Horizontal=�6)   $��Center=�6B   $��0,0,0,5q�6_   .+�57   "   �� $��Số lượng: ��6,   $
��Bold"�6>   
�������6P   �� 58   "   
���������6,   �� *
Quantity+6F   59      �� 5:      $��Đăng kí mượn sách��6%   $��0,10,0,0q�6A   ��5;   %   �� *#!DataContext.RegisterBorrowCommand+ �� RelativeSource ��  �� AncestorType ListView��6�   �� *BookId+��5<   "   �� 5=   &   " ��6,   .�5>   *   ��  � y�$ Visible=�6G    �� Triggers 5?   *   �� 5@   .    �� Binding 6:   �� *
Quantity+ �� Value 06W   .a�5A   2   ��  � y�$ 	Collapsed=�6O   5B   /   5D   '   5F      5G      5H      5I      5K      � 5L   
   $��2��6   .+�5M      �� $	��100��65   $��196,0,326,-2q�6A   ��6   �� *BackCommand+.��6W   Back6]   �� 5N      $��296,2,226,-2q�65   $��30��6K   $	��100��6W   ��6   �� *NextCommand+.��6c   Next6i   5P      5Q      5R      