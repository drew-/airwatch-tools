   M S B A M L   `   `   `  ����H  DAirwatchTools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AirwatchToolsAirwatchTools  5   	       AirwatchTools.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AirwatchTools     5   	     � Title$  
MainWindow��5   	   $	��700��6   $	��700��6)   .��5	      � .+�5
   
   o� -   5         o�Name$ mainMenu��5
      $	��Top=�6!   .@�5      m� $��_File��6   .@�5      m� $��_Open��6   m� 5      $��_Save��6   m� 5      $��_Save As��6   �� 5      m� 5      -   5        $��	_Open Csv��5      6K   m� 5      $��	_Save Csv��6   m� 5      $��_Export to Excel��6   �� 5      m� 5      -   5        $��_Exit��5      6B   5      m� 5      $��_Edit��6   .@�5      m� $��_Preferences��6   63   5      m� 5      $��_Actions��6   .@�5      m� -   5        $��_Visualize Csv��5      6M   m� 5      -   5        $��_Import Names From Excel��5      6b   5      m� 5      $��_About��6   .@�5      m� -   5        $��_About��5      6D   5      5       �� 5!   
   -   5         ��Name$ btnCreateCsv��5!      $��
Create CSV��6'   $
��Left=�6<   $��
95,275,0,0q�6W   $	��Top=�6k   $��75��6�   6�   �� 5"   
   -   5        $ btnAdd��5"      $	��Add��6!   $
��Left=�6/   $��
136,54,0,0q�6J   $	��Top=�6^   $��75��6v    J� RenderTransformOrigin$ 0.373,0.627&�6�   �� 5#   
   -	   5        $ 	btnAppend��5#      $��
Append CSV��6$   $
��Left=�69   $��175,275,0,0q�6T   $	��Top=�6i   $��75��6�   $ 0.123,0.068&�6�   6�   �� 5%   
   -
   5         ��Name$ tbInput��5%      $
��Left=�6#   $	��169��6>   $��
10,100,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��672��6�   �� 5&   
   -   5        $ tbAdd��5&      $
��Left=�6!   $��23��6<   $��	11,51,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5(   
   -   5         ��Name$ label��5(      $#��Add A User By AD Account Name��6   $
��Left=�6G   $��	10,25,0,0q�6b   $	��Top=�6u   �� 5)   
   -   5        $ label1��5)      $��Edit The List��6    $
��Left=�68   $��	11,74,0,0q�6S   $	��Top=�6f   �� 5*   
   -   5        $��Scroller��5*      
���   �$	��254��6<   $��
10,300,0,0q�6I   $	��Top=�6]   $	��672��6u   .��5+      �� $��10, 0, 10, 0q�6N   ��6   �� *ConsoleOutput+ �� Mode$ OneWay=���5,      �� 5-      .R�5.      �� 
��� � �$��Consolas)�6O   $��16(�6e   ��6$   ��  �� Path$ .�6e   5/      51      52      �� 54   
   -   5        	 ��Name$	 awLogo��54      $��Resources\wolf.png��6    $
��Left=�6<   $	��100��6W   $��582,559,0,0q�6d   $	��Top=�6y   $	��100��6�   �� 55   
   -   5        $	 Airwolf��55      $��Resources\airwolf.png��6!   $��90��6@   $	��500��6L   $��64,568,128,11q�6X   �� 56   
   -   5        $ btnGenerateList��56      $��Generate List��6*   $
��Left=�6B   $��
15,275,0,0q�6]   $	��Top=�6q   $��75��6�   6�   57      58      