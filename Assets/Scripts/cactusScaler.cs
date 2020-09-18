using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusScaler : MonoBehaviour
{
    public float seconds = 0;
    static float tLerp = 0.0f;
    public float spin = -360f;
    public float spinScale = 2f;
    public float spinSpeed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        seconds = Time.time;

        transform.localScale = new Vector3(Mathf.Lerp(0.0f,1.0f,tLerp),Mathf.Lerp(0.0f,1.0f,tLerp),Mathf.Lerp(0.0f,1.0f,tLerp));
        tLerp += 0.3f * Time.deltaTime;

        if (spin <= 0){
            transform.localEulerAngles = new Vector3(0,spin,0);
            spin += spinScale;
        }


    }
}
