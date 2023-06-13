using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class useItem : MonoBehaviour
{
    public Text text;
    public int count;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = GameObject.FindGameObjectsWithTag("Item").Length;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = $"{counter}/{count}";
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Item")
            other.GetComponent<item>().isActive = true;
        else if (other.tag == "Usable")
            other.GetComponent<Open>().isActive = true;
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Item")
            other.GetComponent<item>().isActive = false;
        else if (other.tag == "Usable")
            other.GetComponent<Open>().isActive = false;
    }
}
