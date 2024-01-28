using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchHead : MonoBehaviour
{
    public Sprite new_head;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered box collider");
    }
}
