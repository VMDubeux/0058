using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public Perna perna;
    public Perna perna2;

    void Start()
    {
        //primeiro exercício - percorrer lista de dedos na primeira inicialização do GameObject e
        //caso for o dedão, printar o nome no console, bem como informar a posição que o encontrou.

        for (int i = 0; i < perna.dedos.Count; i++) 
        {
            if (perna.dedos[i].gameObject.name == "Dedão") 
            {
                print($"O nome é: {perna.dedos[i].gameObject.name} e sua posição é a: {i}.");
            }
        }
    }

    void Update()
    {
        
    }
}
