using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    public string sceneName; // Nama scene yang ingin dipindahkan

    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    void OnMouseDown()
    {
        Debug.Log("Tombol diklik!");
        // Tambahkan aksi tambahan di sini
    }



}
