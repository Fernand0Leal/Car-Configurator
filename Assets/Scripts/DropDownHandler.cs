using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DropDownHandler : MonoBehaviour
{

    public TMP_Dropdown c_Dropdown;
    public Material defaultMaterial; 

    public Material[] sharedMaterials;
    public Material [] materialS = new Material [7];

    public GameObject [] carPaint; 

  
   
    

    public void Start(){

       carPaint = GameObject.FindGameObjectsWithTag ("carColor");
       defaultMaterial = carPaint[0].GetComponent<MeshRenderer>().sharedMaterials[0];
       

    //    foreach (GameObject carColor in carPaint)
    //     {
    //         Renderer[] renderers = carColor.GetComponents<Renderer>();
    //         foreach (Renderer renderer in renderers)
    //         {
               
    //             Material[] m_materials = renderer.sharedMaterials;
                

    //             foreach (Material material in renderer.sharedMaterials)
    //             {
    //                m_materials[0] = defaultMaterial;
    //             }
    //             renderer.sharedMaterials = m_materials;
                
    //         }
        
    
    //     }

        c_Dropdown.onValueChanged.AddListener(SelectMesh);
    
    }


    public void SelectMesh(int index){

    
        foreach (GameObject carColor in carPaint)
            {
            Renderer[] renderers = carColor.GetComponentsInChildren<Renderer>();

            foreach (Renderer rend in renderers)
            {
             Material[] m_materials = GetComponentInChildren<Renderer>().sharedMaterials;
                

                foreach (Material material in GetComponentInChildren<Renderer>().sharedMaterials)
                {
                 m_materials[0] = materialS[index];
                }
             rend.materials = m_materials;
             
            }
          }

        

        
    }

}