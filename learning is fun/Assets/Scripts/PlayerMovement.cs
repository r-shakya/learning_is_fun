using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // we are using fixed update for messing with physics
    void FixedUpdate()
    {
        //add forward force
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y < -3f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
