package com.alura.JavaJREJDK.EscrevaSeuPrimeiroCodigo.SintaxeVariaveisFluxo;

import java.util.Scanner;

public class TesteIR {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double salario = scanner.nextDouble();

        if (salario >= 1900 && salario <= 2800) {
            System.out.println("A sua aliquota é de 7%");
            System.out.println("Você pode deduzir até R$ 142");
        } else if (salario > 2800 && salario <= 3750) {
            System.out.println("A sua aliquota é de 15%");
            System.out.println("Você pode deduzir até R$ 350");
        } else if (salario > 3750 && salario <= 4664) {
            System.out.println("A sua aliquota é de 22,5%");
            System.out.println("Você pode deduzir até R$ 636");
        }
    }
}
