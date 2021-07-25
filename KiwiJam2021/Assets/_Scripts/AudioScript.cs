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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HitBox"))
        {
            print("Play Sound");
            SFX1.Play();
            SFX2.Play();
            SFX3.Play();
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "HitBox")
    //    {
    //        print("Play Sound");
    //        SFX1.Play();
    //        SFX2.Play();
    //        SFX3.Play();
    //    }
    //}
}
