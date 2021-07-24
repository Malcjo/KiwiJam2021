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
    WallController controller;
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
        if (transform.position.y <= 5.75f)
        {
            resetHeight();
            entrace = false;
            fallSpeed = 0;
        }
        if (entrace)
        {
            rb.velocity = new Vector3(0, -fallSpeed, -speed) * Time.deltaTime;
        }
        else
        {
            rb.velocity = new Vector3(0, 0, -speed) * Time.deltaTime;
        }
    }
    public void SetUpController(WallController wallController)
    {
        controller = wallController;
    }
    private void resetHeight()
    {
        if (reset)
        {
            reset = false;
            transform.position = new Vector3(transform.position.x, 5.75f, transform.position.z);
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
