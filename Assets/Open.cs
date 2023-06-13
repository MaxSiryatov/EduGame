using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject obj, obj1;

    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<useItem>().counter >= 3)
        {
            obj1.SetActive(isActive);


            if (Input.GetKey(KeyCode.E) & isActive)
            {
                Time.timeScale = 0;
                obj.SetActive(true);
            }
        }
    }
}