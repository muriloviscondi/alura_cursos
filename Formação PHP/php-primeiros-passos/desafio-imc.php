<?php

$peso = 45.5;
$altura = 1.68;

$imc = $peso / pow($altura, 2);

echo "IMC = " . round($imc, 2) . PHP_EOL;

if ($imc <= 18.5) {
  echo "Resultado: Abaixo do peso";
} else if ($imc <= 24.9) {
  echo "Resultado: Normal";
} else if ($imc <= 29.9) {
  echo "Resultado: Sobrepeso";
} else {
  echo "Resultado: Obeso";
}
