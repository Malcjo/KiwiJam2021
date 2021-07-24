using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ToonyColorsPro;
using ToonyColorsPro.ShaderGenerator;

public class ToonTest : MonoBehaviour
{
    
    [SerializeField] Renderer test;
    // Start is called before the first frame update
    void Start()
    {
        test.material.SetVector("_BaseMap_SC", new Vector4(0.01f, 0, 0, 0));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
