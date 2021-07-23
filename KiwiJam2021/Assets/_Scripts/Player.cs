using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform leftPos, leftMid, midPos, rightPos, rightMid;
    [SerializeField] private int pos;
    playerInput input;
    private bool capsuleOn = true;
    private bool cubeOn = false;
    private bool rectLong = false;
    private bool rectSmall = false;

    [SerializeField] private GameObject capsule, cube;

    //0 = left, 1 = mid, 2 = right
    private void Awake()
    {
        input = GetComponent<playerInput>();
    }
    private void Start()
    {
        resetBools();
        capsuleOn = true;
    }
    void Update()
    {
        PlayerInputs();
        MoveCharacter();

        if (capsuleOn)
        {
            resetMesh();
            capsule.SetActive(true);
        }
        if (cubeOn)
        {
            resetMesh();
            cube.SetActive(true);
        }
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

        if (Input.GetKey(KeyCode.A))
        {
            resetBools();
            capsuleOn = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            resetBools();
            cubeOn = true;
        }
    }
    
    private void MoveCharacter()
    {
        switch (pos)
        {
            case -1:
                transform.position = new Vector3(leftPos.position.x, leftPos.position.y ,0);
                break;
            case 0:
                transform.position = new Vector3(midPos.position.x, midPos.position.y, 0);
                break;
            case 1:
                transform.position = new Vector3(rightPos.position.x, rightPos.position.y, 0);
                break;
        }
    }
    private void resetBools()
    {
        capsuleOn = false;
        cubeOn = false;
        rectLong = false;
        rectSmall = false;
    }
    private void resetMesh()
    {
        capsule.SetActive(false);
        cube.SetActive(false);
    }
}
