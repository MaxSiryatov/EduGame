using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Matrix3x3_2 : MonoBehaviour
{
    public int[,] tm, mym;
    public bool complete = false;
    public GameObject obj;
    void Start()
    {
        tm = new int[,]
        {
            {-4, 8, -2},
            {0, -6, 4},
            {-10, -2, 6}
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
