   M S B A M L   `   `   `  ����	  TMath$    MatrixSolverApp.MatricesWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Icon$  ../images/app_icon.png��5   	    � Title$/ )TMath - Մատրիցայի լուծում��6'   $	��500��6I   $	��500��6V   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $*��$Մուտքագրեք մատրիցը:��6!   $��5q�6<   �� 5   
   -   5        $��MatrixInputTextBox��5      $��1��6   $(��"1 2 3 4
5 7 8 5
7 3 7 5
9 8 6 4��69   $��5q�6{   $	��100��6�    �� TextWrapping$
 Wrap=�6�    �� AcceptsReturn$
 True��6�   �� 5   
   -   5         ��Name$ cofactorCheckbox��5       $��2��6   $N��HՑույց տալ պատասխանը կոտորակային թվերով��6:   $��5q�6k   �� 5   
   -   5        $��DeterminantButton��5   7   $��3��6   $!��Հաշվել որոշիչը��6   $��5q�6p   �� 5   
   -   5        $��InverseButton��5   8   $��4��6   $#��Գտնել հակադարձը��6   $��5q�6i   �� 5   
   -   5        $��TransposeButton��5   6   $��5��6   $ ��Տրանսպոնացնել��6   $��5q�6k   �� 5   
   -   5        $��ScalarMultiplyButton��5   9   $��6��6   $%��Բազմապատկել թվով��6   $��5q�6x   �� 5   
   -   5        $��PowerButton��5   ;   $��7��6   $)��#Բարձրացնել աստիճան��6   $��5q�6h   �� 5   
   $��8��6   $��Արդյունք:��6!   $��5q�62   �� 5   
   -   5        $��ResultTextBox��5      $��9��6    �� 
IsReadOnly$
 True��64   $��5q�6F   5      5       