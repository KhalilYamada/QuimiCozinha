using UnityEngine;
using System.Collections;

public class CupManager : MonoBehaviour
{
    /// <summary>
    /// 
    /// Script para controlar a limpesa dos copos e verificar se 
    /// estão com os ingredientes certos
    /// 
    /// </summary>


    //Associar todos os sprites dos copos para poder limpar eventualmente
    [SerializeField]
    private Cups[] cupsScripts;

    //Definir os objetivos que os alunos devem chegar com suas combinações
    [SerializeField]
    private int[] expObjective;

    //Boolean responsável por verificar se os copos estão com a combinação correta
    [SerializeField]
    private bool[] correct;


    //Responsável por resetar as bools que verificam se a experiência teve o resultado correto
    void Start()
    {
        correct = new bool[3];
        for (int i = 0; i < correct.Length; i++)
        {
            correct[i] = false;
        }
    }


    //Deve ser associado a um botão, para que quando este for clicado ele limpe todos os copos
    public void CleanCup()
    {
        for (int i = 0; i < cupsScripts.Length; i++)
        {
            cupsScripts[i].BaseCup();
        }
        for (int i = 0; i < correct.Length; i++)
        {
            correct[i] = false;
        }
    }

    //Funcao para analisar se o jogador acertou as 3 combinações
    //Deve ser chamada sempre que a criança combinar algo novo no copo
    public void AnalyzingData()
    {
        for (int i = 0; i < correct.Length; i++)
        {
            if (expObjective[i] * cupsScripts[i].whichCup == cupsScripts[i].expResult)//Dando erro pq não tenho os outros objetos de copo
            {
                correct[i] = true;
            }
            else
            {
                correct[i] = false;
            }
        }
        if (correct[0] == true && correct[1] == true && correct[2] == true)
        {
            Debug.Log("Passou de Fase");
        }
    }
}