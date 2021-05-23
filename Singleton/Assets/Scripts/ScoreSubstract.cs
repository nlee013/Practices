using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSubstract : MonoBehaviour
{
    //public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            ScoreManager.Getinstance().AddScore(-2);
            Debug.Log(ScoreManager.Getinstance().GetScore());
        }
    }
}
