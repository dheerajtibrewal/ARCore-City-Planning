using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisibility : MonoBehaviour
{
    public Transform target;
    public Camera catchingCamera;
    public Renderer matRender;
    public Material oldMat;
    public Material newMat;

   
    
    
   // Camera cam;

    void Start()
    {
       // cam = GetComponent<Camera>();

         if (catchingCamera == null){
        catchingCamera = GameObject.FindGameObjectWithTag("CatchingCamera").GetComponent<Camera>() as Camera;
    }

    matRender= target.GetComponent<Renderer>();
    }

     IEnumerator ExampleCoroutine(){
           yield return new WaitForSeconds(2f);
           matRender.material = newMat;

     }

    void Update()
    {
        Vector3 viewPos = catchingCamera.WorldToViewportPoint(target.position);
        if (viewPos.x > 0.2F && viewPos.x < 0.6F)
            {
                StartCoroutine(ExampleCoroutine());
            }
        else{
                StopCoroutine(ExampleCoroutine());
                matRender.material = oldMat;
        }
            
    }
}
