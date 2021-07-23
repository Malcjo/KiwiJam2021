using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform leftPos, leftMid, midPos, rightPos, rightMid;
    [SerializeField] private int pos;
    playerInput input;
    //0 = left, 1 = mid, 2 = right
    private void Awake()
    {
        input = GetComponent<playerInput>();
    }

    void Update()
    {
        PlayerInputs();
        MoveCharacter();
    }

    private void PlayerInputs()
    {
        pos += input.getInput();
        if(pos < -1)
        {
            pos = -1;
        }
        if(pos > 1)
        {
            pos = 1;
        }
    }
    
    private void MoveCharacter()
    {
        float counter;
        switch (pos)
        {
            case -1:
                transform.position = new Vector3(leftPos.position.x, 0 ,0);
                break;
            case 0:
                transform.position = new Vector3(midPos.position.x, 0, 0);
                break;
            case 1:
                transform.position = new Vector3(rightPos.position.x, 0, 0);
                break;
        }
    }
}
