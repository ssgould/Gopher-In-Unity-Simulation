using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor_detect : MonoBehaviour
{
    [Header("Sensors")]
    public float sensorLen=3f;
    public float sideSenPos=0.2f;
    public float sensorAngle=30;
    private void sensors(){
        RaycastHit hit;
        Vector3 sensorStartPos = transform.position;

        //right sensor
        sensorStartPos.x += sideSenPos;

        if (Physics.Raycast(sensorStartPos, Quaternion.AngleAxis(sensorAngle, transform.up)*transform.forward, out hit, sensorLen)){

        }
        Debug.DrawLine(sensorStartPos, hit.point);

        //left sensor
        sensorStartPos.x -= 2*sideSenPos;
        if (Physics.Raycast(sensorStartPos, Quaternion.AngleAxis(-sensorAngle, transform.up)*transform.forward, out hit, sensorLen)){

        }
        Debug.DrawLine(sensorStartPos, hit.point);

    }
    // Start is called before the first frame update
    void Start()
    {
     sensors();   
    }


}
