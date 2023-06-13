using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    private bool isFirst = true;
    public bool isActive;
    public GameObject pres, list;
    
    void Start()
    {
        isActive = false;
    }
    void Update()
    {
        pres.SetActive(isActive);

        if (Input.GetKey(KeyCode.E) & isActive)
        {
            if (isFirst)
            {
                isFirst = false;
                GameObject.FindGameObjectWithTag("Player").GetComponent<useItem>().counter++;
            }
            Time.timeScale = 0;
            list.SetActive(true);
        }
        
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 1;
            list.SetActive(false);
        }
    }
}
