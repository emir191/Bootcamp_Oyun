using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Firlatma_Gostegesi : MonoBehaviour
{
    public Slider slider;
    public Karakter_Hareketi karakter_Hareketi;
    public TMPro.TextMeshProUGUI metin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Firlatma_degisimi();
        // metin.text = "Fırlatma Kuvveti: %" + karakter_Hareketi.firlatma_yüzdesi;
        metin.text = "Fırlatma Kuvveti: ";



    }
    public void Firlatma_degisimi()
    {
        if (slider != null)
        {
                    slider.value = karakter_Hareketi.firlatma_yüzdesi / 100f;

            
        }

    }
}
