   M S B A M L   `   `   `  ���� 	  TMath    TMath.LimitWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Icon$  ../images/app_icon.png�� � Title$) #TMath - Սահմանի հաշվիչ��$	��200��$	��320��.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��1��$	��lim��$
��Left=�$��	20,10,0,0q�$	��Top=�$��16(��� -   $��functionTextBox��$��1��$$��12 * Math.Pow(x,2) - 3 * x + 8��$
��Left=�$��	74,18,0,0q� �� TextWrapping$ NoWrap=�$	��Top=�$	��222���� $��2��$
��x→��$
��Left=�$��11,0,0,0q�$��Center=�$��14(��� -   $��limitTextBox��$��2��$��2��$
��Left=�$��37,7,0,0q�$ NoWrap=�$	��Top=�$��30�� �� 	MaxLength$ 3���� -   $��3��$%��Ստանալ արդյունքը��$��Center=�$��0,10,0,0q�$	��Top=�$	��292���� -   $��resultLabel��$��4��$��Արդյունք: ��$
��Left=�$��5,5,0,0q�$	��Top=�