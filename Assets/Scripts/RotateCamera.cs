using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCamera : MonoBehaviour
{
    public GameObject target;//the target object
    private float speedMod = 2000.0f;//a speed modifier
    private Vector3 point;//the coord to the point where the camera looks at
    public Button cameraB;
 
    void Start () {//Set up things on the start method
        Button btn = cameraB.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        point = target.transform.position;//get target's coords
        transform.LookAt(point);//makes the camera look to it
    }
 
    void TaskOnClick () {//makes the camera rotate around "point" coords, rotating around its Y axis, 20 degrees per second times the speed modifier
        transform.RotateAround (target.transform.position, Vector3.up, speedMod * Time.deltaTime);  
    }
}
