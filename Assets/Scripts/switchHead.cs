using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    // Update is called once per frame
    void Update()
    {
        // new_head = Resources.Load("dent_head_01", typeof(Sprite)) as Sprite;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered box collider");
    }
}
