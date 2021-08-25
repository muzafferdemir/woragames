using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ver : MonoBehaviour

{
    int sayı1=6;
    int sayı2=9;     
    int toplam;
    int sayı3=10;
    int sayı4=10;
    int çarpma;
    int sayı5 = 20;
    int sayı6 = 12;
    float bölme;

    
    // Start is called before the first frame update
    void Start()
    {
        toplam= sayı1 + sayı2;
        Debug.Log(toplam);
        çarpma = sayı3 * sayı4;
        Debug.Log(çarpma);
        bölme = (float) sayı5 / sayı6;
        Debug.Log(bölme);
        sayı1--;
        Debug.Log(sayı1);
        sayı2++;
        Debug.Log(sayı2);
        toplam=sayı6 % sayı5;
        Debug.Log(toplam);

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
