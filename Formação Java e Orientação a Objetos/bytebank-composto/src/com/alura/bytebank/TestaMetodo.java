package com.alura.bytebank;

public class TestaMetodo {
    public static void main(String[] args) {
       Cliente murilo = new Cliente();
       murilo.nome = "Murilo Viscondi";
       murilo.cpf = "222.222.222-22";
       murilo.profissao = "Programador";

       Conta contaDoMurilo = new Conta();

       contaDoMurilo.deposita(100);

       contaDoMurilo.titular = murilo;

        System.out.println(contaDoMurilo.titular.nome);
    }
}
