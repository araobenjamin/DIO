using System;
using BankTransfer.Entidades;
using BankTransfer.Enums;
using BankTransfer.Repositorios;

namespace BankTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancariaRepo contasRepo = new ContaBancariaRepo();
            Aplicacao app = new Aplicacao(contasRepo);
            app.Principal();
        }
    }
}
