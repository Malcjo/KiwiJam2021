using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int index = 0;
    public float timer;
    public static int mode;
    [SerializeField] int pubMode;
    // Start is called before the first frame update
    void Start()
    {
        mode = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pubMode = mode;
        timer += 1 * Time.deltaTime;
        if(timer > (60 / 10))
        {
            mode = 1;
        }
        else if (timer > 60)
        {
            mode = 2;
        }
    }
}
