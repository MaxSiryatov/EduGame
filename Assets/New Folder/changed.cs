using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changed : MonoBehaviour
{
    public int x, y;
    public GameObject matr;
    
    public void change(string inp)
    {
        matr.GetComponent<matrix>().mym[x, y] =  Int32.Parse(inp);
    }
}
