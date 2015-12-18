using UnityEngine;
using System.Collections;

public class player_move : MonoBehaviour {

    public static int Pspeed = 15;
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Translate(Vector3.forward * Pspeed * Time.deltaTime);
	
	}
}
