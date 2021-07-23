using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{

    public int getInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return -1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            return 1;
        }
        return 0;
    }
}
