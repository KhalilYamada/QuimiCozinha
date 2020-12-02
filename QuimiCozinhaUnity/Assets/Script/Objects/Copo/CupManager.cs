using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
    public bool[] correct;

    [HideInInspector]
    private bool canActivate = true;

    [SerializeField]
    private GameObject nextScreenButton;


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
        if ((correct[0] == true && correct[1] == true && correct[2] == true) && canActivate == true)
        {
            nextScreenButton.SetActive(true);
            canActivate = false;
        }
    }

    public void NextScreen()
    {
        SceneManager.LoadScene(3);
    }

}