using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening; 

public class CRot : MonoBehaviour
{
    public GameObject rightButton;
    public GameObject leftButton;
   
    
    public Button cameraB;
    public Button cameraA;

    private string currentOption = "option1";

    
   
   

    

    public void Start(){

        Button btn = cameraB.GetComponent<Button>();
        Button btn1 = cameraA.GetComponent<Button>();
       
        btn.onClick.AddListener(TaskOnClick);
        btn1.onClick.AddListener(TaskOnClick1);


    }
    public void TaskOnClick () {
       
       
        switch (currentOption)
        {
            case "option1":
            RotateCarRight(); 
             
              
            currentOption = "option2";
            break;

            case "option2":
            StopRotation();
              
            currentOption = "option1";
            break;

        }
       


       
    }
    public void TaskOnClick1(){
        
        switch (currentOption)
        {
            case "option1":
            RotateCarLeft();
              
              
            currentOption = "option2";
            break;

            case "option2":
            StopRotation();
             
            currentOption = "option1";
            break;

        }
        
    }

   
    
 
    public void RotateCarRight(){

        transform.DORotate(new Vector3(0.0f,360.0f, 0.0f), 10.0f, RotateMode.FastBeyond360)
        .SetLoops(-1, LoopType.Restart)
        .SetRelative()
        .SetEase(Ease.Linear);
      
        
        
       
    }

    public void RotateCarLeft(){
        transform.DORotate(new Vector3(0.0f,-360.0f, 0.0f), 10.0f, RotateMode.FastBeyond360)
        .SetLoops(-1, LoopType.Restart)
        .SetRelative()
        .SetEase(Ease.Linear);
  
       
       
    }

    public void StopRotation()
    {
        transform.DORotate(new Vector3(0.0f,0.0f, 0.0f), 10.0f, RotateMode.FastBeyond360)
        .SetLoops(-1, LoopType.Restart)
        .SetRelative()
        .SetEase(Ease.Linear);
        

    }

    

 }

