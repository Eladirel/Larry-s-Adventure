using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotarObjeto : MonoBehaviour
{
    public float velocidad;
    public float delta;
    // Update is called once per frame
    void Update() 
    {
        float y = 4 + Mathf.PingPong(velocidad * Time.time, delta);
        Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = pos;
    }
}
