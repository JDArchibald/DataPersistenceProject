using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public string playerName;
    int score;

    //Make a data manager singleton
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
        DontDestroyOnLoad(instance);
    }

    public void SaveHighScore()
    {
        //to be implemented
    }
    public void LoadHighScore()
    {
        //To be implemented
    }
    [System.Serializable]
    class Score
    {
        string playerName;
        int playerScore;
    }
}
