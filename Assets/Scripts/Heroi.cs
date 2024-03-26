using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroi : Atributos
{
    
    public Inimigo inimigo;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(hp);
        inimigo.hp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
