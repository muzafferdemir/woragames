using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yhhhh: MonoBehaviour
{// 2 katýnýn dört fazlasý 12 olan sayýnýn kendisi kaçtýr
    float sayý1 = 17f;
    float sayý2 = 5f;
    float bölme;
    int sayý3 = 4;
    float a = 2;
    float b = 4;
    float c = 12;
    float x;
    public int benmYasim = 16;
    int arackullanýlabilecekyas = 18;
    private int puan;


    
    // Start is called before the first frame update
    void Start()
    {
        float bölme=sayý1 / sayý2;
        Debug.Log(bölme);

        float çarpma = sayý2 * sayý3;
        Debug.Log(çarpma);
        float x = (c - b) / a;
        Debug.Log(x);

        if (benmYasim > arackullanýlabilecekyas)
        {
            Debug.Log("arac kullanabilirsin");

        } else
        {
            Debug.Log("aracý nah kullanýrsýn");
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
