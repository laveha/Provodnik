using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Provodnik
{
    internal class Papki
    {
        public static void Papochki(string s)
        {
            if (Directory.Exists(s))
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Папка");
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("".PadRight(120, '-'));
                    Console.WriteLine($"{"Название",15} {"Дата создания",38} {"Тип",19}");

                    string[] Papki = Directory.GetDirectories(s);
                    for (int x1 = 0; x1 < Papki.Length; x1++)
                    {
                        string Papka = Papki[x1];
                        string name = Path.GetFileName(Papka);
                        if (name.Length >= 25)
                        {
                            name = name.Substring(0, 25);
                        }
                        Console.Write("  " + name);
                        Console.SetCursorPosition(30, x1 + 3);
                        Console.WriteLine("\t\t" + Directory.GetCreationTime(Papka));
                    }
                    string[] files = Directory.GetFiles(s);
                    for (int x2 = 0; x2 < files.Length; x2++)
                    {
                        string file = files[x2];
                        string fileName = Path.GetFileName(file);

                        Console.Write("  " + fileName);

                        Console.SetCursorPosition(30, x2 + 3 + Papki.Length);
                        string fileExtension = Path.GetExtension(file);
                        Console.WriteLine("\t\t" + Directory.GetCreationTime(file) + "\t\t" + fileExtension);
                    }

                    int pos = Strelki.Strelochki(2, Papki.Length + files.Length + 3);

                    if (pos == -2)
                        return;
                    else if (pos - 3 < Papki.Length)
                        Papochki(Papki[pos - 3]);
                    else
                        Papochki(files[pos - 3 - Papki.Length]);
                }
            }
            else
            {
                Process.Start(new ProcessStartInfo { FileName = s, UseShellExecute = true });
            }
        }
    }
}