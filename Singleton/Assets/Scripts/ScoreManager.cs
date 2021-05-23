using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    //public static ScoreManager instance;
    public static ScoreManager Getinstance()
    {
        if(instance == null)
        {
            instance = FindObjectOfType<ScoreManager>();
        }

        if(instance == null)
        {
            GameObject container = new GameObject("ScoreManager");

            instance = container.AddComponent<ScoreManager>();
        }

        return instance;
     }

    public static ScoreManager instance;


    //private void Awake()
    //{
    //    instance = this;
    //}

    public int GetScore()
    {
        return score;

    }

    // Start is called before the first frame update
    void Start()
    {
        if(instance != null)
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int newScore)
    {
        score = score + newScore;

    }
}
