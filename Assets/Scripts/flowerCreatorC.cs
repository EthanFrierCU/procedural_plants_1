using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerCreatorC : MonoBehaviour
{

    public GameObject flowerPrefabC;
    public int rotationDeg = 20;
    public int flowerLoopSize;

    // Start is called before the first frame update
    void Start()
    {
        flowerLoopSize = 360/rotationDeg;
        for (int i = 0; i < flowerLoopSize; i++) {
            GameObject flowerPedalC = Instantiate(flowerPrefabC);
            flowerPedalC.transform.localPosition = new Vector3(0, 2, 0);
            flowerPedalC.transform.localEulerAngles = new Vector3(0,i*rotationDeg,20);
            flowerPedalC.transform.parent = transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
