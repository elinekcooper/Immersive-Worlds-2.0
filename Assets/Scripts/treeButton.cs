using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeButton : MonoBehaviour
{
    
    public GameObject cloud;
    bool runMotion = false;

    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (runMotion) {


            cloud.transform.position = cloud.transform.position + new Vector3(count*0.005f, 0, count*0.005f);
            count++;
            if (count>350){
                runMotion = false;
            }
        }
    }

    public void Hovered(){
	Debug.Log("hovered");
    }



    public void Selected(){
        Debug.Log("Selected");
	    GetComponent<Renderer>().material.SetColor("_BaseColor",Color.blue);

        
        runMotion = true;

    }


}
