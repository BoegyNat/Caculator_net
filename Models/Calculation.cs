namespace MathCalculatorMVC.Models
{
    public class Calculation
    {
        public int Id { get; set; } // สำหรับเรียงลำดับ
        public double X { get; set; }
        public double Y { get; set; }
        public string Operator { get; set; } = "";
        public double Result { get; set; }
    }
}
