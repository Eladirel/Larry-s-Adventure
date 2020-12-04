// Top Down Starter Kit
// By J. Navarro-Fennell
// Class: Player_Rotator
// Description:

using UnityEngine;
using System.Collections;

public class Player_Rotator : MonoBehaviour 
{
	
	private Vector3 dir;
	
	void Update ()
    {
        //Control de rotacion
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");
 
        dir = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if(dir != Vector3.zero && !GameManager.instance.isPaused)
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }
        
        dir = Vector3.zero;
    }
}
