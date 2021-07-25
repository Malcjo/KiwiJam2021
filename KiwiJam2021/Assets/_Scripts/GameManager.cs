using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public float wallSpeed;
    public float tileSpeed;
    public float treeSpeed;
    public int index = 0;
    public float timer;
    public static int mode;
    [SerializeField] int pubMode;

    private float worldOffset = 100;
    private float tileOffset = 0.00365f;

    private static GameManager _instance;
    public bool inMenu;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        mode = 0;
    }
    [SerializeField] private float counterSet = 10;
    [SerializeField] private float offsetCounter;
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (!inMenu)
            {
                timer += 1 * Time.deltaTime;
                if (timer > counterSet)
                {
                    wallSpeed += worldOffset;
                    treeSpeed += worldOffset;
                    tileSpeed += tileOffset;
                    counterSet = timer + offsetCounter;
                }
            }
        }
        pubMode = mode;
    }
    public void ResetValues()
    {
        timer = 0;
        counterSet = 10;
        wallSpeed = 300;
        treeSpeed = 300;
        tileSpeed = 0.01095f;
    }
}
