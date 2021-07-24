using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInput : MonoBehaviour
{
    public string PlayerPose(string previous)
    {
        if (Input.GetKey(KeyCode.A))
        {
            return "APose";
        }
        if (Input.GetKey(KeyCode.B))
        {
            return "BPose";
        }
        if (Input.GetKey(KeyCode.C))
        {
            return "CPose";
        }
        if (Input.GetKey(KeyCode.D))
        {
            return "DPose";
        }
        if (Input.GetKey(KeyCode.E))
        {
            return "EPose";
        }
        if (Input.GetKey(KeyCode.F))
        {
            return "FPose";
        }
        if (Input.GetKey(KeyCode.G))
        {
            return "GPose";
        }
        if (Input.GetKey(KeyCode.H))
        {
            return "HPose";
        }
        if (Input.GetKey(KeyCode.I))
        {
            return "IPose";
        }
        if (Input.GetKey(KeyCode.J))
        {
            return "JPose";
        }
        if (Input.GetKey(KeyCode.K))
        {
            return "KPose";
        }
        if (Input.GetKey(KeyCode.L))
        {
            return "LPose";
        }
        if (Input.GetKey(KeyCode.M))
        {
            return "MPose";
        }
        if (Input.GetKey(KeyCode.N))
        {
            return "NPose";
        }
        if (Input.GetKey(KeyCode.O))
        {
            return "OPose";
        }
        if (Input.GetKey(KeyCode.P))
        {
            return "PPOse";
        }
        if (Input.GetKey(KeyCode.Q))
        {
            return "QPose";
        }
        if (Input.GetKey(KeyCode.R))
        {
            return "RPose";
        }
        if (Input.GetKey(KeyCode.S))
        {
            return "SPose";
        }
        if (Input.GetKey(KeyCode.T))
        {
            return "TPose";
        }
        if (Input.GetKey(KeyCode.U))
        {
            return "UPose";
        }
        if (Input.GetKey(KeyCode.V))
        {
            return "VPose";
        }
        if (Input.GetKey(KeyCode.W))
        {
            return "WPose";
        }
        if (Input.GetKey(KeyCode.X))
        {
            return "XPose";
        }
        if (Input.GetKey(KeyCode.Y))
        {
            return "YPose";
        }
        if (Input.GetKey(KeyCode.Z))
        {
            return "ZPose";
        }
        return previous;
    }

}
