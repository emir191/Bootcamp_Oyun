using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Konrol_ayari : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Kilit_ac());
        
    }
     IEnumerator Kilit_ac()
    {
        yield return null;
        int sahne_indeksi = SceneManager.GetActiveScene().buildIndex;
        if (sahne_indeksi == 2 || sahne_indeksi == 4|| sahne_indeksi==6)
        {
          
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
