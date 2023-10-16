namespace Impartire;
class Program
{
    static void Main(string[] args)
    {
        int imp = Console.Read();
        int deimp = Console.Read();
        int rezultat = deimp / imp;
        if(deimp%imp==0)
        { Console.WriteLine(rezultat); }
        else { Console.WriteLine("Impartirea nu poate fi efectuata"); }
    }
}

