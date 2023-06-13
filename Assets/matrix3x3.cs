using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matrix3x3 : MonoBehaviour
{
    public int[,] m, tm, mym;
    public bool complete = false;
    public GameObject obj;
    void Start()
    {
        m = new int[,]
        {
            {4, 1},
            {3, 4}
        };
        tm = new int[,]
        {
            {1, 3, 2},
            {2, -5, 7},
            {1, 3, -1}
        };
        mym = new int[,]
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };
    }

    public void Update()
    {

        if (correct(tm, mym, (int)Math.Sqrt(mym.Length)))
        {
            complete = true;
            obj.GetComponent<Button>().interactable = true;
        }
        
    }

    public bool correct(int[,] m1, int[,] m2, int size)
    {
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                if (m1[j, i] != m2[i, j])
                {
                    return false;
                }
            }
        }
        
        return true;
    }
}
