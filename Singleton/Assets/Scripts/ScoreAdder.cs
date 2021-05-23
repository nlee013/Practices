using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    //public ScoreManager scoreManager;

    private void Awake()
    {
        Debug.Log("Start Score" + ScoreManager.Getinstance().GetScore());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ScoreManager.Getinstance().AddScore(5);
            Debug.Log(ScoreManager.Getinstance().GetScore());
        }

    }
}
