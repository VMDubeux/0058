using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opcoes : MonoBehaviour
{
    public string nivelDeDificuldade = "hard";
    
    //SEU C�DIGO DA TAREFA DE SINGLETON
    public static Opcoes opcoes;
    
    void Start()
    {

        //SEU C�DIGO DA TAREFA DE SINGLETON
        if (opcoes != null)
            Destroy(gameObject);
        opcoes = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}