   M S B A M L   `   `   `  ����O  KCoffeeShopManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:CoffeeShopManagementCoffeeShopManagement  5   	   '    !CoffeeShopManagement.CoffeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:CoffeeShopManagement     5   	     � Title$  CoffeeWindow��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5   
   �� -   5         ��Name$ coffname_label��5      $��Coffee Name:��6(   $
��Left=�6?   $��
10,121,0,0q�6Z   $	��Top=�6n   $��39��6�   $	��112��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5         ��Name$ coffname_txt��5      $
��Left=�6(   $��39��6C   $��127,121,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��165��6�   �� 5   
   -   5        $ coffprice_label��5      $��Coffee Price:��6)   $
��Left=�6A   $��
10,198,0,0q�6\   $	��Top=�6p   $	��112��6�   $��38��6�   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5        $ coffprice_txt��5      $
��Left=�6)   $��38��6D   $��127,198,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��165��6�   �� 5   
   -   5         ��Name$ btnCoffeeSave��5      $
��Save��6(   $
��Left=�67   $��
21,254,0,0q�6R   $	��Top=�6f   $��81��6~   $��39��6�   $
��Bold"�6�   $��14(�6�    J� RenderTransformOrigin$ 
0.15,0.426&�6�   �� 5   
   -   5        $ btnCoffeeDelete��5      $��Delete��6*   $
��Left=�6;   $��
21,298,0,0q�6V   $	��Top=�6j   $��81��6�   $��40��6�   $
��Bold"�6�   $��14(�6�   6�   �� 5   
   -   5        $ btnCoffeeUpdate��5      $��Update��6*   $
��Left=�6;   $��
21,343,0,0q�6V   $	��Top=�6j   $��81��6�   $��43��6�   $
��Bold"�6�   $��14(�6�   $ -2.928,2.965&�6�   �� 5   
   -   5        $ btnCoffeeBack��5      $
��Back��6(   $
��Left=�67   $��150,254,0,0q�6R   $	��Top=�6g   $��98��6   $��39��6�   $
��Bold"�6�   $��14(�6�   6�   �� 5   
   -	   5        $ coffid_label��5      $��
Coffee Id:��6&   $
��Left=�6;   $��	10,42,0,0q�6V   $	��Top=�6i   $	��112��6�   $��38��6�   $��16(�6�   $
��Bold"�6�   �� 5   
   -
   5        $ 
coffid_txt��5      $
��Left=�6&   $��38��6A   $��
127,42,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��165��6�   �� 5   
   -   5        $ 
btnCofExit��5      $
��Exit��6%   $
��Left=�64   $��150,298,0,0q�6O   $	��Top=�6d   $��98��6|   $��40��6�   $��16(�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $ btncoffshowall��5      $��ShowAll��6)   $
��Left=�6;   $��150,343,0,0q�6V   $	��Top=�6k   $��98��6�   $��43��6�   $��16(�6�   $
��Bold"�6�   $��Cambria)�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ coffDatagrid��5         AutoGenerateColumns . $
��Left=�6D   $	��344��6_   $��
334,42,0,0q�6l   $	��Top=�6�   $	��418��6�   5      5      