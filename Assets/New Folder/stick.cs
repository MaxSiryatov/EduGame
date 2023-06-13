using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick : MonoBehaviour
{
    public GameObject s1, s2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tt = s2.transform.position - s1.transform.position;
        transform.position = s2.transform.position - (tt)/2;
        transform.LookAt(s2.transform.position);
        transform.Rotate(new Vector3(-90, 0,0));
        float mag = tt.magnitude;

        float rad = 0.001f/Mathf.Pow(mag, 2.5f)-0.00625f;

        if (rad > 0.06f)
        {
            rad = 0.06f;
        }
        else if (rad < 0.001f)
        {
            rad = 0;
        }
            
        transform.localScale = new Vector3(rad, mag/2, rad);

    }
}
