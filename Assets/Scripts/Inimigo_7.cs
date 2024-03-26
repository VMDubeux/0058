using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_7 : Atributos_7
{
    public Combate_7 combate = new();

    void Start()
    {
        Ataque(combate.personagens[0]);
    }

    public override void Ataque(Atributos_7 defensor)
    {
        defensor.hp = Mathf.Max(0, defensor.hp - this.str);
        if (defensor.hp > 0) Ataque(combate.personagens[0]);
    }
}
