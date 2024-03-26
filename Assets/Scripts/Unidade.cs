using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Unidade : MonoBehaviour
{
    public Unidade()
    {
        job = new Job();
    }
    public Job job;

    void Start()
    {
        Unidade unidade = this;
        Skill bolaDeFogo = new Skill();
        Skill raio = new Skill();
        bolaDeFogo.nome = "Bola de fogo";
        raio.nome = "Raio";

        //SEU CÓDIGO AQUI DA TAREFA 1:
        unidade.job.skills.Add(bolaDeFogo);
        Debug.Log(unidade.job.skills[0].nome);
        //

        //SEU CÓDIGO DA TAREFA 2 AQUI
        unidade.job.skills.Add(raio);
        Debug.Log(unidade.job.skills[1].nome);
        //
    }


}

public class Job
{
    public Job()
    {
        skills = new List<Skill>();
    }
    public List<Skill> skills;
}

public class Skill
{
    public Skill() 
    {
        Debug.Log("Novo skill criado!");
    }

    public string nome;
    //public string frase;
}
