   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.PlayerEditWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          �Name$  NewLoginBox��5   	    � Title$ PlayerEditWindow��5   	   $��267.308��6"   $��331.601��63   $y�Visible=�6C   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF5656A0��6    � Offset$ 0Q�6-   � 5      $ 	#FF424253��6   $ 1Q�6-   5      .��5      � $��0,0,626,262q�6   .+�5   
   �� -   5         ��Name$ 	NameLabel��5      $��Podaj nowy login:��6#   $
��Left=�6?   $��23��6Z   $��70,58,-176,-81q�6f   
�������$	��Top=�6�   $	��106��6�   $��10(�6�   �� 5   
   -   5         ��Name$ NewLoginTextBox��5      $
��Left=�6+   $��23��6F   $��158,58,-259,-88q�6R    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��101��6�   ���	#FFCDCDCD6�   �� 5   
   -   5        $ RepeatNewLoginBox��5      $
��Left=�6-   $��24��6H   $��158,108,-259,-138q�6T   $
 Wrap=�6o   $	��Top=�6�   $	��101��6�   ���	#FFCDCDCD6�   �� 5   
   $��Powtórz nowy login:��6   $
��Left=�6.   $��24��6I   $��58,108,-158,-132q�6U   $	��Top=�6o   
�������$	��100��6�   	 � Cursor$
	 None��6�   $��10(�6�   �� 5   
   -   5        
 ��Name$
 	AcceptBox��5      $��Akceptuj��6$   $
��Left=�67   $��32��6R   $��42,171,-145,-203q�6^   $	��Top=�6x   $	��103��6�   6�   �� 5   
   -   5        $
 CancelButton��5      $��Anuluj��6'   $
��Left=�68   $��32��6S   $��182,171,-285,-203q�6_   $	��Top=�6z   $	��103��6�   6�   5      5      