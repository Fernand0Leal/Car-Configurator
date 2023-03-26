using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CameraZoomInterior : MonoBehaviour
{
    Animator dAnimator;
    public Button interiorB;
    public bool door;
    
    

    
    
    void Start (){

        

        Button btn = interiorB.GetComponent<Button>();

        btn.onClick.AddListener(TaskOnClick);
        dAnimator = GetComponent<Animator>();
        




    }

    public void TaskOnClick(){

        door = !door;
        dAnimator.SetBool ("ButtonPress", door);
        
        
    }
 }

