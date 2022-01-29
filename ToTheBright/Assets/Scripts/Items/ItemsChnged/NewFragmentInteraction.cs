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
                    Debug.Log("allFragments");
                    int i = 0;
                    foreach (string item in neededFragments)
                    {
                        if (GameManager.instance.Inventory.Contains(neededFragments[i]))
                        {
                            //for
                            Debug.Log("ver1 " + GameManager.instance.Inventory.ToString());
                            GameManager.instance.Inventory.Remove(neededFragments[i]);
                            Debug.Log("ver2 " + GameManager.instance.Inventory.ToString());
                        }
                        i++;
                    }
                    GameManager.instance.Inventory.Add(lock_.GetComponent<NewLockInteraction>().keyName);
                    lock_.SetActive(true);
                    Debug.Log("verFinish " + GameManager.instance.Inventory[0]);
                }
                else { Debug.Log("missing"); }

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
