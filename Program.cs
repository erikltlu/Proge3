using System;

namespace ConsoleApp4
{
    class Program
    {
        static string[,] laud = new string[,] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        static string mangija = "O";
        static string voitja;
        static int kokkuRuute = 9;
        static int muutujaViik = 0;
        static bool mang = true;
        static void Main(string[] args)
        {
            while(mang == true)
            {
                Console.WriteLine(" {0} | {1} | {2} ", laud[0, 0], laud[0, 1], laud[0, 2]);
                Console.WriteLine(" {0} | {1} | {2} ", laud[1, 0], laud[1, 1], laud[1, 2]);
                Console.WriteLine(" {0} | {1} | {2} ", laud[2, 0], laud[2, 1], laud[2, 2]);

                if(Voit() == false)
                {
                    if(Viik() == false)
                    {
                        if (mangija == "O")
                        {
                            Console.WriteLine("Mängija 1 vali rida 1-3: ");
                            int vastusRida = Convert.ToInt32(Console.ReadLine()) - 1;

                            if (vastusRida <= 2 && vastusRida >= 0)
                            {
                                Console.WriteLine("Mängija 1 vali veerg 1-3: ");
                                int vastusVeerg = Convert.ToInt32(Console.ReadLine()) - 1;

                                if (vastusVeerg <= 2 && vastusVeerg >= 0)
                                {
                                    if (laud[vastusRida, vastusVeerg] != "O" && laud[vastusRida, vastusVeerg] != "X")
                                    {
                                        laud[vastusRida, vastusVeerg] = "O";
                                        mangija = "X";
                                    }
                                    else
                                    {
                                        Console.WriteLine("See koht on juba võetud, proovi uuesti!");
                                    }
                                }
                            }
                        }
                        else if (mangija == "X")
                        {
                            Console.WriteLine("Mängija 2 vali rida 1-3: ");
                            int vastusRida = Convert.ToInt32(Console.ReadLine()) - 1;

                            if (vastusRida <= 2 && vastusRida >= 0)
                            {
                                Console.WriteLine("Mängija 1 vali veerg 1-3: ");
                                int vastusVeerg = Convert.ToInt32(Console.ReadLine()) - 1;

                                if (vastusVeerg <= 2 && vastusVeerg >= 0)
                                {
                                    if (laud[vastusRida, vastusVeerg] != "O" && laud[vastusRida, vastusVeerg] != "X")
                                    {
                                        laud[vastusRida, vastusVeerg] = "X";
                                        mangija = "O";
                                    }
                                    else
                                    {
                                        Console.WriteLine("See koht on juba võetud, proovi uuesti!");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        mang = false;
                        break;
                    }
                }
                else
                {
                    mang = false;
                    if (mangija == "X")
                    {
                        voitja = "1";
                    }
                    if (mangija == "O")
                    {
                        voitja = "2";
                    }
                    break;
                }
            }
            if(Voit() == true)
            {
                Console.WriteLine("Mang labi! Voitis mangija {0}!!!", voitja);
            }
            else if(Viik() == true)
            {
                Console.WriteLine("Mang jai viiki!");
            }
        }
        static public bool Voit()
        {

            if ((laud[0, 0] == "X" && laud[0, 1] == "X" && laud[0, 2] == "X") || (laud[0, 0] == "O" && laud[0, 1] == "O" && laud[0, 2] == "O"))
            {
                return true;
            }
            if ((laud[1, 0] == "X" && laud[1, 1] == "X" && laud[1, 2] == "X") || (laud[1, 0] == "O" && laud[1, 1] == "O" && laud[1, 2] == "O"))
            {
                return true;
            }
            if ((laud[2, 0] == "X" && laud[2, 1] == "X" && laud[2, 2] == "X") || (laud[2, 0] == "O" && laud[2, 1] == "O" && laud[2, 2] == "O"))
            {
                return true;
            }
            if ((laud[0, 0] == "X" && laud[1, 0] == "X" && laud[2, 0] == "X") || (laud[0, 0] == "O" && laud[1, 0] == "O" && laud[2, 0] == "O"))
            {
                return true;
            }
            if ((laud[0, 1] == "X" && laud[1, 1] == "X" && laud[2, 1] == "X") || (laud[0, 1] == "O" && laud[1, 1] == "O" && laud[2, 1] == "O"))
            {
                return true;
            }
            if ((laud[0, 2] == "X" && laud[1, 2] == "X" && laud[2, 2] == "X") || (laud[0, 2] == "O" && laud[1, 2] == "O" && laud[2, 2] == "O"))
            {
                return true;
            }
            if ((laud[0, 0] == "X" && laud[1, 1] == "X" && laud[2, 2] == "X") || (laud[0, 0] == "O" && laud[1, 1] == "O" && laud[2, 2] == "O"))
            {
                return true;
            }
            if ((laud[0, 2] == "X" && laud[1, 1] == "X" && laud[2, 0] == "X") || (laud[0, 2] == "O" && laud[1, 1] == "O" && laud[2, 0] == "O"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool Viik()
        {
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    if (laud[x, y] == "X" || laud[x, y] == "O")
                    {
                        muutujaViik++;
                        if (muutujaViik >= kokkuRuute)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
    }
}