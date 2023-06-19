using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changed : MonoBehaviour
{
    public int x, y;
    public GameObject matr;
    
    public void change(string inp)
    {
        if (matr.GetComponent<matrix>())
        {
            matr.GetComponent<matrix>().mym[x, y] = Int32.Parse(inp);
        }
        else if (matr.GetComponent<matrix2x3>())
        {
            matr.GetComponent<matrix2x3>().mym[x, y] = Int32.Parse(inp);
        }
        else if (matr.GetComponent<matrix3x3>())
        {
            matr.GetComponent<matrix3x3>().mym[x, y] = Int32.Parse(inp);
        }
        else if (matr.GetComponent<Matrix3x3_2>())
        {
            matr.GetComponent<Matrix3x3_2>().mym[x, y] = Int32.Parse(inp);
        }
    }
}
