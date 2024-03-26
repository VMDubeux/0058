using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidade_4 : MonoBehaviour
{
    private string _nivelDificuldade = "Difícil";
    public string nivelDificuldade { 
        get { return _nivelDificuldade; } 
        set { if (_nivelDificuldade != value) Debug.Log($"Mudou para: {value}"); } 
    }

    public Unidade_4()
    {
        job = new Job_4();
    }
    public Job_4 job;

    void Start()
    {
        Unidade_4 unidade = this;
        
        //SEU CÓDIGO AQUI DA TAREFA 1:
        Skill_4 bolaDeFogo = new ();
        Skill_4.nome = "Bola de fogo";
        unidade.job.skills.Add(bolaDeFogo);

        //Debug.Log(unidade.job.skills[0].nome);
        //

        //SEU CÓDIGO DA TAREFA 2 AQUI
        Skill_4 raio = new Skill_4();
        Skill_4.nome = "Raio";
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
        Opcoes_2.MudarNivel("Fácil");
    }


}

public class Job_4
{
    public Job_4()
    {
        skills = new List<Skill_4>();
    }
    public List<Skill_4> skills;
}

public class Skill_4
{
    //SEU CÓDIGO DA TAREFA 2 AQUI
    public Skill_4()
    {
        //Debug.Log("novo skill criado");
    }
    //
    public static string nome; //TAREFA 3, MUDE AQUI PARA ESTÁTICO
}

