using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CameraTarget : MonoBehaviour
{
    Quaternion DefaultRotation;
     Vector3 Distance;
     public float maxdistance = 20;
     public GameObject camera2;
     public GameObject target;
     public Button zoom; 
 
     // Use t$$anonymous$$s for initialization
     void Start () {
         //DefaultRotation = camera.transform.rotation;
         Button btn = zoom.GetComponent<Button>();
         btn.onClick.AddListener(TaskOnClick);
         camera2.SetActive(false);
     }
     
     // Update is called once per frame
     void TaskOnClick () {
         //Debug.Log (Vector3.Distance (camera.transform.position, target.transform.position));
         if (Vector3.Distance (camera2.transform.position, target.transform.position) <= maxdistance) {
             camera2.transform.LookAt (target.transform);
             camera2.SetActive(true);
             
          } //else {
        //      camera.transform.rotation = DefaultRotation;
        //  }
     }
 }

