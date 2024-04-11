
using System;

string [,] candidatos =new string [,]{ 
    {"Provincia", "Candidato 1", "Candidato 2", "Candidato 3", "Candidato 4", "Candidato 5"}, 
    {"CABA:   ",  "104     ", "  8    ", "115   ", "80     ", "20" }, 
    {"Salta:  ",  " 86     ", " 30    ", " 40   ", "20     ", " 3" }, 
    {"Cordoba:",  " 40     ", "  5    ", "100   ", "24     ", "60" },
    {"Mendoza:",  " 67     ", " 32    ", " 43   ", "18     ", " 9" },
    {"Jujuy:  ",  " 43     ", " 25    ", " 32   ", " 4     ", "46" } };

for (int i = 0; i < candidatos.GetLength(0); i++)
{

        Console.Write(" | " + candidatos[0,i]);
   }


Console.WriteLine("");
    for (int i = 1; i < candidatos.GetLength(0); i++)
{
    for (int j = 0; j < candidatos.GetLength(1); j++)
{
        Console.Write(" |  " + candidatos[i, j]);
    }
    Console.WriteLine(" ");
}

Console.WriteLine("\n");
int[] arr = new int[6];
for (int j = 1; j < candidatos.GetLength(0); j++)
{
    
    int suma = 0;
    for (int i = 1; i < candidatos.GetLength(1); i++)
    {
        suma += int.Parse(candidatos[i, j]);
      
    
     
    }
    Console.WriteLine(candidatos[0, j] + " = "+suma);
    arr[j] = suma;
}
Console.WriteLine("\n");
int max = 0;
string ganador="";
for (int i = 0; i < 6; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    ganador = candidatos[0, i];
}
}
Console.WriteLine("El ganador de la eleccion es: "+ganador +" (Votos: "+ max+")");



Console.ReadKey();
