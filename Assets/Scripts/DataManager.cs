using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;
    public string playerName;
    public Score scoreObject;
    public string playerWithHighestScore;
    public int playerScore;

    //Make a data manager singleton
    private void Awake()
    {
        InstantiateManagerInstance();
        LoadHighScore();
    }
    public void InstantiateManagerInstance()
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
        Score score = new Score(playerName, playerScore.ToString());
        string output = JsonUtility.ToJson(score);
        File.WriteAllText(Application.persistentDataPath + "/highScore.json", output);
        LoadHighScore();
    }
    public void LoadHighScore()
    {

        string path = Application.persistentDataPath + "/highScore.json";
        if (!File.Exists(path))
        {
            Score holderData = new Score("nobody", 0.ToString());
            string output = JsonUtility.ToJson(holderData);
            File.WriteAllText(path, output);
        }
        string input = File.ReadAllText(path);
        Score score = JsonUtility.FromJson<Score>(input);
        scoreObject = score;
    }
    [System.Serializable]
    public class Score
    {
        public string playerName;
        public string finalScore;
        public Score(string name, string score)
        {
            playerName = name;
            finalScore = score;
        }
    }
}
