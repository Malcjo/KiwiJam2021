using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeycodeController : MonoBehaviour
{
    [SerializeField] KeyCode memory;
    [SerializeField] KeyCode lastPressed;
    public float keyholdduration = 0.5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            lastPressed = KeyCode.A;
        else
            lastPressed = KeyCode.Tilde;


        //if tilde 


    }
}
