   M S B A M L   `   `   `  ����?  ;Wpfz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfzWpfz  5   	       Wpfz.WaitingBox   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   $localclr-namespace:Wpfz     5   	   -   5          �Name$  wb��5   #    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterOwner=�5   	    � ShowInTaskbar .  
������  � Title$ 
WaitingBox��5
   	   $	��110��5   	   $	��260��6   .��5      � .+�5   
   ��    WaitingBoxBackground_Colors#���   6    J� Opacity$
 0.89Q�5       �� CornerRadius$ 1��5        WindowDropShadow_Colors J� Effect# �  5      �� 5   
   $��Center=�6   	 �� Orientation$	 
Horizontal=�5      $��Center=�5      $��5q�62   .+�5      �� -   5        
 ��Name$
 MyIcon��5   (   $	����6   $��50(�5        
IconzStyle#��[ 5       J� RenderTransformOrigin$ 0.5,0.5&�5      $��3q�68   z�5      �� 5      -   5        TransformMyIcon�� �� Angle$ 0Q�5   ?   5      �� 5      -   5        $
 
txtMessage��5      $��
2,10,15,10q�5      $	��160��5      $��Center=�5      $
��Wrap=�5       正在加载......68   5!      5"       � Triggers 5#      :� 5$   
    :� RoutedEvent$ Window.Loaded��6   .[�5%      �� .��5&      �� .��5'      W�  g� RepeatBehavior$ Forever��6&    �� 
TargetName$ TransformMyIcon��5(   &    �� TargetProperty$ Angle�5)   &   	 W� To$	 360X�5*   &    g� Duration$ 0:0:2.5D�5+   &   5,      5-      5.      50      