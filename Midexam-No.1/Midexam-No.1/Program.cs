using System;

namespace TestMidTerm_01
{
    enum Menu
    {
        Playgame = 1,
        Exit
    }
    class Program
    {
        static void ShowWord()
        {
            /// เเสดงข้อความก่อนเริ่มเล่นเกม
            Console.WriteLine("Welcome to Hangman Game!!!!!!!!");
            Console.WriteLine("------");
            Console.WriteLine("1.Play game");
            Console.WriteLine("2.Exit");

        }
        static void SelectMenu()
        {
            /// ขั้นตอนการเเสดข้อความการเลือก Menu
            Console.Write("Please Select Menu : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));
            ShowMenu(menu);
        }
        static void ShowMenu(Menu menu)
        {
            ///ขั้นตอนการเลือกว่าต้องการจะเล่นเกมหรือจะออกจากเกม
            if (menu == Menu.Playgame)
            {
                ShowingPlayGame();
                List();
            }
            else if (menu == Menu.Exit)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
        }
        static void ShowingPlayGame()
        {
            Console.Clear();
            Console.WriteLine("Play Game");
            Console.WriteLine("-----------------");
            Console.WriteLine("Incorrect Score :");
        }
        static void Main(string[] args)
        {
            ShowWord();
            SelectMenu();

        }

        static void List()
        {
            Allwords list = new Allwords();

            list.Listwords();
            list.Level();
        }

    }
    class Allwords
    {
        public string Random;
        public char[] AllWords;
        public string ListWords;

        public void Level()
        {
            int heart = 6;
            int incorrectScore = 0;
            int testCollect = 0;
            bool test = false;

            for (int wordsposition = 0; wordsposition < Random.Length; wordsposition++)
            {
                AllWords[wordsposition] = '-';
            }
            do
            {
                int D = Random.Length;

                for (int B = 0; B < 1; B++)
                {
                    char PlayertrytoGuess = char.Parse(Console.ReadLine());

                    for (int A = 0; A < Random.Length; A++)
                    {
                        if (PlayertrytoGuess == Random[A])
                        {
                            AllWords[A] = PlayertrytoGuess;  /// เช็คว่าตัวอักษรที่ผู้ใช้กรอกมาเป็นจริงตามคำศัพท์มั้ย
                            if (AllWords[A] != '-')
                            {
                                testCollect++;
                                if (testCollect == Random.Length)
                                {
                                    test = true;
                                }
                            }


                        }
                        else if (PlayertrytoGuess != Random[A])
                        {
                            D--;
                            if (D == 0)
                            {
                                heart--;
                                Console.WriteLine("heart <3 : " + heart);  // ถ้าหากผู้เล่นชนะหัวใจจะไม่ลด
                            }

                        }
                    }
                    Console.WriteLine(AllWords);
                }
            }
            /// Check ว่า คำศัพท์ที่ผู้เล่นกรอกมาถูกมั้ย
            while (true != test);
            Console.WriteLine("You Won");
            incorrectScore++;
            Console.WriteLine("");
            incorrectScore--;
            Console.WriteLine("Incorrect Score : " + incorrectScore);
        }
        public void Listwords()
        {
            /// กำหนดคำศัพท์ที่ต้องการสุ่ม ตามโจทย์กำหนด
            string[] listWords = new string[3];
            listWords[0] = "Tennis";
            listWords[1] = "Football";
            listWords[2] = "Badminton";

            /// ขั้นตอนการสุ่ม
            Random random = new Random();
            int resultRandom = random.Next(0, 2);

            Random = listWords[resultRandom];
            AllWords = new char[Random.Length];
            Console.Write("Input letter alphabet : ");
        }

    }
}

