using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
    [SerializeField] private        float                 speed;
    [SerializeField] private        Rigidbody2D           rigidbody2D;
    [SerializeField] private        Animator              animator;
                     private        Vector2               _direction;
                     private        Vector2               velocity;
                     private        bool                  isDie;


    private void Start()
    {
        velocity = new Vector2(0f, 0f);
        isDie = false;
    }

    private void Update()
    {
        InputUpdate();
        if (isDie)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    private void InputUpdate()
    {
        _direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        animator.SetFloat("Horizontal", _direction.x);
        animator.SetFloat("Vertical", _direction.y);
        animator.SetFloat("Speed", _direction.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        if (!isDie)
        {
            Move();
        }
        else
        {
            _direction = Vector2.zero;
            Move();
        }
    }

    private void Move()
    {
        rigidbody2D.velocity = _direction != Vector2.zero ? _direction * speed : Vector2.zero;
    }

    public void Die()
    {
        animator.SetTrigger("IsDie");
        isDie = true;
    }
}
