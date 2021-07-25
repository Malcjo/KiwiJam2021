using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public AudioSource SFX1;
    public AudioSource SFX2;
    public AudioSource SFX3;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "HitBox")
        {
            SFX1.Play();
            SFX2.Play();
            SFX3.Play();
        }
    }
}
