using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewLockInteraction : Interactables
{
    public string keyName;
    //public UnityEvent Triggers;
    //public UnityEvent startActions;

    private void Start()
    {
        //startActions.Invoke();
        gameObject.SetActive(false);
    }
    private void Update()
    {
        //if (isPlayerInRange)
        //{
        //    if (Input.GetKeyDown(KeyCode.E))
        //    {
        //        Triggers.Invoke();
        //    }
        //}
        if (GameManager.instance.Inventory.Contains(keyName))
        {
            gameObject.SetActive(true);
            Debug.Log("works");
        }
    }
    //public void CheckCointainsNPC()
    //{
    //    if (GameManager.instance.Inventory.Contains(keyName))
    //    {
    //        gameObject.SetActive(true);
    //    }
    //}
    //public void DeleteGameObject()
    //{
    //    Destroy(gameObject);
    //}
    //public void InvokeEvent()
    //{
    //    Triggers.Invoke();
    //}
}
