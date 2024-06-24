using System;
using System.Collections.Generic;

namespace GeneradorHistorias
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frases = new List<string>
            {
                "Había una vez...",
                "En un lugar lejano...",
                "Un día soleado...",
                // Agrega más frases aquí
            };

            List<string> personajes = new List<string>
            {
                "Un principe",
                "María",
                "El capitán",
                // Agrega más personajes aquí
            };

            List<string> lugares = new List<string>
            {
                "en la ciudad",
                "en una isla desierta",
                "en el espacio exterior",
                // Agrega más lugares aquí
            };

            Random random = new Random();
            string fraseAleatoria = frases[random.Next(frases.Count)];
            string personajeAleatorio = personajes[random.Next(personajes.Count)];
            string lugarAleatorio = lugares[random.Next(lugares.Count)];

            string historia = $"{fraseAleatoria} {personajeAleatorio} vivía {lugarAleatorio}.";
            Console.WriteLine(historia);
        }
    }
}
