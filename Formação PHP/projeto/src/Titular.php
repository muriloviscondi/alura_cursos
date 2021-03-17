<?php

class Titular
{
  private Documento $documento;
  private string $nome;

  public function __construct(Documento $documento, string $nome)
  {
    $this->documento = $documento;
    $this->validaNomeTitular($nome);
    $this->nomeTitular = $nome;
  }

  public function recuperaCpf(): string
  {
    return $this->documento->recuperaCpf();
  }

  public function recuperaNome(): string
  {
    return $this->nome;
  }

  private function validaNomeTitular(string $nomeTitular)
  {
    if (strlen($nomeTitular) < 5) {
      echo "Nome precisa ter pelo menos 5 caracteres";
      exit();
    }
  }
}
