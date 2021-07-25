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
        if (rightAnim)
        {
            anim.Play("Run_Right");
        }
        if (leftAnim)
        {
            anim.Play("Run_Left");
        }
    }
    bool rightAnim = false;
    bool leftAnim = false;
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
            anim.Play("B");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.C))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("C");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("D");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("E");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.F))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("F");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.G))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("G");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.H))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("H");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.I))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("I");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.J))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("J");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.K))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("K");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.L))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("L");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.M))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("M");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.N))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("N");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.O))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("O");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.P))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("P");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("Q");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.R))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("R");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("S");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.T))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("T");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.U))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("U");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.V))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("V");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("W");
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
            anim.Play("Y");
            isKeyPressed = true;
            return;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            if (isKeyPressed)
            {
                return;
            }
            anim.Play("Z");
            isKeyPressed = true;
            return;
        }
        if(!rightAnim && !leftAnim)
        {
            anim.Play("IDLE");
            isKeyPressed = false;
        }

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
                    transform.position = new Vector3(leftMid.position.x, leftMid.position.y, leftMid.position.z);
                    leftAnim = true;
                }
                else if (moveCounter <= 0)
                {
                    transform.position = new Vector3(leftPos.position.x, leftPos.position.y, leftPos.position.z);
                    leftAnim = false;
                }
                break;
            case 0:
                switch (previousPos)
                {
                    case -1:
                        if (moveCounter > 0)
                        {
                            transform.position = new Vector3(leftMid.position.x, leftMid.position.y, leftMid.position.z);
                            rightAnim = true;
                        }
                        else if (moveCounter <= 0)
                        {
                            transform.position = new Vector3(midPos.position.x, midPos.position.y, midPos.position.z);
                            rightAnim = false;
                        }
                        break;
                    case 1:
                        if (moveCounter > 0)
                        {
                            transform.position = new Vector3(rightMid.position.x, rightMid.position.y, rightMid.position.z);
                            leftAnim = true;
                        }
                        else if (moveCounter <= 0)
                        {
                            transform.position = new Vector3(midPos.position.x, midPos.position.y, midPos.position.z);
                            leftAnim = false;
                        }
                        break;
                }
                break;
            case 1:
                previousPos = 1;
                if (moveCounter > 0)
                {
                    transform.position = new Vector3(rightMid.position.x, rightMid.position.y, rightMid.position.z);
                    rightAnim = true;
                }
                else if (moveCounter <= 0)
                {
                    transform.position = new Vector3(rightPos.position.x, rightPos.position.y, rightPos.position.z);
                    rightAnim = false;
                }
                break;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            print("Dead");
        }
    }
    public void Dead()
    {
        Destroy(this.gameObject);
    }
}

