   M S B A M L   `   `   `  ����F  BSemana13BDk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Semana13BDkSemana13BDk  5   	       Semana13BDk.InsertWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Semana13BDk     5   	     � Title$  InsertWindow��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ 
txtNombres��5
      $
��Left=�6&   $��
367,79,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��120��6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6(   $��
288,81,0,0q�6C   $
��Wrap=�6W   $��Nombres:��6k   $	��Top=�6{   �� 5   
   -   5        $ txtApellidos��5      $
��Left=�6(   $��367,130,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $ textBlock_Copiar��5      $
��Left=�6/   $��288,132,0,0q�6J   $
��Wrap=�6_   $��
Apellidos:��6s   $	��Top=�6�   �� 5   
   -   5        $ 	txtCarnet��5      $
��Left=�6%   $��367,186,0,0q�6@   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ textBlock_Copiar1��5      $
��Left=�60   $��288,188,0,0q�6K   $
��Wrap=�6`   $��Carnet:��6t   $	��Top=�6�   �� 5   
   -   5        $ txtTelefono��5      $
��Left=�6'   $��367,247,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ textBlock_Copiar2��5      $
��Left=�60   $��288,249,0,0q�6K   $
��Wrap=�6`   $��	Telefono:��6t   $	��Top=�6�   �� 5   
   -	   5         ��Name$ btnCrear��5      $��Guardar��6#   $��Center=�65   $��	0,343,0,0q�6R   $	��Top=�6e    J� RenderTransformOrigin$ 0.601,2.744&�6�   �� 5   
   -
   5        $ txtId��5      $
��Left=�6!   $��
367,34,0,0q�6<   $
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��120��6�   �� 5   
   -   5        $ textBlock_Copiar3��5      $
��Left=�60   $��
288,36,0,0q�6K   $
��Wrap=�6_   $	��Id:��6s   $	��Top=�6~   �� 5   
   -   5        $ textBlock_Copiar4��5      $
��Left=�60   $��294,300,0,0q�6K   $
��Wrap=�6`   $��Carrera:��6t   $	��Top=�6�   �� 5   
   -   5         ��Name$ 
cbCarreras��5       �� DisplayMemberPath$ Nombre��6W    �� SelectedValuePath$ Id��5      $
��Left=�6*   $��367,300,0,0q�6E   $	��Top=�6Z   $	��120��6r   	 �� SelectedValue	 5   (   �� *	Carerra+
 �� Mode$
 OneWay=�5   r   5      5      