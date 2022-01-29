using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragmentInteraction : Interactables
{
    public string name;
    public List<string> neededFragments = new List<string>();
    public LockInteraction completeItem;

    
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
                    GameManager.instance.Inventory.Add(completeItem.keyName);
                    Debug.Log("verFinish " + GameManager.instance.Inventory.ToString());
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
