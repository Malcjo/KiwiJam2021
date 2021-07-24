using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField] private bool entrance = true;
    private int fallSpeed;
    [SerializeField] private int speed;
    private bool reset = true;
    [SerializeField] GameObject[] trippleWallType;
    [SerializeField] GameObject[] singleWallType;
    [SerializeField] bool trippleMovement;
    bool hasSpawned = false;
    [SerializeField] float counter;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        speed = WallSpawner.TrainSpeed;
        fallSpeed = 2500;
    }
    private void Update()
    {
        counter += 1 * Time.deltaTime;
        if (!hasSpawned)
        {
            if (counter > 0.1f)
            {
                if (trippleMovement)
                {
                    int tripRand = Random.Range(0, trippleWallType.Length - 1);
                    GameObject wall = Instantiate(trippleWallType[tripRand], new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
                    hasSpawned = true;
                }
                else
                {
                    int singRand = Random.Range(0, singleWallType.Length - 1);
                    Instantiate(singleWallType[singRand], new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
                    hasSpawned = true;
                }
            }
        }
    }
    private void FixedUpdate()
    {
        if(transform.position.y <= 8f)
        {
            resetHeight();
            entrance = false;
            fallSpeed = 0;
        }
        if (entrance)
        {
            print("falling");
            rb.velocity = new Vector3(0, -fallSpeed, -speed) * Time.deltaTime;
        }
        else
        {
            print("not falling");
            rb.velocity = new Vector3(0, 0, -speed) * Time.deltaTime;
        }
    }
    private void resetHeight()
    {
        if (reset)
        {
            reset = false;
            transform.position = new Vector3(transform.position.x, 8, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroy"))
        {
            Destroy(this.gameObject);
        }
    }
}
