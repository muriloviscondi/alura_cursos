package com.alura.bytebank;

public class Conta {
    double saldo;
    int agencia;
    int numero;
    String titular;

    public void deposita(double valor) {
        this.saldo += valor;
    }

    public String saca(double valor) {
        if (this.saldo < valor) {
            return "Saldo insuficiente";
        }

        this.saldo -= valor;
        return "Saque efetuado com sucesso";
    }

    public String transfere(Conta destino, double valor) {
        if (this.saldo < valor) {
            return "Saldo insuficiente";
        }

        this.saca(valor);
        destino.deposita(valor);

        return "Transferência efetuada com sucesso";
    }
}
