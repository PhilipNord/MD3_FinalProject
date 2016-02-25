using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour

{
    Rigidbody rigidBody;
    public float speed;
    public float m_gravity;
    private Vector3 lowGravity = Vector3.zero;

    void Start() {
        rigidBody = this.GetComponent<Rigidbody>();
        
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        lowGravity += Physics.gravity * m_gravity * Time.fixedTime;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidBody.MovePosition(rigidBody.position + movement * Time.time * speed);
        
    }
}