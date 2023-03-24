using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hood : MonoBehaviour
{

    public TMP_Dropdown h_Dropdown;
    public GameObject hood; 
    public GameObject hood2;
    public GameObject bWindows;
    public GameObject bWindows2;
    public GameObject bWindows3;
    public GameObject fWindows1;
    public GameObject fWindows2;
    public GameObject fWindows3;
    public GameObject fWindows4;
    public GameObject fWindows5;
    public GameObject fWindows6;



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
            hood2.SetActive(true);
            bWindows.SetActive(true);
            bWindows2.SetActive(true);
            bWindows3.SetActive(true);
            fWindows1.SetActive(true);
            fWindows2.SetActive(true);
            fWindows3.SetActive(true);
            fWindows4.SetActive(true);
            fWindows5.SetActive(true);
            fWindows6.SetActive(true);
        }
        if (value ==1){
            hood.SetActive(false);
            hood2.SetActive(false);
            bWindows.SetActive(false);
            bWindows2.SetActive(false);
            bWindows3.SetActive(false);
            fWindows1.SetActive(false);
            fWindows2.SetActive(false);
            fWindows3.SetActive(false);
            fWindows4.SetActive(false);
            fWindows5.SetActive(false);
            fWindows6.SetActive(false);
        }
        
    }
}
