using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Atributos_7 : MonoBehaviour, IAtaque_7
{
    public int str;

    private int _hp = 10;
    public int hp
    {
        get { return _hp; }
        set
        {
            _hp = value;
            Debug.Log($"{gameObject.name}: {_hp}");
        }
    }

    public abstract void Ataque(Atributos_7 defensor);
}