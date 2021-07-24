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
    int random;

    void Start()
    {
        for(int i = 0; i < amountTilesOnSceen; i++)
        {
            //random = Random.Range(0, backGroundTilePrefabs.Length - 1);
            SpawnTile();
        }
    }
    public void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(backGroundTilePrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        Vector3 newPos = new Vector3(0, 0, 1) * spawnZ;
        newPos = new Vector3(spawnPoint.position.x, spawnPoint.position.y, newPos.z);
        go.transform.position = newPos;
        spawnZ += tileLength;

        //int random = Random.Range(0, backGroundTilePrefabs.Length - 1);
        //Instantiate(backGroundTilePrefabs[random], spawnPoint.transform.position, Quaternion.identity);
    }
}
