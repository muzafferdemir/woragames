using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yhhhh: MonoBehaviour
{// 2 kat�n�n d�rt fazlas� 12 olan say�n�n kendisi ka�t�r
    float say�1 = 17f;
    float say�2 = 5f;
    float b�lme;
    int say�3 = 4;
    float a = 2;
    float b = 4;
    float c = 12;
    float x;
    public int benmYasim = 16;
    int arackullan�labilecekyas = 18;
    private int puan;


    
    // Start is called before the first frame update
    void Start()
    {
        float b�lme=say�1 / say�2;
        Debug.Log(b�lme);

        float �arpma = say�2 * say�3;
        Debug.Log(�arpma);
        float x = (c - b) / a;
        Debug.Log(x);

        if (benmYasim > arackullan�labilecekyas)
        {
            Debug.Log("arac kullanabilirsin");

        } else
        {
            Debug.Log("arac� nah kullan�rs�n");
        }

        

     
           






    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  
        {
            puan += 10;
            Debug.Log(puan);
        }
        
    }
}
