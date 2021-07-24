using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] private int trainSpeed;
    [SerializeField] private int spawnFreq;
    public static int TrainSpeed;
    public static int SpawnFrequency;
    [SerializeField] private GameObject wall;
    [SerializeField] private Transform spawnPoint;
    private float counter;
    private void Awake()
    {
        TrainSpeed = trainSpeed;
        SpawnFrequency = spawnFreq;
    }

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
        counter = SpawnFrequency;
        Instantiate(wall, new Vector3(spawnPoint.position.x, spawnPoint.position.y + 100, spawnPoint.position.z), Quaternion.identity);
    }
}