using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraTitulo : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 110f)
        {
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z + Time.deltaTime);
            transform.position = pos;
        }
        else
        {
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, -29.43f);
            transform.position = pos;
        }
    }
}
