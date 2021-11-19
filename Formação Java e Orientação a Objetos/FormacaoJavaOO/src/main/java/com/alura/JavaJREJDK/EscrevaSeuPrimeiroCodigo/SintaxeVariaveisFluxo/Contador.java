package com.alura.JavaJREJDK.EscrevaSeuPrimeiroCodigo.SintaxeVariaveisFluxo;

public class Contador {
    public static void main(String[] args) {
        int contador = 1;

        while(contador <= 10) {

            System.out.println(contador);
            contador++;
        }

        System.out.println();

        for(int i = 0; i <= 10; i++) {
            System.out.println(i);
        }
    }
}
