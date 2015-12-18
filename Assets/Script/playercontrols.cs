using UnityEngine;
using System.Collections;



public class playercontrols : MonoBehaviour {
    public static float power = 1.5f;
    public float force = 15.0f;

	
	// Update is called once per frame
	void Update () {
        if(Input.GetButton("Jump") && power >= 0.001f){
            flyup();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            int spinspeed = 400;
            transform.Rotate(Vector3.forward * spinspeed * Time.fixedDeltaTime);
        }
        

    }

    void flyup(){
        power = Mathf.MoveTowards(power, 0, Time.fixedDeltaTime);
        GetComponent<Rigidbody> ().AddForce(new Vector3(0, force));  

    }
    void OnCollisionStay (Collision Col){
        if (Col.gameObject.tag == "Ground")
        {   
            power = Mathf.MoveTowards(power, 1.5f, Time.fixedDeltaTime);
        }


    }
    

}
