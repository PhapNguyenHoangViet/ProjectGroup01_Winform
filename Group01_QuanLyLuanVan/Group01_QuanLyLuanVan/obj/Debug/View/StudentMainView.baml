   M S B A M L   `   `   `  ����P  LGroup01_QuanLyLuanVan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Group01_QuanLyLuanVan.ViewGroup01_QuanLyLuanVan.View  5   	   W0clr-namespace:Group01_QuanLyLuanVan.UserControls"Group01_QuanLyLuanVan.UserControls  5	   	   0    *Group01_QuanLyLuanVan.View.StudentMainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Group01_QuanLyLuanVan.View     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   9uc0clr-namespace:Group01_QuanLyLuanVan.UserControls  5	   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  Studentmainview��5   	    � Title$ Quản lý luận văn��5   	   $	��750��6"   $
��1100��6/    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�5   	      StudentMainVM � DataContext# [  5   	   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase	   Actions.	 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  
   Command
 6$   �� *Loadwd+   CommandParameter 5       ��  �� ElementName$ Studentmainview��6[   5       � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5       W�  �� 
TargetName$ Studentmainview��6&    �� TargetProperty$ Opacity�5!   &    W� From$ 0X�5"   &   	 W� To$ 1X�5#   &    g� Duration$ 0:0:0.1D�5$   &   5%      5&      5'      .��5+      ��  �� CornerRadius$ 45��6   ���#EBEEF4._�5-   
   �  � ColumnDefinitions 5.      �� 5/      $	��200 �6#   �� 50      .+�54      �� $��0��6   ���#55b3d9$ 	40,0,0,40��56      $	��750��6*   $��Center=�67   ._�57      �  � RowDefinitions 58      �� 59      $��60 �6(   �� 5:      $	��111 �6(   �� 5;      $	��109 �6(   �� 5<      .+�5?      � $��1��6   .+�5@      �� $��/Resource/Image/logo.png��6    5A      � 5B      $��2��6   $��0,30,0,0q�6(   $��2��6:   .+�5D      �� .+�5E      	� -   5         	�Name$ btnDashboard��5H   !   $	��200��5G   !     BtnDashboardStudent#��[ 5I   !    d� 	IsChecked$
 TrueY�5J   !    
 Custom#��[ 5K   !   
 J� Uid$ 0��5L   !   ��5F   !   �� *HomeStudentCM+5N      	� 5P      -   5        $ btnDangKyDeTai��5S   !   $	��200��5R   !   $ 1��5T   !     BtnDangKyDeTai#��[ 5U   !   #��[ 5V   !   ��5Q   !   �� *StudentRegisterCM+5X      	� 5Y      -   5        $ BtnStudentThesis��5\   !   $	��200��5[   !   $ 2��5]   !     BtnStudentThesis#��[ 5^   !   #��[ 5_   !   ��5Z   !   �� *StudentThesisCM+5a      	� 5b      -   5        $ btnCapNhatTask��5e   !   $	��200��5d   !   $ 3��5f   !     BtnCapNhatTask#��[ 5g   !   #��[ 5h   !   ��5c   !   �� *StudentUpdateTaskCM+5j      	� 5l      -   5        $ btnStudentScore��5o   !   $	��200��5n   !   $ 4��5p   !     BtnDiemLuanVan#��[ 5q   !   #��[ 5r   !   ��5m   !   �� *StudentScoreCM+5t      	� 5v      $	��200��5y   !     BtnNoti1#��[ 5z   !   #��[ 5{   !   $ 5��5|   !   ��5x   !   �� *StudentNotiCM+y�5}   !   �� 5      	� 5�      $	��200��5�   !     
BtnSupport#��[ 5�   !   #��[ 5�   !   $ 7��5�   !   ��5�   !   �� *StudentMailCM+5�      � 5�      $��2��6#   $��Bottom=�60    5�   "   �� 5�   &   $	��39* �67   �� 5�   &   $
��161* �67   .+�5�   "   ��  	 	BtnLogOut#��[	 5�   %   #��[ 5�   %   $��	0,0,0,-47q�6J   $��2��5�   ^   ��5�   %   �� *	SignoutCM+��5�   %   �� $ Studentmainview��5�   #   5�      5�      5�      5�      5�      �� 5�      $��1��6   
�������$ 	0,40,40,0��5�      ._�5�      �  5�      �� 5�      $��50 �6(   �� 5�      $��50 �6(   �� 5�      .+�5�      �� $��0��6   ._�5�      5   /Group01_QuanLyLuanVan.UserControls.ControlBarUC   K� ZIndex$ 5��6*   $��45��6;   $��0,0,10,0q�6G   5�      � 5�      $��1��6    5�      �� 5�      $
��139* �6/   �� 5�      $	��11* �6/   .+�5�      � $��0��6   .+�5�      ��  �� Orientation$ 
Horizontal=�6)   $��	650,0,0,0q�6B   .+�5�   "   ]� $��0,0,25,0q�6,   .+�5�   &   �� $��40��5�   )   $��40��5�   )   
���   �$ 50��5�   )   $��	30,5,10,5q�5�   )   ._�5�   *   A� $��40��62   $��40��6>   $	��Top=�6I   ��5�   .   �� 5�   2   -   5        
Avatar�� �� ImageSource 5�   M   �� *Ava+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5�   +   5�   '   �� 5�   &   $
��Left=�61   $��Center=�6L   .+�5�   *   �� -   5         ��Name$ TenDangNhap��5�   4   $��15(�5�   -   $�� ��5�   -   
���   �$
��Thin"�5�   -   #��[ 5�   -   5�   +   �� 5�   *   -	   5        $ Quyen��5�   4   $��
Sinh Viên��5�   -   $��13(�5�   -   
���   �#��[ 5�   -   $
��Thin"�5�   -   5�   +   5�   '   5�   #   5�      5�      � 5�      $��1��6   .+�5�      �� -
   5          ��Name$  btnStudentUpdateInfor��5�   U    
 
BtnSetting#��[
 6%   $��50��6I   ��6t   �� *StudentUpdateInforCM+5�      5�       � 5�      -   5        !  �Name$! frame��5�      
�������$��
43,0,43,42q�5�   /   "  � NavigationUIVisibility$" Hidden=�5�      $��2��6<   # [  6I    5�        5�      $ Loaded��6-   .	 5�   "     
 68   �� *LoadPageHomeCM+ 5�   %   �� $ frame��5�      5�      5�      5�      5�      5�      5�      