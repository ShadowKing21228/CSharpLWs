using LR2;

namespace LR2
{
}

namespace StringSorterProject
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // если .NET 6/7/8
            Application.Run(new Form1());
        }
    }
}