using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroy"))
        {
            Destroy(this.gameObject);
        }
        if (other.CompareTag("HitBox"))
        {
            other.GetComponentInParent<Player>().Dead();
        }
    }
}
