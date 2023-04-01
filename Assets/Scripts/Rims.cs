using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Rims : MonoBehaviour
{

    
    
   const string PrefName = "optionvalue";
    
    public TMP_Dropdown r_Dropdown;
    
    public Material defaultMaterial;

    public Material[] sharedMaterials;
    //[SerializeField]
    public Material [] rMaterial = new Material [3];
    
    //[SerializeField]
    public GameObject [] wheels;

    public GameObject rims0;
    public GameObject rims1;
    public GameObject rims2;
    public GameObject rims3;
    public GameObject rims4;
    public GameObject rims5;

    public bool rimButton;
    public bool colorButton;

    
    public Price price2;

  
   
    public void LoadColorOptions(){

        r_Dropdown.ClearOptions();
        var option0 = new TMPro.TMP_Dropdown.OptionData ("Color"); 
        r_Dropdown.options.Add(option0);
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
        var option0 = new TMPro.TMP_Dropdown.OptionData ("Rims");
        r_Dropdown.options.Add(option0);
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

          if (index == 0 ){

            price2.rimsColorPrice = 0;
            
          }
          if (index == 1 ){

            price2.rimsColorPrice = 0;
            
          }
          if (index == 2 ){

            price2.rimsColorPrice = 100;
            
          }
          if (index == 3 ){

            price2.rimsColorPrice = 200;
            
          }
     }
     
        
    }

    public void RimMesh(int value ) 
     {

                

     if (rimButton == true){

            if (value == 0 ){
            rims0.SetActive(true);
            rims1.SetActive(true);
            rims2.SetActive(false);
            rims3.SetActive(false);
            rims4.SetActive(false);
            rims5.SetActive(false);
            price2.rimsPrice = 0;
            
            }

            if (value == 1){
            rims0.SetActive(false);
            rims1.SetActive(true); 
            rims2.SetActive(false);
            rims3.SetActive(false);
            rims4.SetActive(false);
            rims5.SetActive(false); 
            price2.rimsPrice = 0;

            }
  
            if (value == 2){
            rims0.SetActive(false);
            rims1.SetActive(false);
            rims2.SetActive(true);
            rims3.SetActive(false);
            rims4.SetActive(false);
            rims5.SetActive(false);

            price2.rimsPrice = 500;
            
            }
            
        
             if (value == 3){
            rims0.SetActive(false);
            rims1.SetActive(false);
            rims2.SetActive(false);
            rims3.SetActive(true);
            rims4.SetActive(false);
            rims5.SetActive(false);
             price2.rimsPrice = 600;
            
             }

             if (value == 4){
            rims0.SetActive(false);
            rims1.SetActive(false);
            rims2.SetActive(false);
            rims3.SetActive(false);
            rims4.SetActive(true);
            rims5.SetActive(false);
            price2.rimsPrice = 700;
            
             }

            if (value == 5){
            rims0.SetActive(false);
            rims1.SetActive(false);
            rims2.SetActive(false);
            rims3.SetActive(false);
            rims4.SetActive(false);
            rims5.SetActive(true);

            price2.rimsPrice = 800;
                   
            }

     }
                                  
        
    }

}