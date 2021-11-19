package com.alura.bytebank;

public class TestaSemCliente {
    public static void main(String[] args) {
        Conta contaDoMurilo = new Conta();
        System.out.println(contaDoMurilo.getSaldo());

        contaDoMurilo.titular = new Cliente();
        System.out.println(contaDoMurilo.titular);

        contaDoMurilo.titular.nome = "Murilo";
        System.out.println(contaDoMurilo.titular.nome);
    }
}
