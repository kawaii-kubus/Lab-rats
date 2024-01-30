using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NoteInspector : MonoBehaviour
{
    [SerializeField] Camera _camera;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if(Physics.Raycast(_camera.transform.position, _camera.transform.forward, out RaycastHit hit, 5f))
            {
                Debug.DrawRay(_camera.transform.position, _camera.transform.forward * hit.distance, Color.red);
                if(hit.transform.tag == "Document")
                {
                    Debug.Log("Dokument");
                }
            }
        }
    }
}
