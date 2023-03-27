using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Rims : MonoBehaviour
{
    public TMP_Dropdown r_Dropdown;
    
    public Material defaultMaterial;

    public Material[] sharedMaterials;
    public Material [] rMaterial = new Material [3];
    

    public GameObject [] wheels;

    public GameObject rims1;
    public GameObject rims2;
    public GameObject rims3;
    public GameObject rims4;
    public GameObject rims5;

    public bool rimButton;
    public bool colorButton;
    

   
   

    
    
    // Start is called before the first frame update
    void Start()
    {


        

       
        // addPrice = GameObject.Find("AddValue").GetComponent<Price.cs>();
       
        //wheels = GameObject.FindGameObjectsWithTag ("wheel");
        //defaultMaterial = wheels[0].GetComponent<MeshRenderer>().sharedMaterials[1];
    


        // r_Dropdown.onValueChanged.AddListener(PriceUpdate);

    }

    public void LoadColorOptions(){

        r_Dropdown.ClearOptions();
        var option1 = new TMPro.TMP_Dropdown.OptionData ("Yellow Alloy");
        r_Dropdown.options.Add(option1);
         var option2 = new TMPro.TMP_Dropdown.OptionData ("Black Titanium");
        r_Dropdown.options.Add(option2);
         var option3 = new TMPro.TMP_Dropdown.OptionData ("White Carbon");
        r_Dropdown.options.Add(option3);

        r_Dropdown.RefreshShownValue();

        colorButton = true;
        rimButton = false;

        r_Dropdown.onValueChanged.AddListener(RimColor);
    


    }

     public void LoadRimOptions(){

        r_Dropdown.ClearOptions();
        var option1 = new TMPro.TMP_Dropdown.OptionData ("Style 1");
        r_Dropdown.options.Add(option1);
         var option2 = new TMPro.TMP_Dropdown.OptionData ("Style 2");
        r_Dropdown.options.Add(option2);
         var option3 = new TMPro.TMP_Dropdown.OptionData ("Style 3");
        r_Dropdown.options.Add(option3);
          var option4 = new TMPro.TMP_Dropdown.OptionData ("Style 4");
        r_Dropdown.options.Add(option4);
          var option5 = new TMPro.TMP_Dropdown.OptionData ("Style 5");
        r_Dropdown.options.Add(option5);

        r_Dropdown.RefreshShownValue();
        rimButton = true; 
        colorButton = false;
         
        r_Dropdown.onValueChanged.AddListener(RimMesh);
      
        


    }

    public void RimColor(int index )
    {

     if (colorButton == true){
        
            foreach (GameObject wheel in wheels)
            {
            Renderer[] renderers = wheel.GetComponentsInChildren<Renderer>();

            foreach (Renderer rend in renderers)
            {
             Material[] m_materials = GetComponentInChildren<Renderer>().sharedMaterials;
                

                foreach (Material material in GetComponentInChildren<Renderer>().sharedMaterials)
                {
                 m_materials[0] = rMaterial[index];
                }
             rend.materials = m_materials;
             
            }
          }
     }
     
        
    }

    public void RimMesh(int value ) 
    {

    if (rimButton == true){
        if (value == 0 ){
            rims1.SetActive(true);
            rims2.SetActive(false);
            rims3.SetActive(false);
            rims4.SetActive(false);
            rims5.SetActive(false);
        }
         if (value == 1){
            rims1.SetActive(false);
            rims2.SetActive(true);
            rims3.SetActive(false);
            rims4.SetActive(false);
            rims5.SetActive(false);
        }
         if (value == 2){
            rims1.SetActive(false);
            rims2.SetActive(false);
            rims3.SetActive(true);
            rims4.SetActive(false);
            rims5.SetActive(false);
        }
         if (value == 3){
            rims1.SetActive(false);
            rims2.SetActive(false);
            rims3.SetActive(false);
            rims4.SetActive(true);
            rims5.SetActive(false);
        } if (value == 4){
            rims1.SetActive(false);
            rims2.SetActive(false);
            rims3.SetActive(false);
            rims4.SetActive(false);
            rims5.SetActive(true);
        }
        
    }
       
     

     
        
            
        
    }


    

    
    

    // public void PriceUpdate (int value){

    //     addPrice += value;
    //     Price.cs.updateValue(addPrice);

    //     if (value == 0){
    //         addPrice(0);
            
    //         print ("No Price Change");
    //     }
    //     if (value == 1){
    //         addPrice(2000);
    //         print ("+2000$");
    //     } else { 
    //         print("-2000$");
    //     }
    //     if (value == 2){
    //         print("+3000");
    //     }else { 
    //         print("-3000$");
    //     }
    // }

}   
