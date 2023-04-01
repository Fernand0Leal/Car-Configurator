using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PriceHandler : MonoBehaviour
{
    
    public int pricE = 300000;
    public TextMeshProUGUI priceText; 

    void Start(){

        priceText.text = pricE + "$".ToString();
    }
    public void Update(){

       // pricE = 30000; 
    }
}
