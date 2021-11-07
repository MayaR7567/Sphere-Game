using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour
{
    //public float value;
    //public Material red;
    
        //transform.localScale = new Vector3(1 + Vector3, )
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
    }
}
