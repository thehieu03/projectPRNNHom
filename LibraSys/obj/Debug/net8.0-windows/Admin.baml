   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LibraSys.ViewModelLibraSys.ViewModel  5   	       LibraSys.Admin   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _MahApps.Metro.IconPacks.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=5.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   +vm clr-namespace:LibraSys.ViewModel   5   	     � AllowsTransparency$
  True��5   	    � WindowStartupLocation$ CenterScreen=�6#    � WindowStyle$
 None=�5   	   
������  � Title$ Admin��5	   	   $	��720��6   $
��1080��6$    � DataContext 5
      (  "LibraSys.ViewModel.NavigationAdmin  5   
   6   .��5      �� -   5        
������� �� CornerRadius$ 30��5       ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   61   �� 5      $��* �6#   6/   .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   64   �� 5      $��* �6$   61   .+�5      ��    	topButton#��[  6   $
��Left=�6<   $��
20 28 0 35q�6W   .��5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Menu=�6,   $��15��68   $��15��6C   5      �� 5      $��1��6   ���#623ed0$ 	0 50 0 30��6;   ._�5      ]� .+�5      �� $��80��6!   $��80��6,   	 �� Padding$	 3q�68   
�������$	 100��6W   $	��Top=�5   	   $
��Left=�6   $��
20 -30 0 0q�69   ._�5       A� ��5!   "   �� 5"   &   
 �� ImageSource$-
 'D:/TheHieuPRN/WPF/Images/order_page.png��61   5$      5%      �� 5&      $��	TheHieu03��6$   
�������$��22(�6H   $��SemiBold"�6V   $	��Top=�5'       �� TextAlignment$ Center=�6!   $��	5 25 0 10q�68   �� 5(      $��Welcom Admin��6$   ���#d0bfff$��14(�6M   $��SemiBold"�6[   $	��Top=�5)      $ Center=�6!   �� 5*      $��25q�6$   $	��Top=�60   $	��0.8��6E   ���#7e5fdc6R   �� 5+      $	��Top=�6%   .+�5,      ��   
menuButton#��[ 6H   ��6%   �� *AccountCommand+.��5-   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5.   &     $ Human=�6<     menuButtonIcon#��[ 6I   �� 5/   &   $��Account��60   50   #   51      �� 52      #��[ 6E   ��6%   �� *BookCommand+.��53   "   �� $ 
Horizontal=�6-   .+�54   &     $
 Book=�6<   #��[ 6H   �� 55   &   $
��Book��60   56   #   57      �� 58      #��[ 6%   .��59   "   �� $ 
Horizontal=�6-   .+�5:   &     $ 
HorseHuman=�6<   #��[ 6N   �� 5;   &   $��Athor��60   5<   #   5=      �� 5>      #��[ 6%   .��5?   "   �� $ 
Horizontal=�6-   .+�5@   &     $  OrderAlphabeticalAscending=�6<   #��[ 6^   �� 5A   &   $��Order��60   5B   #   5C      �� 6'   -   5        #��[ 5C   C   .��5D   "   �� $ 
Horizontal=�6-   .+�5E   &     $ Logout=�6<   #��[ 6J   �� 5F   &   $��Logout��60   5G   #   5H      5I      5J      5K      5L      � 5M      $��1��6   .+�5N      �� -   5         ��Name$ Pages��5N   !   ��5O      �� *CurrentView+5P      5Q      5S      5T      