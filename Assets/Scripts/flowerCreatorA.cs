using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerCreatorA : MonoBehaviour
{
    public GameObject flowerPrefabA;
    public int rotationDeg = 20;
    public int flowerLoopSize;


    // Start is called before the first frame update
    void Start()
    {
        flowerLoopSize = 360/rotationDeg;
        for (int i = 0; i < flowerLoopSize; i++) {
            GameObject flowerPedalA = Instantiate(flowerPrefabA);
            flowerPedalA.transform.localPosition = new Vector3(0, 2, 0);
            flowerPedalA.transform.localEulerAngles = new Vector3(0,i*rotationDeg,0);
            flowerPedalA.transform.parent = transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
