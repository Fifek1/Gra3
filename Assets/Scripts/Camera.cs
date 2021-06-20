using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float xRotacja = 0f;
    public Transform obiektgracz;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float myszkaX = Input.GetAxis("Mouse X");
        float myszkaY = Input.GetAxis("Mouse Y");

        obiektgracz.Rotate(Vector3.up * myszkaX);

        xRotacja -= myszkaY;
        xRotacja = Mathf.Clamp(xRotacja, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotacja, 0f, 0f);

        transform.Rotate(Vector3.right * myszkaY * -1);
    }
}