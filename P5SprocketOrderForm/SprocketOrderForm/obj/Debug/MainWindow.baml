   M S B A M L   `   `   `  ����L  HSprocketOrderForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SprocketOrderFormSprocketOrderForm  5   	   "    SprocketOrderForm.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SprocketOrderForm     5   	     � Title$'  !Sprocket Order Form - Quentin Dye��5   	   $��566.087��63   $��492.174��6D   .��5	      � -   5         �Name$ gridAll��5	      $��0,0,2,2q�6   .+�5
   
   �� $'��!Super Sprocket Order Manager 3000��6   $
��Left=�6<   $��	90,10,0,0q�6W   $	��Top=�6j   $��18(�6�   �� 5   
   $��Customer Name��6   $
��Left=�6(   $��28��6C   $��	10,64,0,0q�6O   $	��Top=�6b   $	��104��6z   �� 5   
   -   5         ��Name$ txtCustomerName��5      $
��Left=�6+   $��23��6F   $��
140,69,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��332��6�   
 J� Uid$ txtCustomerName��6�   �� 5   
   -   5         ��Name$ cboxLocalPickup��5      $��Local Pickup?��6,   $
��Left=�6D   $��28��6_   $��
140,97,0,0q�6k   $	��Top=�6   $	��104��6�   6�   �� 5   
   $��Label��6   $
��Left=�6    $��0��6;   $��102,445,0,0q�6F   $	��Top=�6[   $��12��6s   �� 5   
   -   5         ��Name$ 	lblStreet��5   �   $��Street��6   $
��Left=�6!   $��28��6<   $��
10,142,0,0q�6H   $	��Top=�6\   $	��122��6t   6�   �� 5   
   -   5        $ 	txtStreet��5      $
��Left=�6%   $��28��6@   $��140,142,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��266��6�   �� 5   
   -   5        $ lblCity��5   �   $
��City��6   $
��Left=�6   $��28��6:   $��
10,175,0,0q�6F   $	��Top=�6Z   $��35��6r    J� RenderTransformOrigin$ -0.383,0.261&�6}   6�   �� 5   
   -   5        $ txtCity��5   �   $
��Left=�6   $��28��6-   $��
10,208,0,0q�69   $
 Wrap=�6M   $	��Top=�6a   $	��265��6y   6�   �� 5   
   -   5        $ txtState��5   �   $
��Left=�6   $��28��6-   $��305,208,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $��65��6z   6�   �� 5   
   -	   5        $ lblState��5      $��State��6   $
��Left=�6    $��28��6;   $��305,180,0,0q�6G   $	��Top=�6\   $��41��6t   6   �� 5   
   -
   5        $ 
lblZipCode��5   �   $��Zip Code��6   $
��Left=�6#   $��28��6>   $��400,180,0,0q�6J   $	��Top=�6_   $��57��6w   6�   �� 5   
   -   5        $ 
txtZipCode��5   �   $
��Left=�6   $��26��6-   $��400,208,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $��82��6z   6�   �� 5   
   -   5         ��Name$ 	lboxItems��5      $
��Left=�6%   $	��158��6@   $��	0,261,0,0q�6M   $	��Top=�6`   $	��482��6x   �� 5   
   -   5        	 ��Name$	 btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
39,445,0,0q�6J   $	��Top=�6^   $��75��6v   6�   �� 5   
   -   5        $	 	btnRemove��5      $��Remove��6$   $
��Left=�65   $��20��6P   $��200,445,0,0q�6\   $	��Top=�6q   $��75��6�   6�   �� 5   
   -   5        $	 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��20��6P   $��358,445,0,0q�6\   $	��Top=�6q   $��75��6�   6�   5      5      