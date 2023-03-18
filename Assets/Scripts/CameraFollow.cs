using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CameraFollow : MonoBehaviour
{
    


    public CamSpotInfo [] spots;
    [Range(0.1f, 3.0f)] public float animSpeed = 0.3f;
    protected uint idx = 0;
    protected float t = 0.0f;
    public Button rimS;
    
    

    bool cameraZoom = false;
    //bool cameraZoomBack = false;
    
    void Start (){

        
        Button btn = rimS.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        


    }

    public void TaskOnClick () {

        CameraZoom();
     
        
    }
    

    public void CameraZoom(){
       
        cameraZoom = !cameraZoom;

    }
    

    void Update(){

        

        if(cameraZoom){
            
        Transform cam = Camera.main.transform;
        Vector3 dir_target = spots[idx].target.position - cam.position;
        Quaternion roti = Quaternion.LookRotation(dir_target);
        cam.position = Vector3.Lerp(cam.position, spots[idx].transform.position, t);
        cam.rotation = Quaternion.Slerp(cam.rotation, roti, t);
        t += Time.deltaTime * animSpeed;
        }

        

        

       
    }

[System.Serializable]public class CamSpotInfo {
    public Transform transform;
    public Transform target;
    public string name;
    

}


}