   M S B A M L   `   `   `  ����L  HSortingColorsGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SortingColorsGameSortingColorsGame  5   	   #    SortingColorsGame.SortingGame   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SortingColorsGame     5   	     � Title$  SortingGame��5   	   $	��708��6   $
��1260��6*   .��5
      �� -   5        $��canvas��5
      
�������.+�5   
   � 
������� �� Left$	 388��6+   
 �� Top$ 6��6=   $	��255��6L   $	��487��6Y   .+�5      �� -   5         ��Name$ elapsedtimeitem��5      $	��100��6/   $	��Top=�6<   $��
48,56,46,0q�6T   �� 5      -   5         ��Name$ clocktxtblock��5      $��Center=�6/   $��50(�6L   $��82,72,73,118q�6Z    J� RenderTransformOrigin$ 0.5,0.5&�6p   6�   �� 5      -   5         ��Name$ startbtn��5      $��
48,161,0,0q�6'   
������$��Start��6S   $��30(�6c   $��56��6�   $	��Top=�6�   $ 0.222,0.607&�6�   $
��Left=�6�   $	��129��6�   6�   �� 5      -   5        $ stoptbtn��5      $��177,161,0,0q�6'   
�������$
��Stop��6T   $��30(�6c   $��56��6�   $	��Top=�6�   $ 0.222,0.607&�6�   $
��Left=�6�   $	��134��6�   6�   �� 5      -   5        $ resetbtn��5      $��311,161,0,0q�6'   
����·�$��Reset��6Q   $��30(�6a   $��56��6�   $	��Top=�6�   $ 0.222,0.607&�6�   $
��Left=�6�   $	��129��6�   6�   �� 5      -   5        $ 	finishbtn��5      $��	177,0,0,0q�6(   ���	#FFFFFB72$��Finish��6R   $��30(�6c   $��56��6�   $	��Top=�6�   $ 0.222,0.607&�6�   $
��Left=�6�   $	��134��6�   5      �� 5   
   -   5        $ yellow_button��5      ���	#FFFFFB72$	��302��6?   $	��Top=�6L   $	��373��6d   $	 880��6p   $	 377��6�   �� 5   
   -	   5        $ green_button��5      ���	#FF9DFF72$	��318��6>   $	��Top=�6K   $	��373��6c   $ 2.729,0.547&�6o   $	 880��6�   �� 5   
   -
   5        $ blue_button��5      ���	#FF72A5FF$	��302��6=   $	��Top=�6J   $	��383��6b   $	 377��6n   �� 5   
   -   5        $ 
red_button��5      ���	#FFFF7272$	��318��6<   $	��Top=�6I   $	��383��6a   �� 5   
   -   5         ��Name$ 
red_image4��5      $	 274��6$   $	 671��65   $	��100��6G    J� IsManipulationEnabled . $a��[C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-roja.jpg��5      z�5      u� 5      5      �� 5   
   -   5        $ 
red_image2��5      $	 397��6$   $	 524��65   $	��100��6G    . $a��[C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-roja.jpg��5       z�5!      u� 5"      5$      �� 5%   
   -   5        $ 
red_image3��5%      $	 329��6$   $	 743��65   $	��100��6G    . $a��[C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-roja.jpg��5&      z�5'      u� 5(      5*      �� 5+   
   -   5        $ 
red_image1��5+       . $a��[C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-roja.jpg��5,      $	��100��6l   $	 582��6x   $	 307��6�   z�5-      u� 5.      50      �� 51   
   -   5        $ blue_image1��51       . $a��[C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-azul.jpg��52      $	��114��6l   $	��132��6y   $	 416��6�   $	 515��6�   z�53      u� 54      56      �� 57   
   -   5        $ blue_image2��57       . $a��[C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-azul.jpg��58      $	��114��6l   $	��132��6y   $	 736��6�   $	 530��6�   z�59      u� 5:      5<      �� 5=   
   -   5        $ blue_image3��5=       . $a��[C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-azul.jpg��5>      $	��114��6l   $	��132��6y   $	 639��6�   $	 411��6�   z�5?      u� 5@      5B      �� 5C   
   -   5        $ blue_image4��5C       . $a��[C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-azul.jpg��5D      $	��114��6l   $	��132��6y   $	 711��6�   $	 266��6�   z�5E      u� 5F      5H      �� 5I   
   -   5        $ yellow_image1��5I       . $e��_C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-amarilla.jpg��5J      $	��136��6p   $	��125��6}   $	 475��6�   $	 241��6�   z�5K      u� 5L      5N      �� 5O   
   -   5        $ yellow_image2��5O       . $e��_C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-amarilla.jpg��5P      $	��136��6p   $	��125��6}   $	 651��6�   $	 530��6�   z�5Q      u� 5R      5T      �� 5U   
   -   5        $ yellow_image3��5U       . $e��_C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-amarilla.jpg��5V      $	��136��6p   $	��125��6}   $	 651��6�   $	 355��6�   z�5W      u� 5X      5Z      �� 5[   
   -   5        $ yellow_image4��5[       . $e��_C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-amarilla.jpg��5\      $	��136��6p   $	��125��6}   $	 553��6�   $	 510��6�   z�5]      u� 5^      5`      �� 5a   
   -   5        $ green_image1��5a       . $b��\C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-verde.jpg��5b      $	��128��6m   $	��104��6z   $	 415��6�   $	 397��6�   z�5c      u� 5d      5f      �� 5g   
   -   5        $ green_image2��5g       . $b��\C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-verde.jpg��5h      $	��128��6m   $	��104��6z   $	 496��6�   $	 538��6�   z�5i      u� 5j      5l      �� 5m   
   -   5        $ green_image3��5m       . $b��\C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-verde.jpg��5n      $	 776��6m   $	��128��6   $	��104��6�   $	 402��6�   z�5o      u� 5p      5r      �� 5s   
   -   5        $ green_image4��5s       . $b��\C:\Proyecto 4 Arquitectura de Computadores 201820\prototipe-sorting-colors\manzana-verde.jpg��5t      $	��128��6m   $	��104��6z   $	 420��6�   $	 292��6�   z�5u      u� 5v      5x      5y      5{      