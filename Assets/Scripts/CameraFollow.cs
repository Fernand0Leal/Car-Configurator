using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CameraFollow : MonoBehaviour
{
    

    public GameObject rimsC;
    public GameObject cameraRot;
    private string currentOption = "option1";

    public CRot otherS;
    


    public void TaskOnClick () {
        
         rimsC.SetActive(!rimsC.activeSelf);
         cameraRot.SetActive(!cameraRot.activeSelf);
         

         switch (currentOption)
        {
            case "option1":
               
               otherS.StopRotation();
               
              
            currentOption = "option2";
            break;

            case "option2":
                
               otherS.enabled = !otherS.enabled;
               
                
                               
                
            currentOption = "option1";
            break;

        }

        
        
        
     
        
    }
    






}