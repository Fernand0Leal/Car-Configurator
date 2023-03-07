using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DropDownHandler : MonoBehaviour
{

    
    public Material [] materialS = new Material [6];
    public TMP_Dropdown c_Dropdown;
    public GameObject car; 
    public GameObject hood;
    public Material [] hMaterial = new Material [6];
   
    

    public void Start(){

       
        c_Dropdown.onValueChanged.AddListener(SelectMesh);
        
    
    }


    public void SelectMesh(int index){

    
        car.GetComponent<MeshRenderer>().material = materialS[index];
        hood.GetComponent<MeshRenderer>().material = hMaterial[index];

        

        
    }

}