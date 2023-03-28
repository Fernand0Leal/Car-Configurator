using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PriceHandler : MonoBehaviour
{
    public int [,] dropValue = new int [5,5];
    public float pricE;
    public TextMeshProUGUI priceText; 

    void Start(){

        priceText.text = pricE + "$".ToString();
    }
}
