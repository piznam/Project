using UnityEngine;
using System.Collections;

public class Player_Col : MonoBehaviour {
    public GameObject restartUI;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Borg")
        {
            playerdies();
        }
        
    }

    void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.tag == "Gold")
        {
            
            DataManagement.datamanagement.goldCollected++;
            DataManagement.datamanagement.currentScore++;
            Destroy(trig.gameObject);
            
        }
    }

    void playerdies()
    {
        DataManagement.datamanagement.SaveData();
        restartUI.gameObject.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("shipmesh").GetComponent<MeshRenderer>().enabled = false;
        GetComponent<playercontrols>().enabled = false;
        GetComponent<player_move>().enabled = false;
        GetComponent<ParticleSystem>().Play();
       // GameInit.gameIsPlaying = false;





    }
}
