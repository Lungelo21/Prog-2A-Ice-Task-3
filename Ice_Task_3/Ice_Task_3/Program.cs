namespace Ice_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle("Ricky",6,7);
            rec.calculateArea();

            Console.WriteLine();//Leave a line between output

            Circle cir = new Circle("Carlos",8);
            cir.calculateArea();

            Console.ReadKey();
        }
    }
}
