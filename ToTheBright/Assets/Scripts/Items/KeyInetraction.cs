using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInetraction : MonoBehaviour
{
    
    public LockInteraction completeItem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Key") && collision.CompareTag("Player"))
        {
            GameManager.instance.Inventory.Add(completeItem.keyName);

            Debug.Log("Collected");
            Destroy(gameObject);
        }
    }
}
