using System.Collections;
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karakter_Hareketi : MonoBehaviour
{
   
    
    public AudioClip ilk;
    public AudioClip ikinci;
    public AudioClip ez;
   
    public AudioSource audioSource;

    GameObject İtem;
    public int firlatma_yüzdesi;
    public bool nesne_alindi = false;

    public bool nesne_bulundu = false;
    public bool ziplama_kontrol = false;
    float tiklanilan_an;
    float tiklanma_suresi;
    
    [SerializeField] GameObject cube;
    [SerializeField] int çarpım = 2;
    public int ziplama_carpani = 6;
    Rigidbody rigidBody;
    public float atis_gucu = 0;
    void Start()
    {
       
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {

        rigidBody.useGravity = false;





        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.Translate(Vector3.forward * Time.deltaTime * çarpım);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * çarpım);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * çarpım);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * çarpım);

        }
        if (Input.GetKeyDown(KeyCode.Space) && !ziplama_kontrol)
        {

            rigidBody.useGravity = false;

            if ((Vector3.up * ziplama_carpani).magnitude < 50)
            {
                rigidBody.AddForce(Vector3.up * ziplama_carpani, ForceMode.Impulse);
            }
            ziplama_kontrol = true;
        }
        if (Input.GetMouseButtonDown(1) && nesne_bulundu)
        {

            if (İtem != null && !nesne_alindi)
            {
                İtem.SetActive(false);
                nesne_alindi = true;

                audioSource.PlayOneShot(ilk);

            }
            nesne_bulundu = false;
            Debug.Log("merhaba");



        }
        if (Input.GetMouseButtonDown(0) && !nesne_bulundu)
        {
            
            tiklanilan_an = Time.time;




        }
        if (Input.GetMouseButtonUp(0) && nesne_alindi)
        {
            tiklanma_suresi = Time.time - tiklanilan_an;


             atis_gucu = Mathf.Clamp(tiklanma_suresi * 10, 0f, 10f);
   
            
            
        
            firlatma_yüzdesi = (int)atis_gucu * 10;



            if (İtem != null)
            {
                İtem.transform.position = cube.transform.position + cube.transform.forward  + new Vector3(0, 2f, 0);
                İtem.transform.rotation = cube.transform.rotation;

                Rigidbody rb = İtem.GetComponent<Rigidbody>();
                rb.velocity = cube.transform.forward * atis_gucu*1.5f + new Vector3(0, 2f, 0);

                audioSource.PlayOneShot(ikinci);


                İtem.SetActive(true);
                nesne_alindi = false;


            }
        }


        rigidBody.useGravity = true;


    }
    /*void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Nesne"))
        {
            nesne_bulundu = true;
            İtem = other.gameObject;
        }
    }*/
    void OnTriggerExit(Collider other)
    {
        İtem = null;
    }

    void OnCollisionEnter(Collision collision)
    {
         if(collision.gameObject.CompareTag("Dörtgen")&& ziplama_kontrol){
            Debug.Log("çarptı");
    
     rigidBody.AddForce(Vector3.up * 15, ForceMode.Impulse);
     
         }

        if (collision.gameObject.CompareTag("Kac"))
        {
            float carpisma_hizi = collision.relativeVelocity.magnitude;
            if (carpisma_hizi > 2f)
            {
                audioSource.PlayOneShot(ez);
                cube.GetComponent<Karakter_Hareketi>().enabled = false;

                StartCoroutine(Sahne_islemleri());

            }

        }
        if (collision.gameObject.CompareTag("Nesne"))
        {
            if (!nesne_alindi)
            {
                nesne_bulundu = true;
                İtem = collision.gameObject;
            }
        }
        if (collision.gameObject.CompareTag("Zemin"))
        {
            ziplama_kontrol = false;
        }


    }
    IEnumerator Sahne_islemleri()
    {
        
        yield return new WaitForSeconds(1f);
        int current_scene = SceneManager.GetActiveScene().buildIndex;
        Çarpisma_Kontrol.tekrar = 0;
    
        
        SceneManager.LoadScene(current_scene);
        
    }


}
    

  
