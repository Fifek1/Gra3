using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaKamery : MonoBehaviour
{
    private float xRot = 0f;
    public Transform playerbody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float myszkaX = Input.GetAxis("Mouse X");
        float myszkaY = Input.GetAxis("Mouse Y");

        playerbody.Rotate(Vector3.up * myszkaX);

        xRot -= myszkaY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);

        //transform.Rotate(Vector3.right * myszkaY * -1);

    }
}
