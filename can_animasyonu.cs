using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class can_animasyonu : MonoBehaviour
{
    public Color renk1 = Color.red;
    public float zaman = 0f;
    public Color renk2 = Color.white;
public float hiz = 2f;
    public GameObject obj;
    public bool kucultme = true;
 
void Start() {


        kucultme = true;
   
}
    void Update()
    {
      
 if (kucultme) {
        float kucultme_oranı = 1.0f / 60.0f; 
        Vector3 olcek = new Vector3(kucultme_oranı * Time.deltaTime, 0f, 0f);
        transform.localScale -= olcek;
            if (transform.localScale.x < 0.4f)
            {
                zaman += Time.deltaTime;
                float t = Mathf.PingPong(zaman * hiz, 1f);
       //obj.GetComponent<Renderer>().material.color = Color.Lerp(renk1, renk2, t);
        }


            if (transform.localScale.x < 0f)
            {
                Çarpisma_Kontrol.tekrar = 0;

                transform.localScale = new Vector3(0f, 0f, 0f);
                kucultme = false;
                int current_scene=SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(current_scene);
            }
    }
                

    }
}
