namespace Project_4;

public static class Program{
    public static void Main(){
        byte numTask;
        bool stateProg = true;
        while(stateProg){
            Console.Write("Stop program - 4\nEnter number Task: ");
            numTask = Convert.ToByte(Console.ReadLine());
            switch (numTask){
                case 1: 
                    Task_1();
                    break;
                case 2: 
                    Task_2();
                    break;
                case 3: 
                    Task_3();
                    break;
                default:
                    stateProg = false;
                    break;
            }
        }
    }
    public static void Task_1(){
        Console.Write("Enter the number of lines: ");
        byte linesArray = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        byte columnsArray = Convert.ToByte(Console.ReadLine());
        SByte[,] array = new SByte[linesArray, columnsArray];
        int sum = 0;
        Random rnd = new Random();
        Console.WriteLine("Your array");
        for (byte i = 0; i<linesArray; i++){
             for (byte j = 0; j < columnsArray; j++){
                array[i, j] = Convert.ToSByte(rnd.Next(-128, 127));
                Console.Write(String.Format("{0,5}", array[i, j]));
                sum += array[i, j];
             }
             Console.WriteLine();
        }
        Console.WriteLine($"Sum of all elements: {sum}");
        Console.ReadLine();
        Console.Clear();
    }
        public static void Task_2(){
        Console.Write("sArray length: ");
        byte lengthArray = Convert.ToByte(Console.ReadLine());
        int[] sArray = new int[lengthArray];
        Console.WriteLine("Enter sArray");
        byte i = 0;
        //sArray completion
        while(i < lengthArray){
                sArray [i] = Convert.ToInt32(Console.ReadLine());  
                i++;
        }
        int lowestFound = int.MaxValue;
        foreach (int el in sArray)
        {
            // By using int.MaxValue as the initial value
            if (lowestFound > el)
            {
                lowestFound = el;
            }
        }
        Console.WriteLine($"Lowest element in sArray: {lowestFound}");
        Console.ReadLine();
        Console.Clear();
    }
    public static void Task_3(){
        Console.Write("Set a range of numbers: 0 ... ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random();
        int num = rnd.Next(0, maxValue);
        while(1 == 1){
            Console.Write("Guess the number: ");
            int numUser = Convert.ToInt32(Console.ReadLine());
            if (numUser == num)
                break;
            else if (numUser > num)
                Console.WriteLine("Your number is greater. Тry again.");
            else Console.WriteLine("Your number is less. Тry again.");
        }
        Console.WriteLine($"Сongratulations you guessed right. Hidden number: {num}");
        Console.ReadLine();
        Console.Clear();
    }
}