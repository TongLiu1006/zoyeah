   M S B A M L   `   `   `  ����H  DExampleWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ExampleWpfApp.Ch09ExampleWpfApp.Ch09  5      +    %ExampleWpfApp.Ch09.Z03_ScaleTransform   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:ExampleWpfApp.Ch09     5        N� Title$  Ex03_ScaleTransform��5	      .��5
      �� $��Center=�6   $��Center=�6,   .+�5   
   �� -   5        $��textblockScaleMaster��5      $��32(�60   
�����F�$��缩放的文本��5       J� RenderTransformOrigin$ 0.5,0.5&�6   5      �� 5   
   $��32(�6   $
��Bold"�6"   
�����F�$ 0.5,0.5&�5      ��5      ��  �� Path$
 Text� �� ElementName$ textblockScaleMaster��z�5      �� 5       �� ScaleX$	 1.5Q�6!    �� ScaleY$	 1.0Q�6.   5      �� 5   
   $��32(�6   $
��Bold"�6"   
�����F�$ 0.5,0.5&�5      ��5      �� $
 Text�$ textblockScaleMaster��z�5      �� 5      $	 1.0Q�6!   $	 1.5Q�6.   5      5      5      