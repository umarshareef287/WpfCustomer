   M S B A M L   `   `   `  ����  WpfCustomerApp    WpfCustomerApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   � -   5         �Name$ MainContentContainer��5      $��Center=�6-   $��Center=�6H    � RowDefinitions 5	      �� 5
      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ columnNameLabel��5      $��2q�6-   $��0��68   .��6E   _DB Table Column:6X   �� 5      -   5         ��Name$ searchDbColumn��5      $��0��6/   $��1��6<   $	��200��6L   $��30��6X   $��Center=�6d   $
��Left=�6   $��2q�6�   �� 5      -   5        $ searchLabel��5      $��2q�6)   $��1��64   .��6A   _Search Word:6P   �� 5      -   5         ��Name$ 
searchWord��5      $��1��6*   $��1��67   $��2q�6G   �� 5      $��2��6   $��2��6&    �� Orientation$ 
Horizontal=�6:   $��Center=�6S   .+�5      �� -   5         ��Name$ SearchButton��5      $��
_Search...��6/   $��5q�6_   5      5        � 5#   
   -   5        	  �Name$	 	MainFrame��5#      $��2��6#   $��2��60   $��10q�6D   $��Stretch=�6P   $��Stretch=�6l   
  � NavigationUIVisibility$
 Hidden=�6�   5$      5%      