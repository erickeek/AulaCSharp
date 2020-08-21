using System;
using System.Linq;
using AulaCSharp.Context;
using AulaCSharp.Context.Models;

namespace AulaCSharp.Projeto.Helpers
{
    public static class AlbumHelper
    {
        public static Album RecuperarAlbum(this AulaContext context, string enunciado)
        {
            foreach (var item in context.Albuns)
            {
                Console.WriteLine(item);
            }

            Album album;
            do
            {
                var id = ConsoleHelper.SolicitarNumero(enunciado);
                album = context.Albuns.FirstOrDefault(q => q.Id == id);

                if (album == null) Console.WriteLine("Esse album não existe!");

            } while (album == null);

            return album;
        }
    }
}
