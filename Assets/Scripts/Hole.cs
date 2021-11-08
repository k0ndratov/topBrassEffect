using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform shoes;
    [SerializeField] private LayerMask holeLayer;
    [SerializeField] private GameObject gameObject;
    [SerializeField] private Hero hero;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(IsShoesInHole());
        if (collision.tag == "Player" && IsShoesInHole())
        {
            Collapse();
            hero.Die();
        }
    }

    private void Collapse()
    {
        animator.SetTrigger("Collapse");
    }

    private bool IsShoesInHole()
    {
        Collider2D checkHole = Physics2D.OverlapCircle(shoes.position, 0.1f, holeLayer);
        if (checkHole != null)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
