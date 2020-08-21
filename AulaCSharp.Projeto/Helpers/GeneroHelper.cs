using System;
using System.Linq;
using AulaCSharp.Context;
using AulaCSharp.Context.Models;

namespace AulaCSharp.Projeto.Helpers
{
    public static class GeneroHelper
    {
        public static Genero RecuperarGenero(this AulaContext context, string enunciado)
        {
            foreach (var a in context.Generos)
            {
                Console.WriteLine(a);
            }

            Genero genero;
            do
            {
                var id = ConsoleHelper.SolicitarNumero(enunciado);
                genero = context.Generos.FirstOrDefault(q => q.Id == id);

                if (genero == null) Console.WriteLine("Esse genero não existe!");

            } while (genero == null);

            return genero;
        }
    }
}