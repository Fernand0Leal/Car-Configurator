using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Seats : MonoBehaviour
{

    public TMP_Dropdown s_Dropdown;
    public GameObject seat1; 

    
    public Material[] seatsM = new Material [3];

    public Price price2;

    public void Start()
    {
        
        
        s_Dropdown.onValueChanged.AddListener(SelectMesh);
        
    }

    // Update is called once per frame
    void SelectMesh(int index)
    {

        
            Renderer[] renderers = seat1.GetComponentsInChildren<Renderer>();

            foreach (Renderer rend in renderers)
            {
             Material[] m_materials = GetComponentInChildren<Renderer>().materials;
                

                foreach (Material material in GetComponentInChildren<Renderer>().materials)
                {
                 m_materials[1] = seatsM[index];
                }
             rend.materials = m_materials;
             
            }

            if (index == 0){

                price2.seatsPrice = 0;

            }
            if (index == 1){

                price2.seatsPrice = -1000;

            }
            if (index == 2){

                price2.seatsPrice = 1000;

            }
      
       
       

        
    }
}
