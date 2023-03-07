using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Seats : MonoBehaviour
{

    public TMP_Dropdown s_Dropdown;
    public GameObject seat1; 
    public GameObject seat2;

    public Material[] seatsM = new Material [3];

    public void Start()
    {
        s_Dropdown.onValueChanged.AddListener(SelectMesh);
    }

    // Update is called once per frame
    void SelectMesh(int index)
    {
        seat1.GetComponent<MeshRenderer>().material = seatsM[index];
        seat2.GetComponent<MeshRenderer>().material = seatsM[index];


        
    }
}
