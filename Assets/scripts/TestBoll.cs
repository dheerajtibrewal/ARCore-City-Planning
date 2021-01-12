using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoll : MonoBehaviour
{
    public static bool testClick = false;

    public void OnMouseDown() {

        testClick = true;
        Debug.Log("true");

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
