using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIngreso
{
    class Program
    {
        static void Main(string[] args)
        {
            var teclado = new List<Tecla>();
            teclado.Add(new Tecla { Numero = 0, Letra = new List<char> { ' ' } });
            teclado.Add(new Tecla { Numero = 2, Letra = new List<char> { 'a', 'b', 'c' } });
            teclado.Add(new Tecla { Numero = 3, Letra = new List<char> { 'd', 'e', 'f' } });
            teclado.Add(new Tecla { Numero = 4, Letra = new List<char> { 'g', 'h', 'i' } });
            teclado.Add(new Tecla { Numero = 5, Letra = new List<char> { 'j', 'k', 'l' } });
            teclado.Add(new Tecla { Numero = 6, Letra = new List<char> { 'm', 'n', 'o' } });
            teclado.Add(new Tecla { Numero = 7, Letra = new List<char> { 'p', 'q', 'r', 's' } });
            teclado.Add(new Tecla { Numero = 8, Letra = new List<char> { 't', 'u', 'v', } });
            teclado.Add(new Tecla { Numero = 9, Letra = new List<char> { 'w', 'x', 'y', 'z' } });


            Console.Write("escriba una palabra");
            string palabra =Console.ReadLine();

            string resultado = string.Empty;
            int numeroAnterior = 0;
            
                foreach (var letra in palabra.ToCharArray())
                {
                    var tecla = teclado.Where(t => t.Letra.Contains(letra)).FirstOrDefault();

                    if (numeroAnterior == tecla.Numero)
                    {
                        resultado += ' ';
                    }
                    else
                    {
                        numeroAnterior = tecla.Numero;
                    }
                    var index = tecla.Letra.FindIndex(l => l == letra);
                    for (int i = 0; i < (index + 1); i++)
                    {
                        resultado += tecla.Numero.ToString();
                    }

                }
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
    class Tecla
    {
        public List<char> Letra { get; set; }
        public int Numero { get; set; }
    }
}
