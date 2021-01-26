using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    private Rigidbody rb;
    public LayerMask groundLayers;
    public float jumpForce = 7;
    public SphereCollider col;
    #region Monobehaviour API
    void Start()
    {
		rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //flat movement
        float moveVertical = Input.GetAxis("Vertical"); //upwards movement

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        //rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    #endregion
}
