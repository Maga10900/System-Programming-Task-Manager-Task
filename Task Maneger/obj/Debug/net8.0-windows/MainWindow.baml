   M S B A M L   `   `   `  ����G  CTask Maneger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Task_ManegerTask_Maneger  5   	       Task_Maneger.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Task_Maneger     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ���#191919 � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��7* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ ProcessDetailsDataGrid��5         AutoGenerateColumns$ False��63      
IsReadOnly$
 True��6O      HeadersVisibility$ Column=�6a      GridLinesVisibility$ 
Horizontal=�5         ColumnHeaderHeight$ 30Q�64      	RowHeight$ 25Q�6L   ���#191919
�������$��1��5   ;   	   AlternatingRowBackground	 �#2d2d2d��5   6   �� *
Programs+
   ColumnHeaderStyle
 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  �� Property � �� �� Value �#19191963   �� 5       � ��
 �����63   �� 5       � ��$
 Bold"�63   �� 5       � �� �#2d2d2d64   5         RowStyle 5      �� 5      )  #System.Windows.Controls.DataGridRow"  6   .�5      ��  � �� �#19191963   �� 5        � ��
 �����63   �� 5!       � �� �#2d2d2d64   �� 5"       � ��$ 0,0,0,1q�68   �� 5#       � ��$ Center=�6:   �� 5$       � ��$ Stretch=�6<   �� 5%       � ��$ 14(�61   �� 5&       � ��$ 5q�60   �� 5'       � ��$ 0,0,0,2q�6/    �� Triggers 5(      P� 5)       P� Property �@J�IsMouseOver P� Value$
 True��69   . �5*      ��  � �� �#3333336;   5+      P� 5,       �@ 
IsSelected$
 True��68   . �5-      ��  � �� �#2d2d2d6;   5.      50         Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *ProcessName+6S     56      $	 PID��6%   $ 80 6I    62   �� *Id+6I     57      $ Status��6%   $	 100 6T    65   �� *
Responding+6T     58      $	 CPU��6%   $ 80 6Y    62   �� *TotalProcessorTime+6Y     59      $ Memory (Working Set)��6%   $	 150 6u    6C   �� *WorkingSet64+ �� StringFormat$ N0��6u     5:      $ Virtual Memory��6%   $	 150 6v    6=   �� *VirtualMemorySize64+$ N0��6v   5=      �� 5?   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5@      �� -   5        $	��100��5@      $��0 0 20 0q�6!   $��
Black List��63   6H   �� 5A      -   5        $	��100��5A      $��0 0 20 0q�6!   $��Add To Black List��63   
 � Tag 6f   �� *BlackList.Count+�� 5B      -   5        $	��100��5B      $��0 0 20 0q�6!   $��Run New Task��63   6J   �� 5C      -   5        $	��100��5C      $��0 0 20 0q�6!   $��End Task��63   6F   5D      5E      5F      