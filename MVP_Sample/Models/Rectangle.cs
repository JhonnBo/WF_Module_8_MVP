namespace MVP_Sample.Models
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;            
        }
    }
}
