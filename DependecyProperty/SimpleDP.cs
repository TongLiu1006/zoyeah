using System;
using System.Windows;

namespace DependecyProperty
{
    public class SimpleDP : DependencyObject
    {

        public static DependencyProperty ValidDPProperty =
            DependencyProperty.Register("ValidDP", typeof(int), typeof(SimpleDP),

                new FrameworkPropertyMetadata
                (0, FrameworkPropertyMetadataOptions.None,

                new PropertyChangedCallback(onValueChanged),
                new CoerceValueCallback(onCoereValue)),
                new ValidateValueCallback(isValidValue)

                );

        private static bool isValidValue(object value)
        {
            Console.WriteLine("当属性值的IsValidValue方法被调用，对属性值进行验证，返回bool值，如果返回True表示严重通过，否则会以异常的形式抛出： {0}", value);

            return true;
        }

        private static void onValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Console.WriteLine(
                "当前属性值onValueChanged方法被调用，属性值为{0}",e.NewValue);
        }

        private static object onCoereValue(DependencyObject d, object value)
        {
            Console.WriteLine("当属性值的CoerceValue方法被调用，属性值强制为： {0}", value);

            return value;
        }

        public int ValidDP
        
        { get {return (int)GetValue(ValidDPProperty); } 
        set { SetValue(ValidDPProperty, value); }
        }

       
    }
}