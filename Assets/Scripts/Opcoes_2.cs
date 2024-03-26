using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Opcoes_2
{
    public static void MudarNivel(string nivelDeDificuldade) 
    {
        Unidade_4 unidade = new();
        unidade.nivelDificuldade = nivelDeDificuldade;
    }
}

