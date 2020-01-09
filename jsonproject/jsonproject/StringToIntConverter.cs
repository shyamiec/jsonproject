using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace jsonproject
{
    class StringToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return string.Empty;
            string stringob = value as string;
            string st1 = string.Empty;
            foreach (char c in stringob)
            {
                st1 += getPARAM(c);
            }
            return st1;
        }

        public static int getPARAM(char ch)
        {
            int i = 0;
            if (ch.Equals('a') || ch.Equals('b') || ch.Equals('c'))
            {
                //st = st + i;
                i = 2;
            }
            else if (ch.Equals('d') || ch.Equals('e') || ch.Equals('f'))
            {
                //st = st + (i + 1);
                i = 3;
            }
            else if (ch.Equals('g') || ch.Equals('h') || ch.Equals('i'))
            {
                //st = st + (i + 2);
                i = 4;
            }
            else if (ch.Equals('j') || ch.Equals('k') || ch.Equals('l'))
            {
                //st = st + (i + 3);
                i = 5;
            }
            else if (ch.Equals('m') || ch.Equals('n') || ch.Equals('o'))
            {
                //st = st + (i + 4);
                i = 6;
            }
            else if (ch.Equals('p') || ch.Equals('q') || ch.Equals('r') || ch.Equals('s'))
            {
                //st = st + (i+5);
                i = 7;
            }
            else if (ch.Equals('t') || ch.Equals('u') || ch.Equals('v'))
            {
                //st = st + (i + 6);
                i = 8;
            }
            else if (ch.Equals('w') || ch.Equals('x') || ch.Equals('y') || ch.Equals('z'))
            {
                //st = st + (i + 7);
                i = 9;
            }
            return i;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
