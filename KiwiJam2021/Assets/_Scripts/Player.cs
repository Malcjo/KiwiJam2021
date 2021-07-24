using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public enum keys { A, B, C, D}
public class Player : MonoBehaviour
{
    [SerializeField] private Transform leftPos, leftMid, midPos, rightPos, rightMid;
    [SerializeField] private int pos;
    //0 = left, 1 = mid, 2 = right
    [SerializeField] bool tripleMovement;

    [SerializeField] Animator anim;
    private bool isKeyPressed = false;

    private void Start()
    {
        anim.Play("IPose");
    }
    void Update()
    {
        moveCounter -= 1 * Time.deltaTime;
        PlayerInputs();
        if (tripleMovement)
        {
            setPosInput();
            MoveCharacter();
        }
    }

    private void PlayerInputs()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.B))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.C))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.F))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.G))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.H))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.I))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.J))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.K))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.L))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.M))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.N))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.O))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.P))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.R))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.T))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.U))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.V))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.X))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("X");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.Y))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("A");
            isKeyPressed = true;
            return;
        }
        anim.Play("IDLE");
        isKeyPressed = false;
    }

    private int previousPos;
    public void setPosInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos -= 1;
            moveCounter = 0.2f;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos += 1;
            moveCounter = 0.2f;
        }

        if (pos < -1)
        {
            previousPos = -1;
            pos = -1;
        }
        if (pos > 1)
        {
            previousPos = 1;
            pos = 1;
        }

    }
    private float moveCounter;
    private void MoveCharacter()
    {
        switch (pos)
        {
            case -1:
                previousPos = -1;
                if (moveCounter > 0)
                {
                    transform.position = new Vector3(leftMid.position.x, leftMid.position.y, 0);
                }
                else if (moveCounter <= 0)
                {
                    transform.position = new Vector3(leftPos.position.x, leftPos.position.y, 0);
                }
                break;
            case 0:
                switch (previousPos)
                {
                    case -1:
                        if (moveCounter > 0)
                        {
                            transform.position = new Vector3(leftMid.position.x, leftMid.position.y, 0);
                        }
                        else if (moveCounter <= 0)
                        {
                            transform.position = new Vector3(midPos.position.x, midPos.position.y, 0);
                        }
                        break;
                    case 1:
                        if (moveCounter > 0)
                        {
                            transform.position = new Vector3(rightMid.position.x, rightMid.position.y, 0);
                        }
                        else if (moveCounter <= 0)
                        {
                            transform.position = new Vector3(midPos.position.x, midPos.position.y, 0);
                        }
                        break;
                }
                break;
            case 1:
                previousPos = 1;
                if (moveCounter > 0)
                {
                    transform.position = new Vector3(rightMid.position.x, rightMid.position.y, 0);
                }
                else if (moveCounter <= 0)
                {
                    transform.position = new Vector3(rightPos.position.x, rightPos.position.y, 0);
                }
                break;
        }
    }
    //private void resetMesh()
    //{
    //    anim.SetBool("APose", false);
    //    anim.SetBool("BPose", false);
    //    anim.SetBool("CPose", false);
    //    anim.SetBool("DPose", false);
    //    anim.SetBool("EPose", false);
    //    anim.SetBool("FPose", false);
    //    anim.SetBool("GPose", false);
    //    anim.SetBool("HPose", false);
    //    anim.SetBool("IPose", false);
    //    anim.SetBool("JPose", false);
    //    anim.SetBool("KPose", false);
    //    anim.SetBool("LPose", false);
    //    anim.SetBool("MPose", false);
    //    anim.SetBool("NPose", false);
    //    anim.SetBool("OPose", false);
    //    anim.SetBool("PPose", false);
    //    anim.SetBool("QPose", false);
    //    anim.SetBool("RPose", false);
    //    anim.SetBool("SPose", false);
    //    anim.SetBool("TPose", false);
    //    anim.SetBool("UPose", false);
    //    anim.SetBool("VPose", false);
    //    anim.SetBool("WPose", false);
    //    anim.SetBool("XPose", false);
    //    anim.SetBool("YPose", false);
    //    anim.SetBool("ZPose", false);
    //}
}

