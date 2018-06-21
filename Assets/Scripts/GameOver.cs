using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
    public static GameOver _instance;

    public GUIText highScore;
    public GUIText nowScore;

    void Awake() {
        _instance = this;
        this.gameObject.SetActive(false);
    }

    public void Show(float nowScore) {
        float historyScore = PlayerPrefs.GetFloat("historyHighScore", 0);
        if (nowScore > historyScore) {
            PlayerPrefs.SetFloat("historyHighScore", nowScore);
        }
        highScore.text = historyScore + "";
        this.nowScore.text = nowScore + "";

        this.gameObject.SetActive(true);
    }


}
