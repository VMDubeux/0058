using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteCoroutine : MonoBehaviour
{
    Coroutine umaCoroutine;

    private void Start()
    {
        umaCoroutine = StartCoroutine(nameof(Teste_Coroutine));
        Teste_Invoke();
    }

    IEnumerator Teste_Coroutine()
    {
        while (true)
        {
            Debug.Log($"{Time.time} -> Coroutine");
            yield return new WaitForSeconds(1);
        }
    }

    void Teste_Invoke()
    {
        Invoke(nameof(Teste_Invoke), 5);
        Debug.Log($"{Time.time} -> Invoke");
        StopCoroutine(umaCoroutine);
        Debug.Log($"Parar a Coroutine");
    }
}
