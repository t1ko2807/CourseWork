   M S B A M L   `   `   `  ����	  TMath    TMath.LimitWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Icon$  ../images/app_icon.png��5   	    � Title$) #TMath - Սահմանի հաշվիչ��6'   $	��200��6F   $	��320��6S   .��5      �  � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $	��lim��6   $
��Left=�6+   $��	20,10,0,0q�6F   $	��Top=�6Y   $��16(�6q   �� 5   
   -   5        $��functionTextBox��5      $��1��6   $$��12 * Math.Pow(x,2) - 3 * x + 8��66   $
��Left=�6\   $��	74,18,0,0q�6w    �� TextWrapping$ NoWrap=�6�   $	��Top=�6�   $	��222��6�   �� 5   
   $��2��6   $
��x→��6   $
��Left=�6*   $��11,0,0,0q�6E   $��Center=�6W   $��14(�6r   �� 5   
   -   5        $��limitTextBox��5      $��2��6   $��2��63   $
��Left=�6<   $��37,7,0,0q�6W   $ NoWrap=�6i   $	��Top=�6   $��30��6�    �� 	MaxLength$ 3��6�   �� 5   
   -   5        $��3��5      $%��Ստանալ արդյունքը��6   $��Center=�69   $��0,10,0,0q�6V   $	��Top=�6h   $	��292��6�   6�   �� 5   
   -   5        $��resultLabel��5   2   $��4��6   $��Արդյունք: ��6   $
��Left=�6E   $��5,5,0,0q�6`   $	��Top=�6q   5      5      