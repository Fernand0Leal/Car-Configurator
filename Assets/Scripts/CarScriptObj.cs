using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu]
public class CarScriptObj : ScriptableObject
{
    public TMP_Dropdown c_Dropdown;
    public Material defaultMaterial; 

    public Material[] sharedMaterials;
    public Material [] materialS = new Material [7];

    public GameObject [] carPaint; 
    
}