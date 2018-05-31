using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedButtonTrigger : MonoBehaviour {

    Transform button;
    public float setWeight;
    Vector3 originalPosition;
    public float setPosition;
    public Animator doorAnimator;
	// Use this for initialization
	void Start ()
    {
        button = gameObject.transform.parent;
        originalPosition = button.gameObject.transform.position;
        Debug.Log(originalPosition);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rigidbody>().mass >= setWeight)
        {
            Debug.Log(originalPosition);
            //Destroy(button.gameObject.GetComponent<BoxCollider>());
            button.position = new Vector3(originalPosition.x,setPosition,originalPosition.z);
            Debug.Log(button.position);
            //Set Door Open
            doorAnimator.SetBool("IsDoorOpen", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        button.position = originalPosition;
        doorAnimator.SetBool("IsDoorOpen", false);
    }
}
