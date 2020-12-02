using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public void ClosePopUp(GameObject PopUpGO)
    {
        PopUpGO.SetActive(false);
    }
}
