using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(touched)
        {
            Application.Quit();
        }       
    }

    private void OnTriggerEnter(Collider other) {
        {
            if(other.CompareTag("deformity"))
            {
                print("Touched");
            }
        }
    }
}
