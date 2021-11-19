package com.alura.bytebank;

public class Testa {
    public static void main(String[] args) {
        Cliente murilo = new Cliente("Murilo Viscondi", "222-222-222-22", "Desenvolvedor");
        Conta contaMurilo = new Conta(0, 1337, 587921, murilo);
        System.out.println(contaMurilo.getTitular().getNome());

        Cliente telma = new Cliente("Telma Viscondi", "333-333-333-33", "Administrativo");
        Conta contaTelma = new Conta(0, 1337, 587921, telma);
        System.out.println(contaTelma.getTitular().getNome());

        Cliente lavinia = new Cliente("Lavinia Viscondi", "444-444-444-44", "Estudante");
        Conta contaLavinia = new Conta(0, 1337, 587921, lavinia);
        System.out.println(contaLavinia.getTitular().getNome());

        System.out.println("Total de contas: " + Conta.getTotalContas());
    }
}
