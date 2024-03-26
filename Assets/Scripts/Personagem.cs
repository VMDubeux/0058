using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public Perna perna;
    public Perna perna2;

    void Start()
    {
        //primeiro exerc�cio - percorrer lista de dedos na primeira inicializa��o do GameObject e
        //caso for o ded�o, printar o nome no console, bem como informar a posi��o que o encontrou.

        for (int i = 0; i < perna.dedos.Count; i++) 
        {
            if (perna.dedos[i].gameObject.name == "Ded�o") 
            {
                print($"O nome �: {perna.dedos[i].gameObject.name} e sua posi��o � a: {i}.");
            }
        }
    }

    void Update()
    {
        
    }
}
