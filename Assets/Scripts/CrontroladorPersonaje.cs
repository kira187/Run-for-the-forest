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

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

  
    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
        animator.SetBool("IsGrounded", enSuelo);

        if (enSuelo)
        {
            dobleSalto = false;
        }
    }

    // Update is called once per frame
    void Update()
    {    
        if ((enSuelo || !dobleSalto) && Input.GetKeyDown(KeyCode.Space)) //Input.GetMouseButtonDown(0)
        {
            rbPlayer.velocity = (new Vector2(rbPlayer.velocity.x, fuerzaSalto));           
            if (!dobleSalto && !enSuelo)
            {
                dobleSalto = true;
            }
        }
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
}
