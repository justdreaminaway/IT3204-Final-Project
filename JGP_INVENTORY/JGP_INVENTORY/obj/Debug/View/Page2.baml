   M S B A M L   `   `   `  ����H  DJGP_INVENTORY, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:JGP_INVENTORY.ViewJGP_INVENTORY.View  5          JGP_INVENTORY.View.Page2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:JGP_INVENTORY.View     5        N� Title$  Page2��5	      $	��760��6   .��5      � $��	10,10,0,0q�6    � RowDefinitions 5   
   �� 5      $
��119* �6   �� 5      $	��61* �6   �� 5      $	��28* �6   .+�5   
   �� $��PRODUCTS��6   $
��Left=�6#   $��62��6>   $��	34,10,0,0q�6J   $	��Top=�6]   $	��193��6u   $��24(�6�   ���	#FFD08805��6�   Z� 6�   � 5   
   $
��Left=�6   $	��310��6*   $	��Top=�67   $	��684��6O   $��0,0,0,-20.4q�6[   $��3��6p   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��dataGridCustomers��5         AutoGenerateColumns .  $
��Left=�5   3   $��
48,73,0,26q�6N   $	��608��5         CanUserResizeRows .  ���	#FFF6F6E2   AlternatingRowBackground �	#FFF6F6E2   RowBackground �	#FFE5CF0B��6&   ��  �� Path$ LoadDataBinding�   HorizontalGridLinesBrush 5   2   Z�    VerticalGridLinesBrush 6V   Z� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Product Id��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6^      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� $ prod_id�   
Foreground 5      �� 5       �� EndPoint$ 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��5   "   �  � Color$ Black��6/    � Offset$ 0Q�6=   � 5   "   $ Black��6/   $ 1Q�6=   5      5         5!      $
 Product Name��6L   $	 200 6b    .  6)   �� $ 	prod_name�5"        5#      $
 Product Quantity��6K   $	 150 6e    .  6)   �� $ prod_qty�5$        5%      $
 Product Price��6M   $	 150 6d    .  6)   �� $ 
prod_price�6p   5'      �� 5)      -   5        $��btnloaddata��5*      $��	Load Data��5)      $��23��6)   $
��Left=�65   $��
399,25,0,0q�6P   $	��Top=�5*      $��68��6,   67   �� 5+      -   5         ��Name$ 	searchBox��5+      $
��Left=�6)   $��23��6D   $��
186,25,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��116��6�   �� 5,      -   5         ��Name$ 	searchBtn��5,      $��Search��6(   $
��Left=�69   $��
307,25,0,0q�6T   $	��Top=�6h   $��75��6�   $��23��6�   6�   �� 5-      -   5        $ addBtn��5-      $	��Add��6%   $
��Left=�63   $��	10,25,0,0q�6N   $	��Top=�6a   $��75��6y   6�   5.      �� 5/   
   -   5        $ 	deleteBtn��5/      $��Delete��6$   $
��Left=�65   $	��Top=�6P   $��81��6h   $��	92,25,0,0q�6s   $��20��6�   6�   51      52      