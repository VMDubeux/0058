using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestandoInvoke : MonoBehaviour
{
    void Start()
    {
        TesteInvoke();
        TesteInvoke_2();
        CancelaOsInvoke();
    }

    void TesteInvoke() 
    {
        Debug.Log($"{Time.time} -> Teste 1");
        Invoke("TesteInvoke", 1);
    }
    
    void TesteInvoke_2() 
    {
        Debug.Log($"{Time.time} -> Teste 2");
        Invoke("TesteInvoke_2", 5);
    }

    void CancelaOsInvoke() 
    {
        CancelInvoke("TesteInvoke");
        CancelInvoke("TesteInvoke_2");
        Debug.Log("Cancelar todos os Invokes");
    }
}
