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
        {
            if (other.GetComponent<Open>())
                other.GetComponent<Open>().isActive = true;
            else if (other.GetComponent<MoveNextLvl>())
                other.GetComponent<MoveNextLvl>().isActive = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Item")
            other.GetComponent<item>().isActive = false;
        else if (other.tag == "Usable")
        {
            if (other.GetComponent<Open>())
                other.GetComponent<Open>().isActive = false;
            else if (other.GetComponent<MoveNextLvl>())
                other.GetComponent<MoveNextLvl>().isActive = false;
        }
    }
}
