// See https://aka.ms/new-console-template for more information

Object[]? vect = { };

T? longitudArray<T>(T[] array)
{

    if (array == null)
    {
        return default;
    }
    else if (array.Length == 0) {
        return default;
    }
    return array[0];

}

Console.WriteLine($"El primer elemento del array es: {longitudArray<Object>(vect)}");

List<String> lista = new List<String>();

foreach (String a in lista) { 

}

//Diccionarios
Dictionary<String, int> dict = new Dictionary<String, int>()
{
    {"Manuel Jesús Curtido Rosado", -5},
    {"Luis", 5 },
    {"YO", 12}
};

dict.Add("Pepe", 2); // agrega valor
dict["Antonio"] = 0; // Agraga y modifica

Console.WriteLine(dict["Antonio"]);

if (dict.ContainsKey("Manuel Jesús Curtido Rosado")) { 
    
}

dict.Count();

//Antonio - 0;
foreach (var valor in dict) { 
    Console.WriteLine("{0} - {1}", valor.Key, valor.Value); 
}

//Ejercicio DiccionarioParImpar Claves: Par, Impar
//Valores: Lista de los numeros de pares e impares del 1 al 10.

Dictionary<String, List<Int16>> mapa = new Dictionary<string, List<Int16>>();
mapa["Par"] = new List<Int16>();
mapa["Impar"] = new List<Int16>();

Int16 cont = 1;
bool salir = false;
while (!salir) {
    foreach (var valor in mapa)
    {
        if (cont % 2 == 0)
        {
            mapa["Par"].Add(cont);
        }
        else
        {
            mapa["Impar"].Add(cont);
        }
        if (cont == 10) {
            salir = true;
        }
        cont++;
    }
}

//Mostrar pares e impares
Console.WriteLine("\n");
foreach (var valor in mapa)
{
    if (valor.Key == "Par")
    {
        Console.WriteLine("PARES:");
        foreach (var clav in valor.Value) {
            Console.WriteLine("\t\t -> " + clav);
        }
    }
    else
    {
        Console.WriteLine("IMPARES:");
        foreach (var clav in valor.Value)
        {
            Console.WriteLine("\t\t -> " + clav);
        }
    }

}