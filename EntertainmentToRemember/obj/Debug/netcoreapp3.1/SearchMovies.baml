   M S B A M L   `   `   `  ����R  NEntertainmentToRemember, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:EntertainmentToRememberEntertainmentToRemember  5      *    $EntertainmentToRemember.SearchMovies   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:EntertainmentToRemember     5        N� Title$  SearchMovies��5	      .��5      �  � 	Resources 5   
    �� 
TargetType �� Property �� Value��%  '��       '�� �    �� 5      " ��6   .�5      ��  � ��
 �����6/   �� 5       � ��$ 30��6+   �� 5       � ��$ 15(�6-   �� 5       � ��$ 15q�6+   �� 5       � ��$ 	ExtraBold"�6/   �� 5       � ��$	 100��6*   68   �� 5       � ��$ Oblique$�6.   6@   �� 5       � ��$ Bradley Hand ITC)�6/   6J   �� 5       � ��
 �����6?   5      �� 5      " ��6   .�5      ��  � ��
 �����6/   �� 5       � ��$ 30��6+   �� 5       � ��$ 15(�6-   �� 5       � ��$
 Bold"�6/   �� 5       � ��$	 150��6*   68   �� 5       � ��$ Oblique$�6.   6@   �� 5        � ��$ Bradley Hand ITC)�6/   6J   �� 5!       � ��
 ��  �6B   5"      5#      ��5$   
   �� 5%       j� Stretch$
 Fill=�6    �� ImageSource$! /Images/backgroundHome4.jpg��6(    j� 
AlignmentY$	 Top=�5&       j� 
AlignmentX$ Center=�6"   	 � RowDefinitions	 5)   
   �� 5*      $	��120 �6   6+   �� 5+      $	��120 �6   6+   �� 5,      $	��100 �6   6+   �� 5-      $	��150 �6   6+   
 � ColumnDefinitions
 5/   
   �� 50      $
��Auto �6   6.   �� 51      $
��Auto �6   6.   �� 52      $
��Auto �6   6.   .+�56   
   �� -   5         ��Name$ lblCast��56      $��0��6!   $��0��6.   $��	Star Cast��6>   $��Center=�6R   �� 57   
   -   5         ��Name$ txtCast��57      $��0��6#   $��1��60   $��Center=�6@   $��45q�6]   �� 5:   
   -   5        $ lblGenre��5:      $��1��6"   $��0��6/   $��Genre��6?   $��Center=�6O   �� 5<   
   -   5        $��drpdownGenre��5<      $��1��6'   $��1��67   $��15(�6D   $��Center=�6R   $��25��6o   $	��160��6{   
�������$��Bradley Hand ITC)�6�   $��Oblique$�6�   $��	ExtraBold"�6�    � Cursor$ Arrow��6�   .@�5=      ��  �� 
IsSelected$
 True��6   $��Choose your option��6-   6L   �� 5>      $��Action��6   6.   �� 5?      $��Comedy��6   6.   �� 5@      $��Drama��6   6-   �� 5A      $��Romance��6   6/   �� 5B      $��Thriller��6   60   5C      �� 5E   
   -   5         ��Name$ 	btnSubmit��5E      $��Search Movie��6$   $��2��6;   $��Oblique$�5F      $��Center=�6%   $��	ExtraBold"�6B   $	��180��5G      $��30��6   $��15(�6)   $��Bradley Hand ITC)�67   $��2��5H      $	��Top=�6%   $ Arrow��6U   �� 5I   
   -   5        $ btnHome��5I      $��3��6"   $��2��6/   $
��Home��6C   $��Center=�5J      $��Oblique$�6.   $��	ExtraBold"�6C   $	��180��5K      $��30��6   $��15(�6)   $��Bradley Hand ITC)�67   $	��Top=�5L      6+   �� 5M   
   -   5        $ txtSearchResult��5M      $��4��6+   $��2��6<   $��Center=�6L   $��25q�6i   $	��180��6u   $��     Search Result��6�   
���   �$	��400��6�   6�   5N      5O      