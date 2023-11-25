using MenteBacata.ScivoloCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private float Horizontal = 0f;
    private float Vertical = 0f;
    private float direction = 0f;
    private Vector3 rotation;
    private Vector3 position;
    [SerializeField] private float HorizontalSpeed;
    [SerializeField] private float VerticalSpeed;
    [SerializeField] private float Speed;
    [SerializeField] private GameObject Character;
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
        if(Character.TryGetComponent<CharacterMover>(out CharacterMover component))
        if (Input.GetKey(KeyCode.W))
        {
                //component.Move(transform.forward * Speed * Time.deltaTime,false);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * Speed * -1 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * Speed * -1 * Time.deltaTime;
        }
        rotation = new Vector3(Vertical, Horizontal * -1, 0);
        transform.eulerAngles -= rotation;
    }
}
