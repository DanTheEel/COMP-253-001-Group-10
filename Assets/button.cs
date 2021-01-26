using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject otherButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        otherButton.SetActive(true);
        transform.parent.gameObject.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" )
        {
            this.transform.position = new Vector3(this.transform.position.x - .70f, this.transform.position.y, -21.24586f);
            otherButton.SetActive(true);
            transform.parent.gameObject.SetActive(false);
        }
    }
}
