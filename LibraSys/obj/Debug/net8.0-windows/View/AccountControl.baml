   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LibraSys.ViewLibraSys.View  5      7 clr-namespace:LibraSys.ViewModelLibraSys.ViewModel  5      "    LibraSys.View.AccountControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:LibraSys.View     5      /vm clr-namespace:LibraSys.ViewModel     5      c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5        � DataContext  5      0  *LibraSys.ViewModel.AccountControlViewModel  5   
    � 	Resources 5         DataGridRowStyle1 �� 
TargetType)  #System.Windows.Controls.DataGridRow �� Property �� Value �� 
TargetType  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell��%  &	        &	 �     �� 5   
   "  6*   .�5      ��  � �� 5      �� 5      "  6&   .R�5      � 5      5      5      �� 5   
   "  6+   .�5      ��  � �� 5      �� 5      "  6&   .R�5      � 5      5      5       5!      .��5"      �  � RowDefinitions 5#   
   �� 5$      $
��auto �6   �� 5%      $
��auto �6   �� 5&      $��* �6   .+�5(   
   � $	��300��6   $
��Left=�6   .+�5)      �� -   5         ��Name$ searchTextBox��5)        textboxSearch#��[ 6I   ��6-   �� *
SearchUser+6I   .  (MahApps.Metro.IconPacks.PackIconMaterial  5*         Kind$ Magnify=�6$   $��15��63   $��15��6>   $��Center=�6J   $��0 0 15 0q�5+      ���#b0b9c6$��Right=�6C   �� 5,        	topButton#��[ 67   $��262,14,0,14q�6Z   ���#dcdcdc	 J� RenderTransformOrigin$	 9.085,0.423&�6�   ��6   �� *SearchCommand+6�   5-      � 5.   
   $��1��6   .+�5/      �� $��Members��6   $��32(�6'   $��SemiBold"�65   $��0 20 0 0q�50      $
��Left=�6   ���#12151869   �� 51        exportButton#��[ 6   .��52      �� 
 �� Orientation$
 
Horizontal=�6   .+�53        $
 Plus=�6,   $��Center=�68   $��11��54       $��11��6+   $��0 1 8 0q�67   �� 55      $��Export Excel��6    56      57      58      &   System.Windows.Controls.DataGrid  59   
      CanUserAddRows$ False��61      AutoGenerateColumns$ False��6H   $��3��6d   ��6   �� *Users+   Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ UserName��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6T   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 67   �� *
UserName+6T     5<      $ Password��6%   $	 150 6T    67   �� *
PassWord+6T     5=      $ Email��6%   $	 150 6N    64   �� *Email+6N     5>      $ Gender��6%   $	 150 6P    65   �� *Gender+6P     5?      $ Address��6%   $	 150 6V    66   �� *UserAddress+6V   4
  .System.Windows.Controls.DataGridTemplateColumn
  5@      $ Option��6)    
  CellTemplate 5A      �� 5B      .R�5C      �� $
 
Horizontal=�6)   .+�5D   "   �� $��Delete��6)   ��6:   �� *DataContext.DeleteCommand+ �� RelativeSource ��  �� AncestorType DataGrid��5E   !   �� *Id+5F      5G      5I      5K      5L      5M      