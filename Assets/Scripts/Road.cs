using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Road : MonoBehaviour
{
    public Button road;
    public Button flat; 
    public GameObject roadE;
    public GameObject flatE;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = road.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick1);

        Button btn2 = flat.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
        
    }

    // Update is called once per frame
    void TaskOnClick1()
    {
        roadE.SetActive(true);
        flatE.SetActive(false);
        
    }

    void TaskOnClick2(){
        roadE.SetActive(false);
        flatE.SetActive(true);

    }
}
