<?php

$virgula = true;

for ($i = 0; $i < 100; $i++) {
  if ($i % 2 !== 0) {
    if (!$virgula) {
      echo ", $i";
    } else {
      $virgula = false;
      echo $i;
    }
  }
}

echo ".";
