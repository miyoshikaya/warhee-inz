   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     N� Title$  
MainWindow��5   	   $	��600��6   $
��1000��6)   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF5656A0��6    � Offset$ 0Q�61   � 5      $ 	#FF424253��6   $ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $ ��Wybierz płeć przeciwnika��6   $
��Left=�63   $��	4,270,0,0q�6N   $	��Top=�6a    J� RenderTransformOrigin$ 0.078,0.513&�6y   $��1��6�   $��16(�6�   �� 5   
   -   5         ��Name$ SexSelector��5      $
��Left=�6(   $��224,270,0,0q�6C   $	��Top=�6X   $	��193��6p   $��1��6�   $��16(�6�   .@�5      �� $��Kobieta��6   �� 5      $��Mężczyzna��6   5      �� 5   
   $��Wybierz tryb gry��6   $
��Left=�6+   $��
46,330,0,0q�6F   $	��Top=�6Z   $ -9.566,0.115&�6r   $��1��6�   $��16(�6�   �� 5   
   -   5        $ GameTypeSelector��5      $
��Left=�6-   $��224,332,0,0q�6H   $	��Top=�6]   $	��193��6u   $��1��6�   $��16(�6�   .@�5      �� $��Wariant wygranej��6   �� 5      $��Wariant przegranej��6   �� 5      $��Wariant remisu��6   �� 5      $��Wariant nieuczciwy��6   5       �� 5!   
   -   5         ��Name$ LoginButton��5!      $��przejdź do logowania��6&   $��77,430,106,0q�6E   $	��Top=�6[   $��38��6s   $��1��6�   $��20(�6�   �� 5"   
   $��HOT COMBAT GAME ��6   $
��1000��6+   $	��146��68   $��48(�6E   $
��Bold"�6S   $��Showcard Gothic)�6e   ���	#FFDADADA���	#FF363636$��0q�6�   ���	#FFDADADA$��3��6�   $��Center=�6�   $	��Top=�6  $��Center=�6,  �� 5#   
   $
��Left=�6   $��74��6+   $��179.5,30,0,0q�67   $	��Top=�6M   $��76��6e   $��2��6p   $-��'D:\uni\barcio\WpfApp1\icons\gamepad.png��6�   �� 5$   
   -   5        	 ��Name$	 scissors��5$      $
��Left=�6"   $��76��6=   $��
24,498,0,0q�6I   $	��Top=�6]   $��74��6u   $��scissors1.png��6�   $ 0.255,4.465&�6�   5&      5'      