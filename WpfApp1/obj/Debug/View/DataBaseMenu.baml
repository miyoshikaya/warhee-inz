   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5          WpfApp1.View.DataBaseMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp1.View     5        N� Title$  DataBaseMenu��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ MainGrid��5   X   ���	#FF2C2C2C$
��Left=�6j   $	��238��6�   $��211,104,0,0q�6�   $	��Top=�6�   $	��355��6�      
IsReadOnly .    SelectionMode$ Single=�6�   ���	#FF4C759C���	#FF2B2626   RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5      ��  �� Property � �� �� Value �	#FF2C2C2C63   5         ColumnHeaderStyle 5      �� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  � �� �	#FF2C2C2C63   5      5      �� 5   
   -   5        	 ��Name$	 ShowPlayersButton��5      $��Pokaż Graczy��6,   $
��Left=�6C   $��
174,35,0,0q�6^   $	��Top=�6r   $	��125��6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   $��44��6�   5      �� 5   
   -   5        $	 ShowResearchersButton��5      $��Pokaż Badaczy��60   $
��Left=�6H   $��
328,35,0,0q�6c   $	��Top=�6w   $	��123��6�   $��44��6�   �� 5   
   -   5        $	 ShowResearchButton��5      $��Pokaż Badania��6-   $
��Left=�6E   $��
478,35,0,0q�6`   $	��Top=�6t   $	��130��6�   $��44��6�   �� 5   
   -   5        $��Pokaż szczegóły��5      $
��Left=�6+   $��631,104,0,0q�6F   $	��Top=�6[   $	��118��6s   $��62��6   6�   �� 5   
   $%��Pokaż wszystkie 
gry 
gracza��6   $
��Left=�6J   $��631,195,0,0q�6e   $	��Top=�6z   $	��118��6�   $��69��6�   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6�   $y�Hidden=�6�   �� 5   
   -   5        $	 BackToMenuButton��5      $��Powrót��6+   $
��Left=�6<   $��	23,25,0,0q�6W   $	��Top=�6j   $��75��6�   6�   �� 5    
   -   5        $	 ImportButton��5       $��Importuj do excela��6'   $
��Left=�6D   $��
631,35,0,0q�6_   $	��Top=�6s   $	��118��6�   $��44��6�   6�   �� 5!   
   -   5        $	 
EditButton��5!      $��Edytuj��6%   $
��Left=�66   $��631,183,0,0q�6Q   $	��Top=�6f   $	��118��6~   $��62��6�   6�   5#      5$      