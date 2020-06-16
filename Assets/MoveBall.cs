using System.Collections;

using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody rg;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody> ();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rg.AddForce(movement * speed);


    }
}
