namespace Temperature_Sensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sensor => Adjust temp (Input And Output)
            //Display
            //Alarm


            Sensor sensor = new Sensor();
            Display display = new Display();
            Alarm alarm = new Alarm(50);
            //5.Subscribition
            sensor.SensorChanged += display.DisplayTemp;
            sensor.SensorChanged += alarm.FireAlarm;
            while (true)
            {
                Console.WriteLine("Welcome to the Temperature System");
                Console.WriteLine("1. Set the Temperature");
                Console.WriteLine("2. Set the Alarm Value (Default 20)");
                Console.WriteLine("3. Exit");

                string userInput = Console.ReadLine();

                switch (userInput) {
                    case "1":
                        Console.Write("1. Set the Temperature, Please Enter Temperature Number: ");
                        double temp = double.Parse(Console.ReadLine());
                        sensor.ChangeTemp = temp;
                        break;
                    case "2":
                        Console.Write("2. Set the Alarm Value, Please Enter Alarm Value: ");
                        double alarmValue = double.Parse(Console.ReadLine());
                        alarm.AlarmValue = alarmValue;
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                        default:
                        Console.Write("Wrong Input, Please Enter Valid Choice: ");
                        break;
                }
            }
        }
    }
}
