using jsonproject;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
[assembly: ExportRenderer(typeof(Entry),typeof(CustomEntry))]
namespace jsonproject
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create(nameof(BorderWidth), typeof(int), typeof(CustomEntry), Device.OnPlatform<int>(1,2,2));
        public int BorderWidth
        {
            get
            {
                return (int)GetValue(BorderWidthProperty);
            }
            set
            {
                SetValue(BorderWidthProperty, value);
            }
        }

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadius),typeof(double),typeof(CustomEntry),Device.OnPlatform<double>(6,7,7));

        public Double CornerRadius
        {
            get
            {
                return (double)GetValue(CornerRadiusProperty);
            }
            set
            {
                SetValue(CornerRadiusProperty, value);
            }
        }

        public static readonly BindableProperty isEnableProperty =
             BindableProperty.Create(nameof(isEnable), typeof(bool), typeof(CustomEntry),true);

        public bool isEnable
        {
            get
            {
                return (bool)GetValue(IsEnabledProperty);
            }
            set
            {
                SetValue(IsEnabledProperty, value);
            }
        }


    }
}
