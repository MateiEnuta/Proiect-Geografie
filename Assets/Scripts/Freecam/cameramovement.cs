using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class cameramovement : MonoBehaviour
{
    private float Horizontal = 0f;
    private float Vertical = 0f;
    private float direction = 0f;
    private Vector3 rotation;
    [SerializeField] private float HorizontalSpeed = 100f;
    [SerializeField] private float VerticalSpeed = 100f;
    [SerializeField] private float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = HorizontalSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;
        Vertical = VerticalSpeed * Input.GetAxis("Mouse Y") * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += transform.forward * Speed * -1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position += transform.right * Speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += transform.right * Speed * -1 * Time.deltaTime;

        rotation = new Vector3 (Vertical, Horizontal*-1, 0);
        transform.eulerAngles -= rotation;
    }
}
