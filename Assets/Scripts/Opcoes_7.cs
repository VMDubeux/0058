using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Opcoes_7
{
    static string _nivelDeDificuldade = "hard";
    public static string nivelDeDificuldade
    {
        set
        {
            Debug.Log("Dificuldade mudou para " + value);
            _nivelDeDificuldade = value;
        }
        get
        {
            return _nivelDeDificuldade;
        }
    }
}
