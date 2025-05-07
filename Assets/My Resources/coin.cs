using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class coin : MonoBehaviour{
    public AudioClip collectSound;
    private AudioSource audioSource;
    private Rigidbody rb;
	public int coinCount;

    void Start () {
	    rb = GetComponent<Rigidbody>();
        coinCount = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)  {
        if (other.gameObject.CompareTag ("Coin")) {
            Destroy(other.transform.parent.gameObject);
            //other.gameObject.SetActive (false);
            coinCount +=1;
            if (collectSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(collectSound);
            }
        } else if (other.gameObject.CompareTag("Finish")) {
            PlayerPrefs.SetInt("CoinsCollected", coinCount);
            PlayerPrefs.SetFloat("CompletionTime", Time.timeSinceLevelLoad);

            SceneManager.LoadScene("FinishScene");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
