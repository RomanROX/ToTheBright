using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewFragmentInteraction : Interactables
{
    public string name;
    public List<string> neededFragments = new List<string>();
    public GameObject lock_;



    private void Update()
    {
        if (isPlayerInRange)
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

            GameManager.instance.itemCounter++;
            //GameManager.instance.gameUI.GetComponentInChildren<Image>().transform.Find("Num").GetComponent<Text>().text = "x0" + GameManager.instance.itemCounter;

            GameManager.instance.UpdateCounter();
            Destroy(gameObject);

        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    GameManager.instance.Inventory.Add(name);

    //    if (CheckList())
    //    {
    //        int i = 0;
    //        foreach (string item in neededFragments)
    //        {
    //            if (GameManager.instance.Inventory.Contains(neededFragments[i]))
    //            {

    //                GameManager.instance.Inventory.Remove(neededFragments[i]);
    //            }
    //            i++;
    //        }
    //        GameManager.instance.Inventory.Add(lock_.GetComponent<NewLockInteraction>().keyName);
    //        lock_.SetActive(true);

    //    }

    //    GameManager.instance.itemCounter++;
    //    //GameManager.instance.gameUI.GetComponentInChildren<Image>().transform.Find("Num").GetComponent<Text>().text = "x0" + GameManager.instance.itemCounter;
    //    collision.GetComponent<Player>().UpdateCounter();
    //    //GameManager.instance.UpdateCounter();
    //    Destroy(gameObject);

    //}

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
