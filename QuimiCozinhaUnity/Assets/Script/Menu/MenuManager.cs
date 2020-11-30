using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    /// <summary>
    /// 
    /// Script para fazer a transição de telas
    /// 
    /// </summary>


    //Associar os valores de cada cena nos botões
    public void ScreenTransition(int whichScreen)
    {
        SceneManager.LoadScene(whichScreen);
    }
}