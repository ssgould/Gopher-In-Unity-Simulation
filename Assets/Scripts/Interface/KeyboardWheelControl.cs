using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///     This script detects keyboard controls and
///     use them to control the mobile robot
/// </summary>
public class KeyboardWheelControl : MonoBehaviour
{
    public ArticulationWheelController wheelController;
    public GameObject r_cam_back;
    public GameObject l_cam_back;

    public float speed = 1.5f;
    public float angularSpeed = 1.5f;
    private float targetLinearSpeed;
    private float targetAngularSpeed;

    void Start()
    {
    }

    void Update()
    {
        // Get key input
	if (Input.GetKeyDown(KeyCode.Z)){
	    Debug.Log("press Z");
	    r_cam_back.SetActive(false);
	    l_cam_back.SetActive(true);
	}
	if (Input.GetKeyDown(KeyCode.X)){
	    Debug.Log("press X");
   	    r_cam_back.SetActive(false);
	    l_cam_back.SetActive(false);
	}
	if (Input.GetKeyDown(KeyCode.C)){
	    Debug.Log("press C");
   	    r_cam_back.SetActive(true);
	    l_cam_back.SetActive(false);
	}
        targetLinearSpeed = Input.GetAxisRaw("Vertical") * speed;
        targetAngularSpeed = -Input.GetAxisRaw("Horizontal") * angularSpeed;
    }

    void FixedUpdate()
    {
        wheelController.SetRobotVelocity(targetLinearSpeed, targetAngularSpeed);
    }
}
