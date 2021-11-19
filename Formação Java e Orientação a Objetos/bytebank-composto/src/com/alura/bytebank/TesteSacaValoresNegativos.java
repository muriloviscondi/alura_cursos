package com.alura.bytebank;

public class TesteSacaValoresNegativos {
    public static void main(String[] args) {
        Conta novaConta = new Conta();
        novaConta.deposita(100);

        System.out.println(novaConta.saca(200));
        System.out.println(novaConta.getSaldo());
    }
}
