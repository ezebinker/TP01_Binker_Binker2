class Program
{
    private static void Main(string[] args)
    {
        //LISTAS

        List<string> nombres = new List<string>();

        nombres.Add("Roberto");

        nombres.Insert(0, "Juan");

        nombres[0] = "Luis";

        nombres.Remove("Luis");

        //DICCIONARIOS

        SortedDictionary<string, string> diccionario = new SortedDictionary<string, string>();

        diccionario.Add("Escuela", "Lugar para divertirse programando :)");
        diccionario.Add("Aula", "El lugar del lugar para divertirse programando :)");
        diccionario.Add("Patio", "El lugar donde la gente no se divierte programando");

        if (diccionario.ContainsKey("Patio"))
        {
            Console.WriteLine("Patio ya existe en el diccionario");
        }
        else
        {
            diccionario.Add("Patio", "El lugar donde la gente no se divierte programando");
        }

        foreach (string palabra in diccionario.Keys)
        {
            Console.WriteLine(palabra + " : " + diccionario[palabra]);
        }

        Dictionary<DateTime, List<string>> nacimientos = new Dictionary<DateTime, List<string>>();

        DateTime fechaHoy = new DateTime(2023, 03, 20);

        nacimientos.Add(fechaHoy, new List<string>());

        nacimientos[fechaHoy].Add("Binker");

        foreach (DateTime fecha in nacimientos.Keys)
        {
            Console.WriteLine("FECHA " + fecha.ToShortDateString() + " - Nacimientos: ");
            foreach (string nombre in nacimientos[fecha])
            {
                Console.WriteLine("-" + nombre);
            }
        }

        Dictionary<string, bool> presentes = new Dictionary<string, bool>();
        presentes.Add("Eitan", true);
        presentes.Add("Cañete", false);

    }
}