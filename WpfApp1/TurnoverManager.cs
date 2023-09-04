﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
   public class TurnoverManager:DependencyObject
    {
        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.RegisterAttached("Angle",typeof(double),typeof(TurnoverManager),new PropertyMetadata(0.0,onAngleChanged));

        private static void onAngleChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var element = obj as UIElement;
            if (element != null)
            {
                element.RenderTransformOrigin = new Point(0.5, 0.5);
                element.RenderTransform = new RotateTransform((double)e.NewValue);

            }
        }

        public static double GetAngle(DependencyObject obj)
        {
            return (double)obj.GetValue(AngleProperty);
        }


        public static void SetAngle(DependencyObject obj,double value)
        { 
        obj.SetValue(AngleProperty,value);
        }
    }
}
