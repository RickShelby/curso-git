using System;
using System.Collections.Generic;
using System.Text;

namespace Banco {
    class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Quantia { get; private set; }


        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double quantia) : this(numero, titular) {
            Quantia = quantia;
        }

        public override string ToString() {
            return "Conta: "
            + Numero
                + "Titular "
                + Titular
                + "Valor  "
                + Quantia;

        }

        public ContaBancaria(){}

















    }
}
