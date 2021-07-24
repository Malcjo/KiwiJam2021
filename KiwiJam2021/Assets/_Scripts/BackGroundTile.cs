using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundTile : MonoBehaviour
{
    [SerializeField] GameObject[] tile;
    [SerializeField] Transform spawnPoint;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPoint = GameObject.FindGameObjectWithTag("TileSpawnPoint").transform;
    }
    private void FixedUpdate()
    {
        rb.velocity = (-Vector3.forward * 300) * Time.deltaTime;
        //transform.position -= new Vector3 (0,0,15f) * Time.deltaTime;
        if(this.gameObject.transform.position.z <= -10)
        {
            int random = Random.Range(0, tile.Length);
            Instantiate(tile[random], spawnPoint.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
    
}
