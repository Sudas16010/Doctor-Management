   M S B A M L   `   `   `  ����L  HDoctor Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Doctor_ManagementDoctor_Management  5   	   %    Doctor_Management.Search_doctor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Doctor_Management     5   	     � Title$  Search_doctor��5   	   $	��650��6   $
��1200��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��131* �6   �� 5      $
��133* �6   .+�5   
   �� $��SEARCH DOCTOR PANEL��6   $
��Left=�6.   $��50��6I   $��
270,41,0,0q�6U   $	��Top=�6i   $	��671��6�   ���	#FF41BDAC
�������$��24(�6�   $
��Bold"�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��	200,5,5,5q�6�   $��2��6  z�5      V� 5      .~�5      �� �� 5       �� AngleY$ -0.264Q�6$   �� 5       �� Angle$ 0.396Q�6&   T� 5       T� X$ 0.014Q�6)    T� Y$ -2.085Q�63   5      5      �� 5   
   $��	Location:��6   $
��Left=�6$   $��45��6?   $��263,152,0,0q�6K   $	��Top=�6`   $	��124��6x   $��20,5,5,5q�6�   $��20(�6�   $
��Bold"�6�   ���	#FFD3B4B46�   �� 5   
   -   5         ��Name$ txt_loc��5      $
��Left=�6#   $��45��6>   $��387,152,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��262��6�   $��5,5,0,0q�6�   ���	#FFF1F1F1$��18(�6�   $
��Bold"�6�   ���	#FF0F0F0F$��2��6�   �� 5   
   $��Type:��6   $
��Left=�6    $��45��6;   $��263,225,0,0q�6G   $	��Top=�6\   $	��124��6t   $��30,5,5,5q�6�   $��20(�6�   $
��Bold"�6�   ���	#FFD3B4B46�   �� 5   
   -   5        $ txt_ty��5      $
��Left=�6"   $��45��6=   $��387,225,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��262��6�   $��5,5,0,0q�6�   ���	#FFF1F1F1$��18(�6�   $
��Bold"�6�   
���   �$��2��6�   �� 5   
   -   5        $��Search��5      $��1��6"   $
��Left=�62   $��50��6M   $��127,186,0,0q�6Y   $	��Top=�6n   $	��171��6�   $��24(�6�   ���	#FFF7D2C7���	#FF170CFF$
��Bold"�6�   6�   �� 5   
   $��Details:��6   $
��Left=�6#   $��45��6>   $��263,315,0,0q�6J   $	��Top=�6_   $	��124��6w   $��25,5,5,5q�6�   $��20(�6�   $
��Bold"�6�   ���	#FFD3B4B46�   �� 5   
   -   5        	 ��Name$	 txt_details��5      $��2��6)   $
��Left=�6=   $	��268��6X   $��387,315,0,0q�6e   $
��Wrap=�6z   $	��Top=�6�   $	��439��6�   $��18(�6�   
 �� Padding$
 5,5,0,0q�6�   ���	#FFF5F0F0 J� OpacityMask �	#FFF309096�   �� 5   
   -   5        $��Log out��5      $��1��6#   $
��Left=�63   $��39��6N   $��427,518,0,0q�6Z   $	��Top=�6o   $	��141��6�   ���	#FFE4D1D1$��22(�6�   ���	#FFFF0606$
��Bold"�6�   6�   5!      5"      