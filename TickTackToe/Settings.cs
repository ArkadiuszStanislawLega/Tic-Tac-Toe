using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.Drawing;
using TickTackToe.Properties;

namespace TickTackToe
{
    static public class Settings
    {
        public static int AreaID = 0;
        public static int NumberOfColumns = 5;
        public static int NeedToWin = 3;
        public static int Size = 37;
        public static int FirstSize = 37;
        public static int SizeBetweenThem = 3;

        public static long SizeOfNamePlayer1 = 0;
        public static long SizeOfNamePlayer2 = 0;

        public static bool Player1 = false;
        public static bool Player2 = false;
        public static bool meesegeBoxSended;
        public static bool UnmuteSound = true;

        public static string Player1Name;
        public static string Player2Name;
        public static string FileName = "Lista_zwyciezcow.bin";

        public static Area[,] L; //List whith map areas. | Lista z polami mapy. 
        public static List<int> ListWithId = new List<int>();
        static StreamWriter sw;

        private static bool finish;
        private static bool winByLeftSlant;
        private static bool winByRightSlant;
        private static bool winVertical;
        private static bool winHorizontally;

        /// <summary>
        /// Makes list with areas. Its depend on size the map which user chose.
        /// Tworzy listę z polami. Dopiero wtedy kiedy gracz wybierze ilość kolumn.
        /// </summary>
        public static void GenerateTable() { L = new Area[NumberOfColumns, NumberOfColumns]; }

        /// <summary>
        /// Consider which player won.
        /// Rozpatruje który gracz wygrał.
        /// </summary>
        /// <param name="winner">X = player 1 or O = player 2 | X = gracz 1 albo O = gracz 2</param>
        public static void Win(string winner)
        {
            finish = true;
            foreach (Area a in L) { a.area.Enabled = false; }
            if (!File.Exists(FileName))
            {
                try
                {
                    sw = File.AppendText(FileName);
                    sw.WriteLine();
                }
                catch (UnauthorizedAccessException) { }
            }
            else 
                sw = File.AppendText(FileName);
            if (winner == "X") AllIfWin(Player1Name, "X");
            else AllIfWin(Player2Name, "O");
        }

        /// <summary>
        /// He does all the things to finish the victory correctly.
        /// Wykonuje wszystkie rzeczy do poprawnego zakończenia zwycięstwa.
        /// </summary>
        /// <param name="sign">The sign which won. | Znak który wygrał.</param>
        private static void AllIfWin(string winer, string sign)
        {
            if (UnmuteSound) Sound.Winner();
           
            if (winer == Player1Name)
            {
                sw.WriteLine(Player1Name);
                sw.WriteLine(Player2Name);
            }
            else
            {
                sw.WriteLine(Player2Name);
                sw.WriteLine(Player1Name);
            }
            sw.Close();
            LookingForWin(sign);
            MessageWin(winer);
            finish = false;
            winByLeftSlant = false;
            winByRightSlant = false;
            winHorizontally = false;
            winVertical = false;
        }

        /// <summary>
        /// Is showing the Message Box with information about win.
        /// Podaje MessageBox z informacją o wygranej.
        /// </summary>
        /// <param name="winner">Imie gracza który wygrał.</param>
        public static void MessageWin(string winner)
        {
            if (!meesegeBoxSended)
            {
                meesegeBoxSended = true;
                System.Windows.Forms.MessageBox.Show("Wygrałeś! " + winner + " Gratulacje!! ");
            }
        }

        /// <summary>
        /// It's looking for win.
        /// Poszukuje wygranej.
        /// </summary>
        /// <param name="sign">The sign which is looking for. | Znak którego szuka.</param>
        public static void LookingForWin(string sign)
        {
            for (int i = 0; i < NumberOfColumns; i++)
            {
                for (int z = 0; z < NumberOfColumns; z++)
                {
                    int checker = 1;

                    try //right slant | skos prawostronny
                    {
                        for (int q = 0; q < NeedToWin; q++)
                        {
                            if (L[i, z].CompareTo(L[i + checker, z - checker]) == 1 && L[i, z].area.Text == sign)
                            {
                                if (finish && winByRightSlant)//In this "if" there are thinks to do after win. To bold areas. | W tym "ifie" są tylko dodatkowe rzeczy do wyboldowania znaków w polach.
                                {
                                    if (checker == 1) MakeBoldWineerLine(L[i, z]);
                                    if (checker > 1)
                                    {
                                        MakeBoldWineerLine(L[i, z]);
                                        MakeBoldWineerLine(L[i + checker, z - checker]);
                                    }
                                }
                                checker++;
                                if (checker == NeedToWin && !finish) { winByRightSlant = true; Win(sign); }
                            }
                            else { checker = 1; break; }
                        }
                    }
                    catch (IndexOutOfRangeException) { }

                    try //left slant | skos lewostronny 
                    {
                        for (int q = 0; q < NeedToWin; q++)
                        {
                            if (L[i, z].CompareTo(L[i + checker, z + checker]) == 1 && L[i, z].area.Text == sign)
                            {
                                if (finish && winByLeftSlant)//In this "if" there are thinks to do after win. To bold areas. | W tym "ifie" są tylko dodatkowe rzeczy do wyboldowania znaków w polach.
                                {
                                    if (checker == 1) MakeBoldWineerLine(L[i, z]);
                                    if (checker > 1)
                                    {
                                        MakeBoldWineerLine(L[i, z]);
                                        MakeBoldWineerLine(L[i + checker, z + checker]);
                                    }
                                }
                                checker++;
                                if (checker == NeedToWin && !finish) { winByLeftSlant = true; Win(sign); }
                            }
                            else { checker = 1; break; }
                        }
                    }
                    catch (IndexOutOfRangeException) { }

                    try //vertical | pionowo
                    {
                        for (int q = 0; q < NeedToWin - 1; q++)
                        {
                            int x = i;
                            if (L[i + checker - 1, z].CompareTo(L[i + checker, z]) == 1 && L[i + checker - 1, z].area.Text == sign)
                            {
                                if (finish && winVertical)//In this "if" there are thinks to do after win. To bold areas. | W tym "ifie" są tylko dodatkowe rzeczy do wyboldowania znaków w polach.
                                {
                                    if (checker == 1) MakeBoldWineerLine(L[i + checker - 1, z]);
                                    if (checker > 1)
                                    {
                                        MakeBoldWineerLine(L[i + checker - 1, z]);
                                        MakeBoldWineerLine(L[i + checker, z]);
                                    }
                                }
                                checker++;
                                if (checker == NeedToWin && !finish) { winVertical = true; Win(sign); }
                            }
                            else { checker = 1; break; }
                        }
                    }
                    catch (IndexOutOfRangeException) { }

                    try //horizontaly | poziomo
                    {
                        for (int q = 0; q < NeedToWin; q++)
                        {
                            if (L[i, z + checker - 1].CompareTo(L[i, z + checker]) == 1 && L[i, z].area.Text == sign)
                            {
                                if (finish && winHorizontally)//In this "if" there are thinks to do after win. To bold areas. | W tym "ifie" są tylko dodatkowe rzeczy do wyboldowania znaków w polach.
                                {
                                    if (checker == 1) MakeBoldWineerLine(L[i, z]);
                                    if (checker > 1)
                                    {
                                        MakeBoldWineerLine(L[i, z]);
                                        MakeBoldWineerLine(L[i, z + checker]);
                                    }
                                }
                                checker++;
                                if (checker == NeedToWin && !finish) { winHorizontally = true; Win(sign); }
                            }
                            else { checker = 1; break; }
                        }
                    }
                    catch (IndexOutOfRangeException) { }
                }
            }
        }

        /// <summary>
        /// The signs which are won, they are bolded. 
        /// Znaki które tworzą zwycięską linię zostają wyblodowane.
        /// </summary>
        /// <param name="a">The area which should be bolded after win. | Pole do wyblodowania po wygranej.</param>
        static private void MakeBoldWineerLine(Area a)
        {
            a.area.Font = new Font("Microsoft Sans Serif", 26, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        //public static void LookingForWin(string sign)
        //{
        //    for (int i = 0; i < numberOfColumns; i++)
        //    {
        //        for (int z = 0; z < numberOfColumns; z++)
        //        {
        //            if (l[i, z].area.Text == sign)
        //            {
        //                try { if (l[i, z].area.Text == l[i + 1, z - 1].area.Text && l[i + 1, z - 1].area.Text == l[i + 2, z - 2].area.Text) { Win(); } } catch (IndexOutOfRangeException) { }
        //                try { if (l[i, z].area.Text == l[i + 1, z + 1].area.Text && l[i + 1, z + 1].area.Text == l[i + 2, z + 2].area.Text) { Win(); } } catch (IndexOutOfRangeException) { }
        //                try { if (l[i, z].area.Text == l[i + 1, z].area.Text && l[i + 1, z].area.Text == l[i + 2, z].area.Text) { Win(); } } catch (IndexOutOfRangeException) { }
        //                try { if (l[i, z].area.Text == l[i, z + 1].area.Text && l[i, z + 1].area.Text == l[i, z + 2].area.Text) { Win(); } } catch (IndexOutOfRangeException) { }
        //            }
        //        }
        //    }
        //}
    }
}

