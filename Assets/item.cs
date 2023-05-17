using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
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
