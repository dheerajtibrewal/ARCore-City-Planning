using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQuadInterior : MonoBehaviour
{
    public GameObject model;
    public GameObject OBJ_Interior;
    public static bool testClick = false;
    

      


     private void OnMouseDown() {
        model.SetActive(true);
        OBJ_Interior.SetActive(false);
        testClick = true;
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
