using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman_Zamanlayici : MonoBehaviour
{

    public Karakter_Hareketi karakter_Hareketi;
   
    public GameObject nesne;
    
    public bool ses_oynatildi = false;
    public AudioClip yuvarlan;
    float sahne_baslangici;
    void Start()
    {
        sahne_baslangici = Time.time;
       
    }

    void Update()
    {
       
        if (Time.time - sahne_baslangici >= 5 && !ses_oynatildi)
         {
             karakter_Hareketi.audioSource.PlayOneShot(yuvarlan);
             nesne.SetActive(false);
             ses_oynatildi = true;

         }

    }
}
