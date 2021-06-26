using System;

namespace ConsoleMusic
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringVariant;
            do
            {
                Console.WriteLine();
                Console.WriteLine("\nВыберите музыку:\n1. Jingle Bells \n2. Grasshoper\n3. Tannenbaum" +
                    "\n4. Mission Impossible \n5. Star Wars\n6. Beethoven \n7. Happy Birthday\n8. Super Mario \n0. Выход");
                Console.WriteLine();
                Validate(out stringVariant, 0, 10);
                switch (Byte.Parse(stringVariant))
                {
                    case 1:
                        try
                        {
                            DJ.PutJingleBells();
                        }
                        catch (Exception ex)
                        {
                            WriteWrongMessage(ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            DJ.PutGrasshoper();
                        }
                        catch (Exception ex)
                        {
                            WriteWrongMessage(ex.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            DJ.PutTannenbaum();
                        }
                        catch (Exception ex)
                        {
                            WriteWrongMessage(ex.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            DJ.PutMissionImpossible();
                        }
                        catch (Exception ex)
                        {
                            WriteWrongMessage(ex.Message);
                        }
                        break;
                    case 5:
                        try
                        {
                            DJ.PutStarWars();
                        }
                        catch (Exception ex)
                        {
                            WriteWrongMessage(ex.Message);
                        }
                        break;
                    case 6:
                        try
                        {
                            DJ.PutBeethoven();
                        }
                        catch (Exception ex)
                        {
                            WriteWrongMessage(ex.Message);
                        }
                        break;
                    case 7:
                        try
                        {
                            DJ.PutHappyBirthday();
                        }
                        catch (Exception ex)
                        {
                            WriteWrongMessage(ex.Message);
                        }
                        break;
                    case 8:
                        try
                        {
                            DJ.PutSuperMario();
                        }
                        catch (Exception ex)
                        {
                            WriteWrongMessage(ex.Message);
                        }
                        break;
                }
            } while (Byte.Parse(stringVariant) != 0);
        }

        static void Validate(out string stringVariant, int from, int to)
        {
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                stringVariant = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (!IsRightInDiapason(stringVariant, from, to))
                {
                    WriteWrongMessage("Ошибка! Неверный ввод");
                }
            }
            while (!IsRightInDiapason(stringVariant, from, to));
        }

        static bool IsRightInDiapason(string stringVariant, int from, int to)
        {
            int variant;

            if (Int32.TryParse(stringVariant, out variant))
            {
                if (variant >= from && variant <= to)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        static void WriteWrongMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
