   M S B A M L   `   `   `  ����D  @WPF_Login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF_Login	WPF_Login  5      #    WPF_Login.NewGeneralEntryPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:WPF_Login     5        N� Title$  NewGeneralEntryPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $	��280��6   $��80��6,   $��40 �6;   �� 5      $��* �6   �� 5      $��40 �6   �� 5      $��10 �6   .+�5   
   �� -   5        $��txtTopic��5      $��Topic��6$   $��1��61   $��0��6A   $��Right=�6N   $��Center=�6j   �� 5   
   -   5        $��txtBoxTopic��5      $��2��6%   $��0��65   $��Stretch=�6B   $��Center=�6`   $��8q�6{   �� 5   
   -   5        $��
txtTopicCB��5      $��Topic��6&   $��3��63   $��0��6C   $��Right=�6P   $��Center=�6l   �� 5    
   -   5        $��cbTopic��5       $��4��6"   $��0��62   $��Stretch=�6?   $��Center=�6]   $��8q�6x    �� 
IsEditable . ��5!      �� 5"      .R�5#      �� $��cbTextBlock��6    
���   ���6F   �� *	topicName+6d   5$      5&      �� 5)   
   -   5        $��txtTitle��5)      $��Title��6$   $��1��61   $��1��6A   $��Right=�6N   $��Center=�6j   �� 5*   
   -   5        $��txtBoxTitle��5*      $��2��6%   $��1��65   $��Stretch=�6B   $��Center=�6`   $��8q�6{   �� 5,   
   -   5        $��txtTags��5,      $
��Tags��6#   $��3��6/   $��1��6?   $��Right=�6L   $��Center=�6h   �� 5-   
   -   5        $��
txtBoxTags��5-      $��4��6$   $��1��64   $��Stretch=�6A   $��Center=�6_   $��8q�6z   �� 5/   
   -	   5        $��txtDescription��5/      $��Description��6*   $��1��6=   $��2��6M   $��Right=�6Z   $��Center=�6v   �� 50   
   -
   5        $��txtBoxDescription��50      $��2��6+   $��3��6;   $��2��6O   $��Stretch=�6\   $��Center=�6z    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6�   $��8q�6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   �� 53      -   5        $��
rtxContent��53      $��1��6,   $��4��6<   $��3��6P   $��Stretch=�6]   $��Center=�6{   $
 Auto=�6�   �� 56   
   -   5        $	��btn��56      $
��Save��6   $��1��6+   $��4��6;   $��4��6O   $��35��6\   $��80��6h   6s   58      59      