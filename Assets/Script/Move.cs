using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 position;
    private int speed=5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position=transform.position;
        
      if(Input.GetKey(KeyCode.W)){
        position.x +=speed*Time.deltaTime;
        transform.position=position;
      }
      if(Input.GetKey(KeyCode.S)){
        position.x-=speed*Time.deltaTime;
        transform.position=position;
      }
       if(Input.GetKey(KeyCode.A)){
        position.z +=speed*Time.deltaTime;
        transform.position=position;
      }
      if(Input.GetKey(KeyCode.D)){
        position.z-=speed*Time.deltaTime;
        transform.position=position;
      }
      
      
    }
}
