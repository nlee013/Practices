using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//여러개의 코르틴 사용가능 = 병렬 구조 가능

public class HelloCoroutine : MonoBehaviour 
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("HelloUnity");
        //StartCoroutine(HelloUnity());

        //StartCoroutine("HiCSharp");
        //Debug.Log("End");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StopCoroutine("HelloUnity");
        }
    }

    IEnumerator HelloUnity()
    {
        while (true)
        {
            //yield return new WaitForSeconds(3.0f);
            yield return null;//대기 시간을 주지 않고 null 입력 시, 딱 한 frame을 쉰다 = 대충 60분의 1초 쉼

            Debug.Log("Hello Unity");

        }
    }

    //IEnumerator HiCSharp()
    //{
    //    Debug.Log("Hi");

    //    yield return new WaitForSeconds(5.0f);

    //    Debug.Log("CSharp");
    //}

}
