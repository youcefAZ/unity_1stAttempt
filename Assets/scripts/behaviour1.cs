using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behaviour1 : MonoBehaviour
{

    public Rigidbody player;
    public float speed=100;

  /*  // Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("z")){
            player.AddForce(Vector3.left * Time.deltaTime * speed, ForceMode.VelocityChange);
              if(Input.GetKey("q")){
                 player.AddForce(Vector3.back * Time.deltaTime * speed, ForceMode.VelocityChange);
           }
             else if(Input.GetKey("d")){
                 player.AddForce(Vector3.forward * Time.deltaTime * speed, ForceMode.VelocityChange);
             } 
             
              else if(Input.GetKey("f")){
            player.AddForce(Vector3.up * Time.deltaTime * speed, ForceMode.VelocityChange);
        }
        }
       
        else if (Input.GetKey("s")){
            player.AddForce(Vector3.right * Time.deltaTime * speed, ForceMode.VelocityChange);
        }
        
    }
}
