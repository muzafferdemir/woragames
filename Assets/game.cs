using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public GameObject küre;
    public GameObject küp;
    public int skor;

    // Start is called before the first frame update
    void Start()
    {
        küre.GetComponent<MeshRenderer>().material.color = Color.green;
    }
    // Update is called once per frame
    void Update()
    {
             
        if (Input.GetKeyDown(KeyCode.Space) && skor <= 1000)
            skor += 25;
        
            if (skor > 50)
                küre.GetComponent<MeshRenderer>().material.color = Color.black;
        if (skor > 75)
            küre.GetComponent<MeshRenderer>().material.color = Color.blue;

        if (küre.GetComponent<MeshRenderer>().material.color == Color.blue)
            
            küp.GetComponent<MeshRenderer>().material.color = Color.green;

        if (skor > 100)
            küre.GetComponent<MeshRenderer>().material.color = Color.red;

        if (küre.GetComponent<MeshRenderer>().material.color == Color.red)
        küp.GetComponent<MeshRenderer>().material.color = Color.yellow;








    }
}
