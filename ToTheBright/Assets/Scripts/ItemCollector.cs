using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum ItemType
{
    hart,
    clock,
    notes,
    page,
    book,
    gamepad,
    none
}


public class ItemCollector : MonoBehaviour
{
    //public bool clock;
    //public bool hart;
    //public bool book;
    //public bool gamepad;
    //public bool notes;

    public ItemType currentItemsOnScene;
    public List<Sprite> itemLogos;

    public Image Item;

    public int itemNum;

    private void Start()
    {
        //CheckAndUpdate();
        itemNum = 0;
        CheckAndUpdate();
    }
    public void CheckAndUpdate()
    {
        //switch (GameManager.instance.LastLevelPlayed)
        //{
        //    case "Level01":
        //        currentItemsOnScene = ItemType.hart;
        //        break;
        //    case "Level02":
        //        currentItemsOnScene = ItemType.clock;
        //        break;
        //    case "Level03":
        //        currentItemsOnScene = ItemType.notes;
        //        break;
        //    case "Level04":
        //        currentItemsOnScene = ItemType.notes;
        //        break;
        //    default:
        //        currentItemsOnScene = ItemType.none;
        //        break;
        //}
        Item.sprite = itemLogos[itemNum];


    }

}
