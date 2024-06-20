namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many whells do you need for your vehicle");
            string userInput = Console.ReadLine();
            int parsedValue = int.Parse (userInput);
            IVehicle myVehicle = VehicleFactory.GetVehicle(parsedValue);


            myVehicle.Drive();


        }



    }



}
