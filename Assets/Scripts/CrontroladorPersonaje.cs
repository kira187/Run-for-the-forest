using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrontroladorPersonaje : MonoBehaviour
{

    public float fuerzaSalto = 16;

    private bool enSuelo = true;
    public Transform comprobadorSuelo;
    public LayerMask mascaraSuelo;
    private float comprobadorRadio = 0.07f;
    private Rigidbody2D rbPlayer;

    private bool dobleSalto = false;
    private Animator animator;

    public bool corriendo = false;
    public float velocidad = 8f;

    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        if (corriendo)
        {
            rbPlayer.velocity = new Vector2(velocidad, rbPlayer.velocity.y);
        }
        animator.SetFloat("VelocidadX", rbPlayer.velocity.x);
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
        animator.SetBool("IsGrounded", enSuelo);

        if (enSuelo)
        {
            dobleSalto = false;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (corriendo)
            {
                if (enSuelo || !dobleSalto)
                {
                    rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, fuerzaSalto);

                    if (!dobleSalto && !enSuelo)
                    {
                        dobleSalto = true;
                    }
                }
            }
            else
            {
                corriendo = true;
                NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeEmpiezaAcorrer");
            }
        }
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
