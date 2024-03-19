using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.position += transform.forward * horizontalInput * speed * Time.deltaTime;
        float verticalInput = Input.GetAxisRaw("Vertical");
        transform.position += transform.forward * verticalInput * speed * Time.deltaTime;
    }
}