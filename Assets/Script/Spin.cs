using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
    public int spinspeed;
   
    // Update is called once per frame
    void FixedUpdate () {
       
        transform.Rotate(Vector3.up * spinspeed * Time.fixedDeltaTime);
       
    }
}
