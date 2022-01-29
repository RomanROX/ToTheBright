using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public bool clock;
    public bool hart;
    public bool book;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (clock)
            {
                GameManager.instance.clock++;
            }
            else if (book)
            {
                GameManager.instance.book++;
            }
            else if (hart)
            {
                GameManager.instance.hart++;
            }
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
