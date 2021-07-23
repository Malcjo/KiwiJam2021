using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] wallTiles;
    [SerializeField] private Transform spawnPoint;
    private float counter;

    // Update is called once per frame
    void Update()
    {
        counter -= 1 * Time.deltaTime;
        if (counter <= 0)
        {
            SpawnWall();
        }
    }
    private void SpawnWall()
    {
        counter = 8;
        Instantiate(wallTiles[randomTile()], new Vector3(spawnPoint.position.x, spawnPoint.position.y + 100, spawnPoint.position.z), Quaternion.identity);
    }
    private int randomTile()
    {
        return Random.Range(0, wallTiles.Length - 1);
    }
}