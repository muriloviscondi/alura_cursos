<?php

require_once 'src/Conta.php';
require_once 'src/Titular.php';
require_once 'src/Documento.php';

$vinicius = new Titular(new Documento('123.456.789-10'), 'Murilo');
$primeiraConta = new Conta($vinicius);
$primeiraConta->deposita(500);
$primeiraConta->saca(300); // isso é ok

echo $primeiraConta->recuperaNomeTitular() . PHP_EOL;
echo $primeiraConta->recuperaCpfTitular() . PHP_EOL;
echo $primeiraConta->recuperaSaldo() . PHP_EOL;

$patricia = new Titular(new Documento('698.549.548-10'), 'Patricia');
$segundaConta = new Conta($patricia);
var_dump($segundaConta);

$outra = new Conta(new Titular(new Documento('123.654.789-01'), 'Abcdefg'));
unset($segundaConta);
echo Conta::recuperaNumeroConta();
