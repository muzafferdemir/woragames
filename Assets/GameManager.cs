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
        
        Debug.Log("ortalamadeðer" +ortalama);



        if (ortalama >= 90)
        {
            Debug.Log("öðrenci sýnavdan A almýþtýr");
        }
        else if (ortalama >= 80) 
        {
            Debug.Log("öðrenci sýnavdan B almýþtýr");
        }  else if (ortalama >=70)
        {
            Debug.Log("öðrenci sýnavdan C almýþtýr");

        } else
        {
            Debug.Log("öðrencimiz sýnavdan kalmýþtýr");

        }







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
