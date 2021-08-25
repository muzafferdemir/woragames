using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
    
{
    float cu;
   public float toplanan1; 
    public float toplanan2; 
    
    // Start is called before the first frame update
    void Start()
    {
        cu = toplanan1 + toplanan2;
        Debug.Log(cu);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
