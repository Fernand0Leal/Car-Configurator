using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hood : MonoBehaviour
{

    public TMP_Dropdown h_Dropdown;
    public GameObject hood; 
    public GameObject rWindow1;
    public GameObject rWindow2;
    public GameObject rWindow3;
   



    // Start is called before the first frame update
    void Start()
    {
        h_Dropdown.onValueChanged.AddListener(SelectMesh);
        
    }

    // Update is called once per frame
    void SelectMesh(int value)
    {
        if (value ==0){
            hood.SetActive(true);
            rWindow1.SetActive(true);
            rWindow2.SetActive(true);
            rWindow3.SetActive(true);
        }
        if (value ==1){
            hood.SetActive(false);
            rWindow1.SetActive(false);
            rWindow2.SetActive(false);
            rWindow3.SetActive(false);
            
        }
        
    }
}
