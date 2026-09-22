using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    // Start the game
    public void PlayGame() {
        SceneManager.LoadScene("_Scene_0");
    }

}
