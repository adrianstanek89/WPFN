   M S B A M L   `   `   `  ����F  BProgressBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ProgressBarProgressBar  5   	       ProgressBar.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ProgressBar     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �� .+�5
   
   �� $��Download File��6   .��5      � $��5q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5       � RowDefinitions 5      �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   .+�5      �� $
��URL:��6   $
��Bold"�6(   ��6:   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType$
 GridL� �� Path$ Margin��� 5      -   5         ��Name$ 
urlAddress��5      $��1��6/   ��6@   ��  �� *FindAncestor+$
 GridL�$ Margin�� 5      $��1��6   $��2��6$   ��68   ��  �� *FindAncestor+$
 GridL�$ Margin�.+�5      � -   5         �Name$ progressBarDownload��5   "   $��20��6@    � Minimum$ 0Q�6M   	 � Maximum$		 100Q�6Y   �� 5      -   5        
 ��Name$
 	labelPerc��5       $��Center=�63   $��Center=�6P   5      �� 5      -   5         ��Name$ buttonDownload��5      $��Download��61   $��2��6D   $��2q�6�   ��6Q   ��  �� *FindAncestor+$
 GridL�$ Margin�6�   5      5      5      5       