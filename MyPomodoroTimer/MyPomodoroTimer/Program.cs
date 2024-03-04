namespace MyPomodoroTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            namespace MyPomodoroTimer
    {
        internal class MyPomodoroProgram
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to My Pomodoro Timer!");
                Console.ReadLine();

                while (true)
                {
                    // Create an instance of the MyPomodoroTime class
                    MyPomodoroTime myTimer = new MyPomodoroTime();
                    Console.ReadLine();

                    // Start the Pomodoro timer
                    myTimer.StartPomodoro();
                    Console.ReadLine();

                    Console.WriteLine("Press 'Enter' to start the next Pomodoro or 'Ctrl + C' to exit.");
                    //prompts the user to start the next Pomodoro cycle or exit the program.
                    Console.ReadLine();
                }
            }
        }

    }
}
}
