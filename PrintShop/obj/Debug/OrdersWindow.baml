   M S B A M L   `   `   `  ����D  @PrintShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PrintShop	PrintShop  5   	       PrintShop.OrdersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PrintShop     5   	     � Title$  OrdersWindow��5   	   $	��450��6   $	��800��6+   $	��450��67   $	��800��6G   $	��450��6V   $	��800��6f   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtg_orders��5
         AutoGenerateColumns .  $��	0,0,0,234q�6C      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	ID_Orders��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   "   ��  �� Path$ 	ID_Orders�6G     5      $ ID_Customers��6%    5   "   �� $ ID_Customers�6J     5      $ ID_Services��6%    5   "   �� $ ID_Services�6I     5      $ Total_Price��6%    5   "   �� $ Total_Price�6I     5      $
 Time��6%    5   "   �� $
 Time� �� StringFormat$ {0:dd.MM.yy hh:mm:ss}��6g     5      $ Delivery_Address��6%    5   "   �� $ Delivery_Address�6N     5      $ Recipients_Name��6%    5   "   �� $ Recipients_Name�6M   5      �� 5   
   -   5         ��Name$ btn_add��5      $��Добавить��6"   $
��Left=�65   $��136,217,0,0q�6P   $	��Top=�6e   $��55��6}   $	��111��6�   6�   �� 5   
   -   5        $ 
btn_delete��5      $��Удалить��6%   $��Center=�67   $��	0,217,0,0q�6T   $	��Top=�6g   $��55��6   $	��112��6�   6�   �� 5   
   -   5        $ btn_red��5      $��Изменить��6"   $
��Left=�65   $��556,217,0,0q�6P   $	��Top=�6e   $	��111��6}   $��55��6�   6�   �� 5   
   -   5        	 ��Name$	 tb_name��5      $
��Left=�6#   $��136,317,0,0q�6>   
 �� TextWrapping$

 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5    
   -   5        $	 tb_time��5       $
��Left=�6#   $��136,382,0,0q�6>   $

 Wrap=�6S   $	��Top=�6g   $	��120��6   �� 5!   
   -   5        $	 
tb_service��5!      $
��Left=�6&   $��344,317,0,0q�6A   $

 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5"   
   -   5        $	 
tb_address��5"      $
��Left=�6&   $��344,382,0,0q�6A   $

 Wrap=�6V   $	��Top=�6j   $	��120��6�   �� 5#   
   -	   5        $	 tb_price��5#      $
��Left=�6$   $��556,317,0,0q�6?   $

 Wrap=�6T   $	��Top=�6h   $	��120��6�   �� 5$   
   -
   5        $	 tb_name_rec��5$      $
��Left=�6'   $��556,382,0,0q�6B   $

 Wrap=�6W   $	��Top=�6k   $	��120��6�   �� 5%   
   $!��ID Пользователя��6   $
��Left=�6*   $��145,286,0,0q�6E   $	��Top=�6Z   �� 5&   
   $��ID Услуги��6   $��Center=�6$   $��	0,286,0,0q�6A   $	��Top=�6T   �� 5'   
   $��Цена��6   $
��Left=�6   $��565,286,0,0q�6:   $	��Top=�6O   �� 5(   
   $/��)Время (ДД:ММ:ГГГГ ЧЧ:ММ)��6   $
��Left=�63   $��114,351,0,0q�6N   $	��Top=�6c   �� 5)   
   $��
Адрес��6   $��Center=�6    $��	0,351,0,0q�6=   $	��Top=�6P   �� 5*   
   $0��*Имя получателя(необяз.)��6   $
��Left=�62   $��542,351,0,0q�6M   $	��Top=�6b   5+      5,      