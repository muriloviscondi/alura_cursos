<?php

class Documento
{
  private string $cpf;

  public function __construct($cpf)
  {
    $this->validaCpf($cpf);
    $this->cpf = $cpf;
  }

  public function recuperaCpf(): string
  {
    return $this->cpf;
  }

  public function validaCpf($cpf): void
  {
    $cpf = filter_var($cpf, FILTER_VALIDATE_REGEXP, [
      'options' => [
        'regexp' => '/^[0-9]{3}\.[0-9]{3}\.[0-9]{3}\-[0-9]{2}$/'
      ]
    ]);
    if ($cpf === false) {
      echo "Cpf inválido";
      exit();
    }
  }
}
