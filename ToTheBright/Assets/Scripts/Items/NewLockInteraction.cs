using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class NewLockInteraction : Interactables
{
    public string keyName;
    public string nextScene;
    

    private void Start()
    {
        GameManager.instance.LastLevelPlayed = SceneManager.GetActiveScene().name;
        GameManager.instance.gameObject.GetComponent<ItemCollector>().CheckAndUpdate();
        gameObject.SetActive(false);
        if (!(SceneManager.GetActiveScene().ToString() == "MainMenu" || SceneManager.GetActiveScene().ToString() == "MainMenuSunVersion" || SceneManager.GetActiveScene().ToString() == "IntroCutscene" || SceneManager.GetActiveScene().ToString() == "OutroScene05"))
        {
            GameManager.instance.UpdateTotal();
        }
    }
    private void Update()
    {
       
        if (GameManager.instance.Inventory.Contains(keyName))
        {
            gameObject.SetActive(true);
            Debug.Log("works");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextScene);
            
            GameManager.instance.itemCounter = 0;
            //GameManager.instance.GetComponent<ItemCollector>().CheckAndUpdate();

            GameManager.instance.UpdateCounter();
        }
    }
}
