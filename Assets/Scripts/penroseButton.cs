using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class penroseButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Hovered(){
	Debug.Log("hovered");
    transform.Rotate(Vector3.up* Time.deltaTime);
    }



    public void Selected(){
        Debug.Log("Selected");
	    GetComponent<Renderer>().material.SetColor("_BaseColor",Color.blue);
    
    }



    public void Activated(){
        Debug.Log("activated");
    }
}
