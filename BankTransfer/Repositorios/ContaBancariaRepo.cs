using System;
using System.Collections.Generic;
using System.Linq;
using BankTransfer.Entidades;
using BankTransfer.Enums;
using BankTransfer.DTO;

namespace BankTransfer.Repositorios
{
    public class ContaBancariaRepo : IRepositorio
    {
        private List<ContaBancaria> lista = new ();

        public ContaBancariaRepo()
        {
            // TODO - Buscar contas de repositório persistente
        }

        public Boolean Adicionar(IDTO dto)
        {
            if (lista.Exists(c => c.Id == dto.Id))
            {
                System.Console.WriteLine("Numero de conta já existe.");
                return false;
            }

            if (dto is ContaBancariaDTO contaDTO)
            {
                ContaBancaria conta = new ContaBancaria(contaDTO.NomePessoa, contaDTO.Id, contaDTO.TipoPessoa, contaDTO.Saldo, contaDTO.Credito);
                lista.Add(conta);
                return true;
            }

            throw new ArgumentOutOfRangeException("Argumento precisa ser um ContaBancariaDTO");
        }

        public IEnumerable<IEntidade> Listar() =>
            new List<ContaBancaria>(lista);

        public IEntidade Buscar(String id)
        {
            ContaBancaria conta = lista.FirstOrDefault(c => c.Id == id);

            return conta;
        }

        public Boolean ExisteId(String id)
        {
            return lista.Exists(c => c.Id == id);
        }
    }
}