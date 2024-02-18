using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public Transform cam;
    public float playerActionDistance; // Perbaikan pada penamaan variabel

    private void Update()
    {
        RaycastHit hit;
        bool active = Physics.Raycast(cam.position, cam.forward, out hit, playerActionDistance); // Mengubah cam.TransformDirection(Vector3.forward) menjadi cam.forward

        if (Input.GetKeyDown(KeyCode.F) && active) // Mengubah KeyCode.f menjadi KeyCode.F agar sesuai dengan format casing pada KeyCode
        {
            if (hit.transform != null && hit.transform.GetComponent<Animator>() != null) // Memeriksa apakah ada objek yang terkena raycast dan memiliki komponen Animator
            {
                hit.transform.GetComponent<Animator>().SetTrigger("Active");
            }
        }
    }
}
