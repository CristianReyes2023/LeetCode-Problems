using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //PALINDROMOOOO 

        //PRIMERA FORMA
        // Console.WriteLine("Inserte numero: ");
        // int x = Convert.ToInt32(Console.ReadLine());
        // if (x < 0)
        // {
        //     Console.WriteLine("false");
        // }
        // string palidromo = Convert.ToString(x);
        // string confirpali = "";
        // for (int j = palidromo.Length - 1; j >= 0; j--)
        // {
        //     confirpali = confirpali + palidromo[j];
        // }
        // if(confirpali == palidromo)
        // {
        //     Console.WriteLine("Son palindromo");
        // }
        // else{
        //     Console.WriteLine("no son palindromo");
        // }

        //SEGUNDA FORMA
        // int x = 34543;
        // int r = 0, c = x;
        // while (c > 0)
        // {
        //     r = r * 10 + c % 10;
        //     c /= 10;
        // }
        // Console.WriteLine(x);
        // return r == x;


        //ROMAN INTEGER
        string s = "CXC";
        List<string> caracteresLista = new List<string>();

        foreach (char caracter in s)
        {
            caracteresLista.Add(caracter.ToString());
        }
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (caracteresLista[i] == "I")
            {
                if (i + 1 < s.Length && caracteresLista[i + 1] != "V" && caracteresLista[i + 1] != "X")
                {
                    sum = sum + 1;
                }
                if (i == s.Length - 1)
                {
                    sum = sum + 1;
                }
            }
            if (caracteresLista[i] == "V")
            {
                sum = sum + 5;
                if (i > 0 && caracteresLista[i - 1] == "I")
                {
                    sum = sum - 1;
                }
            }
            if (caracteresLista[i] == "X")
            {
                if (i + 1 < s.Length && caracteresLista[i + 1] != "L" && caracteresLista[i + 1] != "C")
                {
                    sum = sum + 10;
                    if (i > 0 && caracteresLista[i - 1] == "I")
                    {
                        sum = sum - 1;
                    }
                }
                if (i == s.Length - 1)
                {
                    sum = sum + 10;
                    if (i > 0 && caracteresLista[i - 1] == "I")
                    {
                        sum = sum - 1;
                    }
                }

            }
            if (caracteresLista[i] == "L")
            {
                sum = sum + 50;
                if (i > 0 && caracteresLista[i - 1] == "X")
                {
                    sum = sum - 10;
                }
            }
            if (caracteresLista[i] == "C")
            {
                if (i + 1 < s.Length && caracteresLista[i + 1] != "D" && caracteresLista[i + 1] != "M")
                {
                    sum = sum + 100;
                    if (i > 0 && caracteresLista[i - 1] == "X")
                    {
                        sum = sum - 10;
                    }
                }
                if (i == s.Length - 1)
                {
                    sum = sum + 100;
                    if (i > 0 && caracteresLista[i - 1] == "X")
                    {
                        sum = sum - 10;
                    }
                }

            }
            if (caracteresLista[i] == "D")
            {
                sum = sum + 500;
                if (i > 0 && caracteresLista[i - 1] == "C")
                {
                    sum = sum - 100;
                }
            }
            if (caracteresLista[i] == "M")
            {
                sum = sum + 1000;
                if (i > 0 && caracteresLista[i - 1] == "C")
                {
                    sum = sum - 100;
                }
            }
        }
        Console.WriteLine(sum);
        
    }
}