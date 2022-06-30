using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoleCollision : MonoBehaviour
{
    /*private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("étoile capturée !!!"); // Affichage d'un message dans la console
        Destroy(gameObject); // On efface l'étoile
        SceneManager.LoadScene("SampleScene"); // On recharge la scène
    }*/

        // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Perdu...");
         SceneManager.LoadScene("BoardScene");
    }
}