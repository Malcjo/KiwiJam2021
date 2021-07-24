using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    [SerializeField] GameObject[] backGroundTilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLength = 10;
    private int amountTilesOnSceen = 15;
    [SerializeField] Transform spawnPoint;
    [SerializeField] int random;

    void Start()
    {
        startSpawn(0);
        startSpawn(1);
        startSpawn(0);
        startSpawn(1);
        startSpawn(1);
        startSpawn(0);
        startSpawn(0);
        startSpawn(1);
        startSpawn(0);
        startSpawn(1);
        startSpawn(1);
        startSpawn(0);
        //for (int i = 0; i < amountTilesOnSceen; i++)
        //{

        //    SpawnTile();
        //}
    }
    public void SpawnTile(int prefabIndex = -1)
    {
 
        GameObject go;
        go = Instantiate(backGroundTilePrefabs[random]) as GameObject;
        go.transform.SetParent(transform);
        Vector3 newPos = new Vector3(0, 0, 1) * spawnZ;
        newPos = new Vector3(spawnPoint.position.x, spawnPoint.position.y, newPos.z);
        go.transform.position = newPos;
        spawnZ += tileLength;
        random = Random.Range(0, backGroundTilePrefabs.Length - 1);
        //int random = Random.Range(0, backGroundTilePrefabs.Length - 1);
        //Instantiate(backGroundTilePrefabs[random], spawnPoint.transform.position, Quaternion.identity);
    }
    private void startSpawn(int number) 
    {
        GameObject go;
        go = Instantiate(backGroundTilePrefabs[number]) as GameObject;
        go.transform.SetParent(transform);
        Vector3 newPos = new Vector3(0, 0, 1) * spawnZ;
        newPos = new Vector3(spawnPoint.position.x, spawnPoint.position.y, newPos.z);
        go.transform.position = newPos;
        spawnZ += tileLength;
        random = Random.Range(0, backGroundTilePrefabs.Length - 1);
    }

}
