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
        }
    }
}
