using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void ExitGameButton()
    {
        // Keluar dari aplikasi
        Application.Quit();
    }

     void Update()
    {
        // Jika tombol "Escape" ditekan
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Keluar dari aplikasi
            Application.Quit();
        }
    }

}
