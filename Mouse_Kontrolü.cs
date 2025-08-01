using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Mouse_Kontrolü : MonoBehaviour
{
    public GameObject karakter;
    public GameObject yönerge_oku;
    public Camera cam;
    public float kontrol = 1f;
    public float döndür = 0f;


    void Start()
    {
        

    }
   
    void Update()
    {
        Yatay_hareket();
       


    }
    void Yatay_hareket()
    {
        float dönüş_takibi = Input.GetAxis("Mouse X") * kontrol;
        döndür = (döndür + dönüş_takibi) % 360f;
        //cam.transform.rotation = Quaternion.Euler(0, döndür, 0);
        karakter.transform.rotation = Quaternion.Euler(0, döndür, 0);
        Vector3 ok_konum = yönerge_oku.transform.rotation.eulerAngles;
        yönerge_oku.transform.rotation = Quaternion.Euler(ok_konum.x, döndür + 90, ok_konum.z);
       // yönerge_oku.transform.position = karakter.transform.position + karakter.transform.forward * 0.7f+Vector3.up*0.2f;
        

        
        
    }
   
    
}
