using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Price : MonoBehaviour
{
    public GameObject priceManager;
    public int priCe = 300000;
    public int rimsPrice;
    public int rimsColorPrice; 
    public int convertPrice;
    public int seatsPrice;
    public int windowsPrice;
    public TextMeshProUGUI priceTxt;

    void Start(){

       //priceTxt = GetComponent<Rims>().price;
    }

    public void IncreasePrice(){

        
    }

    void Update(){

        priceTxt.text = windowsPrice + seatsPrice + convertPrice + rimsColorPrice + rimsPrice + priCe + "$".ToString();
        print (priCe);
    }

    
}