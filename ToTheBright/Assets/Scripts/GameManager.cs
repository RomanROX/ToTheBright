using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject GameUI;
    //public GameObject PauseUI;
    //public bool isPaused = false;
    public static GameManager instance;
    //public KeybindsManager keybinds;
    public DialogueManager dialogueManager;
    public int clock;
    public int book;
    public int hart;

    private GameObject go;

    //public int coins = 0;
    public List<string> Inventory = new List<string>();

    //public string LastLevel

    private void Awake()
    {
        if (instance is null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }

        else
        {
            DestroyImmediate(gameObject);
        }
    }
    // Start is called before the first frame update
    //void Start()
    //{
    //    keybinds = GetComponentInChildren<KeybindsManager>();
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
