   M S B A M L   `   `   `  ����D  @WPF_Login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF_Login	WPF_Login  5   	       WPF_Login.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPF_Login     5   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1200��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� 
���   �$��1q�6%   $��1��69   $
��auto��6I   $��2��6W   $
��auto��6d   �� 5   
   
���   �$��1q�6%   $��1��69   $
��auto��6I   $��1��6W   $
��auto��6d   � 5   
   $��1��6   $��1��6$   $��Center=�61   .+�5      �� -   5         ��Name$ BtnHome��5      $��80��6&   $	��120��62   .��6T   Home6Z   �� 5      -   5        $ BtnCreateNewEntry��5      $��80��60   $	��120��6<   .��6h   	New Entry6s   �� 5      -   5        $ BtnSearchEntry��5      $��80��6-   $	��120��69   .��6b   Search Entry6p   �� 5      -   5        $ BtnExportImport��5      $��80��6.   $	��120��6:   .��6d   Export/Import6s   �� 5      -   5        $ BtnTasks��5      $��80��6'   $	��120��63   .��6V   Tasks6]   �� 5      -   5        $ BtnUserConfig��5      $��80��6,   $	��120��68   .��6`   User config6m   �� 5       -   5        $ BtnCloseApplication��5       $��80��62   $	��120��6>   .��6l   Exit6r   �� 5"      -   5         ��Name$ currentUser��5"      $��Current User: ��6-   $��Right=�6C   $��80��6�   $
��Wrap=�6�   5#       � 5%   
   -	   5          �Name$ 	MainFrame��5%      $��1��6#   $��2��63     � NavigationUIVisibility$ Hidden=�6@   5'      5(      