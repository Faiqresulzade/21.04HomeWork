using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Task_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.name = "Empty";
        collision.transform.parent = transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().enabled = false;
       // Debug.Log("Hello");
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().enabled = true;
        other.gameObject.tag = "Entered";
    }
}
