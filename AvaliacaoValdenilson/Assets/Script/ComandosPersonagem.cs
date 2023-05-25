using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandosPersonagem : MonoBehaviour
{
    private Rigidbody2D rbPlayer;
    private Animator anim;
    public float velocidade;
    private float inputMovimento;
    public float forcaPulo;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputMovimento = Input.GetAxisRaw("Horizontal");
        rbPlayer.velocity = new Vector2(inputMovimento * velocidade, rbPlayer.velocity.y);
        if (Input.GetButtonDown("Jump")) 
        {
            rbPlayer.AddForce(new Vector2(0, forcaPulo));
        }
    }
}
