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
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        // addPrice = GameObject.Find("AddValue").GetComponent<Price.cs>();
       
        wheels = GameObject.FindGameObjectsWithTag ("wheel");
        defaultMaterial = wheels[1].GetComponent<MeshRenderer>().sharedMaterials[1];
        
       
        foreach (GameObject wheel in wheels)
        {
            Renderer[] renderers = wheel.GetComponents<Renderer>();
            foreach (Renderer renderer in renderers)
            {
               
                Material[] m_materials = renderer.sharedMaterials;
                

                foreach (Material material in renderer.sharedMaterials)
                {
                   m_materials[0] = defaultMaterial;
                }
                renderer.sharedMaterials = m_materials;
                
            }
            

        }
       

    

        r_Dropdown.onValueChanged.AddListener(RimsMesh);
        // r_Dropdown.onValueChanged.AddListener(PriceUpdate);

    }


    public void RimsMesh(int index )
    {
        
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
