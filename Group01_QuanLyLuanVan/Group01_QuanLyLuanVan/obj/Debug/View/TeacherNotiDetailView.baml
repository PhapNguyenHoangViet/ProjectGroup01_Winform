   M S B A M L   `   `   `  ����P  LGroup01_QuanLyLuanVan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Group01_QuanLyLuanVan.ViewGroup01_QuanLyLuanVan.View  5      6    0Group01_QuanLyLuanVan.View.TeacherNotiDetailView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Group01_QuanLyLuanVan.View     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          N�Name$  TeacherNotiDetailWd��5      $	��605��5
      $	��700��6      TeacherNotiDetailVM � DataContext# [  5       N� Title$ TeacherNotiDetailView��5      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *LoadListNotiCommand+   CommandParameter 5       ��  �� ElementName$ TeacherNotiDetailWd��6`   5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $
��404* �6   �� 5      $
��201* �6   .+�5   
   � $��2��6   	 5      �� 5      $	��104 �6    �� 5      $��44 �6    �� 5      $	��264 �6    �� 5      .+�5       � $��0��6   .+�5!      �� 
 �� Orientation$
 
Horizontal=�6   $��Center=�5"      $��Center=�5#      $	��670��68   .+�5,      �� $
 
Horizontal=�6!   $��0��5-      $��0,0,0,0q�6   .+�5.      ��  � Cursor$
 Hand��6    $��45��5/      $��0��50      $��47��51      .��53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�66   ���#55b3d9$��40��55      $��	0,-18,0,0q�56      $��35��57       58        59   "   $ MouseLeftButtonDown��62   . 5:   &      6<   �� *back+ 5;   4   �� $ TeacherNotiDetailWd��6s   5<   #   5>      5?      �� 5@      -   5         ��Name$ TenDeTai��5C       $��Center=�5A      $��45,0,0,0q�5B       $	��500��5D       $��Center=�5E       
 Custom#��[ 5F      $��20(�5G      $��SemiBold"�5H      ���#55b3d9$
��Wrap=�5J       $��64��64   5M      5Q      � 5R      $��1��6    � ColumnDefinitions 5S      �� 5T      $	��184 �6'   �� 5U      .+�5W      � $��0��6   .+�5X      �� $
 
Horizontal=�6!   $��Center=�5Y   !   $��Center=�5Z   !   .+�5\      �� $��NGÀY��6$   #��[ 5]      $��16(�5^      $��SemiBold"�5_      5`      5a      � 5b      $��1��6   $��44��6)   $��Bottom=�65   .+�5c      �� $
 
Horizontal=�6!   $��Center=�5d   !   $��Center=�5e   !   .+�5f      �� $��TIÊU ĐỀ��6$   #��[ 5g      $��16(�5h      $��SemiBold"�5i      5j      5k      5l      � 5m      $��2��6    5n      �� 5o      $��7* �6'   �� 5p      $��3* �6'   	 5r      �� 5s      $
��102* �6$   �� 5t      $
��161* �6$   �� 5u      $��* �6$   .+�5w      �� -   5         ��Name$ ListThongBaoView��5x       �� SelectionMode$ Single=�5y      $��Hidden=�5z      
�������$��2��5|   (   $��2��69   $��0,0,0,41q�6M   ��5{      �� *ListThongBao+��5}      �� 5~      .R�5      �� $	��684��5�   !   $��40��5�   !    �� CornerRadius$ 10��5�   !   $	��0.5q�5�   !   
�������
�������._�5�   "   �  5�   &   �� 5�   *   $	��184 �6;   �� 5�   *   .+�5�   &   � $��0��6+   .+�5�   *   �� $
 Ngay��5�   -   ���#FFA500$��Center=�5�   -   $��Center=�5�   -   #��[ 5�   -   $��14(�5�   -   ��5�   -   �� *Ngay+5�   +   5�   '   � 5�   &   $��1��6+   .+�5�   *   �� $ TieuDe��5�   -   ���#1e90ff$��Center=�5�   -   $��Center=�5�   -   #��[ 5�   -   $��14(�5�   -   ��5�   -   �� *TieuDe+5�   +   5�   '   5�   #   5�      5�      ��5�      �� 5�      .R�5�      �  � Orientation$ Vertical=�6(   5�       5�        5�      $ SelectionChanged��6)   . 5�         64   �� *DetailThongBaoCommand+ 5�   8   �� $ TeacherNotiDetailWd��6w   5�      5�      5�      � 5�      $��3��6   .+�5�      �� $
 Vertical=�6   .+�5�      �� $��
NỘI DUNG��6$   #��[ 5�      $��16(�5�      $��SemiBold"�5�       �� Padding$ 
50,10,0,10q�5�      $��44��6.   $	��679��6:   �� 5�      
�������$	��0.5q�5�      $ 10��5�      
�������$��	10,0,10,0q�5�      ._�5�      �� -   5        $ NoiDung��5�      ���#55b3d9$	��Top=�5�      $
��Wrap=�5�      #��[ 5�      $��16(�5�      $	��103��5�      $ 20q�5�      ��5�      �� *SelectedThongBaoNoiDung+5�      5�      �� 5�      $��0q�5�      $��+ Thêm��5�      $��
600,10,0,0q�5�      $��83��5�      $��30��5�      $��Center=�5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 5��5�      ���#55b3d9#��[ 5�       5�        5�      $ Click��6-   . 5�   "      5�      �� *	AddNoti+ 5�      �� $ TeacherNotiDetailWd��5�      5�      5�      5�      5�      5�      5�      