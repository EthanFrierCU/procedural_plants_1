using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusManager : MonoBehaviour
{
    public int cactusNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0)) {
            cactusNum =+ 1;
        } 
    }
}
