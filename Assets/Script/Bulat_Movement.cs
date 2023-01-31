using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulat_Movement : MonoBehaviour
{
    [SerializeField]float speed = 5f;
    public Color color1 = Color.green;
    
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.color = color1;
    }
}
