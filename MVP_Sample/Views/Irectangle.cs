using System;

namespace MVP_Sample.Views
{
    internal interface Irectangle
    {
        string LengthText { get; set; }
        string WidthText { get; set; }
        string AreaText { get; set; }

        event EventHandler CalculateArea;
    }
}
