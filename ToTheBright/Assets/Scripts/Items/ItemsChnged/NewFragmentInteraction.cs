using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewFragmentInteraction : Interactables
{
    public string name;
    public List<string> neededFragments = new List<string>();
    public GameObject lock_;

    
    private void Update()
    {
        if (isPlayerInRange)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameManager.instance.Inventory.Add(name);

                if (CheckList())
                {
                    int i = 0;
                    foreach (string item in neededFragments)
                    {
                        if (GameManager.instance.Inventory.Contains(neededFragments[i]))
                        {
                            GameManager.instance.Inventory.Remove(neededFragments[i]);
                        }
                        i++;
                    }
                    GameManager.instance.Inventory.Add(lock_.GetComponent<NewLockInteraction>().keyName);
                    lock_.SetActive(true);
                }
                

                Destroy(gameObject);
            }
        }
    }


    public bool CheckList()
    {

        foreach (string item in neededFragments)
        {
            int i = 0;
            if (!GameManager.instance.Inventory.Contains(neededFragments[i]))
            {
                return false;

            }
        }
        return true;
    }
}
