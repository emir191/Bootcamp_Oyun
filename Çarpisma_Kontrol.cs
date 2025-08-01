using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Çarpisma_Kontrol : MonoBehaviour
{
   public AudioSource audioSource;
    GameObject[] toplar;
    public int ilk_değer;
    public static int tekrar = 0;
    void Start()
    {
        
        toplar = GameObject.FindGameObjectsWithTag("Nesne");
       ilk_değer = toplar.Length;
    }
    void Update()
    {
        
        if (tekrar == ilk_değer)
        {
             int current_scene = SceneManager.GetActiveScene().buildIndex;
            tekrar = 0;

            SceneManager.LoadScene(current_scene + 1);


        }
       
    
}
    void OnCollisionEnter(Collision collision)
{

    if (collision.gameObject.CompareTag("Nesne"))
    {
            audioSource.Play();
        tekrar++;
        Debug.Log(tekrar);
        /*if (tekrar == 7)
        {
            SceneManager.LoadScene(3);
        }*/


    }
}
}

