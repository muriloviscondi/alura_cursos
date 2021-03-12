<?php

$conta1 = [
  'titular' => 'Murilo',
  'saldo' => 1000
];

$conta2 = [
  'titular' => 'Maria',
  'saldo' => 1000
];

$conta3 = [
  'titular' => 'Joaquim',
  'saldo' => 1000
];

$arrayContas = [$conta1, $conta2, $conta3];

for ($i = 0; $i < count($arrayContas); $i++) {
  echo $arrayContas[$i]['titular'] . PHP_EOL;
}
