using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {

    private GameObject player;
    public float camSpeed = 5.0f;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("player");

	
	}
	
	// Update is called once per frame
	void Update () {
        //follow char x
        Vector3 campos = transform.position;
        campos.x = player.transform.position.x - -9.0f;
        transform.position = Vector3.Lerp (transform.position, campos, 3 * Time.fixedDeltaTime);

        //follow char y
        campos.y = player.transform.position.y + 2;
        transform.position = Vector3.Lerp(transform.position, campos, 7.0f * Time.fixedDeltaTime);

    }
}
