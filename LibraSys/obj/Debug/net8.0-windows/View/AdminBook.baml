   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LibraSys.ViewLibraSys.View  5      7 clr-namespace:LibraSys.ViewModelLibraSys.ViewModel  5      7 clr-namespace:LibraSys.UtilitiesLibraSys.Utilities  5          LibraSys.View.AdminBook   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:LibraSys.View     5      /vm clr-namespace:LibraSys.ViewModel     5      2utils clr-namespace:LibraSys.Utilities     5      c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5	        � 	Resources  5      2   ,LibraSys.Utilities.ByteArrayToImageConverter   ByteArrayToImageConverter  DataGridRowStyle1 �� 
TargetType)  #System.Windows.Controls.DataGridRow �� Property �� Value �� 
TargetType  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell��%5  &	        &	      &	 �       5   
   6*   �� 5   
   "  6*   .�5      ��  � �� 5      �� 5      "  6&   .R�5      � 5      5      5      �� 5   
   "  6+   .�5      ��  � �� 5      �� 5      "  6&   .R�5      � 5      5      5      5       .��5!      �  � RowDefinitions 5"   
   �� 5#      $
��auto �6   �� 5$      $
��auto �6   �� 5%      $��* �6   .+�5'   
   � $	��300��6   $
��Left=�6   .+�5(      �� -   5         ��Name$ searchTextBox��5(   2     textboxSearch#��[ 6I   ��6   �� *
SearchBook+6I   .  (MahApps.Metro.IconPacks.PackIconMaterial  5)         Kind$ Magnify=�6$   $��15��63   $��15��6>   $��Center=�6J   $��0 0 15 0q�5*      ���#b0b9c6$��Right=�6?   �� 5+        	topButton#��[ 67   $��262,14,0,14q�6Z   ���#dcdcdc J� RenderTransformOrigin$ 9.085,0.423&�6�   ��6   �� *SearchCommand+6�   5,      � 5-   
   $��1��6   .+�5.      �� $
��Book��6   $��32(�6$   $��SemiBold"�62   $��0 20 0 0q�5/      $
��Left=�6   ���#12151865   �� 50        exportButton#��[ 65   ��6   �� *
AddCommand+.��51      �� 	 �� Orientation$	 
Horizontal=�6   .+�52        $
 Plus=�6,   $��Center=�68   $��11��53      $��11��6'   $��0 1 8 0q�63   �� 54      $��Add Book��6    55      56      57      &   System.Windows.Controls.DataGrid  58   
   
   CanUserAddRows$
 False��64      AutoGenerateColumns$ False��6K   $��3��6g   ��6   �� *
BookList+   Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$
 Tên��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6O   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 62   �� *
BookName+6O   4
  .System.Windows.Controls.DataGridTemplateColumn
  5;      $ Image��6)   $	 200 68    
  CellTemplate 5<      �� 5=      .R�5>      �� $	��150��6u   $	��100��6�   $
��Fill=�6�   ��6$   �� *	BookImg+ �� 	Converter# [  6�   5?      5A        5B      $ 
Tác giả��6%   $	 120 6\    66   �� *Author.AuthorName+6\     5C      $ Loại sách��6%   $	 120 6b    68   �� *Category.CategoryName+6b     5D      $ Số lượng��6%   $	 150 6T    67   �� *
Quantity+6T   
  5E      $ Option��6)    5F      �� 5G      .R�5H      �� $	 
Horizontal=�6)   .+�5I   "   �� $��Delete��6)   ��6:   �� *DataContext.DeleteCommand+ �� RelativeSource ��  �� AncestorType DataGrid��5J      �� *BookId+5M      5N      5P      5R      5S      5T      