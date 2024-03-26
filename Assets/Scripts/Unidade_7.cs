using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidade_7 : MonoBehaviour
{
    public Unidade_7()
    {
        job = new Job_7();
    }
    public Job_7 job;

    void Start()
    {
        Unidade_7 unidade = this;
        Skill_7 bolaDeFogo = new Skill_7();
        Skill_7.nome = "Bola de fogo";

        //SEU CÓDIGO AQUI DA TAREFA 1:
        unidade.job.skills.Add(bolaDeFogo);
        //Debug.Log(unidade.job.skills[0].nome);
        //

        //SEU CÓDIGO DA TAREFA 2 AQUI
        Skill_7 raio = new Skill_7();
        Skill_7.nome = "Raio";
        unidade.job.skills.Add(raio);
        //

        //SEU CÓDIGO DA TAREFA 3 AQUI
        //for(int i=0; i<unidade.job.skills.Count; i++){
        //  Debug.Log(Skill.nome);
        //}
        //

        //SEU CÓDIGO DA TAREFA DE SINGLETON
        //Debug.Log(Opcoes.instance.nivelDeDificuldade);
        //
        Invoke("MudaDificuldade", 2);


    }

    void MudaDificuldade()
    {
        Opcoes_7.nivelDeDificuldade = "Fácil";
    }


}

public class Job_7
{
    public Job_7()
    {
        skills = new List<Skill_7>();
    }
    public List<Skill_7> skills;
}

public class Skill_7
{
    //SEU CÓDIGO DA TAREFA 2 AQUI
    public Skill_7()
    {
        //Debug.Log("novo skill criado");
    }
    //
    public static string nome; //TAREFA 3, MUDE AQUI PARA ESTÁTICO
}
