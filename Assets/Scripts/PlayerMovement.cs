using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("PlayerComponents")]
    private Rigidbody rb;
    private CharacterController chController;
    [SerializeField]private float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        chController = GetComponent<CharacterController>();

    }

    private void Update()
    {
        Walking();

    }

    private void Walking()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        chController.Move(move * moveSpeed * Time.deltaTime);

    }
}
