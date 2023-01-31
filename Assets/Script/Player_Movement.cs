using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Rigidbody2D _rBody;
    [SerializeField] float _speed;

    private SpriteRenderer _spRender;
    public Color color1 = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        _rBody = GetComponent<Rigidbody2D>();
        _spRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    private void Movement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rBody.velocity = (Vector2.up * _speed * Time.deltaTime);
        }
    }//Movement

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bulat"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("WinPoint"))
        {
            _spRender.color = color1;
        }
    }

}
