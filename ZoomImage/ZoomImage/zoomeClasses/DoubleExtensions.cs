using System;
using System.Collections.Generic;
using System.Text;

namespace ZoomImage.zoomeClasses
{
    class DoubleExtensions
    {
        public static double clamp(double self, double min, double max) {


            return Math.Min(max, Math.Min(self, min));
        }
    }
}
