   M S B A M L   `   `   `  ����F  BHotelOrigin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HotelOriginHotelOrigin  5   	        HotelOrigin.AddReservation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HotelOrigin     5   	     � Title$  AddReservation��5   	   $	��300��6    $	��350��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ buttonSaveReservation��5
      $��Save Reservation��60   $
��Left=�6K   $��
10,240,0,0q�6f   $	��Top=�6z   $	��322��6�   6�   �� 5   
   -   5         ��Name$ comboBoxCustomer��5       �� DisplayMemberPath$ 	FirstName��6-   $
��Left=�6K   $��25��6f   $��	95,81,0,0q�6r   $	��Top=�6�   $	��205��6�   6�   �� 5   
   -   5        $ comboxBoxRoom��5      $ 
RoomNumber��6*   $
��Left=�6I   $��25��6d   $��
95,111,0,0q�6p   $	��Top=�6�   $	��205��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ datePickerCheckInDate��5      $
��Left=�64   $��
95,141,0,0q�6O   $	��Top=�6c   $	��195��6{   6�     5   
   -   5        $ datePickerCheckOutDate��5      $
��Left=�65   $��25��6P   $��
95,170,0,0q�6\   $	��Top=�6p   $	��195��6�   6�   �� 5   
   -   5         ��Name$ textBlockReservation��5      $��
10,10,10,0q�62   $
��Wrap=�6F   $��Add Reservation��6Z   $	��Top=�6q   $��24(�6�   $��Center=�6�   �� 5   
   -   5        $ 	textBlock��5      $
��Left=�6'   $��	39,90,0,0q�6B   $
��Wrap=�6U   $��Customer��6i   $	��Top=�6y   �� 5   
   -   5        $ 
textBlock1��5      $
��Left=�6(   $��
57,120,0,0q�6C   $
��Wrap=�6W   $
��Room��6k   $	��Top=�6w   �� 5   
   -	   5        $ 
textBlock2��5      $
��Left=�6(   $��
43,145,0,0q�6C   $
��Wrap=�6W   $��Check In��6k   $	��Top=�6{   �� 5   
   -
   5        $ 
textBlock3��5      $
��Left=�6(   $��
39,174,0,0q�6C   $
��Wrap=�6W   $��	Check Out��6k   $	��Top=�6|   5      5      