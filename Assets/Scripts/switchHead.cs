using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class switchHead : MonoBehaviour
{
    // public Sprite new_head;
    public SpriteRenderer spriteRenderer;
    public GameObject dented_head;
    public GameObject normal_head;
    // Start is called before the first frame update
    void Start()
    {
        // Get dented and normal heads and hide the dented on start.
        dented_head = GameObject.Find("dent_head");
        normal_head = GameObject.Find("head");
        dented_head.SetActive(false);

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        Debug.Log(spriteRenderer);
    }

    // Update is called once per frame
    void Update()
    {
        // new_head = Resources.Load("dent_head_01", typeof(Sprite)) as Sprite;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other);
        if(other.gameObject.name == "rock"){
            //Checks if rock triggers head hitbox
            other.gameObject.SetActive(false);
            Debug.Log(other + "hit the head");

            //Change normal head to dented head.
            normal_head.SetActive(false);
            dented_head.SetActive(true);
        }
    }
}
