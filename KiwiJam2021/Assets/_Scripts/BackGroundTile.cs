using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundTile : MonoBehaviour
{
    [SerializeField] GameObject[] tile;
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject manager;
    Rigidbody rb;
    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("TileManager");

        rb = GetComponent<Rigidbody>();
        spawnPoint = GameObject.FindGameObjectWithTag("TileSpawnPoint").transform;
    }
    private void FixedUpdate()
    {
        rb.velocity = (-Vector3.forward * 300) * Time.deltaTime;

    }
    private void Update()
    {
        TileManager tileManager = manager.GetComponent<TileManager>();
        if (this.gameObject.transform.position.z <= -10)
        {
            int random = Random.Range(0, tile.Length);
            //tileManager.SpawnTile();
            Instantiate(tile[random], spawnPoint.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

}
