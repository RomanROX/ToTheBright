using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public List<Sprite> itemLogos;
    public Image Item;
    public int itemNum;

    
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        if (clock)
    //        {
    //            GameManager.instance.clock++;
    //        }
    //        else if (book)
    //        {
    //            GameManager.instance.book++;
    //        }
    //        else if (hart)
    //        {
    //            GameManager.instance.hart++;
    //        }
    //        Destroy(gameObject);
    //    }
    //}
    // Start is called before the first frame update
    void Start()
    {
        itemNum = 0;
        CheckAndUpdate();
    }

    

    public void CheckAndUpdate()
    {
        Item.sprite = itemLogos[itemNum];
    }
}
