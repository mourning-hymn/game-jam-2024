using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "door"){
            Time.timeScale = 1f;
            SceneManager.LoadScene("BrokenLegs");
        }
        else if(other.gameObject.name == "Door 2")
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("GameOver");
        }
    }
}
