   M S B A M L   `   `   `  ����F  BHotelOrigin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HotelOriginHotelOrigin  5   	   '    !HotelOrigin.ReservationListWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HotelOrigin     5   	     � Title$  ReservationListWindow��5   	   $	��300��6'   $	��800��64   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridReservations��5
      $��
10,35,10,0q�61   $	��Top=�6E   $	��224��6]      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Customer.FirstName+6`     5      $ 	Last Name��6%    .  68   �� *Customer.LastName+6^     5      $
 Room��6%    .  63   �� *Room.RoomNumber+6W     5      $ Check In��6%    .  67   �� *CheckInDate+6W     5      $ 	Check Out��6%    .  68   �� *CheckOutDate+6Y   5      �� 5   
   -   5         ��Name$ buttonAddReservation��5      $��Add Reservation��6/   $
��Left=�6I   $��	10,10,0,0q�6d   $	��Top=�6w   $	��380��6�   6�   �� 5   
   -   5        $ buttonDeleteReservation��5      $��Delete Reservation��62   $
��Left=�6O   $��
402,10,0,0q�6j   $	��Top=�6~   $	��380��6�   6�   5      5      