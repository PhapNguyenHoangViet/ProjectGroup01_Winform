   M S B A M L   `   `   `  ����P  LGroup01_QuanLyLuanVan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Group01_QuanLyLuanVan.ViewGroup01_QuanLyLuanVan.View  5      7    1Group01_QuanLyLuanVan.View.StudentUpdateInforView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Group01_QuanLyLuanVan.View     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          N�Name$  StudentUpdateInforwd��5      $	��700��5      $	��605��6    N� Title$ StudentUpdateInforView��5
         StudentUpdateInforVM � DataContext# [  5      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6%   �� *Loadwd+   CommandParameter 5   %   ��  �� ElementName$ StudentUpdateInforwd��5      5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $	��102 �6   �� 5      $	��378 �6   �� 5      .+�5   
   � $��0��6   .+�5      �� $��THÔNG TIN CHUNG��5      $��Josefin Sans)�5      $	�� 25(�5      $��	0,20,0,10q�5       ���#55b3d9$
��Bold"�5"      $��Center=�5#      5$      � 5%   
   $��1��6   
 � ColumnDefinitions
 5&      �� 5'      $	��47* �6#   �� 5(      $	��93* �6#   .+�5*      � $��0��6   	 5+      �� 5,      $	��374 �6$   �� 5-      .+�5/      � $��0��6   $��	20,0,0,10q�6$   .+�50      �� ._�51      A� $	��150��6"   $	��150��6/   $	��Top=�52   "   $��Center=�6:   $��5��6W    J� Effect 53      3  -System.Windows.Media.Effects.DropShadowEffect  54   "      ShadowDepth$ 0Q�63      Color$ Black��55   #      Opacity$ 10Q�56   #      
BlurRadius$ 10Q�57   #   ��59      �� 5:   "   -   5        ProfilePicture�� �� ImageSource 5:   E   �� *Ava+ 5<        5=   "   $ MouseLeftButtonDown��61   . 5>   &      6<   �� *
AddImage+ 5?   ?   �� $ ProfilePicture��6z   5@   #   5B      5C      5D      5E      � 5F      $��1��6   $��35,0,0,0q�6#   	 5G      �� 5H      $��4* �6$   �� 5I      .+�5K      ��  �� Orientation$ Vertical=�6   $��2��64   .+�5L      �� $ 
Horizontal=�6!   $��0,0,20,0q�6:   $��Center=�5M   !   .+�5N      �� -   5         ��Name$ 
sinhVienId��5O      
���   �)  #MaterialDesignThemes.Wpf.HintAssist   
Foreground
 �   �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#1784C2$	��190��5S        MaterialDesignFilledTextBox#��[ 5T      $	��Top=�5U       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5W      $	��400��5X      $��Josefin Sans)�5Y       �� 
IsReadOnly .    Hint$ Mã số��5[      $��45��6a   ��6D   �� *
SinhVienId+6a   �� 5\      -   5         ��Name$ tenKhoa��5^      $��20,0,0,0q�5]      $��Josefin Sans)�5^   .      MaterialDesignFilledComboBox#��[ 5_      
 �   � �#1784C2$
 Khoa��5b      $��45��5c      $	��190��5d       �� SelectedIndex 5b   C   �� *	TenKhoa+.@�5e      �� $��Công nghệ thông tin��5f   !   �� 5g      $��	Kinh tế��5h   !   5i      5j      �� 5l      $ 
Horizontal=�6!   $��	0,20,20,0q�6:   $��Center=�5m      .+�5n      �� -   5        $ hoTen��5o      
���   �
 �   � �#1784C2$	��190��5s      #��[ 5t      $	��Top=�5u       . $
 Wrap=�5w      $	��400��5x      $��Josefin Sans)�5y      $ 	Họ tên��5z      $��45��6Y   ��6A   �� *HoTen+6Y   �� 5{      -   5        $ GTBox��5}   	   $��20,0,0,0q�5|   	   $��Josefin Sans)�5}      #��[ 5~   	   
 �   � �#1784C2$ Giới tính��5�   	   $��45��5�   	   $	��190��5�   	    5�   4   �� *
GioiTinh+.@�5�      �� $	��Nam��5�      �� 5�      $
��Nữ��5�      5�      5�      �� 5�      $ 
Horizontal=�6!   $��	0,20,20,0q�6:   $��Center=�5�   !   .+�5�      (  "System.Windows.Controls.DatePicker  -   5          Name$ DateBox��5�   0   
 �   � �#1784C2
���   �$��Josefin Sans)�5�      |�.  $ 
Ngày sinh��5�       " MaterialDesignFilledDatePicker#��[ 6c   $	��190��5�         Text 5�   I   �� *
NgaySinh+5�      �� 5�      -   5        $	 sdt��5�   8   $��20,0,0,0q�5�      $	��190��60   #��[ 5�      
 �   � �#1784C2$	��Top=�5�       . $
 Wrap=�5�      $
��Left=�5�      $��Josefin Sans)�5�      $ Số điện thoại��5�      ��5�   F   �� *SDT+5�      5�      �� 5�      -	   5        $
 Mail��5�   (   
���   �$��	0,20,20,0q�5�      #��[ 5�      $	��Top=�5�       . $
 Wrap=�5�      $	��400��5�      
 �   � �#1784C2$��Josefin Sans)�5�       . $ Email��5�      ��5�   6   �� *Mail+5�      �� 5�      -
   5        $ DiaChi��5�   (   
���   �$��	0,20,20,0q�5�      #��[ 5�      $	��Top=�5�       . $
 Wrap=�5�      $	��400��5�      
 �   � �#1784C2$��Josefin Sans)�5�      $ Địa chỉ��5�      ��5�   9   �� *DiaChi+5�      �� 5�      $	��400��5�      $��	0,20,20,0q�5�      $	��Top=�5�      $��Cập nhật thông tin��5�      $��0q�5�      $��Josefin Sans)�5�      
����������#55b3d9$��40��5�       ! MaterialDesignFlatMidBgButton#��[ 5�       5�        5�      $ Click��6-   . 5�   "      68   �� *
UpdateInfo+ 5�   8   �� $ StudUpdateInforWd��6u   5�      5�      5�      5�      5�      � 5�   
   $��2��6   .+�5�      �� $��Đổi mật khẩu��5�      $��13(�5�      $��Josefin Sans)�5�      $��25��5�      $
��Left=�5�      
������  � Cursor$
 Hand��5�      $��572,38,0,63q�6     5�        5�      $ Click��6%   . 5�         60   �� *
ChangePass+ 5�   8   �� $ StudentUpdateInforwd��6x   5�      ��5�      �� 5�       �� 
TargetType" ��6   .�5�      ��  �� Property � ��  �� Value
  ���� 67   �� 5�       � ��  �#55b3d967   ! �� Triggers! 5�      P� 5�      " P� Property" �@J�IsMouseOver# P� Value# . . �5�   "   ��  � ��  �#6891DF6?   �� 5�   "    � ��
  �����6?   5�      5�      ��5�      �� 5�      $ �� 
TargetType"$ ��6&   .R�5�      �� $	��100��6!   $��25��6-   % �� CornerRadius$% 9��5�   %   #��z��5�   %   ._�5�      �� $��Center=�6/   $��Center=�5�   -   5�      5�      5�      5�      5�      5�      5�      