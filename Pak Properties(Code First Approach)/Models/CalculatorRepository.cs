namespace WebApplication2.Models
{
    public class CalculatorRepository
    {
        public List<double> constructionCost(double size)
        {
            //In Pakistan, the average cost of construction per square foot ranges from PKR 4,000 to PKR 6,500.
            List<double> cost= new List<double>();
            double x = size * 4000;
            double y = size * 6500;
            cost.Add(x);
            cost.Add(y);
            return cost;
        }
        public double areaConverter(double area,string  required)
        {
            double answer = 0.0;
            switch (required)
            {
                case "marla":
                    answer=MarlaToSQFT(area);
                    break;
                case "kanal":
                    answer= KanalToSQFT(area);
                    break;
                case "sqm":
                    answer = SQMToSQFT(area);
                    break;
                case "sqy":
                    answer = SQYToSQFT(area);
                    break;
                case "sqi": 
                    answer = SQIToSQFT(area);
                    break;
                case "hectare":
                    answer = HectareToSQFT(area);
                    break;
                case "acre":
                    answer = AcreToSQFT(area);
                    break;
                default:                    
                    break;
                 
            }
            return answer;
        }
        public double MarlaToSQFT(double marla)
        {
            //marla to square foot
            double x = marla * 272.251;
            return x;
        }
        public double KanalToSQFT(double kanal)
        {
            //kanal to square foot
            double x = kanal*5445;
            return x;
        }
        public double SQMToSQFT(double sqm)
        {
            //square meter to square foot
            double x =sqm*10.7639 ;
            return x;
        }
        public double SQYToSQFT(double sqy)
        {
            //square yard to square foot
            double x = sqy * 9;
            return x;
        }
        public double SQIToSQFT(double sqi)
        {
            //square Inch to square foot
            double x = sqi * 0.000771605;
            return x;
        }
        public double HectareToSQFT(double hectare)
        {
            //square Inch to square foot
            double x = hectare * 11959.9;
            return x;
        }
        public double AcreToSQFT(double acre)
        {
            //square Inch to square foot
            double x = acre * 4840;
            return x;
        }
    }
}
