using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman_düzenleme : MonoBehaviour
{
    public Karakter_Hareketi karakter_Hareketi;
    public GameObject kar;
    public GameObject nes;
    public GameObject nes1;
    public bool ses_oynatildi = false;
    public bool ses_kontrol = false;

    public AudioClip yuvarlan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Mathf.Abs(kar.transform.position.z - nes.transform.position.z) < 8 && !ses_oynatildi )
        {
            karakter_Hareketi.audioSource.PlayOneShot(yuvarlan);
            nes.SetActive(false);
            ses_oynatildi = true;


        }
       
        if (Mathf.Abs(kar.transform.position.z - nes1.transform.position.z) < 10 && !ses_kontrol)
        {
            karakter_Hareketi.audioSource.PlayOneShot(yuvarlan);
            ses_kontrol = true;
            nes1.SetActive(false);
            ses_oynatildi = true;


        }
    }
}
