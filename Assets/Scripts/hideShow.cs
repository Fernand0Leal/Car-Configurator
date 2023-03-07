using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideShow : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void hide (){
        menu.SetActive(false);
    }

    public void show (){
        menu.SetActive(true);
    }
}
