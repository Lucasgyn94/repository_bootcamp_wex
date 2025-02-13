﻿namespace Dio.Async.Programming;

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }

    public void IncrementarIdade()
    {
        // lock faz executar 1 thread por vez
        lock (this) {
            Idade++;
        }            
    }

    public override string ToString()
    {
        return $"Id: {Id}, Nome: {Nome}, Idade: {Idade}";
    }
}
