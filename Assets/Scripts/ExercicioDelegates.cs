using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public delegate float delegateTeste_1();
public delegate string delegateTeste_2(object i);

public class ExercicioDelegates : MonoBehaviour
{
    delegateTeste_1 delegateTeste_1_1;
    delegateTeste_2 delegateTeste_2_1;

    private void Start()
    {
        delegateTeste_1_1 += DelegateTeste_1;

        Debug.Log(delegateTeste_1_1);

        delegateTeste_2_1 += DelegateTeste_2;

        Debug.Log(delegateTeste_2_1(delegateTeste_1_1));
    }

    public float DelegateTeste_1()
    {
        return Random.Range(1, 11);
    }

    public string DelegateTeste_2(object i)
    {
        return i.ToString();
    }
}
