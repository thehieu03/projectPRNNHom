   M S B A M L   `   `   `  ����C  ?LibraSys, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:LibraSysLibraSys  5   	       LibraSys.ResetPassword   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:LibraSys     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ ResetPassword��5	      $	��450��6#   $	��500��60   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��124* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ btnVerifyOTP��5   3   ���#F7B21D���#ffff$��Change��6q   $��Century Gothid)�6�   $
��14px(�6�   $
��Bold"�6�   $
��Left=�6�   $��138,382,0,0q�6�   $	��Top=�6�   $��42��6  $	��252��6  $��1��6   ��6   �� *ChangeCommand+6   �� 5   
   $��New Password:��6   $
��Left=�6(   $��151,158,0,0q�6C   $��Century Gothic)�6Y   $
��Bold"�6u   $	��Top=�6�   $	��164��6�   $��29��6�   $��1��6�   �� 5   
   $��Confirm Password:��6   $��Century Gothic)�6,   $
��Bold"�6H   $��Center=�6[   $��	0,233,0,0q�6x   $	��Top=�6�   $	��164��6�   $��1��6�   $��29��6�   �� 5   
   $��Reset Password��6   $��Century Gothic)�6*   $
��Bold"�6F   $��30(�6X   ���#13538B$��Center=�6{   $��0,27,0,0q�6�   $	��Top=�6�   $��1��6�   $��47��6�   $	��232��6�   �� 5   
   $��Center=�6>   $��	0,192,0,0q�6[    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��193��6�   $��25��6�   $��1��6�   ��6   �� *PasswordNew1+ �� Mode$ TwoWay=�6�   �� 5   
   $��	0,262,0,0q�6<   $
 Wrap=�6O   $	��Top=�6d   $	��193��6|   $��25��6�   $��1��6�   ��6   �� *PasswordNew2+$ TwoWay=�6�   �� 5   
   $��Email :��6   $��Center=�6"   $��0,90,0,0q�6?   $��Century Gothic)�6R   $
��Bold"�6n   $	��Top=�6�   $	��164��6�   $��29��6�   $��1��6�   �� 5   
   $��Center=�65   $��	0,129,0,0q�6R   $
 Wrap=�6e   $	��Top=�6y   $	��192��6�   $��25��6�   $��1��6�   ��6   �� *Email+$ TwoWay=�6�   �� 5   
   -   5         ��Name$ txtOTP��5   7   $��Center=�6G   $��	0,325,0,0q�6d   $
 Wrap=�6w   $	��Top=�6�   $	��194��6�   $��25��6�   $��1��6�   ��6   �� *	OtpCode+$ TwoWay=�6�   �� 5   
   $��Get OTP code :��6   $��Century Gothic)�6)   $
��Bold"�6E   $��Center=�6X   $��	0,296,0,0q�6u   $	��Top=�6�   $	��164��6�   $��29��6�   $��1��6�   �� 5   
   -   5        $ btnOTP��5   0   $��1��6@   $��Nhận Mã OTP��6P   $
��Left=�6f   $��375,330,0,0q�6�   $	��Top=�6�    J� RenderTransformOrigin$ 0.166,-0.117&�6�   ��6   �� *
OtpCommand+6�   5      5      