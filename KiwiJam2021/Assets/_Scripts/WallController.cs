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
    [SerializeField] GameObject[] singleMode;
    [SerializeField] GameObject[] doubleMode;
    [SerializeField] GameObject[] tripleMode;
    [SerializeField] GameObject[] singleWallType;
    [SerializeField] bool trippleMovement;
    bool hasSpawned = false;
    [SerializeField] float counter;
    [SerializeField] GameObject gm;
    private void Awake()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
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
                int tripRand = Random.Range(0, singleMode.Length - 1);
                GameObject wall = Instantiate(singleMode[GameManager.index], new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
                wall.GetComponent<holeController>().SetUpController(this.gameObject);
                hasSpawned = true;
                GameManager.index += 1;
                //switch (GameManager.mode)
                //{
                //    case 0:
                //        int tripRand = Random.Range(0, singleMode.Length - 1);
                //        GameObject wall = Instantiate(singleMode[tripRand], new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
                //        wall.GetComponent<holeController>().SetUpController(this.gameObject);
                //        hasSpawned = true;
                //        break;

                //    case 1:
                //        int tripRand2 = Random.Range(0, doubleMode.Length - 1);
                //        GameObject wall2 = Instantiate(doubleMode[tripRand2], new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
                //        wall2.GetComponent<holeController>().SetUpController(this.gameObject);
                //        hasSpawned = true;
                //        break;

                //    case 2:
                //        int tripRand3 = Random.Range(0, tripleMode.Length - 1);
                //        GameObject wall3 = Instantiate(tripleMode[tripRand3], new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
                //        wall3.GetComponent<holeController>().SetUpController(this.gameObject);
                //        hasSpawned = true;
                //        break;

                //}
                //if (trippleMovement)
                //{
                //    int tripRand = Random.Range(0, singleMode.Length - 1);
                //    GameObject wall = Instantiate(singleMode[tripRand], new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
                //    wall.GetComponent<holeController>().SetUpController(this.gameObject);
                //    hasSpawned = true;
                //}
                //else
                //{
                //    int singRand = Random.Range(0, singleWallType.Length - 1);
                //    GameObject wall = Instantiate(singleWallType[singRand], new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
                //    wall.GetComponent<holeController>().SetUpController(this.gameObject);
                //    hasSpawned = true;
                //}
            }
        }
    }
    private void FixedUpdate()
    {
        if(transform.position.y <= 0)
        {
            resetHeight();
            entrance = false;
            fallSpeed = 0;
        }
        if (entrance)
        {
            print("falling");
            rb.velocity = new Vector3(0, -fallSpeed, -GameManager.Instance.wallSpeed) * Time.deltaTime;
        }
        else
        {
            print("not falling");
            rb.velocity = new Vector3(0, 0, -GameManager.Instance.wallSpeed) * Time.deltaTime;
        }
    }
    private void resetHeight()
    {
        if (reset)
        {
            reset = false;
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
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
