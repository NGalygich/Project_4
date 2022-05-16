namespace Project_4;

public static class Program{
    public static void Main(){
        byte num_task;
        bool state_prog = true;
        while(state_prog){
            Console.Write("Stop program - 4\nEnter number Task: ");
            num_task = Convert.ToByte(Console.ReadLine());
            switch (num_task){
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
                    state_prog = false;
                    break;
            }
        }
    }
    public static void Task_1(){
        Console.Write("Enter the number of lines: ");
        byte lines = Convert.ToByte(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        byte columns = Convert.ToByte(Console.ReadLine());
        SByte[,] array = new SByte[lines, columns];
        int sum = 0;
        Random rnd = new Random();
        Console.WriteLine("Your array");
        for (byte i = 0; i<lines; i++){
             for (byte j = 0; j < columns; j++){
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
        Console.Write("Sequence length: ");
        byte length = Convert.ToByte(Console.ReadLine());
        int[] sequence = new int[length];
        Console.WriteLine("Enter sequence");
        byte i = 0;
        //Sequence completion
        while(i < length){
                sequence [i] = Convert.ToInt32(Console.ReadLine());  
                i++;
        }
        int lowestFound = int.MaxValue;
        foreach (int el in sequence)
        {
            // By using int.MaxValue as the initial value
            if (lowestFound > el)
            {
                lowestFound = el;
            }
        }
        Console.WriteLine($"Lowest element in sequence: {lowestFound}");
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
            int num_user = Convert.ToInt32(Console.ReadLine());
            if (num_user == num)
                break;
            else if (num_user > num)
                Console.WriteLine("Your number is greater. Тry again.");
            else Console.WriteLine("Your number is less. Тry again.");
        }
        Console.WriteLine($"Сongratulations you guessed right. Hidden number: {num}");
        Console.ReadLine();
        Console.Clear();
    }
}