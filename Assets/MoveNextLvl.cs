using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveNextLvl : MonoBehaviour
{
    public GameObject obj1;
    public bool isActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        obj1.SetActive(isActive);
        if (Input.GetKey(KeyCode.E) & isActive)
        {
            SceneManager.LoadScene(1);
        }
    }
}
