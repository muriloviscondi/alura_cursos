package com.alura.bytebank;

public class TestaMetodo {
    public static void main(String[] args) {
        Conta contaDoMurilo = new Conta();

        contaDoMurilo.saldo = 550;
        contaDoMurilo.deposita(200);
        System.out.println(contaDoMurilo.saldo);

        String saca = contaDoMurilo.saca(10000);
        System.out.println(saca);

        Conta contaDaTelma = new Conta();
        contaDaTelma.deposita(1000);

        String transfere = contaDaTelma.transfere(contaDoMurilo, 500);

        System.out.println(transfere);
        System.out.println(contaDaTelma.saldo);
        System.out.println(contaDoMurilo.saldo);
    }
}
