using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameObject scoreUI;
    public GameObject highScoreUi;
	
	void Update () {
        if(DataManagement.datamanagement.currentScore > DataManagement.datamanagement.highScore){
            DataManagement.datamanagement.highScore = DataManagement.datamanagement.currentScore;
        }
        scoreUI.GetComponent<Text>().text = ("Score " + DataManagement.datamanagement.currentScore.ToString());
        highScoreUi.GetComponent<Text>().text = ("High Score " + DataManagement.datamanagement.highScore.ToString());

    }
}
