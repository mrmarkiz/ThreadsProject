namespace ThreadsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter task to run: ");
            int.TryParse(Console.ReadLine(), out int taskRun);
            switch(taskRun)
            {
                case 1:
                    Task1.Run();
                    break;
                case 2:
                    Task2.Run();
                    break;
                case 3:
                    Task3.Run();
                    break;
                case 4:
                    Task4.Run();
                    break;
                case 5:
                    Task5.Run();
                    break;
            }
        }
    }
}