using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInetraction : Interactables
{
    public LockInteraction completeItem;

   
    private void Update()
    {
        if (isPlayerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameManager.instance.Inventory.Add(completeItem.keyName);

                Debug.Log("Collected");
                Destroy(gameObject);
            }
        }
    }
}
