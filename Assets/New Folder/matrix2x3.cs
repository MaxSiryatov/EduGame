using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class matrix2x3 : MonoBehaviour
{
    public int[,] tm, mym;
    public bool complete = false;
    public GameObject obj;
    void Start()
    {
        tm = new int[,]
        {
            {20, -10, 15},
            {10, 5, -15}
        };
        mym = new int[,]
        {
            {0, 0, 0},
            {0, 0, 0}
        };
    }

    public void Update()
    {

        if (correct(tm, mym, 3))
        {
            complete = true;
            obj.GetComponent<Button>().interactable = true;
        }
        
    }

    public bool correct(int[,] m1, int[,] m2, int size)
    {
        for (var i = 0; i < 2; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                if (m1[i, j] != m2[i, j])
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}
