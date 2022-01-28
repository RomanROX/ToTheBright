using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockInteraction : MonoBehaviour
{
    public string keyName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Lock") && collision.CompareTag("Player"))
        {
            if (GameManager.instance.Inventory.Contains(keyName))
            {
                Destroy(gameObject);
            }

        }
    }
}
