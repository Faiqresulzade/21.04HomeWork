using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<BoxCollider>().enabled = false;
        Destroy(GetComponent<BoxCollider>());
        gameObject.tag = "Changed";
        if (gameObject.tag == "Changed")
        {
            gameObject.name = "Changed";
            Destroy(GetComponent<Task_1>());
           // GetComponent<Task_1>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
