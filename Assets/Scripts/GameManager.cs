using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public void NewGame (string sceneName) {
        PlayerPrefs.SetInt("DataFromSave", 0);
        SceneManager.LoadScene(sceneName);
    }

    public void LoadGame()
    {
        PlayerPrefs.SetInt("DataFromSave", 1);
    }
}
