namespace MyApp // Note: actual namespace depends on the project name.
{
    public class AdapterPay : IDollarPay
    {
        private IEuroPay euroPay = new SimpleCalculator();
        public double Pay(double x)
        {
            return euroPay.Pay(x * 0.88);
        }
    }
}