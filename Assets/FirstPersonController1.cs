using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController1 : MonoBehaviour
{
    public float sensitivitasMouse = 100f;
    public Transform badanPemain;

    float rotasiX = 0f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouse_X = Input.GetAxis("Mouse X") * sensitivitasMouse * Time.deltaTime;
        float mouse_Y = Input.GetAxis("Mouse Y") * sensitivitasMouse * Time.deltaTime;

        rotasiX -= mouse_Y;
        rotasiX = Mathf.Clamp(rotasiX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotasiX, 0f, 0f);

        badanPemain.Rotate(Vector3.up * mouse_X);

        float maju = Input.GetAxis("Vertical");
        float samping = Input.GetAxis("Horizontal");

        Vector3 arahGerak = (transform.forward * maju + transform.right * samping).normalized;

        // Pindahkan Rigidbody daripada transform langsung
        rb.MovePosition(rb.position + arahGerak * Time.deltaTime * 5f);
    }
}
