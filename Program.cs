using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeUsuario;
            string textoIdadeUsuario;
            bool idadeUsuarioValida;

            Console.Clear();
            Console.WriteLine("--- Doador de sangue");

            Console.Write("Digite sua idade: ");
            textoIdadeUsuario = Console.ReadLine();

            idadeUsuarioValida = int.TryParse(textoIdadeUsuario, out idadeUsuario);

            if (!idadeUsuarioValida)
            {
                Console.WriteLine("Valor inválido");
                Environment.Exit(-1);
            }
            else if (idadeUsuario >= 18 && idadeUsuario <= 67)
            {
                Console.WriteLine("Você pode ser doador de sangue.");
            }
            else if (idadeUsuario < 18)
            {
                Console.WriteLine("Você não pode ser doador de sangue.");
            }
            else if (idadeUsuario > 67)
            {
                Console.WriteLine("Você não pode ser doador de sangue.");
            }
        }
    }
}
