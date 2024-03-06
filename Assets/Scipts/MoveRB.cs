using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 5f; // ความเร็วในการเคลื่อนที่
    [SerializeField]private float rotationSpeed = 100f; // ความเร็วในการหมุน

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = false; // ไม่ให้ Rigidbody หมุนโดยอัตโนมัติ
    }

    void Update()
    {
        // เคลื่อนที่และหมุน
        MoveAndRotate();
    }

    void MoveAndRotate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.right * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.right * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

         if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.forward * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
             transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-transform.forward * moveSpeed * Time.deltaTime, ForceMode.VelocityChange);
             transform.Rotate(Vector3.right, -rotationSpeed * Time.deltaTime);

        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }
}
