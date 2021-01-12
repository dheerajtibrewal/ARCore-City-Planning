using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonscript : MonoBehaviour
{
    // public GameObject house;
    // public GameObject camera;
    public GameObject AR;
   // public GameObject Model;
   // public GameObject button;
    
    
        

    private void Awake() {
       // AR = GameObject.Find("GameObjectAR");
    }

    private void OnMouseDown() {
       
       
        
      
    }
    // Start is called before the first frame update
    void Start()
    {
       // AR.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(TestQuadBut.testClick == true){
            //Model.SetActive(false);
        // house.SetActive(true);
        // camera.SetActive(true);
        AR.SetActive(false);
        //button.SetActive(true);
        Debug.Log("Its Working");
        TestQuadBut.testClick = false;
        


       } 

       if(TestQuadInterior.testClick == true){
           AR.SetActive(true);
           TestQuadInterior.testClick = false;
       }
    }
}
