package com.alura.bytebank;

public class Conta {
    private double saldo;
    private int agencia;
    private int numero;
    private Cliente titular;

    private static int totalContas;

    protected Conta() {
    }

    public Conta(double saldo, int agencia, int numero, Cliente titular) {
        this.saldo = saldo;
        this.agencia = agencia;
        this.numero = numero;
        this.titular = titular;

        Conta.totalContas++;
    }

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

    public double getSaldo() {
        return this.saldo;
    }

    public int getAgencia() {
        return agencia;
    }

    public void setAgencia(int agencia) {
        this.agencia = agencia;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public Cliente getTitular() {
        return titular;
    }

    public void setTitular(Cliente titular) {
        this.titular = titular;
    }

    public static int getTotalContas() {
        return Conta.totalContas;
    }
}
