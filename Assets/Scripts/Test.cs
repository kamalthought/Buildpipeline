using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float d;
    // Update is called once per frame
    void Update()
    {
        d = Mathf.PingPong(Time.time, 3.5f);
       
        transform.localScale = Vector3.one * d;
    }
}
