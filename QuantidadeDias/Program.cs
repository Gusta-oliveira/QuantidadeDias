internal class Program
{
    private static void Main(string[] args)
    {
        int litte_year, bigger_year, count = 0, aux_year, year_bix = 0, sum_days;
        Console.WriteLine("Informe um ano inicio ");
        litte_year = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe um ano fim ");
        bigger_year = int.Parse(Console.ReadLine());

        if (litte_year > bigger_year)
        {
            aux_year = litte_year;
            litte_year = bigger_year;
            bigger_year = aux_year;
        }
        while((aux_year = (litte_year + count)) < bigger_year) { 
            // Determinando Ano bissexto
            if ((aux_year % 4 == 0) && (aux_year % 100 != 0) || (aux_year % 400 == 0))
            {
                year_bix++;
            }
            count++;

        }

        sum_days = ((count * 365) + year_bix);
        Console.WriteLine("A quantidade de dias entre os anos {0} e {1} é de {2}", litte_year, bigger_year, sum_days);
       
    }
}