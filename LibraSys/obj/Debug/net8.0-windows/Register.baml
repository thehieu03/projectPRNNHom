   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LibraSysLibraSys  5   	       LibraSys.Register   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   "localclr-namespace:LibraSys  5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
User Setup��5
      $	��400��6   $	��669��6+    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%  '��       '��     �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 9��6!   
����������	#FF00A7FF$��2q�5      ._�5      �� $ PART_ContentHost��66   $��0q�6+   66   5      5      5      5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 9��6!   #��z��5      #��z��5       #��z��5!      ._�5"      �� $��Center=�6/   $��Center=�6L   5#      5$      5&      5'      5(      .��5)      � $��0,0,10,0q�6   	 � ColumnDefinitions	 5*   
   �� 5+      $	��240 �6   �� 5,      .+�5.   
   �� ���	#FF00A7FF$��Center=�6,   $��Center=�6G   $	��384��6d   $	��236��6q   .+�5/      �� $N��HIMG/660e22fc55ece846d65b2b02-wilson-jones-s490-visitor-register-book.jpg��6   $	��100��6h   $	��100��6t   $��10q�6�   �� 50      $��Let's get you set up��6   $��20(�64   $
��Bold"�6B   $��10q�6T   
 �� TextAlignment$
 Center=�6`   $��Times New Roman)�6w   �� 51      $E��?it should only take a couple of minutes to pair with your watch��6   $
��Wrap=�6_   $��10q�6s   $
 Center=�6   $��Times New Roman)�6�   �� 52      $	��→��6   $��40��6!   $��40��6,   $��Center=�68   $��10q�6U   53      �� 54   
   $��1��6   $��20,70,20,20q�55      .+�56      ��  �� Orientation$ 
Horizontal=�6   $��5q�62   .+�57      �� $��	User Name��6   $	��100��6-   $��Center=�69   $��Times New Roman)�6T   �� 58      -   5         ��Name$ txtUserName��58   @   $	��200��6U   ��6   �� *
Username+ �� Mode$ TwoWay=�6U   59      �� 5:      $ 
Horizontal=�6   $��5q�62   .+�5;      �� $��Email��6   $	��100��6)   $��Center=�65   $��Times New Roman)�6P   �� 5<      -   5        $ txtNewEmail��5<   =   $	��200��6R   ��6   �� *Email+$ TwoWay=�6R   5=      �� 5>      $��1��6   $ 
Horizontal=�6)   $��5q�6B   .+�5?      �� $��Gender��6   $	��100��6+   $��Center=�67   $��Times New Roman)�6R   $��0,0,10,0q�6o   	� 5@      -   5         	�Name$ 
MaleGender��5@   G   $
��Male��6[    	� 	GroupName$ Gender��6j   $��5,0,10,0q�6}   $��Times New Roman)�6�    d� 	IsChecked 6   �� *IsMale+$ TwoWay=�6�   	� 5A      -   5        $ FemaleGender��5A   I   $��Female��6_   $ Gender��6p   $��Times New Roman)�6�    6   �� *
IsFemale+$ TwoWay=�6�   5B      �� 5C      $ 
Horizontal=�6   $��5q�62   .+�5D      �� $��Address��6   $	��100��6+   $��Center=�67   $��Times New Roman)�6R   �� 5E      -   5        $ 
txtAddress��5E   ?   $	��200��6S   ��6   �� *	Address+$ TwoWay=�6S   5F      �� 5G      $ 
Horizontal=�6   $��5q�62   .+�5H      �� $��Password��6   $	��100��6,   $��Center=�68   $��Times New Roman)�6S   �� 5I      -   5        $ txtPass��5I   @   $	��200��6Q   ��6   �� *
Password+$ TwoWay=�6Q   5J      �� 5K      $ 
Horizontal=�6   $��5q�62   .+�5L      �� $��OTP Code��6   $	��100��6,   $��Center=�68   $��Times New Roman)�6S   �� 5M      -   5        $ txtOTP��5M   G   $	��199��6W   ��6   �� *OtpCodeText+$ TwoWay=�6W   �� 5N      $	��OTP��6=   $��51��6K   $��5,0,0,0q�6V   ���	#FF26B2FB��6   �� *OtpCodeCommand+6g   5O      �� 5P      $ 
Horizontal=�6   $��Center=�62   $��30,0,0,0q�6O   .+�5Q      �� $��Login��6:   $	��100��6J   $��5q�6V   ���	#FF00A7FF���	#FF24B4FF$��Times New Roman)�6�   ��6   �� *LoginCommand+6�   �� 5R      $
��Save��69   $	��100��6H   $��5q�6T   ���	#FF00A7FF���	#FF26B2FB$��Times New Roman)�6�   ��6   �� *SaveCommand+6�   5S      5T      5U      5V      