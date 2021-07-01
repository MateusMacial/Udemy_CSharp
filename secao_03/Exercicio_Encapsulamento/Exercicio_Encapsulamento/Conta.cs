using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Encapsulamento
{
    class Conta
    {
        private double _saldo;
        public int NumeroConta { private set; get; }
        public string Titular { set; get; }

        public Conta()
        {

        }

        public Conta(int NumeroConta, string Titular, double Saldo)
        {
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
            _saldo = Saldo;
        }

        public Conta(int NumeroConta, string Titular)
        {
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
        }

        public double Saldo
        {
            get { return _saldo; }
        }

        public void Deposito( double Valor)
        {
            this._saldo += Valor;
        }

        public void Saque( double Valor)
        {
            this._saldo -= (Valor + 5);
        }

        public override string ToString()
        {
            return Titular + ", " + NumeroConta + ", $" + _saldo.ToString("F2");
        }

    }
}
