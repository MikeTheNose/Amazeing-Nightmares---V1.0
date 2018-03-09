using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand_script : MonoBehaviour {

    // Use this for initialization

    public float distance = 5.0f;
    public LayerMask boxMask;
    GameObject CubeToMoved;
    float m_Speed;


    void Start()
        {
        m_Speed = 3.0f;
    }

    
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, distance,boxMask))
            print("There is something in front of the object!");

        RaycastHit hitt;
        Physics.Raycast(transform.position, transform.forward, out hitt, distance, boxMask);

        if (hitt.collider != false && Input.GetKey(KeyCode.E)) { 
            Debug.Log("I took the COLLIDER NOT NULL!");
            CubeToMoved = hitt.collider.gameObject;
            Rigidbody rb = hitt.rigidbody;
            CubeToMoved.transform.Translate(fwd* m_Speed * Time.deltaTime);
            transform.parent.transform.Translate(fwd * m_Speed * Time.deltaTime);
        }

        if (hitt.collider != false && Input.GetKey(KeyCode.F))
        {
            Debug.Log("I took the COLLIDER NOT NULL!");
            CubeToMoved = hitt.collider.gameObject;
            Rigidbody rb = hitt.rigidbody;
            CubeToMoved.transform.Translate(fwd * -m_Speed * Time.deltaTime);
            transform.parent.transform.Translate(fwd * -m_Speed * Time.deltaTime);
        }
    }

}


