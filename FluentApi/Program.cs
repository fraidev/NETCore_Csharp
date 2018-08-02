using System;

namespace FluentApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Voo.CriarVoo(1234).Origem("SP").Destinacao("RJ").Quando(DateTime.Today).Duracao(1);
        }
    }
}
