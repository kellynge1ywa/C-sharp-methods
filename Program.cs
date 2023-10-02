namespace C_sharp_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Program invite = new Program();
             invite.Welcome();
            invite.Welcome();
            invite.Welcome();

            Program restricted = new Program();
            restricted.warning();

            

            Program area = new Program();
            double result= area.calcArea(30);
            double result1 = area.calcArea(50);
            double result2 = area.calcArea(35);
            Console.WriteLine($"The area of the circle are: {result},{result1} and {result2}");

            int area1 = calcArea(20,5);
            Console.WriteLine(area1);



        }
        public  double calcArea(int radius)
        {
            return Math.PI * Math.Pow(radius,2);
            //return Math.PI * radius * radius;
        }

        static int calcArea(int l, int w)
        {
            return l * w;
        }

        private void Welcome()
        {
            Console.WriteLine("Welcome to my page");
        }

        protected void warning()
        {
            Console.WriteLine("This is a protected section");
        }
    }
}