using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainShake : MonoBehaviour
{
    [SerializeField] float speed = 1.0f; //how fast it shakes
    [SerializeField] float amount = 0.1f; //how much it shakes
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, (Mathf.Sin(speed * Time.deltaTime) * amount) -2.5f, transform.position.z);
    }
}
