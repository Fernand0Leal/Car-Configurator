using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Price : MonoBehaviour
{
    public TextMeshProUGUI priceValue;
    private int Price1;

    [SerializeField]
    private TextMeshProUGUI priceText;

    // Start is called before the first frame update
    void Start()
    {

    
        priceText.text = 0 + "$";
        

        
    }

    public void Update(){
        
    }
   

    // Update is called once per frame
    public void AddValue (int pricE)
    {
            
            
        
    }

    public void updateValue (int totalPrice){

        priceText.text =  totalPrice.ToString() + "$"; 
    }
}
