   M S B A M L   `   `   `  ����C  ?BookShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BookShopBookShop  5   	       BookShop.UserAbout   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BookShop     5   	   ���#A6A2A1  � Title$  	UserAbout��5   	   $	��450��6   $	��900��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   o� $��5q�6   $��4��6   $��60��60   $��30(�6<   ���#725A7A���#C6CBD1$��0,0,0,45q�5      .@�5      m� -   5        $��Отзывы��5      6'   m� 5      -   5        $��30,0,0,0q�5      $��Роли��6)   67   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ UserDgr��5      $��1��6$   $��3��61   ���#A6A2A1���#A6A2A1$��2��6q   $��	0,0,20,20q�6�   6�   �� 5   
   -   5         ��Name$
 back��5      $��3��6   $	��←��6,   $��30(�68   ���#725A7A���#C6CBD1$��50��5      $��50��6   $��	0,0,120,0q�6(   6;   �� 5!   
   -   5         ��Name$ LoginTbx��5!   [   $��3��6   $��0,30,0,0q�6"   $	��150��64   $��40��6@    �� 	MaxLength$ 20��6L   6m   �� 5"   
   -   5        $ PassTxt��5"   m   $��3��6   $��2��6#   $��0,10,0,0q�64   $ 20��6F   $	��150��6U   $��40��6a   6~   �� 5#   
   -   5        $ FirstTxt��5#   j   $��3��6   $��0,0,0,10q�6"   $��1��66   $ 20��6C   $	��150��6R   $��40��6^   6|   �� 5$   
   -   5        $ LastTxt��5$   h   $��3��6   $��0,70,0,0q�6"   $��1��64   $ 20��6A   $	��150��6P   $��40��6\   6y   �� 5%   
   -	   5        $ AdrTxt��5%   z   $��3��6   $��0,50,0,0q�6"   $��2��65   $ 30��6F   $��1��6U   $	��150��6b   $��40��6n   6�   �� 5&   
   -
   5        $ 	PhonUsTxt��5&   i   $��3��6   $��0,15,0,0q�6"   $��2��65   $ 12��6B   $	��150��6Q   $��40��6]   6|   �� 5'   
   -   5         ��Name$ roleTxt��5'   m   $��3��6   $��0,0,0,10q�6#   $��2��65   $��2��6H   $	��150��6U   $��40��6a   6~   �� 5*   
   -   5        $
 Dele��5*   �   $	��☓��6   ���#C6CBD1���#725A7A$��80,0,0,0q�6G   $��3��6Y   $��3��6f   $��30��6v   $��30��6�   6�   �� 5+   
   -   5        $	 Add��5+   �   $	��✛��6   ���#C6CBD1���#725A7A$��0,0,0,0q�6G   $��3��6X   $��3��6e   $��30��6u   $��30��6�   6�   �� 5,   
   -   5        $ Update��5,   �   $	��♺��6   ���#C6CBD1���#725A7A$��0,0,80,0q�6H   $��3��6Z   $��3��6g   $��30��6w   $��30��6�   6�   5/      50      