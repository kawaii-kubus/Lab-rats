using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Header("Mouse settings")]
    [SerializeField] private float sensitivity;
    private float xRotation = 0f;
    [Header("Player")]
    [SerializeField]private Transform playerBody;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRotation();

    }

    private void PlayerRotation()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float mouseXCalc = mouseX * sensitivity * Time.deltaTime;
        float mouseYCalc = mouseY * sensitivity * Time.deltaTime;

        xRotation -= mouseYCalc;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseXCalc);
    }
}
