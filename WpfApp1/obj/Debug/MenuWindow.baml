   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MenuWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     N� Title$  
MenuWindow��5   	   $	��600��6   $
��1000��6)   .��5	      � ���	#FFDADADA � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��36* �6   �� 5      $
��Auto �6   $	��309��6*   �� 5      $	��61* �6   .+�5   
   �� -   5         ��Name$ NewGamebutton��5      $�� ��6(   $��110,110,446,0q�63   $	��120��6f   $	��Top=�6s   $��1��6�   $��1��6�   $	��120��6�   ��5      �� 5       �� ImageSource$+ %D:\uni\barcio\WpfApp1\icons\start.png��6   5      �� 5   
   -   5        $ ReturnButton��5      $�� ��6'   $��278,110,278,0q�62    J� RenderTransformOrigin$ -0.925,1.662&�6I   $	��120��6�   $	��Top=�6�   $��1��6�   $��1��6�   $	��120��6�   �� 5   
   -   5        $ DataBaseButton��5      $�� ��6)   $��0,110,110,0q�64   $��Right=�6I   $	��120��6e   $	��120��6�   $	��Top=�6�   $��1��6�   $��1��6�   �� 5   
   $��HOT COMBAT GAME��6   $��10,0,10,225q�6*   $��36(�6?   $
��Bold"�6M   $��59��6_   $��Bottom=�6k   $��1��6�   $��1��6�   ���	#FF363636$��Center=�6�   �� 5   
   $
��Left=�6   $��86��6+   $	��Top=�67   $��86��6O   $��128,126,0,0q�6Z   $��1��6o   $+��%D:\uni\barcio\WpfApp1\icons\start.png��6|   $ 	2.6,0.875&�6�   $��1��6�   {�.  6�   �� 5   
   $��Nowa gra��6   $
��Left=�6#   $��110,235,0,0q�6>   $	��Top=�6S   $ 0.078,0.513&�6k   $��1��6�   $��16(�6�   $��1��6�   $	��120��6�   ���	#FF666666$��Center=�6�   �� 5   
   $��Wczytaj grę��6   $
��Left=�6&   $��278,235,0,0q�6A   $	��Top=�6V   $ 0.078,0.513&�6n   $��1��6�   $��16(�6�   $��1��6�   $	��120��6�   ���	#FF666666$��Center=�6�   �� 5   
   $��Baza danych��6   $
��Left=�6&   $��446,235,0,0q�6A   $	��Top=�6V   $ 0.078,0.513&�6n   $��1��6�   $��16(�6�   $��1��6�   $	��120��6�   ���	#FF666666$��Center=�6�   �� 5    
   $
��Left=�6   $��86��6+   $	��Top=�67   $��86��6O   $��464,126,0,0q�6Z   $��1��6o   $.��(D:\uni\barcio\WpfApp1\icons\database.png��6|   $ 	2.6,0.875&�6�   $��1��6�   �� 5!   
   $
��Left=�6   $��86��6+   $	��Top=�67   $��86��6O   $��296,126,0,0q�6Z   $��1��6o   $,��&D:\uni\barcio\WpfApp1\icons\folder.png��6|   $ 	2.6,0.875&�6�   $��1��6�   5#      5$      