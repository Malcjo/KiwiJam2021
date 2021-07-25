using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holeController : MonoBehaviour
{
    private Rigidbody rb;
    private bool entrace = true;
    private int fallSpeed;
    [SerializeField] private int speed;
    private bool reset = true;
    Transform wall;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        speed = WallSpawner.TrainSpeed;
        fallSpeed = 2500;
    }
    private void FixedUpdate()
    {
        if (transform.position.y <= 0)
        {
            resetHeight();
            entrace = false;
            fallSpeed = 0;
        }
        if (entrace)
        {
            rb.velocity = new Vector3(0, -fallSpeed, -GameManager.Instance.wallSpeed) * Time.deltaTime;
        }
        else
        {
            rb.velocity = new Vector3(0, 0, -GameManager.Instance.wallSpeed) * Time.deltaTime;
        }
    }
    public void SetUpController(GameObject wallController)
    {
        wall = wallController.gameObject.transform;
    }
    private void resetHeight()
    {
        if (reset)
        {
            reset = false;
            transform.position = new Vector3(transform.position.x, 0, wall.transform.position.z);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Destroy"))
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    if (other.CompareTag("HitBox"))
    //    {
    //        other.GetComponentInParent<Player>().Dead();
    //    }
    //}

}
