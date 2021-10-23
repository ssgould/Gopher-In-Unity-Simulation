using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_cam_switch : MonoBehaviour

{
    public GameObject r_cam_back;
    public GameObject l_cam_back;


    // Start is called before the first frame update
    void Swithc()
    {
        //clear_all();
	if (Input.GetKeyDown(KeyCode.E)){
	    Debug.Log("press E");
	    r_cam_back.SetActive(true);
	    l_cam_back.SetActive(false);
	}
	if (Input.GetKeyDown(KeyCode.Q)){
	    Debug.Log("press Q");
   	    r_cam_back.SetActive(false);
	    l_cam_back.SetActive(true);
	}
    }

    // Update is called once per frame
    //public void clear_all()
    //{
    //    r_cam_back.SetActive(false);
    //    l_cam_back.SetActive(false);
    //}
}
