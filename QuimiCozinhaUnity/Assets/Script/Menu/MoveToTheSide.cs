using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveToTheSide : MonoBehaviour
{

    private bool wasClicked = false;
    public Transform lugar;

    float target = 10;

    public void Update()
    {
        if (wasClicked)
        {
            float xPos = Mathf.Lerp(transform.position.x, target, 0.02f);            
            transform.position = new Vector3(xPos, 0.0f, 0.0f);
        }
    }



    public void Move()
    {
        wasClicked = true;
    }
}
