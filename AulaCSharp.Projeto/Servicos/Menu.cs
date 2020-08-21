using AulaCSharp.Projeto.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AulaCSharp.Projeto.Servicos
{
    public class Menu
    {
        private readonly string _enunciado;
        private readonly Dictionary<string, Action> _opcoes = new Dictionary<string, Action>();

        public Menu(string enunciado)
        {
            _enunciado = enunciado;
        }

        protected virtual void Apresentar()
        {
            Console.WriteLine(_enunciado);

            var i = 0;
            foreach (var opcao in _opcoes)
            {
                i++;
                Console.WriteLine($"{i} - {opcao.Key}");
            }
            Console.WriteLine("0 - Sair");
        }

        public void Adicionar(string opcao, Action acao)
        {
            _opcoes.Add(opcao, acao);
        }

        public void Executar()
        {
            do
            {
                Console.Clear();

                Apresentar();
                var indice = ConsoleHelper.SolicitarNumero();

                if (indice == 0) break;

                var opcao = _opcoes.ElementAtOrDefault(indice - 1);
                if (opcao.Key != null)
                {
                    opcao.Value.Invoke();
                }

            } while (true);
        }
    }
}