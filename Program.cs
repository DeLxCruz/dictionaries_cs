internal class Program
{
    private static void Main(string[] args)
    {
        //CREAR UN NUEVO DICCIONARIO
        Dictionary<string, string> dict = new();

        //AÑADIR ELEMENTOS A DICCIONARIO
        dict.Add("Nombre","Javier");
        dict.Add("Apellido","Morales");
        dict.Add("Edad", "17");
        dict.Add("Correo","javierevolution");

        //OBTENER  NUMERO DE PARES INCLUIDOS EN DICCIONARIO
        Console.WriteLine("El total de elementos del diccionarios son: {0}", dict.Count);
        Console.ReadKey();

        //OBTENER LLAVES DEL DICCIONARIO EN UNA LISTA
        Dictionary<string, string>.KeyCollection keyCall = dict.Keys;
        foreach (string key in keyCall)
        {
            Console.WriteLine(key);
        }
        Console.ReadKey();

        //OBTENER TODOS LOS VALORES DEL DICCIONARIO EN UNA LISTA
        Dictionary<string, string>.ValueCollection valueCall = dict.Values;
        foreach (string value in valueCall)
        {
            Console.WriteLine(value);
        }
        Console.ReadKey();

        //OBTENER LLAVES Y VALORES EN UNA LISTA
        foreach (KeyValuePair<string, string> pareja in dict)
        {
            Console.WriteLine("Llave: {0} - valor: {1}", pareja.Key, pareja.Value);
        }
        Console.ReadKey();

        //DETERINA SI EL DICCIONARIO CONTIENE UNA LLAVE ESPECIFICA
        if(dict.ContainsKey("Edad"))  Console.WriteLine("Esta llave si existe");
        else Console.WriteLine("Esta llave no se encuentra");
        Console.ReadKey();

        //ELIMINAR EL VALOR DE UNA CLAVE ESPECIFICA
        dict.Remove("Correo");
        foreach (KeyValuePair<string, string> pareja in dict)
        {
            Console.WriteLine("Llave: {0} - valor: {1}", pareja.Key, pareja.Value);
        }
        Console.ReadKey();

        //QUITAR TODAS LAS CLAVES Y LLAVES
        dict.Clear();
        if (dict.Count == 0) Console.WriteLine("Este diccionario se encuentra vacio");
        Console.ReadKey();
    }
}
