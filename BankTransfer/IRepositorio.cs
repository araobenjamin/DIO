using System;
using System.Collections.Generic;

namespace BankTransfer
{
    public interface IRepositorio
    {
        IEnumerable<IEntidade> Listar();
        Boolean Adicionar(IDTO entidade);
        IEntidade Buscar(String id);
        Boolean ExisteId(String id);
    }
}