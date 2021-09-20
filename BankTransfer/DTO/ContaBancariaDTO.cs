using System;
using BankTransfer.Enums;

namespace BankTransfer.DTO
{
    // public record ContaBancariaDTO(String NomePessoa, TipoPessoa TipoPessoa, Int32 NumeroConta, Decimal Saldo, Decimal Credito);

    public record ContaBancariaDTO : IDTO
    {
        public String NomePessoa { get; init; }
        public TipoPessoa TipoPessoa { get; init; }
        public String Id { get; init; }
        public Decimal Saldo { get; init; }
        public Decimal Credito { get; init; }
    }
}