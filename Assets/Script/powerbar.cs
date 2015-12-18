using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class powerbar : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        changepowerbar();

	
	}
    void changepowerbar()
    {
        if (playercontrols.power > 0.001)
        {
            gameObject.transform.localScale = new Vector3(playercontrols.power, 1, 1);
        }
    }
}
