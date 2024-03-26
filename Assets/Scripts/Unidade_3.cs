using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidade_3 : MonoBehaviour
{
    public Unidade_3()
    {
        job = new Job_3();
    }
    public Job_3 job;

    void Start()
    {
        Unidade_3 unidade = this;
        Skill_3 bolaDeFogo = new Skill_3();
        Skill_3.nome = "Bola de fogo";

        //SEU CÓDIGO AQUI DA TAREFA 1:
        unidade.job.skills.Add(bolaDeFogo);
        //Debug.Log(unidade.job.skills[0].nome);
        //

        //SEU CÓDIGO DA TAREFA 2 AQUI
        Skill_3 raio = new Skill_3();
        Skill_3.nome = "Raio";
        unidade.job.skills.Add(raio);
        //

        //SEU CÓDIGO DA TAREFA 3 AQUI
        for (int i = 0; i < unidade.job.skills.Count; i++)
        {
            Debug.Log(Skill_3.nome);
        }
        //

        //SEU CÓDIGO DA TAREFA DE SINGLETON
        Debug.Log(Opcoes.opcoes.nivelDeDificuldade);
        //
    }


}

public class Job_3
{
    public Job_3()
    {
        skills = new List<Skill_3>();
    }
    public List<Skill_3> skills;
}

public class Skill_3
{
    //SEU CÓDIGO DA TAREFA 2 AQUI
    public Skill_3()
    {
        Debug.Log("novo skill criado");
    }
    //
    public static string nome; //TAREFA 3, MUDE AQUI PARA ESTÁTICO
}
