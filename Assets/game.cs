using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public GameObject k�re;
    public GameObject k�p;
    public int skor;

    // Start is called before the first frame update
    void Start()
    {
        k�re.GetComponent<MeshRenderer>().material.color = Color.green;
    }
    // Update is called once per frame
    void Update()
    {
             
        if (Input.GetKeyDown(KeyCode.Space) && skor <= 1000)
            skor += 25;
        
            if (skor > 50)
                k�re.GetComponent<MeshRenderer>().material.color = Color.black;
        if (skor > 75)
            k�re.GetComponent<MeshRenderer>().material.color = Color.blue;

        if (k�re.GetComponent<MeshRenderer>().material.color == Color.blue)
            
            k�p.GetComponent<MeshRenderer>().material.color = Color.green;

        if (skor > 100)
            k�re.GetComponent<MeshRenderer>().material.color = Color.red;

        if (k�re.GetComponent<MeshRenderer>().material.color == Color.red)
        k�p.GetComponent<MeshRenderer>().material.color = Color.yellow;








    }
}
