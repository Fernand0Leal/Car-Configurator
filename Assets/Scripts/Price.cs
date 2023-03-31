using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Price : MonoBehaviour
{
    public GameObject priceManager;
    public int priCe;
    public TextMeshProUGUI priceTxt;

    void Start(){

       //priceTxt = GetComponent<Rims>().price;
    }

    void Update(){

        priceTxt.text = priCe + "$".ToString();
        print (priceTxt.ToString());
    }

    
}