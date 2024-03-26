using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Heroi_7 : Atributos_7
{
    public Combate_7 combate = new();

    void Start()
    {
        Ataque(combate.personagens[1]);
    }

    public override void Ataque(Atributos_7 defensor)
    {
        defensor.hp = Mathf.Max(0, defensor.hp - this.str);
        if (defensor.hp > 0) Ataque(combate.personagens[1]);
    }
}
