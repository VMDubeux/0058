using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestandoInvoke_2 : MonoBehaviour
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
        InvokeRepeating(nameof(TesteInvoke), 1.0f, 1.0f);
    }

    void TesteInvoke_2()
    {
        Debug.Log($"{Time.time} -> Teste 2");
        InvokeRepeating(nameof(TesteInvoke_2), 1.0f, 5.0f);
    }

    void CancelaOsInvoke()
    {
        CancelInvoke();
        /*CancelInvoke(nameof(TesteInvoke));
        CancelInvoke(nameof(TesteInvoke_2));*/
        Debug.Log("Cancelar todos os Invokes");
    }
}
