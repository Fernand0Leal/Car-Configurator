using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CRot : MonoBehaviour
{
    public GameObject rotatedObject;
    public float rotationSpeed;
    bool rotateRight = false;
    bool rotateLeft = false;
    public Button cameraB;
    public Button cameraA;
   
   

    void Start () {
        Button btn = cameraB.GetComponent<Button>();
        Button btn1 = cameraA.GetComponent<Button>();
       
        btn.onClick.AddListener(TaskOnClick);
        btn1.onClick.AddListener(TaskOnClick1);
       


    
    }
    void TaskOnClick () {
       RotateCarRight(); 
    }
    void TaskOnClick1(){
        RotateCarLeft();
    }

   
    
 
    public void RotateCarRight(){
        rotateRight = !rotateRight;
    }

    public void RotateCarLeft(){
        rotateLeft = !rotateLeft;
    }

    public void Zoom(){
        
    }

    public void Update(){

        

       
        if (rotateRight){
            rotationSpeed = 20;
            transform.Rotate(0,rotationSpeed*Time.deltaTime,0);
        }

        if (rotateLeft){
           rotationSpeed = -20;
           transform.Rotate(0,rotationSpeed*Time.deltaTime,0);
        }

        

    }
    }

