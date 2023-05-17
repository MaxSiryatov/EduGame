using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Usable")
            other.GetComponent<item>().isActive = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Usable")
            other.GetComponent<item>().isActive = false;
    }
}
