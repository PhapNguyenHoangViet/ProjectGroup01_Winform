   M S B A M L   `   `   `  ����P  LGroup01_QuanLyLuanVan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Group01_QuanLyLuanVan.ViewGroup01_QuanLyLuanVan.View  5      >    8Group01_QuanLyLuanVan.View.TeacherDissertationDetailView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      :local(clr-namespace:Group01_QuanLyLuanVan.View     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          N�Name$  DetailBookwd��5       N� 
Background
 ����    TeacherDissertationDetailVM � DataContext# [  5      $	��450��5      $	��690��5      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *Loadwd+   CommandParameter 5       ��  �� ElementName$ DetailBookwd��6X   5      .��5      �� 
������ 	 �� CornerRadius$	 15��5      $��3q�5      ��5   
   �� 5      
 �� EndPoint$
 0.5,1&�6"    �� 
StartPoint$ 0,0.5&�63   .��5      �  � Color$ Transparent��6    � Offset$ 0Q�63   � 5      $ Transparent��6   $ 1Q�63   5       5    
     5!      $ MouseLeftButtonDown��6   . 5"         6(   �� *
MoveWindow+ 5#   $   �� $ DetailBookwd��6\   5$        5%      $ Loaded��6   . 5&         6(   �� *	GetName+ 5'   $   �� $ DetailBookwd��6\   5(      ._�5*   
   �  � ColumnDefinitions 5+      �� 5,      �� 5-      .+�5/      � $��0��6    � RowDefinitions 50      �� 51      $	��350 �6$   �� 52      .+�54      �� -   5         ��Name$ HinhAnhSach��55      $��0��54      $��Center=�56      �� 57      $��1��6   .+�58      �� -   5         ��Name$ 
btncapnhat��5=      $��CẬP NHẬT��58      $	��125��59      $��30��5:      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5;      $��0q�5<      ���#353A55
�������$
��Left=�5A       �� Left$ 46��68   
 �� Top$ 26��6I    5C        5D      $ Click��6-   . 5E   "      68   �� *
UpdateBook+ 5F   4   �� $ DetailBookwd��6l   5G      5I      �� 5J      -   5        $ btnxoa��5N      $
��XÓA��5J      $��85��5K      $��30��5L      $��0q�5M      ���#353A55
�������$ 15��5Q      $
��Left=�5R      $	 203��68   $ 26��6J    5T        5U      $ Click��6-   . 5V   "      68   �� *
DeleteBook+ 5W   4   �� $ DetailBookwd��6l   5X      5Z      5[      5\      � 5]      $��1��6    5^      �� 5_      �� 5`      $��50 �6$   .+�5b      � $��1��6   .+�5c      �� $��Hủy��5d      $	��100��5e      $��40��5f      $��Center=�5g      $��
200,10,0,0q�5h      
����������#353A55$
��Left=�5k      $��1��64    5m        5n      $ Click��6-   . 5o   "      5p   )   �� *back+ 5q   )   �� $ DetailBookwd��6a   5r      5t      5u      � 5v      $��0��6   
������ .+�5w      ��  �� Orientation$ Vertical=�6!   $��	15,20,0,0q�5x      .+�5z      �� -   5         ��Name$ TenSach��5�       $
��Left=�5{   !   $��28(�5|       .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5}       $��0q�5~        
 Custom#��[ 5       5�       �� 5�      $ 
Horizontal=�6%   .+�5�      �� -   5        $ GiaSach��5�       $��20(�5�       $ Hidden=�5�      $��0q�5�      #��[ 5�       5�       �� 5�      $��10 0 0 0q�5�   !   $��20(�5�       $ Hidden=�5�      $��0q�5�      #��[ 5�       $�� ��5�   9   5�      �� 5�      $ 
Horizontal=�6%   .+�5�      �� #��[ 5�      $��14(�5�      $��Center=�5�      $�� ��5�      �� 5�      -   5         ��Name$ LoaiSach��5�       $��Center=�5�      $��14(�5�       $ Hidden=�5�       #��[ 5�       5�       5�      �� 5�      -   5        $ SLSach��5�       $��14(�5�       #��[ 5�       $��0,0,0,10q�5�       5�       �� 5�      $ 
Horizontal=�6%   .+�5�      �� #��[ 5�   !   $��14(�5�   !   $��Center=�5�   !   $�� ��5�   !   �� 5�      -	   5        $ TenNXB��5�   !   $��Center=�5�   "   $��14(�5�   !   $ Hidden=�5�   !   #��[ 5�   "   5�   !   5�      9� 5�      -
   5         9�Name$
 Info��5�      
������ $�� ��5�      #��[ 5�      .��5�      �� -   5        $
 Mota��5�   &   $	��120��5�   "    �� TextWrapping$
 Wrap=�5�   "   $ Hidden=�5�   "   $��0q�5�   "    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�5�   "   5�      5�      5�      5�      5�      5�      5�      