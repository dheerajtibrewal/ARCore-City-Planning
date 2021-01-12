using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
   public Transform target;
    public Camera catchingCamera;
     public GameObject house;
    
    public GameObject AR;
    public GameObject Model;
    public GameObject camera;
   public GameObject button;
    public GameObject buttonQuad;

    bool clicked = false;

    public void exitInterior(){
        // if(clicked == false){
        AR.SetActive(false);
       // Model.SetActive(true);
       if(Model.activeInHierarchy == false){
        house.SetActive(true);
        camera.SetActive(true);
        button.SetActive(false);
        buttonQuad.SetActive(true);
        Debug.Log("Yrs hitdd");
       }
        // clicked = true;
        // }
        // else{
// AR.SetActive(true);
//        // Model.SetActive(true);
//         house.SetActive(false);
//         camera.SetActive(false);
//         clicked = false;
//         }
    }
    

   
    
    
   // Camera cam;

    void Start()
    {
       // cam = GetComponent<Camera>();

         if (catchingCamera == null){
        catchingCamera = GameObject.FindGameObjectWithTag("CatchingCamera").GetComponent<Camera>() as Camera;
       
    }
    }

    
    
    public void OnMouseDown() {

        // if(clicked == false){
          AR.SetActive(true);
       // Model.SetActive(true);
        house.SetActive(false);
        camera.SetActive(false);
        button.SetActive(true);
        Debug.Log("Yrs hit");
        buttonQuad.SetActive(false);
        // clicked = true;
        // }else{
        //      AR.SetActive(true);
        // Model.SetActive(true);
        // house.SetActive(false);
        // camera.SetActive(false);
        // Debug.Log("Yrs hitdd");
        // clicked = false;
        // }
    }

     IEnumerator ExampleCoroutine(){
           yield return new WaitForSeconds(2f);
           
        
        AR.SetActive(true);
       // Model.SetActive(true);
        house.SetActive(false);
        camera.SetActive(false);
        button.SetActive(true);
        buttonQuad.SetActive(false);
           

     }

    // void Update()
    // {
    //     Vector3 viewPos = catchingCamera.WorldToViewportPoint(target.position);
    //     if (viewPos.x > 0.2F && viewPos.x < 0.6F)
    //         {
    //             StartCoroutine(ExampleCoroutine());
    //         }
    //     else{
    //             StopCoroutine(ExampleCoroutine());
    //             Debug.Log("Yrs hitsss");
                
    //     }

        
            
    // }
    }

