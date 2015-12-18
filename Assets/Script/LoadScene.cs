using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	public void loadtoScene(int scenetoload)
    {
        Application.LoadLevel(scenetoload);
    }
}
