<?php

function sacar($conta, $valorSaque)
{
  if ($valorSaque > $conta['saldo']) {
    mensagem("Você não pode sacar");
  } else {
    $conta['saldo'] -= $valorSaque;
  }

  return $conta;
};

function depositar($conta, $valorDeposito)
{
  if ($valorDeposito > 0) {
    $conta['saldo'] += $valorDeposito;
  } else {
    mensagem("Depósitos precisam ser positivos");
  }

  return $conta;
};

function mensagem($mensagem)
{
  echo $mensagem . PHP_EOL;
};

function titularComLetrasMaiusculas(&$conta)
{
  $conta['titular'] = mb_strtoupper($conta['titular']);
}

function exibeConta(array $conta)
{
  ['titular' => $titular, 'saldo' => $saldo] = $conta;
  echo "<li>Titular: $titular. Saldo: $saldo</li>";
}
