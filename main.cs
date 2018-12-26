using System;
using System.Diagnostics;
using static mspaintArtist.alphabet;

namespace mspaintArtist
{
    class Program
    {
        
        static void write(string input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                switch (input[i].ToString().ToLowerInvariant())
                {
                    case "a":
                        A();
                        break;
                    case "b":
                        B();
                        break;
                    case "c":
                        C();
                        break;
                    case "d":
                        D();
                        break;
                    case "e":
                        E();
                        break;
                    case "f":
                        F();
                        break;
                    case "g":
                        G();
                        break;
                    case "h":
                        H();
                        break;
                    case "i":
                        I();
                        break;
                    case "j":
                        J();
                        break;
                    case "k":
                        K();
                        break;
                    case "l":
                        L();
                        break;
                    case "m":
                        M();
                        break;
                    case "n":
                        N();
                        break;
                    case "o":
                        O();
                        break;
                    case "p":
                        P();
                        break;
                    case "q":
                        Q();
                        break;
                    case "r":
                        R();
                        break;
                    case "s":
                        S();
                        break;
                    case "t":
                        T();
                        break;
                    case "u":
                        U();
                        break;
                    case "v":
                        V();
                        break;
                    case "w":
                        W();
                        break;
                    case "x":
                        X();
                        break;
                    case "y":
                        Y();
                        break;
                    case "z":
                        Z();
                        break;
                    case " ":
                        SPACE();
                        break;
                    default:
                        Console.WriteLine("An error occured, please make sure that you are only using letters");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Process.Start("mspaint.exe");
            while (true)
            {
                write(Console.ReadLine());
            }
        }
    }
}
