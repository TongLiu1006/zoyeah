using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _03_DependenceProperty_CurrentValueAndMixValueAndMaxValue
{
    class MyValiDP : System.Windows.Controls.Control
    {


        //注册Current依赖属性，并添加PropertyChanged、CoerceValue、ValidateValue的回调委托

        public static readonly DependencyProperty CurrrentValueProperty =
            DependencyProperty.Register(
                "CurrrentValue",
                typeof(double),
                typeof(MyValiDP),
                new FrameworkPropertyMetadata(
                    Double.NaN,
                    FrameworkPropertyMetadataOptions.None,
                    new PropertyChangedCallback(onCurrentValueChanged),
                    new CoerceValueCallback(CoreCurrentValue)

                    ),
                new ValidateValueCallback(IsValidValue)

                );


        //当Current值改变的时候，调用Min和Max的CoerceValue回调委托

        private static void onCurrentValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(MixValueProperty);
            d.CoerceValue(MaxValueProperty);
        }

        //在CoerceCurrent加入强制判断赋值
        private static object CoreCurrentValue(DependencyObject d, object baseValue)
        {
            MyValiDP dp = (MyValiDP)d;
            double current = (double)baseValue;
            if (current < dp.MinValue) current = dp.MinValue;
            if (current > dp.MinValue) current = dp.MaxValue;
            return current;

        }

        //注册Min依赖属性，并添加PropertyChanged、CoerceValue、ValidateValue的回调委托

        public static readonly DependencyProperty MixValueProperty =
            DependencyProperty.Register(
                "MinValue",
                typeof(double),
                typeof(MyValiDP),
                new FrameworkPropertyMetadata(
                    Double.NaN,
                    FrameworkPropertyMetadataOptions.None,
                    new PropertyChangedCallback(onMixValueChanged),
                    new CoerceValueCallback(CoerceMinValue)

                    ),
                new ValidateValueCallback(IsValidValue) );

        private static object CoerceMinValue(DependencyObject d, object value)

        {

            MyValiDP g = (MyValiDP)d;

            double min = (double)value;

            if (min > g.MaxValue) min = g.MaxValue;

            return min;

        }

        //当OnMin值改变的时候，调用Current和Max的CoerceValue回调委托
        private static void onMixValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(MaxValueProperty);

            d.CoerceValue(CurrrentValueProperty);
        }

      



        //注册Max依赖属性，并添加PropertyChanged、CoerceValue、ValidateValue的回调委托

        public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register(

           "MaxValue",

           typeof(double),

           typeof(MyValiDP),

           new FrameworkPropertyMetadata(

               double.NaN,

               FrameworkPropertyMetadataOptions.None,

               new PropertyChangedCallback(OnMaxValueChanged),

               new CoerceValueCallback(CoerceMaxValue)

           ),

           new ValidateValueCallback(IsValidValue)

       );

      
        private static object CoerceMaxValue(DependencyObject d, object value)

        {

            MyValiDP g = (MyValiDP)d;

            double max = (double)value;

            if (max < g.MinValue) max = g.MinValue;

            return max;

        }

        private static void OnMaxValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(MixValueProperty);

            d.CoerceValue(CurrrentValueProperty);
        }
       
       
        

        private static bool IsValidValue(object value)
        {
            double v = (Double)value;

            return (!v.Equals(Double.NegativeInfinity) && !v.Equals(Double.PositiveInfinity));
        }

      


       

        public double CurrentValue
        {
            get { return (double)GetValue(CurrrentValueProperty); }
            set { SetValue(CurrrentValueProperty, value); }
        }

        //属性包装器，通过它来暴露Max的值

        public double MaxValue

        {

            get { return (double)GetValue(MaxValueProperty); }

            set { SetValue(MaxValueProperty, value); }

        }


        //属性包装器，通过它来暴露Max的值

        public double MinValue

        {

            get { return (double)GetValue(MixValueProperty); }

            set { SetValue(MixValueProperty, value); }

        }
    }
}
