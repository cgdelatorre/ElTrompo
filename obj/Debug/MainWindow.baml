   M S B A M L   `   `   `  ����C  ?ElTrompo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ElTrompoElTrompo  5   	       ElTrompo.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ElTrompo     5   	   X TXceed.Wpf.Toolkit, Version=2.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Sistema��5	   	   $	��600��6   $	��900��6&    � WindowStartupLocation$ CenterScreen=�62    � 	Resources 5
         sbShowLeftMenu �� TargetProperty t� From	 t� To g� DecelerationRatio g� Duration  sbHideLeftMenu g� AccelerationRatio  ButtonImage	 �� ImageSource  ButtonImageAU  ButtonImageSU
 �� 
TargetType  ButtonStyled �� Property �� Value �� 
TargetType J� SnapsToDevicePixels �� Triggers P� Property P� Value  ButtonStyled2 �� Triggers  MyFocusVisual �� StrokeDashArray � ActualWidth � ActualHeight �� CornerRadius  ShadowStyle 	 InformButton �� Padding �� 
TargetName �� 
StartPoint �� EndPoint � Color � Offset T� Y��%3  &	        &	 �     &	     &	 >    &	 m    &	 �    7  &	 L    &	 
    &	 2    &		 r    7  �� 5   
   .��5      t� $ Margin�6!   $ 
-150,0,0,0X�6D   $ 0,0,0,0X�6V   $ .9Q�6c   $ 0:0:1D�6z   5      �� 5   
   .��5      t� $ Margin�6!   $ 0,0,0,0X�6D   $ 
-150,0,0,0X�6S   $ .9Q�6c   $ 0:0:1D�6z   5      �� 5   
   $!	 Resources/HamburgerMenu.png��6)   6U   �� 5   
   $��Resources/AddUser.png��6&   �� 5   
   $��Resources/SearchUser.png��6&   �� 5   
   "
 ��6   .�5      ��  � ��8   6R   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��6K   ._�5      �� #��z��6/   #��z��5      #��z��68   # z 5      ��. 6Q   5       5      P� 5       �@J�IsMouseOver . . �5    "   ��  � ��
 ��  �6?   �� 5!   "    �@�Cursor$
 Hand��6;   5#      5%      5'      5(      �� 5)   
   "
 ��6   .�5*      ��  � �� �	#FF4E35936+   �� 5+       � �� �	#FFFFFFFF6+   �� 5,       � �� 5-      �� 5.      " ��6&   .R�5/      �� #��z��6!   ._�50      �� $��Center=�6/   $��Center=�6L   51      52      54       55      P� 56       �@J�IsMouseOver . . �57      ��  � �� �	#FFA1C51763   �� 58       � �� �	#FFFFFFFF63   59      5;      �� 5=   
   .�5>      ��  � �� 5?      �� 5@      " ��6&   .R�5A      � $	��3 2q�6   .+�5B      �� $��r1��6(   $��1��62   
���   �$	 2 2R�6U   �� 5C      $��border��6%   #��z 63   #��z 6Y   $ 2��6�   $��1q�6�   5D      5E      5G      5H      �� 5I   
   .�5J      ��  � ��
 �����63   5K      �� 5L   
   "
 ��6%   .�5M      ��  �@�OverridesDefaultStyle . 66   �� 5N       � ��$ 1q�6'   �� 5O       � ��$7 1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6+   �� 5P       � ��$	 9pt(�6)   �� 5Q       � ��$ Normal"�6+   �� 5R       �@�FocusVisualStyle8   61   �� 5S       � �� 5T      �� 5U      " ��6&   .R�5V      �� $��border��6!   $��1q�5W      $	 4,2q�5X      
�������$ 5��5Z      #��z��5[      ._�5\      � .+�5]   "   �� $��content��5^   @   $��Center=�5]   3   $��Center=�5^   %   6@   5_      5`       5a      P� 5b       �@J�IsMouseOver . . �5c   "   �� $ border��6)    � �� �	#FF4788c86T   �� 5d   "    � �� �	#FF4788c86?   �� 5e   "    � �� �	#FFA1C5176?   5f      P� 5g       � �� . . �5h   "   ��  � �� 5i   &   �� 5j   *   $	 0,0&�6>   $	 0,1&�6O   .��5k   .   � $ 	#FFFFD190��6;   $
 0.35Q�6M   � 5l   .   $ 	#FF4E3593��6;   $
 0.95Q�6M   � 5m   .   $ 	#FFFFD190��6;   $ 1Q�6M   5n   +   5p   #   �� 5q   "   $ content��6)    � z� 5r   &   T� 5s   *   $	 1.0Q�6=   5u   #   5v      P� 5w       �@��IsDefaulted . . �5x   "   �� $ border��6)    � �� �	#FF2828286T   5y      P� 5z       �@J�	IsFocused . . �5{   "   �� $ border��6)    � �� �	#FF2828286T   5|      P� 5}       � {� .  . �5~   "   �� $ border��6)    �@J�Opacity$	 0.7Q�6P   �� 5   "    � ��
 �����6?   5�      5�      5�      5�      5�      .��5�      (�  (� Stretch$
 Fill=�6   .��5�   
   � -   5         �Name$ grdAltaCliente��5�      .+�5�      �� -   5          ��Name$  cvBienvenida��5�      $
��Left=�6+   $	��319��6F   $	��Top=�6S   $	��469��6k   $��48,0,0,0q�6w   $y�Hidden=�6�   ��5�      �� 5�      $	 Resources/Bienvenida.gif��6!   5�      �� 5�      -   5        $  cvAltaCliente��5�      $
��Left=�6,   $	��319��6G   $	��Top=�6T   $	��517��6l   ���	#FF3AC5C8$y�Hidden=�6�   .+�5�      �� -   5        ! ��Name$! 
btnGuardar��5�   ?   #��[	 6   $��Guardar��6S   $
��Left=�6e   $��0q�6�   $	��Top=�6�   $��75��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   " K� ZIndex$" 10��6�   
����������	#FF4E3593# �� Left$	# 168��6�  
$ �� Top$	$ 294��6�  �� 5�      -   5        $! btnCancelar��5�   ?   #��[	 6   $��Cancelar��6T   $
��Left=�6g   $��0q�6�   $	��Top=�6�   $��75��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 11��6�   
����������	#FF4E3593$	# 274��6�  $	$ 294��6�  �� 5�      -   5        % ��Name$% 	lblNombre��5�      $��Nombre Completo��6+   $
��Left=�6E   $	��Top=�6`   $��26��6x   $	��116��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $# 4��6�   $$ 65��6�   �� 5�      -   5        $% lblTelefono��5�      $��Telefono��6-   $
��Left=�6@   $	��Top=�6[   & J� RenderTransformOrigin$& 	0.182,0.5&�6s   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $	# 136��6�   $$ 88��6�   �� 5�      -   5        $% 	lblCelSec��5�      $��Celular��6+   $
��Left=�6=   $	��Top=�6X   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6p   $# 4��6�   $$ 88��6�   �� 5�      -	   5        $% 	lblCorreo��5�      $��Correo Electronico��6+   $
��Left=�6H   $	��Top=�6c   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6{   $	# 262��6�   $$ 88��6�   �� 5�      -
   5        $% lblMunicipio��5�      $��	Municipio��6.   $
��Left=�6B   $	��Top=�6]   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6u   $	# 178��6�   $	$ 136��6�   �� 5�      -   5        $% 	lblEstado��5�      $��Estado��6+   $
��Left=�6<   $	��Top=�6W   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6o   $# 9��6�   $	$ 136��6�   �� 5�      -   5        $% 
lblColonia��5�      $��Colonia��6,   $
��Left=�6>   $	��Top=�6Y   $& 0.5,0.5&�6q   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $	# 349��6�   $	$ 136��6�   �� 5�      -   5        $% lblTurno��5�      $��Turno��6*   $
��Left=�6:   $	��Top=�6U   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6m   $	# 262��6�   $	$ 189��6�   �� 5�      -   5        $% 	lblSector��5�      $��Sector��6+   $
��Left=�6<   $	��Top=�6W   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6o   $# 49��6�   $	$ 189��6�   �� 5�      -   5        $% lblClave��5�      $��Clave��6*   $
��Left=�6:   $	��Top=�6U   $��44��6m   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6x   $	# 349��6�   $$ 65��6�   �� 5�      -   5        ' ��Name$' cbSector��5�      $
��Left=�6-   $	��Top=�6H   $	��160��6`   $& -0.473,-1.455&�6l   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 8��6�   $# 97��6�   $	$ 191��6�   $��23��6  �� 5�      -   5        $' cbTurno��5�      $
��Left=�6,   $	��Top=�6G   $	��160��6_   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6k   $" 9��6�   $	# 307��6�   $	$ 191��6�   $��23��6�   �� 5�      -   5        ( ��Name$( tbNombre��5�      $
��Left=�6,   $��23��6G   ) �� TextWrapping$
) Wrap=�6S   $	��Top=�6g   $	��235��6   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $	# 114��6�   $$ 65��6�   �� 5�      -   5        $' 	cbEstados��5�      $
��Left=�6.   $	��Top=�6I   $	��160��6a   * �� 
IsEditable* . $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6   $" 5��6�   $# 9��6�   $	$ 161��6  $��23��6  %  Xceed.Wpf.Toolkit.MaskedTextBox  5�      -   5        +  Name$+ 	tbCelular��5�   %   $
��Left=�68   $
) Wrap=�6S   $��MaskedTextBox��6g   $	��Top=�6|   ,   Mask$, (000) 000-0000��6�   $��23��6�   $	��122��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 2��6  $# 9��6  $	$ 113��6"  �� 5�      -   5        $( tbClave��5�      $
��Left=�6+   $��23��6F   $
) Wrap=�6R   $�� ��6f   $	��Top=�6n   $	��117��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 1��6�   $	# 393��6�   $$ 65��6�     5�      -   5        $+ 
tbTelefono��5�   %   $
��Left=�69   $
) Wrap=�6T   $��MaskedTextBox��6h   $	��Top=�6}   $, (000) 000-0000��6�   $��23��6�   $	��122��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 3��6  $	# 136��6  $	$ 113��6%  �� 5�      -   5        $( tbCorreoElectronico��5�      $
��Left=�67   $��23��6R   $
) Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��244��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 4��6�   $	# 266��6�   $	$ 113��6   �� 5�      -   5        $' cbMunicipios��5�      $
��Left=�61   $	��Top=�6L   $	��160��6d   * . $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 6��6�   $	# 178��6�   $	$ 161��6�   $��23��6�   �� 5�      -   5        $( 	tbColonia��5�      $
��Left=�6-   $��23��6H   $
) Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��160��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 7��6�   $	# 349��6�   $	$ 161��6�   �� 5�      -   5        $% lblAltaCliente��5�      $��Alta Cliente��60   $
��Left=�6G   $	��Top=�6b   $��21.333(�6z   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $
��Bold"�6�   $	# 189��6�   �� 5�      -   5        $% lblClabeInterna��5�      $��Clave Interna��61   $
��Left=�6I   $	��Top=�6d   $& -0.302,-4.68&�6|   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $	# 292��6�   $$ 39��6�   �� 5�      -   5        $( tbClaveInterna��5�      $
��Left=�62   $��23��6M   $
) Wrap=�6Y   $�� ��6m   $	��Top=�6u   $	��135��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $" 1��6�   $	# 375��6�   $$ 39��6�   {�. - �� 
IsReadOnly- . $��14.667(�6.  �� 5�      -   5        $% lblNombreInstitucion��5�      $��Nombre Institución��66   $
��Left=�6S   $	��Top=�6n   $��26��6�   $	��116��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $# 4��6�   $$ 39��6�   �� 5�      -   5        $( tbNombreInstitucion��5�      $
��Left=�67   $��23��6R   $
) Wrap=�6^   $	��Top=�6r   $	��170��6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $	# 114��6�   $$ 39��6�   �� 5�      $	��497��6   $��70��6%   $# 10��61   $	$ 219��6B   
���   �$��1q�6g   ._�5�      �� -   5        $% lblNivelEscolar��5�      $��Nivel Escolar��65   $
��Left=�6M   $	��Top=�6h   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $# 10��6�   $	$ 219��6�   5�      	� 5�      -    5        . 	�Name$. rbJardinDeNinos��5�      $��Jardin de niños��67   $# 69��6Q   $	$ 250��6b   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6s   	� 5�      -!   5        $. 
rbPrimaria��5�      $��Primaria��62   $	# 201��6E   $	$ 263��6W   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6h   	� 5�      -"   5        $. rbSecundaria��5�      $��
Secundaria��64   $	# 201��6I   $	$ 239��6[   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6l   	� 5�      -#   5        $. rbPreparatoria��5�      $��Preparatoria��66   $	# 326��6M   $	$ 239��6_   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6p   	� 5�      -$   5        $. rbUniversidad��5�      $��	Univerdad��65   $	# 326��6I   $	$ 263��6[   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6l   5�      �� 5�      -%   5        $  cvConsultaCliente��5�      $
��Left=�60   $	��319��6K   $	��Top=�6X   $	��517��6p   {�. $y�Visible=�6�   .+�5�      �� -&   5        $( tbbuscar��5�      $��23��6,   $	# 139��68   $
) Wrap=�6J   $��TextBox��6^   $$ 38��6m   $	��120��6}   6�   �� 5�      -'   5        $% lblConsultaCliente��5�      $��Consulta Cliente��64   $
��Left=�6O   $	��Top=�6j   $��21.333(�6�   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6�   $
��Bold"�6�   $	# 189��6�   �� 5�      -(   5        $! 	btnBuscar��5�      $��Buscar��6,   $��Center=�6=   $��Center=�6Z   $	# 264��6u   $$ 38��6�   $& 1.043,0.174&�6�   $��24��6�   $��74��6�   &   System.Windows.Controls.DataGrid  5�      -)   5        /  Name$/ 
dgConsulta��5�      $# 10��6/   $$ 67��6@   $	��242��6P   $	��497��6]   5�      � 5�      .+�5�      �� -*   5        $��pnlLeftMenu��5�   .   $" 2��6   0 �� Orientation$0 
Horizontal=�6A   $
��Left=�6Z   $��
-150,0,0,0q�6u   .+�5�      �� $	��150��6   ._�5�      �� ���	#FFA1C517$��0,36,0,0q�68   .+�5�      �� -+   5        $% 
lblUsuario��5�   $   $��Alta Cliente��68   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6O   $
��Bold"�6�   $��13.333(�6�   $# 39��6�   
�������$$ 10��6�   �� 5�      -,   5        $! btnAgregarUsuario��5�   &   #��[ 6A   $��33��6j   $��33��6v   $$ 8��6�   $# 6��6�   6�   �� 5�      --   5        $! btnConsultaUsuario��5�   &   #��[ 6B   $��33��6k   $��33��6w   $# 6��6�   $$ 44��6�   6�   �� 5�      -.   5        $% lblUsuario2��5�   $   $��Consulta Cliente��69   $7��1/ElTrompo;component/#Chalet LondonNineteenSeventy)�6T   $
��Bold"�6�   $��13.333(�6�   $# 39��6�   
�������$$ 48��6�   5�      5�      5�      �� 5�      ���	#FFA1C517$��38��60   $��0,0,479,281q�6;   $��38��6P   .+�5�      �� -/   5        $��btnLeftMenuHide��5�   C   #��[ 6   $��38��6Z   $��38��6e   $�� ��6�   $��40(�6�   $��Center=�6�   $��Center=�6�   �� 5�      -0   5        $! btnLeftMenuShow��5�   C   #��[ 6   $��38��6\   $��38��6g   $��Center=�6�   $��Center=�6�   5�      5�      5�      5�      5�      