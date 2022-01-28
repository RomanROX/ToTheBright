using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockInteraction : Interactables
{
    public string keyName;

    
    private void Update()
    {
        if (isPlayerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (GameManager.instance.Inventory.Contains(keyName))
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
