using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public string nickname;

    public float weight;

    public static int count = 0;

    void Awake()
    {
        count = count + 1;
    }

    void Start()
    {
        Bark();
    }

    public void Bark()
    {
        Debug.Log("Number of all dogs:" + count);
        Debug.Log(nickname + ": Bark!");
    }

    public static void ShowAnimalStyle()
    {
        Debug.Log("This is a dog");
    }
    
}
