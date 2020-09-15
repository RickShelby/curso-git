using System;
using System.Globalization;
using System.Text;

namespace Serio {
    class Banco {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Deposito { get; private set; }


        public void SetNumero(int numero) {
            Numero = numero;
        }

        public void SetDeposito(double deposito) {
            Deposito = deposito;
        }

        public void SetTitular(string titular) {
            Titular = titular;
        }

        public override string ToString() {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Deposito.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void OperacaoSoma(double deposito) {
            Deposito = Deposito + deposito;
        }

        public void OperacaoSaque(double deposito) {
            Deposito = Deposito - deposito - 5;
        }


    }
}
