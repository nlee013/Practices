using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //public int[] scores = new int[10];
    //private int index = 0;

    public List<int> scores = new List<int>();

   
    // Start is called before the first frame update
    void Start()
    {
        ////scores = new int[11];
        //int score0 = 45;
        //int score1 = 77;
        //int score2 = 89;

        //scores.Add(score0);
        //scores.Add(score1);
        //scores.Add(score2);

        ////scores.RemoveAt(1);
        //scores.Remove(77);

        ////Debug.Log(scores[0]);
        //Debug.Log(scores[1]);

        while (scores.Count > 0)
        {
            scores.RemoveAt(0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //{
        //    //scores[index] = Random.Range(0, 100);
        //    //index++;

        //    int randomNumber = Random.Range(0, 100);
        //    scores.Add(randomNumber);
            

        //}

        //if (Input.GetMouseButton(1))
        //{
        //    scores.RemoveAt(3);
        //}


    }
}
