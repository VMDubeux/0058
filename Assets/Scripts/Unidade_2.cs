using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidade_2 : MonoBehaviour
{
    public Job_2 job;

    public Unidade_2()
    {
        job = new Job_2();
    }

    void Start()
    {
        Unidade_2 unidade = this;

        //SEU CÓDIGO AQUI DA TAREFA 1:
        Skill_2 bolaDeFogo = new();
        Skill_2.nome = "Bola de fogo";
        unidade.job.skills.Add(bolaDeFogo);
        //

        //SEU CÓDIGO DA TAREFA 2 AQUI
        Skill_2 raio = new();
        Skill_2.nome = "Raio";
        unidade.job.skills.Add(raio);
        //

        //SEU CÓDIGO DA TAREFA 3 AQUI
        for (int i = 0; i < unidade.job.skills.Count; i++)
        {
            print($"{Skill_2.nome}");
        }
        //
    }


}

public class Job_2
{
    public List<Skill_2> skills;

    public Job_2()
    {
        skills = new List<Skill_2>();
    }
}

public class Skill_2
{
    public static string nome; //TAREFA 3, MUDE AQUI PARA ESTÁTICO

    //SEU CÓDIGO DA TAREFA 2 AQUI
    public Skill_2()
    {
        Debug.Log("novo skill criado");
    }
    //
}
