using System;

namespace Provodnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 0);
                    Console.WriteLine("Этот компьютер");
                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

                    Console.SetCursorPosition(0, 2);

                    DriveInfo[] diski = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in diski)
                    {
                        Console.Write("  " + drive.Name);
                        Console.WriteLine("  Всего: " + drive.TotalSize / 1073741824 + "Гб   Cвободно: " + drive.TotalFreeSpace / 1073741824 + "ГБ ");
                    }
                    int pos = Strelki.Strelochki(1, diski.Length + 2);
                    Papki.Papochki(diski[pos - 2].Name);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}