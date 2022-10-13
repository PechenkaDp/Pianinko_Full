namespace Практическая3
{
    using System.Threading;
    class Program
    {
        static void Main(string[] args)
        {
            Pianino();

        }

        static void Pianino()
        {
            Console.WriteLine("Доступные клавиши:");
            Console.WriteLine("Обычные: A-до; S-ре; D-ми; F-фа; G-соль; H-ля; J-си;");
            Console.WriteLine("Диезные и бемольные: W - До # и ре b; E - ми # и фа b; R- фа # и соль b; T- ля# и си b; Y- си # и до b.");
            Console.WriteLine("Переключение октавы: 1- F1; 2- F2; 3-F3.");
            Console.WriteLine("Для выхода нажмите Num9");
            List<int[]> Oktava = new List<int[]>
            {   new int[] {1661, 1480, 1245, 1109, 932, 1568, 1397, 1319, 1175, 1047, 987, 880},
                new int[] { 830, 740, 622, 554, 466, 784, 698, 659, 587, 523, 493, 440 },
                new int[] { 207, 185, 155, 138, 116, 196, 174, 164, 146, 130, 123, 110 }
            };

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.F6)
            {
                oktava6(Oktava[0]);
            }
            if (key.Key == ConsoleKey.F5)
            {
                oktava5(Oktava[1]);
            }
            if (key.Key == ConsoleKey.F3)
            {
                oktava3(Oktava[2]);
            }
            if (key.Key == ConsoleKey.Backspace)
            {
                exit();
            }


        }


        static void oktava6(int[]sound)
        {
            Console.Clear();
            Console.WriteLine("Вы ввошли в шестую октаву");
            for (ConsoleKeyInfo k = Console.ReadKey(); k.Key != ConsoleKey.Backspace;)
            {

                ConsoleKeyInfo l = Console.ReadKey();
                k = l;

                




                if (k.Key == ConsoleKey.A)
                {
                    Console.Beep(sound[11], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.S)
                {
                    Console.Beep(sound[10], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.D)
                {
                    Console.Beep(sound[9], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.F)
                {
                    Console.Beep(sound[8], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.G)
                {
                    Console.Beep(sound[7], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.H)
                {
                    Console.Beep(sound[6], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.J)
                {
                    Console.Beep(sound[5], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.W)
                {
                    Console.Beep(sound[4], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.E)
                {
                    Console.Beep(sound[3], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.R)
                {
                    Console.Beep(sound[2], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.T)
                {
                    Console.Beep(sound[1], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.Y)
                {
                    Console.Beep(sound[0], 150);
                    Console.Clear();
                }

            }
            Pianino();
        }


        static void oktava5(int[] sound)
        {
            Console.Clear();
            Console.WriteLine("Вы ввошли во пятую октаву");
            for (ConsoleKeyInfo ke = Console.ReadKey(); ke.Key != ConsoleKey.Backspace;)
            {

                ConsoleKeyInfo l = Console.ReadKey();
                ke = l;

                

                if (ke.Key == ConsoleKey.A)
                {
                    Console.Beep(sound[11], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.S)
                {
                    Console.Beep(sound[10], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.D)
                {
                    Console.Beep(sound[9], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.F)
                {
                    Console.Beep(sound[8], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.G)
                {
                    Console.Beep(sound[7], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.H)
                {
                    Console.Beep(sound[6], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.J)
                {
                    Console.Beep(sound[5], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.W)
                {
                    Console.Beep(sound[4], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.E)
                {
                    Console.Beep(sound[3], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.R)
                {
                    Console.Beep(sound[2], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.T)
                {
                    Console.Beep(sound[1], 100);
                    Console.Clear();
                }
                if (ke.Key == ConsoleKey.Y)
                {
                    Console.Beep(sound[0], 100);
                    Console.Clear();
                }

                

            }
            Pianino();
        }

        static void oktava3(int[] sound)
        {
            Console.Clear();
            for (ConsoleKeyInfo k = Console.ReadKey(); k.Key != ConsoleKey.Backspace;)
            {
                ConsoleKeyInfo l = Console.ReadKey();
                k = l;






                if (k.Key == ConsoleKey.A)
                {
                    Console.Beep(sound[11], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.S)
                {
                    Console.Beep(sound[10], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.D)
                {
                    Console.Beep(sound[9], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.F)
                {
                    Console.Beep(sound[8], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.G)
                {
                    Console.Beep(sound[7], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.H)
                {
                    Console.Beep(sound[6], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.J)
                {
                    Console.Beep(sound[5], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.W)
                {
                    Console.Beep(sound[4], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.E)
                {
                    Console.Beep(sound[3], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.R)
                {
                    Console.Beep(sound[2], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.T)
                {
                    Console.Beep(sound[1], 150);
                    Console.Clear();
                }
                if (k.Key == ConsoleKey.Y)
                {
                    Console.Beep(sound[0], 150);
                    Console.Clear();
                }



            }
            Pianino();

        }
        static void exit()
        {
            Console.Clear();
            Console.WriteLine("Завершение программы");
        }



    }
}