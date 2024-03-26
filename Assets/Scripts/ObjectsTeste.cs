using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsTeste : MonoBehaviour
{
    private void Start()
    {
        //Recebe(3);
        Recebe("batata");
    }

    public void Recebe(object i) 
    {
        //int a = (int)i;
        string a = (string)i;
        Debug.Log(a);
    }
}
