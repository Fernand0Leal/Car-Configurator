using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hood : MonoBehaviour
{

    public TMP_Dropdown h_Dropdown;
    public GameObject hood; 
    public GameObject bWindows;

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
            bWindows.SetActive(true);
        }
        if (value ==1){
            hood.SetActive(false);
            bWindows.SetActive(false);
        }
        
    }
}
