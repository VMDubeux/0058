using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ClasseA : MonoBehaviour
{
    public List<ClasseB> listaPersonagem = new();
    public ScriptEnum escolha = new();
    public bool startProcura;
    public bool encontrouProcura;

    public void Update()
    {
        if (startProcura)
        {
            startProcura = false;
            StartCoroutine(procurarLista());
        }
    }

    IEnumerator procurarLista()
    {
        while (!encontrouProcura)
        {
            for (int i = 0; i < listaPersonagem.Count; i++)
            {
                if (listaPersonagem[i].scriptEnum == escolha)
                {
                    encontrouProcura = true;
                    Debug.Log(listaPersonagem[i].scriptEnum);
                    break;
                }
            }
            yield return new WaitForSeconds(1);
        }
        encontrouProcura= false;
    }
}
