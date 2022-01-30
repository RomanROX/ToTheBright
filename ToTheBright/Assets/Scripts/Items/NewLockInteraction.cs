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
        gameObject.SetActive(false);
        if (!(SceneManager.GetActiveScene().ToString() == "MainMenu"))
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
            GameManager.instance.LastLevelPlayed = SceneManager.GetActiveScene().ToString();
            GameManager.instance.GetComponent<ItemCollector>().itemNum++;
            GameManager.instance.itemCounter = 0;
            GameManager.instance.GetComponent<ItemCollector>().CheckAndUpdate();

            GameManager.instance.UpdateCounter();
        }
    }
}
