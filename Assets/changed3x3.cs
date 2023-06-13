using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changed3x3 : MonoBehaviour
{
    public int x, y;
    public GameObject matr;
    
    public void change(string inp)
    {
        matr.GetComponent<matrix3x3>().mym[x, y] =  Int32.Parse(inp);
    }
}
