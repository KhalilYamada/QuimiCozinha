using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{

    /// <summary>
    /// 
    /// Script responsável por informar qual
    /// ingrediente esse objeto é
    /// 
    /// O "whichSample" NUNCA PODE SER "0" OU 
    /// MAIOR QUE "3"
    /// 
    /// </summary>


    [SerializeField]
    public int whichSample;

    [SerializeField]
    private Sprite[] samplesSprites;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = samplesSprites[whichSample - 1];
    }

}
