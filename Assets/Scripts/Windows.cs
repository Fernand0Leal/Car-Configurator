using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Windows : MonoBehaviour
{
    public TMP_Dropdown w_Dropdown;
    public GameObject window1; 
    public GameObject window2;

    public Material[] windowM = new Material [3];

    public void Start()
    {
        w_Dropdown.onValueChanged.AddListener(SelectMesh);
    }

    // Update is called once per frame
    void SelectMesh(int index)
    {
        window1.GetComponent<MeshRenderer>().material = windowM[index];
        window2.GetComponent<MeshRenderer>().material = windowM[index];


        
    }
}

