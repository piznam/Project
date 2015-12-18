using UnityEngine;
using System.Collections;

public class GameInit : MonoBehaviour {
    public static bool gameIsPlaying;
	
	void Start () {
        gameIsPlaying=true;
        DataManagement.datamanagement.currentScore = 0;
        DataManagement.datamanagement.LoadData();
	
	}
	

}
