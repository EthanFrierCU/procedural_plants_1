using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusScaler : MonoBehaviour
{
    public float seconds = 0;
    static float t = 0.0f;
    public float spin = -360f;
    public float spinScale = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        seconds = Time.time;

        transform.localScale = new Vector3(Mathf.Lerp(0.0f,1.0f,t),Mathf.Lerp(0.0f,1.0f,t),Mathf.Lerp(0.0f,1.0f,t));
        t += 0.3f * Time.deltaTime;

        if (spin <= 0){
            transform.localEulerAngles = new Vector3(0,spin,0);
            spin += spinScale;
        }

    }
}
