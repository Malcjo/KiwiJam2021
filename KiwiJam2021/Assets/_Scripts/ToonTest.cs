using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ToonyColorsPro;

public class ToonTest : MonoBehaviour
{
    [SerializeField] Renderer test;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        test.material.SetVector("_BaseMap_SC", new Vector4(GameManager.Instance.tileSpeed, 0, 0, 0));
    }
}
