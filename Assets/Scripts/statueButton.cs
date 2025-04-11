using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class statueButton : MonoBehaviour
{

    public GameObject bigStatue;
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


            bigStatue.transform.position = bigStatue.transform.position + new Vector3(0, -count*0.002f, count*0.002f);
            count++;
            if (count>500){
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
