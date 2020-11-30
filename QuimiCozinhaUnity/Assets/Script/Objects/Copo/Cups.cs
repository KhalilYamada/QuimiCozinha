using UnityEngine;
using System.Collections;

public class Cups : MonoBehaviour
{


    /// <summary>
    /// 
    /// Define o que será colocado no copo
    /// 
    /// </summary>


    //Referência do CupManager
    [SerializeField]
    public CupManager cupManagerScript;

    //Necessário definir no inspector o número de cada copo sendo eles 1 / 2 / 3 dependendo do elemento que for colocado inicialmente
    [SerializeField]
    public int whichCup;

    //Sprites de ingredientes básicos que serão incluídos em cada copo
    [SerializeField]
    private Sprite[] baseCup;

    //Associar o sprite renderer do copo
    [SerializeField]
    private SpriteRenderer myCupSprite;

    //Array com todas as possíveis imagens de combinação
    //Lembrar de colocar as imagens de misturas na ordem correta levando em consideração as combinações de copos
    [SerializeField]
    private Sprite[] mixedCups;

    //Entregar o valor da combinação atual
    [HideInInspector]
    public int expResult;

    //Deve ficar ligada quando um ingrediente for misturado
    private bool dirtyCup = false;


    void Start()
    {
        myCupSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ingredient") && dirtyCup == false)
        {
            other.GetComponent<ClickAndDrag>().isBeingHeld = false;
            MixIngredients(other.GetComponent<Sample>().whichSample);
        }
    }


    //Reseta o sprite do copo para o original
    public void BaseCup()
    {
        myCupSprite.sprite = baseCup[whichCup - 1];
        dirtyCup = false;
    }


    //Funcao que muda a cor do copo e chama o código responsável pela verificação da combinação correta
    public void MixIngredients(int ingrediente)
    {
        Debug.Log((ingrediente + ((whichCup * 3) - 3)) - 1);
        myCupSprite.sprite = mixedCups[(ingrediente + ((whichCup * 3) - 3)) - 1];
        dirtyCup = true;
        expResult = (ingrediente + ((whichCup * 3) - 3)) - 1;

        cupManagerScript.AnalyzingData(); //Verifica a combinação correta
    }
}