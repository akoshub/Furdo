   M S B A M L   `   `   `  ����D  @StrandWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:StrandWPF	StrandWPF  5   	       StrandWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:StrandWPF     5   	     � Title$  Fürdők��5   	   $	��450��6   $	��900��6%   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��2* �6   .+�5   
   �� $��Fürdő adatai��6   $��Center=�6'   $��0,10,0,0q�6D   $	��Top=�6V   $��20(�6n   �� 5   
   $
��Név��6   $
��Left=�6   $��	0,58,0,10q�69   $	��Top=�6L   �� 5   
   -   5         ��Name$ Tbx_Nev��5      $��Stretch=�6#   $��	0,89,0,10q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   �� 5   
   $
��Cím��6   $
��Left=�6   $��
0,128,0,10q�69   $	��Top=�6M   �� 5   
   -   5        $ Tbx_Cim��5      $��Stretch=�6#   $��
0,159,0,10q�6A   $
 Wrap=�6U   $	��Top=�6i   �� 5   
   $	��Ár��6   $
��Left=�6   $��Center=�68   �� 5   
   -   5        $ Tbx_Ar��5      $��Stretch=�6"   $��
0,235,0,10q�6@   $
 Wrap=�6T   $	��Top=�6h   �� 5   
   $��
Vízhőfok��6   $
��Left=�6#   $��
0,271,0,10q�6>   $	��Top=�6R   �� 5   
   -   5        $ Tbx_Vizhofok��5      $��Stretch=�6(   $��
0,302,0,10q�6F   $
 Wrap=�6Z   $	��Top=�6n   � 5   
   -   5         �Name$ 	Pb_toltes��5      $��Stretch=�6)   $��23��6G   $��	0,336,0,0q�6S   $	��Top=�6f   �� 5   
   -   5         ��Name$ 
Btn_Mentes��5      $��Mentés��6%   $��Stretch=�66   $��	0,376,0,0q�6T   $	��Top=�6g   6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	Dg_adatok��5      $��1��6&   66   5      5      