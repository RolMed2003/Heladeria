   M S B A M L   `   `   `  ����T  PHeladeriaLosEspaciales1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:HeladeriaLosEspaciales1._0HeladeriaLosEspaciales1._0  5   	   )    #HeladeriaLosEspaciales1._0.Empleado   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:HeladeriaLosEspaciales1._0     5   	   -   5          � Title$  Empleado��5   	   $	��412��5	   	   $	��890��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   .��5      � 
�������.+�5   
   �� -   5         ��Name$ SalirBtn��5      
���  ��$��70��5      $��30��5      $��Salir��5      
������� � Cursor$
 Hand��5      $��810,18,10,364q�5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ productsTbl��5      $��10,107,271,10q�6(      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ ID Producto��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 5!   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5"   %   �� *	IDProduct+  5$      $ Nombre��6%   $	 * 5%   %   
 5&   %   �� *Name+  5(      $ Costo��6%   $		 100 5)   %   
 5*   %   �� *Cost+  5,      $ Precio��6%   $		 100 5-   %   
 5.   %   �� *Price+  50      $ Cantidad��6%   $		 100 51   %   
 52   %   �� *Amount+56      o� 57   
   $��0,18,210,364q�6   $��30��58      .@�5:      m� $��
Inventario��6   $��18(�5;      $��30��5<      .@�5>      m� -   5         m�Name$ agregarproductoBtn��5?      $��Editar producto��5>      $��16(�5@      $��22��5A      6'   m� 5C      -   5        $ eliminarproductoBtn��5D      $��Eliminar producto��5C      $��16(�5E      $��22��5F      6'   5H      m� 5J      $��Empleado��6   $��18(�5K      $��30��5L      .@�5N      m� -   5        $ verPerfilBtn��5O      $��
Ver perfil��5N      $��16(�5P      $��22��5Q      6'   5S      5U      �� 5V   
   $��Tabla de productos��6   $
��Left=�6-   $��36��6H   $��	10,66,0,0q�6T   $	��Top=�6g   $	��169��6   $��16(�6�   $��SemiBold"�6�   �� 5W   
   -   5         ��Name$	 img��5W      $
��Left=�6   $	��189��68   $��646,153,0,0q�6E   $	��Top=�6Z   $	��216��6r   $!��/Assets/Batido de Piña.png��6~   $y�Hidden=�6�   �� 5X   
   -   5        $ img_Copy��5X      $
��Left=�6"   $	��189��6=   $��646,153,0,0q�6J   $	��Top=�6_   $	��216��6w   $"��/Assets/Batido de Sandia.jpg��6�   $y�Hidden=�6�   �� 5Y   
   -	   5        $ 	img_Copy1��5Y      $
��Left=�6#   $	��189��6>   $��646,153,0,0q�6K   $	��Top=�6`   $	��216��6x   $��/Assets/batidoFresa.png��6�   $y�Hidden=�6�   �� 5Z   
   -
   5        $ 	img_Copy2��5Z      $
��Left=�6#   $	��189��6>   $��646,153,0,0q�6K   $	��Top=�6`   $	��216��6x   $#��/Assets/Canasta de Helado.png��6�   $y�Hidden=�6�   �� 5[   
   -   5        $ 	img_Copy3��5[      $
��Left=�6#   $	��189��6>   $��646,153,0,0q�6K   $	��Top=�6`   $	��216��6x   $��/Assets/Cono Junior.png��6�   $y�Hidden=�6�   �� 5\   
   -   5        $ 	img_Copy4��5\      $
��Left=�6#   $	��189��6>   $��646,153,0,0q�6K   $	��Top=�6`   $	��216��6x   $��/Assets/Cono triple.jpg��6�   $y�Hidden=�6�   �� 5]   
   -   5        $ 	img_Copy5��5]      $
��Left=�6#   $	��189��6>   $��646,153,0,0q�6K   $	��Top=�6`   $	��216��6x   $ ��/Assets/Copa de Helado.png��6�   $y�Hidden=�6�   �� 5^   
   -   5        $ 	img_Copy6��5^      $
��Left=�6#   $	��189��6>   $��646,153,0,0q�6K   $	��Top=�6`   $	��216��6x   $$��/Assets/malteada-chocolate.png��6�   $y�Hidden=�6�   �� 5_   
   -   5        $ 	img_Copy7��5_      $
��Left=�6#   $	��189��6>   $��646,153,0,0q�6K   $	��Top=�6`   $	��216��6x   $��/Assets/Sundae.png��6�   $y�Hidden=�6�   �� 5`   
   -   5        $��Actualizar ��5`      $
��Left=�6'   $��36��6B   $��
500,66,0,0q�6N   $	��Top=�6b   $	��119��6z   6�   �� 5a   
   -   5        $ SalirBtn_Copy��5b      
��� ���$��30��5c      $��Cerrar sesión��5d      
�������$
 Hand��5g      $��796,372,10,10q�5h      5j      5k      