using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Firlatma_Gostergesi : MonoBehaviour
{
    public Karakter_Hareketi karakter_Hareketi;
    public TMPro.TextMeshProUGUI metin;
    // Start is called before the first frame update
    void Start()
    {
     

    }


    void Update()
    {
        
            metin.text = "Fırlatma Kuvveti: %" + karakter_Hareketi.firlatma_yüzdesi;
        


    }

}