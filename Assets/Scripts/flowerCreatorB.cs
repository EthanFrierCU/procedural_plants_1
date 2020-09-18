using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerCreatorB : MonoBehaviour
{
    public GameObject flowerPrefabB;
    public int rotationDeg = 20;
    public int flowerLoopSize;


    // Start is called before the first frame update
    void Start()
    {
        flowerLoopSize = 360/rotationDeg;
        for (int i = 0; i < flowerLoopSize; i++) {
            GameObject flowerPedalB = Instantiate(flowerPrefabB);
            flowerPedalB.transform.localPosition = new Vector3(0, 2, 0);
            flowerPedalB.transform.localEulerAngles = new Vector3(0,i*rotationDeg,20);
            flowerPedalB.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
