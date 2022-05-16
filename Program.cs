namespace Project_4;

public static class Program{
    public static void Main(){
        Task_1();
        //Task_2();
        //Task_3();
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

}