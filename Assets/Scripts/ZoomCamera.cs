using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour {

    float minFov = 15.0f;
    float maxFov = 90f;
    float sensitivity = 10f;
    Camera mainCamera;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

	// Update is called once per frame
	void Update ()
    {
        float fov = Camera.main.fieldOfView;
        fov += Input.GetAxis("Mouse ScrollWheel") * sensitivity;
        fov = Mathf.Clamp(fov, minFov, maxFov);
        mainCamera.fieldOfView = fov;
    }
}
