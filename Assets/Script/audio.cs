using UnityEngine;
using System.Collections;

public class audio : MonoBehaviour {


    public AudioClip death,boosters,latinum;

	// Update is called once per frame
	void Update () {
        if(Input.GetButton ("Jump")&& playercontrols.power >= 0.01f)
        {
            GetComponent<AudioSource>().PlayOneShot(boosters, 0.001f);
        }
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Borg")
        {
            GetComponent<AudioSource>().PlayOneShot(death, 0.8f);
        }
    }
    void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Gold")
        {
            AudioSource audio = GetComponent<AudioSource>();
 
            audio.clip = latinum;
            
            audio.Play();

        }

        }
    
}
