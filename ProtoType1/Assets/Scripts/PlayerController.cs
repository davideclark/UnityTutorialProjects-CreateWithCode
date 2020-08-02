using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnSpeed = 25f;
    private float horizontialInput;
    private float fowardInput;

    public string horizontalInput; // Vertical2
    public string verticalInput; // Horizontal2

    //private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        //playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontialInput = Input.GetAxis(horizontalInput);
        Debug.Log(horizontialInput);
        fowardInput = Input.GetAxis(verticalInput);
        Debug.Log(fowardInput);
        // we'll move the vehicle foward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);
        
        // playerRb.AddForce(fowardInput * speed * Vector3.forward);

        // turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontialInput);
    }
}
