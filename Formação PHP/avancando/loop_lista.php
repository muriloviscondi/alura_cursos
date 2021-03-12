<?php

$listaIdade = [10, 20, 30, 10, 80, 55, 47, 18, 72, 65, 5, 6, 48];

$virgula = true;

for ($i = 0; $i < count($listaIdade); $i++) {
  if (!$virgula) {
    echo ", $listaIdade[$i]";
  } else {
    $virgula = false;
    echo $listaIdade[$i];
  }
}

echo ".";
