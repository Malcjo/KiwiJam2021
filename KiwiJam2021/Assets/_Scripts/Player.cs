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

    [SerializeField] GameObject[] groupPoses;
    [SerializeField] Animator anim;

    private void Start()
    {
        //groupPoses[0].SetActive(true);
    }
    void Update()
    {
        anim.SetTrigger("IPose");
        setPosInput();
        MoveCharacter();
        PlayerInputs();


    }
    private void SetPose(int obj, bool onOff)
    {
        groupPoses[obj].SetActive(onOff);
    }
    private void PlayerInputs()
    {
        resetMesh();
        int keyNumber;
        if (Input.GetKey(KeyCode.A))
        {
            //keyNumber = (int)keys.A;
            //SetPose(keyNumber, true);
        }
        if (Input.GetKey(KeyCode.B))
        {
            //keyNumber = (int)keys.B;
            //SetPose(keyNumber, true);
        }
        if (Input.GetKey(KeyCode.C))
        {

        }
        if (Input.GetKey(KeyCode.D))
        {

        }
        if (Input.GetKey(KeyCode.E))
        {

        }
        if (Input.GetKey(KeyCode.F))
        {

        }
        if (Input.GetKey(KeyCode.G))
        {

        }
        if (Input.GetKey(KeyCode.H))
        {

        }
        if (Input.GetKey(KeyCode.I))
        {
            anim.SetTrigger("IPose");
        }
        if (Input.GetKey(KeyCode.J))
        {

        }
        if (Input.GetKey(KeyCode.K))
        {

        }
        if (Input.GetKey(KeyCode.L))
        {

        }
        if (Input.GetKey(KeyCode.M))
        {

        }
        if (Input.GetKey(KeyCode.N))
        {
            anim.SetTrigger("NPose");

        }
        if (Input.GetKey(KeyCode.O))
        {

        }
        if (Input.GetKey(KeyCode.P))
        {

        }
        if (Input.GetKey(KeyCode.Q))
        {

        }
        if (Input.GetKey(KeyCode.R))
        {

        }
        if (Input.GetKey(KeyCode.S))
        {

        }
        if (Input.GetKey(KeyCode.T))
        {
            anim.SetTrigger("TPose");

        }
        if (Input.GetKey(KeyCode.U))
        {

        }
        if (Input.GetKey(KeyCode.V))
        {

        }
        if (Input.GetKey(KeyCode.W))
        {

        }
        if (Input.GetKey(KeyCode.X))
        {

        }
        if (Input.GetKey(KeyCode.Y))
        {

        }
        if (Input.GetKey(KeyCode.Z))
        {

        }

        foreach (KeyCode vKey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKey(vKey))
            {


                switch (vKey)
                {
                    case KeyCode.A:

                        break;
                    case KeyCode.B:

                        break;
                    case KeyCode.C:
                        keyNumber = (int)keys.C;
                        SetPose(keyNumber, true);
                        break;
                    case KeyCode.D:
                        keyNumber = (int)keys.D;
                        SetPose(keyNumber, true);
                        break;
                    case KeyCode.E:
                        SetPose(4, true);
                        break;
                    case KeyCode.F:
                        SetPose(5, true);
                        break;
                    case KeyCode.G:
                        break;
                    case KeyCode.H:
                        break;
                    case KeyCode.I:
                        break;
                    case KeyCode.J:
                        break;
                    case KeyCode.K:
                        break;
                    case KeyCode.L:
                        break;
                    case KeyCode.M:
                        break;
                    case KeyCode.N:
                        break;
                    case KeyCode.O:
                        break;
                    case KeyCode.P:
                        break;
                    case KeyCode.Q:
                        break;
                    case KeyCode.R:
                        break;
                    case KeyCode.S:
                        break;
                    case KeyCode.T:
                        break;
                    case KeyCode.U:
                        break;
                    case KeyCode.V:
                        break;
                    case KeyCode.W:
                        break;
                    case KeyCode.X:
                        break;
                    case KeyCode.Y:
                        break;
                    case KeyCode.Z:
                        break;
                }
            }
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
    private void resetMesh()
    {
        foreach(GameObject poses in groupPoses)
        {
            poses.SetActive(false);
        }
    }
}
