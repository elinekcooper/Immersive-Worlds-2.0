using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeButton : MonoBehaviour
{
    
    public GameObject cloud;

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
    }



    public void Selected(){
        Debug.Log("Selected");
	    GetComponent<Renderer>().material.SetColor("_BaseColor",Color.blue);

        cloud.transform.position = new Vector3(10, 0, 5);

    }


}
