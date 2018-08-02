using System;
using System.Data;
using System.Runtime.CompilerServices;

namespace FluentApi
{
    public class Voo
    {
        string _origem;
        string _destinacao;
        DateTime _data;

        public int VooId { get; private set; }

        public Voo(int id)
        {
            this.VooId = id;
        }
        
        public static Voo CriarVoo(int id)
        {
            return new Voo(id);
        }

        public Voo Origem(string origem)
        {
            this._origem = origem;
            return this;
        }

        public Voo Destinacao(string destinacao)
        {
            this._destinacao = destinacao;
            return this;
        }

        public Voo Quando(DateTime data)
        {
            this._data = data;
            return this;
        }

        public int Duracao(int horas)
        {
            return horas;
        }
    }
}