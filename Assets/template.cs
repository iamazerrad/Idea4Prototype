using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class template : MonoBehaviour
{
    public Animator doorAnimator;
    public CharacterJoint cj;
    bool isDoorOpen;
	// Use this for initialization
	void Awake ()
    {
        isDoorOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(cj==null)
        {
            Debug.Log("trigere");
            if (isDoorOpen == false)
            {
                doorAnimator.SetBool("OpenDoor", true);
                isDoorOpen = true;
            }
            
        }
	}
}
