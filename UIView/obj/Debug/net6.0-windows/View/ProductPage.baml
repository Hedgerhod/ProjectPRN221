   M S B A M L   `   `   `  ����A  =UIView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UIView.ConverterUIView.Converter  5   	   )clr-namespace:UIView.ViewUIView.View  5   	       UIView.View.ProductPage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4	converterclr-namespace:UIView.Converter     5   	   +localclr-namespace:UIView.View     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowState$ 	Maximized=�5
   	    � 
ResizeMode$ NoResize=�5   	    � Title$ ProductPage��5   	   $	��600��6    � 	Resources 5      /   )UIView.Converter.BooleanToStringConverter   BooleanToStringConverter0   *UIView.Converter.RoleToVisibilityConverter  RoleToVisibilityConverter��%:   &	        &	        5   
   6-     5   
   6.   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Danh sách sản phẩm��6   $��20(�6.   $
��Bold"�6<   $��10q�6N   $��0��6Z   �� 5   
    �� Orientation$ Vertical=�6   $��10q�6,   $��1��68   .+�5      �� $ 
Horizontal=�6   .+�5      �� $ Vertical=�6   $��10q�64   $	��500��6@   .+�5      �� $ 
Horizontal=�6!   .+�5      �� $)��#Tìm kiếm theo tên sản phẩm:��6    $��0,0,5,5q�6F   �� 5      -   5         ��Name$ ProductNameFilter��5   "   $	��200��6=   $��0,0,0,5q�6I   ��5      �� *ProductNameFilter+ �� UpdateSourceTrigger$ PropertyChanged=�5       �� 5!      $ 
Horizontal=�6!   .+�5"      �� $��Giá tối đa:��6    $��0,0,5,5q�66   �� 5#      -   5        	 ��Name$	 PriceFilter��5#   !   
 � Minimum$
 0Q�66    � Maximum$
 1000Q�6B   $	��200��6Q   $��0,5,0,5q�6]    �� TickFrequency$	 100Q�5%       �� IsSnapToTickEnabled$
 True��5&       � Value 5$      �� *MaxPriceFilter+$ PropertyChanged=�5&      �� 5'      $��10,0,0,0q�6T   $��Center=�6f   ��6$   �� *MaxPriceFilter+ �� StringFormat$ C��6f   5(      5)      �� 5*      $ Vertical=�6   $��10q�64   .+�5+      �� $��Chọn nhà cung cấp:��6   $��0,0,5,5q�69   �� 5,      -   5         ��Name$ SupplierFilter��5,      $	��150��67   $��0,0,0,5q�6C    �� DisplayMemberPath$ SupplierName��5.       �� SelectedValuePath$ 
SupplierId��5/      ��5-      �� *	Suppliers+ �� SelectedValue 50      �� *SelectedSupplierId+ �� Mode$ TwoWay=�51      �� 52      $ Vertical=�6   $��10q�64   .+�53      �� $��Chọn chi nhánh:��6   $��0,0,5,5q�66   �� 54      -   5        $ BranchFilter��54      $	��150��65   $��0,0,0,5q�6A   $ 
BranchName��56      $ BranchId��57      ��55      �� *
Branches+ 58      �� *SelectedBranchId+$ TwoWay=�59      �� 5:      $ Vertical=�6   $��10q�64   .+�5;      �� $!��Chọn loại sản phẩm:��6   $��0,0,5,5q�6:   �� 5<      -   5        $ CategoryFilter��5<      $	��150��67   $��0,0,0,5q�6C   $ CategoryName��5>      $ 
CategoryId��5?      ��5=      �� *
Categories+ 5@      �� *SelectedCategoryId+$ TwoWay=�5A      �� 5B      $ 
Horizontal=�6   $��10q�66   $��Bottom=�6B   .+�5C      �� $��Refresh��6   $	��100��6/   $��30��6;   $	��5,0q�6G   ��6T   �� *RefreshCommand+�� 5D      $��Create��6   $	��100��6.   $��30��6:   $��	100,0,0,0q�6F   ��6Y   �� *CreateCommand+�� 5E      $
��Home��6   $	��100��6,   $��30��68   $	��5,0q�6D   ��6Q   �� *HomeCommand+5F      5G      5H      &   System.Windows.Controls.DataGrid  5J   
      AutoGenerateColumns$ False��5K         CanUserAddRows$ False��6/      CanUserDeleteRows$ False��5L      $��10q�5M      $��Arial)�6   $��14(�62   $��2��6@   $��Stretch=�5N      $��Stretch=�61   ��5J      �� *
Products+   Columns 5O      4  .System.Windows.Controls.DataGridTemplateColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ Hình ảnh��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6;      HeaderStyle 5Q      �� 5R       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5S      ��  �� Property � �� �� Value$ Center=�6K   5T         CellTemplate 5V      �� 5W      .R�5X      �� $��UniformToFill=�6@   ��6$   �� *
ImageUrl+6@   5Y      5[        5]      $ ID��6)       MinWidth$	  100Q�65   $
 Auto 6D    5^      �� 5_      "  6    .�5`      ��  � ��$ Center=�6K   5a       5c      �� 5d      .R�5e      �� $��Center=�6C   $��Center=�6`   ��6(   �� *	ProductId+6`   5f      5h        5j      $ Tên sản phẩm��6)   $	  150Q�6?   $
 Auto 6N    5k      �� 5l      "  6    .�5m      ��  � ��$ Center=�6K   5n       5p      �� 5q      .R�5r      �� $��Center=�6E   $��Center=�6b   ��6(   �� *ProductName+6b   5s      5u        5w      $
 Giá��6)   $	  100Q�66   $
 Auto 6E    5x      �� 5y      "  6    .�5z      ��  � ��$ Center=�6K   5{       5}      �� 5~      .R�5      �� $��Center=�6O   $��Center=�6l   ��6(   �� *Price+$ C��6l   5�      5�        5�      $ Số lượng��6)   $	  100Q�6;   $
 Auto 6J    5�      �� 5�      "  6    .�5�      ��  � ��$ Center=�6K   5�       5�      �� 5�      .R�5�      �� $��Center=�6B   $��Center=�6_   ��6(   �� *
Quantity+6_   5�      5�        5�      $ Số lượng tồn kho��6)   $	  100Q�6C   $
 Auto 6R    5�      �� 5�      "  6    .�5�      ��  � ��$ Center=�6K   5�       5�      �� 5�      .R�5�      �� $��Center=�6G   $��Center=�6d   ��6(   �� *StockQuantity+6d   5�      5�        5�      $ Kích hoạt��6)   $	  100Q�6<   $
 Auto 6K    5�      �� 5�      "  6    .�5�      ��  � ��$ Center=�6K   5�       5�      �� 5�      .R�5�      �� $��Center=�5�       $��Center=�5�       ��5�   (   �� *
IsActive+! �� 	Converter#! [  5�       5�      5�        5�      $ Mô tả��6)   $	  200Q�68   $ * 6G    5�      �� 5�      "  6    .�5�      ��  � ��$ Center=�6K   5�       5�      �� 5�      .R�5�      �� $
��Wrap=�6E   $��Center=�6Y   ��6(   �� *Description+6Y   5�      5�        5�      $  ��6)   $	 120 63   "   
Visibility" 5�   )   �� *	Visible+ 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5�   "   �� $��Cập nhật��6)   $	��100��6<   $��30��6H   ��6T   �� *DataContext.UpdateCommand+# �� RelativeSource# �� $ �� AncestorType$ UserControl��6�   �� 5�      5�      5�        5�      $  ��6)   $	 120 63   " 5�   )   �� *	Visible+ 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5�   "   �� $
��Xóa��6)   $	��100��68   $��30��6D   ��6P   �� *DataContext.DeleteCommand+# �� $ UserControl��6�   �� 5�      5�      5�      5�      5�      5�      