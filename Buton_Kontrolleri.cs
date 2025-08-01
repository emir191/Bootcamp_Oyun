using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buton_Kontrolleri : MonoBehaviour
{
    public Image image;
    // Start is called before the first frame update
    public void OyunuBaslat()
    {
        int current_scene = SceneManager.GetActiveScene().buildIndex;


        SceneManager.LoadScene(current_scene + 1);
    }
    public void Oyundan_cik()
    {
        Application.Quit();
    }
    public void Nasil_Oynanir()
    {
        image.gameObject.SetActive(true);

    }
    public void Bilgilendirme_kapat()
    {
         image.gameObject.SetActive(false);
    
   }
}
