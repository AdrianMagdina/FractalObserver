// programmed by Adrian Magdina in 2012
// in this file is the implementation of linear color interpolation
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalObserverApplication
{
    public static class ColorInterpolation
    {
        // to static methods for linear interpolation of color
        public static FractalColorValue InterpolateColor(double valueIn, double minimumValueIn, double maximumValueIn, FractalColorValue color1In, FractalColorValue color2In)
        {
            FractalColorValue aInterpolatedColor = new FractalColorValue();

            aInterpolatedColor.alpha = (int)(color1In.alpha + (double)(color2In.alpha - color1In.alpha) * Math.Abs(valueIn - minimumValueIn) / Math.Abs(maximumValueIn - minimumValueIn));
            aInterpolatedColor.red = (int)(color1In.red + (double)(color2In.red - color1In.red) * Math.Abs(valueIn - minimumValueIn) / Math.Abs(maximumValueIn - minimumValueIn));
            aInterpolatedColor.green = (int)(color1In.green + (double)(color2In.green - color1In.green) * Math.Abs(valueIn - minimumValueIn) / Math.Abs(maximumValueIn - minimumValueIn));
            aInterpolatedColor.blue = (int)(color1In.blue + (double)(color2In.blue - color1In.blue) * Math.Abs(valueIn - minimumValueIn) / Math.Abs(maximumValueIn - minimumValueIn));

            return aInterpolatedColor;
        }

        public static FractalColorValue InterpolateColor(int valueIn, int minimumValueIn, int maximumValueIn, FractalColorValue color1In, FractalColorValue color2In)
        {
            FractalColorValue aInterpolatedColor;

            aInterpolatedColor = InterpolateColor((double)valueIn, (double)minimumValueIn, (double)maximumValueIn, color1In, color2In);

            return aInterpolatedColor;
        }
    }
}