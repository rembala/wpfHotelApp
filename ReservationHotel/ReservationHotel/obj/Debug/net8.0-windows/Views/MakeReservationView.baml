   M S B A M L   `   `   `  ����K  GReservationHotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ReservationHotel.ViewsReservationHotel.Views  5      0    *ReservationHotel.Views.MakeReservationView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:ReservationHotel.Views     5      .��5	      �   � IsSharedSizeScope$
  True��6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��24(�5      $��Make reservation��5      5      � 5   
   $��1��6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $��UserName��6%   �� 5      $��1��6   $��0 5 0 0q�5      ��5       �� *
UserName+.��64   5!      5"      � 5$   
   $��2��6    5%      �� 5&      $
��Auto �6    �� 5'      $
��Auto �6     � ColumnDefinitions 5*      �� 5+      $
��Auto �6#    z� SharedSizeGroup$ fistName��60   �� 5,      $
��Auto �6#   $ lastName��60   .+�5/      �� $��0��6   $��0��50      $��	Floor No.��51      52      �� 53      $��1��6   $��0��54      $��0 5 0 0q�55      ��56      �� *FloorNumber+ �� UpdateSourceTrigger$ PropertyChanged=�.��6X   57      �� 59      $��0��6   $��1��5:      $��5 0 0 0q�5;      $��Room No.��5<      5=      �� 5>      $��1��6   $��1��5?      $��5 5 0 0q�5@      ��5A      �� *
RoomNumber+$ PropertyChanged=�.��6W   5B      5C      � 5E   
   $��3��6    5F      �� 5G      $
��Auto �6    �� 5H      $
��Auto �6     5K      �� 5L      $
��Auto �6#   $ fistName��60   �� 5M      $
��Auto �6#   $ lastName��60   .+�5P      �� $��0��6   $��0��5Q      $��
Start date��5R      5S      (  "System.Windows.Controls.DatePicker  5T      $��1��6   $��0��5U      $��0 5 0 0q�5V         SelectedDate 5W      �� *	StartDate+$ PropertyChanged=�5X      �� 5Z      $��0��6   $��1��5[      $��5 0 0 0q�5\      $��End date��5]      5^        5_      $��1��6   $��1��5`      $��5 5 0 0q�5a       5b      �� *	EndDate+$ PropertyChanged=�5c      5d      �� 5f   
    �� Orientation$ 
Horizontal=�6   $��4��6.   .+�5g      �� $��Submit��6   ��6&   �� *SubmitCommand+�� 5h      $��Cancel��6   ��6&   �� *CancelCommand+5i      5j      5k      