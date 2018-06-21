using UnityEngine;
using System.Collections;

public enum GameState{
	Runing,
	Pause
}

public class GameManager : MonoBehaviour {

	public static GameManager _instance;

	public int score=0;

	private GUIText guiText;
	public GameState gameState = GameState.Runing;

	void Awake(){
		_instance=this;
		guiText=GameObject.FindGameObjectWithTag("ScoreGUI").GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text="Score:"+score;
	}
	public void transfromGameState(){
		if(gameState==GameState.Runing){
			pauseGame();
		}else if(gameState==GameState.Pause){
			continueGame();
		}
	}

	public void pauseGame(){
		Time.timeScale=0;// time.delatTime = 0
		gameState=GameState.Pause;
	}
	public void continueGame(){
		Time.timeScale=1;
		gameState=GameState.Runing;
	}
}
