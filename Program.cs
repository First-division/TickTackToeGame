using System;

namespace TicTackToeGame
{
    class Program
    {
        static string Player;
        static string System;
        static int SystemChoice() => Random.Shared.Next(1, 10);
        static string One = "1";
        static string Two = "2";
        static string Three = "3";
        static string Four = "4";
        static string Five = "5";
        static string Six = "6";
        static string Seven = "7";
        static string Eight = "8";
        static string Nine = "9";

        static bool GoodValue = false;
        static bool won = false;
        
        public static int FirstMove() => Random.Shared.Next(1, 2);
        static void Main(string[] args) {

            

            while (!GoodValue) 
            {
                Console.WriteLine("This is tictak toe. would you like to be (1) [X] or (2) [O] ?");
                var Test = Console.ReadKey(true).Key;
                switch (Test) {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                    //GoodValue = false;
                    Player = "X";
                    System = "O";
                    GoodValue = true;
                    break;

                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                    Player = "O";
                    System = "X";
                    GoodValue = true;
                    break;

                    default:
                    //GoodValue = true;
                    Console.WriteLine("Please try again");
                    continue;
                }
            }

            DrawGame();
            
             switch (FirstMove()) {
                case 1:
                while(!won) {
                    Playerturn();
                    DrawGame();
                    WinCheck();
                    SystemTurnE();
                    DrawGame();
                    WinCheck();
                }    
                break;

                case 2:
                    
                while(!won) {
                    SystemTurnE();
                    DrawGame();
                    WinCheck();
                    Playerturn();
                    DrawGame();
                    WinCheck();
                }
                break;
            }
        }

        static void DrawGame() {
            Console.WriteLine($"PLayer: {Player}");
            Console.WriteLine($"System: {System}\n");

            Console.WriteLine($" {One} | {Two} | {Three} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {Four} | {Five} | {Six} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {Seven} | {Eight} | {Nine} ");

        }

        static void Playerturn() {
            Console.WriteLine($"it is your turn. where would you like to put your first");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($" [{Player}?]");
            Console.WriteLine("(1) - (9)");
            Console.ForegroundColor = ConsoleColor.White;

            bool GoodValue0 = false;
            var turn = Console.ReadKey(true).Key;
            switch (turn) {
                case ConsoleKey.D1 or ConsoleKey.NumPad1:
                while (!GoodValue0)
                {
                    if (One == System || One == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;
                        // is filled find another one
                    }
                    else {
                        One = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;       

                case ConsoleKey.D2 or ConsoleKey.NumPad2:
                while (!GoodValue0)
                {
                    if (Two == System || Two == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;
                        // is filled find another one
                    }
                    else {
                        Two = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;

                case ConsoleKey.D3 or ConsoleKey.NumPad3:
                while (!GoodValue0)
                {
                    if (Three == System || Three == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;
                        // is filled find another one
                    }
                    else {
                        Three = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;

                case ConsoleKey.D4 or ConsoleKey.NumPad4:
                while (!GoodValue0)
                {
                    if (Four == System || Four == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;
                        // is filled find another one
                    }
                    else {
                        Four = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;

                case ConsoleKey.D5 or ConsoleKey.NumPad5:
               while (!GoodValue0)
                {
                    if (Five == System || Five == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;
                        // is filled find another one
                    }
                    else {
                        Five = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;

                case ConsoleKey.D6 or ConsoleKey.NumPad6:
                while (!GoodValue0)
                {
                    if (Five == System || Five == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;
                        // is filled find another one
                    }
                    else {
                        Five = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;

                case ConsoleKey.D7 or ConsoleKey.NumPad7:
                while (!GoodValue0) {
                    if (Seven == System || Seven == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;
                        // is filled find another one
                    }
                    else {
                        Seven = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;

                case ConsoleKey.D8 or ConsoleKey.NumPad8:
                while (!GoodValue0) {
                    if (Eight == System || Eight == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;

                        // is filled find another one
                    }
                    else {
                        Eight = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;

                case ConsoleKey.D9 or ConsoleKey.NumPad9:
                while (!GoodValue0) {
                    if (Nine == System || Nine == Player) {
                        GoodValue = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plese pick another spot that is not taken");
                        Console.ForegroundColor = ConsoleColor.White;
                        turn = Console.ReadKey(true).Key;
                        // is filled find another one
                    }
                    else {
                        Nine = Player;
                        GoodValue0 = true;
                        // is not filled
                    }
                
                }
                break;
            }
        }
        static void SystemTurnE() {
            bool _true = true;
            while (_true) { // while _True has to be ture but when a space is not full make it false
                switch (SystemChoice()) 
                {
                    case 1:
                    if (One == Player){
                        _true = true;
                    }
                    else {
                        One = System;
                        _true = false;
                    }
                    break;

                    case 2:
                    if (Two == Player){
                        _true = true;
                    }
                    else {
                        Two = System;
                        _true = false;
                    }
                    break;

                    case 3:
                    if (Three == Player){
                        _true = true;
                    }
                    else {
                        Three = System;
                        _true = false;
                    }
                    break;

                    case 4:
                    if (Four == Player){
                        _true = true;
                    }
                    else {
                        Four = System;
                        _true = false;
                    }
                    break;

                    case 5:
                    if (Five == Player){
                        _true = true;
                    }
                    else {
                        Five = System;
                        _true = false;
                    }
                    break;

                    case 6:
                    if (Six == Player){
                        _true = true;
                    }
                    else {
                        Six = System;
                        _true = false;
                    }
                    break;

                    case 7:
                    if (Seven == Player){
                        _true = true;
                    }
                    else {
                        Seven = System;
                        _true = false;
                    }
                    break;

                    case 8:
                    if (Eight == Player){
                        _true = true;
                    }
                    else {
                        Eight = System;
                        _true = false;
                    }
                    break;

                    case 9:
                    if (Nine == Player){
                        _true = true;
                    }
                    else {
                        Nine = System;
                        _true = false;
                    }
                    break;
                }
            }
        }
        // static void SystemturnH() {
            
        // }

        static void WinCheck() {
            // 1 2 3 //
            // 4 5 6 // 
            // 7 8 9 //
            // 1 4 7 //
            // 2 5 8 //
            // 3 6 9 //
            // 1 5 9 // 
            // 7 5 3 //
            if (Player == One && Player == Two && Player == Three) {
                Console.WriteLine("Player won!!!");
                won = true;
            }
            if (Player == Four && Player == Five && Player == Six) {
                Console.WriteLine("Player won!!!");
                won = true;
            }
            if (Player == Seven && Player == Eight && Player == Nine) {
                Console.WriteLine("Player won!!!");
                won = true;
            }
            if (Player == One && Player == Four && Player == Seven) {
                Console.WriteLine("Player won!!!");
                won = true;
            }
            if (Player == Two && Player == Five && Player == Eight) {
                Console.WriteLine("Player won!!!");
                won = true;
            }
            if (Player == One && Player == Six && Player == Nine) {
                Console.WriteLine("Player won!!!");
                won = true;
            }
            if (Player == One && Player == Five && Player == Nine) {
                Console.WriteLine("Player won!!!");
                won = true;
            }
            if (Player == Seven && Player == Five && Player == Three) {
                Console.WriteLine("Player won!!!");
                won = true;
            }
            if (System == One && System == Two && System == Three) {
                Console.WriteLine("System won!!!");
                won = true;
            }
            if (System == Four && System == Five && System == Six) {
                Console.WriteLine("System won!!!");
                won = true;
            }
            if (System == Seven && System == Eight && System == Nine) {
                Console.WriteLine("System won!!!");
                won = true;
            }
            if (System == One && System == Four && System == Seven) {
                Console.WriteLine("System won!!!");
                won = true;
            }
            if (System == Two && System == Five && System == Eight) {
                Console.WriteLine("System won!!!");
                won = true;
            }
            if (System == One && System == Six && System == Nine) {
                Console.WriteLine("System won!!!");
                won = true;
            }
            if (System == One && System == Five && System == Nine) {
                Console.WriteLine("System won!!!");
                won = true;
            }
            if (System == Seven && System == Five && System == Three) {
                Console.WriteLine("System won!!!");
                won = true;
            }
            else {
                Console.WriteLine("Keep playing no one has won yet");
            }
        } 
    }
}
