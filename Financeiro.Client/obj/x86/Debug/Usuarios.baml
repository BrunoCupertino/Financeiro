   M S B A M L   `   `   `  ����  Financeiro.Client     Financeiro.Client.Usuarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Usuarios��5   	   $	��400��6   $	��464��6'   
������� � WindowStartupLocation$ CenterOwner=�6I    � WindowStyle$ SingleBorderWindow=�6m    � 
ResizeMode$ NoResize=�6�   .��5      � .+�5   
   �� -   5        $��
gbUsuarios��5   l   $��Consulta de Usuários��6   $	��204��61   $
��Left=�6>   $��	12,12,0,0q�6Y   $	��Top=�6~   $	��418��6�   .��5      � .+�5      �� -   5        $��tbNome��5   V   $��14��6   $
��Left=�6(   $��	36,10,0,0q�6C   $��Nome:��6d   $	��Top=�6q   �� 5	      -   5        $��txtNome��5	   S   $��23��6   $
��Left=�6&   $��95,6,0,0q�6A   $	��Top=�6b   $	��200��6z   �� 5
      -   5        $��tbSobrenome��5
   U   $��14��6   $
��Left=�6(   $��7,46,0,0q�6C   $��
Sobrenome:��6h   $	��Top=�6z   �� 5      -   5        $��txtSobrenome��5   T   $��23��6   $
��Left=�6&   $��	95,42,0,0q�6A   $	��Top=�6h   $	��200��6�   �� 5      -   5        $��tbEmail��5   V   $��14��6   $
��Left=�6(   $��	37,81,0,0q�6C   $��Email:��6e   $	��Top=�6s   �� 5      -   5        $��txtEmail��5   T   $��23��6   $
��Left=�6&   $��	95,77,0,0q�6A   $	��Top=�6d   $	��200��6|   �� 5      -   5        $��tbSatus��5   W   $��14��6   $
��Left=�6(   $��
34,118,0,0q�6C   $��Status:��6f   $	��Top=�6u   �� 5      -	   5        $��cbSatus��5   V   $��23��6   $
��Left=�6'   $��
95,109,0,0q�6B   $	��Top=�6e   $	��200��6}   �� 5      -
   5        $��btnConsultar��5   h   $��	Consultar��6   $��23��6-   $
��Left=�69   $��
95,146,0,0q�6T   $	��Top=�6|   $��75��6�   6�   �� 5      -   5        $��tbNovo��5   X   $��14��6   $
��Left=�6(   $��364,151,0,0q�6C   $��+ Novo��6f   $	��Top=�6t    � Cursor$
 Hand��6�   6�   5      5      �� 5   
   -   5        $��lstUsuarios��5   O   $	��113��6   $
��Left=�6    $��
12,236,0,0q�6;   $	��Top=�6b   $	��418��6z    �� View 5      �� 5      .P�5      �� $
��Nome��6%    �� DisplayMemberBinding 63   ��  �� Path$ 	FirstName��� 5      $��	Sobrenome��6%    68   �� $ LastName��� 5      $��Email��6%    64   �� $ Email��� 5      $��State��6%    64   �� $ State�5      5      5      5      