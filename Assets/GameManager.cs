using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float quiz1, quiz2, quiz3, quiz4;
    float ortalama;

    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0, 101);
        quiz2 = Random.Range(0, 101);
        quiz3 = Random.Range(0, 101);
        quiz4 = Random.Range(0, 101);



        ortalama = (quiz1 + quiz2 + quiz3 + quiz4)/4;
        
        Debug.Log("ortalamade�er" +ortalama);



        if (ortalama >= 90)
        {
            Debug.Log("��renci s�navdan A alm��t�r");
        }
        else if (ortalama >= 80) 
        {
            Debug.Log("��renci s�navdan B alm��t�r");
        }  else if (ortalama >=70)
        {
            Debug.Log("��renci s�navdan C alm��t�r");

        } else
        {
            Debug.Log("��rencimiz s�navdan kalm��t�r");

        }







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
