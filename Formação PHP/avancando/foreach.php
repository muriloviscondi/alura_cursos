<?php

$arrayContas = [
  '123.456.789-10' => [
    'titular' => 'Murilo',
    'saldo' => 1000
  ],
  '123.456.789-11' => [
    'titular' => 'Maria',
    'saldo' => 1000
  ],
  '123.456.789-12' => [
    'titular' => 'Joaquim',
    'saldo' => 1000
  ]
];

$arrayContas['123.456.789-13'] = [
  'titular' => 'Cláudia',
  'saldo' => 1000
];

foreach ($arrayContas as $key => $conta) {
  echo $key . " " . $conta['titular'] . PHP_EOL;
}
