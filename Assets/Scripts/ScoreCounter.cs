using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Enables use of uGUI classes

public class ScoreCounter : MonoBehaviour {
    [Header("Dynamic")]
    public int score = 0;

    public Text roundCounter;
    private Text uiText;
    void Start() {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        uiText.text = score.ToString("#,0");
        UpdateRound();
    }

     void UpdateRound() {
        int round = (score / 1000) + 1;
        roundCounter.text = "Round " + round;
    }
}
