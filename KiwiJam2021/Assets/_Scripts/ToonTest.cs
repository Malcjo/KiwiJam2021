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

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        test.material.SetVector("_BaseMap_SC", new Vector4(0.01f + 1 * Time.deltaTime, 0, 0, 0));
    }
}
