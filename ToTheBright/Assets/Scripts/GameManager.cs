using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public GameObject GameUI;
    //public GameObject PauseUI;
    //public bool isPaused = false;
<<<<<<< HEAD
<<<<<<< HEAD
    //public KeybindsManager keybinds;

    public static GameManager instance;
=======
    public static GameManager instance;
    public KeybindsManager keybinds;
>>>>>>> abc5b3e763af3336dadd2955efe2de0cd614c38f
=======
    public static GameManager instance;
    public KeybindsManager keybinds;
>>>>>>> abc5b3e763af3336dadd2955efe2de0cd614c38f
    public DialogueManager dialogueManager;
    public GameObject gameUI;

    public GameObject a;

    public int itemCounter;
    public int totalCounter;

    private GameObject go;

    public List<string> Inventory = new List<string>();

<<<<<<< Updated upstream
    public string LastLevelPlayed;
=======
    public Dictionary<string, KeyCode> dictionary = new Dictionary<string, KeyCode>();

    //public string LastLevel
>>>>>>> Stashed changes


    private void Start()
    {
        LastLevelPlayed = "Level01";
        totalCounter = 5;
        //gameUI = GetComponentInChildren<Canvas>();
        UpdateCounter();
        //UpdateTotal();
        gameUI.SetActive(false);
    }
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

    public void UpdateTotal()
    {
        totalCounter = FindObjectOfType<NewFragmentInteraction>().neededFragments.Count;

        //Debug.Log(totalCounter);
        gameUI.GetComponentInChildren<Image>().transform.Find("Total").GetComponent<Text>().text = "/" + totalCounter;
    }
    public void UpdateCounter()
    {
        // gameUI.transform.Find("Num").GetComponent<Text>().text = "x0" + itemCounter;
        gameUI.GetComponentInChildren<Image>().transform.Find("Num1").GetComponent<Text>().text="x"+itemCounter;
    }
   

    // Start is called before the first frame update
    void Start()
    {
        keybinds = GetComponentInChildren<KeybindsManager>();
        dictionary.Add("MoveLeft", KeyCode.A);
        dictionary.Add("MoveRight", KeyCode.D);
        dictionary.Add("Jump", KeyCode.Space);
        dictionary.Add("Dialogue", KeyCode.E);

    }

    // Update is called once per frame

}
