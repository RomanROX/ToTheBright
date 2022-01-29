using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpdetect : MonoBehaviour
{
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool jumpdet = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumpdet = true;
        }
    }
}
