using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScreen : MonoBehaviour
{
    //Associar os valores de cada cena nos botões
    public void ScreenTransition(int whichScreen)
    {
        SceneManager.LoadScene(whichScreen);
    }
}