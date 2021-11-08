using UnityEngine;

public class Thorn : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Transform shoes;
    [SerializeField] private LayerMask layer;
    [SerializeField] private Hero hero;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && IsShoesInThorn())
        {
            Attack();
            hero.Die();
        }
    }

    private void Attack()
    {
        animator.SetTrigger("Attack");
    }

    private bool IsShoesInThorn()
    {
        Collider2D checkThorn = Physics2D.OverlapCircle(shoes.position, 0.1f, layer);
        if (checkThorn != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
