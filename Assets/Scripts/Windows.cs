using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Windows : MonoBehaviour
{
    public TMP_Dropdown w_Dropdown;
    public GameObject [] windowS;

    public Material defaultMaterial; 
 
  

    public Material[] windowM = new Material [3];

    public void Start()
    {
        windowS = GameObject.FindGameObjectsWithTag ("Window");
        defaultMaterial = windowS[0].GetComponent<MeshRenderer>().sharedMaterials[0];
        w_Dropdown.onValueChanged.AddListener(SelectMesh);
    }

    // Update is called once per frame
    void SelectMesh(int index)
    {

        foreach (GameObject Window in windowS)
            {
            Renderer[] renderers = Window.GetComponentsInChildren<Renderer>();

            foreach (Renderer rend in renderers)
            {
             Material[] m_materials = GetComponentInChildren<Renderer>().sharedMaterials;
                

                foreach (Material material in GetComponentInChildren<Renderer>().sharedMaterials)
                {
                 m_materials[0] = windowM[index];
                }
             rend.materials = m_materials;
             
            }
          }

    }
}

