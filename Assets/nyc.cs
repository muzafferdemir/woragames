using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nyc : MonoBehaviour
{
    public string muzaffer;
    private int numara = 20;
    public float ondalikliSayi1 = 1.5f;
    public float ondalikliSayi2 = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(muzaffer);
        Debug.Log(numara);
        float toplam = ondalikliSayi1 + ondalikliSayi2;
        Debug.Log(toplam);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
