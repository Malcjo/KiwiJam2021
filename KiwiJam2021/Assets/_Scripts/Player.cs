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

    private void Start()
    {
        anim.Play("IPose");
    }
    void Update()
    {
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
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.B))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.C))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.E))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.F))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.G))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.H))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.I))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.J))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.K))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.L))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.M))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.N))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.O))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.P))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.Q))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.R))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.T))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.U))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.V))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.W))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.X))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.Y))
        {
            anim.Play("BPose");
        }
        if (Input.GetKey(KeyCode.Z))
        {
            anim.Play("BPose");
        }
    }

    public void setPosInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            pos -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            pos += 1;
        }

        if (pos < -1)
        {
            pos = -1;
        }
        if (pos > 1)
        {
            pos = 1;
        }
    }

    private void MoveCharacter()
    {
        switch (pos)
        {
            case -1:
                transform.position = new Vector3(leftPos.position.x, leftPos.position.y, 0);
                break;
            case 0:
                transform.position = new Vector3(midPos.position.x, midPos.position.y, 0);
                break;
            case 1:
                transform.position = new Vector3(rightPos.position.x, rightPos.position.y, 0);
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

