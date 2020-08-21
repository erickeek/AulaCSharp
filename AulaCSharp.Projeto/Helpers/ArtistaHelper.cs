using AulaCSharp.Context;
using AulaCSharp.Context.Models;
using System;
using System.Linq;

namespace AulaCSharp.Projeto.Helpers
{
    public static class ArtistaHelper
    {
        public static Artista RecuperarArtista(this AulaContext context, string enunciado)
        {
            foreach (var a in context.Artistas)
            {
                Console.WriteLine(a);
            }

            Artista artista;
            do
            {
                var id = ConsoleHelper.SolicitarNumero(enunciado);
                artista = context.Artistas.FirstOrDefault(q => q.Id == id);

                if (artista == null) Console.WriteLine("Esse artista não existe!");

            } while (artista == null);

            return artista;
        }
    }
}