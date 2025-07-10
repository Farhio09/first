using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string name = Ask("Magaca"), id = Ask("ID"); int score = 0;
        List<string> res = new();
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nQ{i}: Xulo nooca: \n1.Kudar \n2.Kajar \n3.Kudhufo \n4.Uqeybi");
            if (!int.TryParse(Console.ReadLine(), out int c) || c < 1 || c > 4) { res.Add($"Q{i}: Doorasho khaldan"); continue; }
            (string q, int a, string op) = GenQ(c);
            Console.Write($"Su’aal: {q} = ");
            if (!int.TryParse(Console.ReadLine(), out int u)) { res.Add($"Q{i}: {q} = ?? (Khalad)"); continue; }
            bool ok = u == a; if (ok) score += 10;
            res.Add($"Q{i}: {id.PadRight(5)} {name.PadRight(10)} {op.PadRight(8)} {q.PadRight(10)} {a,4} {u,4}  {(ok ? "Haa" : "Maya")}");

        }
        Show(res, id, name, score);
    }

    static string Ask(string label) { Console.Write($"{label}: "); return Console.ReadLine(); }

    static (string, int, string) GenQ(int ch)
    {
        Random r = new(); int a = r.Next(1, 20), b = r.Next(1, 10);
        if (ch == 4) { while (b == 0) b = r.Next(1, 10); int ans = a / b; a = ans * b; return ($"{a} / {b}", ans, "Uqeybi"); }
        return ch switch
        {
            1 => ($"{a} + {b}", a + b, "Kudar"),
            2 => ($"{a} - {b}", a - b, "Kajar"),
            3 => ($"{a} * {b}", a * b, "Kudhufo"),
            _ => ("", 0, "")
        };
    }

    static void Show(List<string> r, string id, string name, int score)
    {
        Console.WriteLine("\n------ Natiijooyinka ------");
        Console.WriteLine("Q#\tID\tMagac\tNooc\tSu'aal\tJwb Sax\tUser\tSax");
        r.ForEach(x => Console.WriteLine(x));
        double pct = score; string g = pct >= 80 ? "A - Heer Sare" : pct >= 60 ? "B" : pct >= 40 ? "C" : "F";
        Console.WriteLine($"\n>> Score: {score}/100\n>> %: {pct}\n>> Natiijo: {g}");
    }
}
