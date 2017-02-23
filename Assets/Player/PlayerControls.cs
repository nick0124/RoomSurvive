using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

    public float xSpeed;
    public float zSpeed;

    public float jumpForce;

    public GameObject head;

    public bool grounded;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


            //gameObject.GetComponent<Rigidbody>().velocity = transform.forward * Input.GetAxis("Vertical") * xSpeed;
            //gameObject.GetComponent<Rigidbody>().velocity = transform.right * Input.GetAxis("Horizontal") * zSpeed;
        float x = Input.GetAxis("Vertical") * xSpeed;
        float z = Input.GetAxis("Horizontal") * zSpeed;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(x, gameObject.GetComponent<Rigidbody>().velocity.y, -z);


        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
            head.transform.eulerAngles = new Vector3(0, -270, 0);
        else if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
            head.transform.eulerAngles = new Vector3(0, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
            gameObject.GetComponent<Rigidbody>().AddForce(0, jumpForce, 0);
	}

    void OnCollisionStay(Collision coll)
    {
        if (coll.contacts.Length > 0)
            grounded = true;
        else
            grounded = false;
    }

    void OnCollisionExit(Collision coll)
    {
        if (coll.contacts.Length > 0)
            grounded = true;
        else
            grounded = false;
    }
}
