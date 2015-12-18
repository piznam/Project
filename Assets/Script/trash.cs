using UnityEngine;
using System.Collections;

public class trash : MonoBehaviour {

    private float timetillclean = 10.0f;


	
	// Update is called once per frame
	void Update () {
        timetillclean -= Time.deltaTime;
        if(timetillclean < 0.01 && GameInit.gameIsPlaying == true)
        {
            Destroy(gameObject);
        }
	
	}
}
