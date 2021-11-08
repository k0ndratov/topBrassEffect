using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            animator = GetComponent<Animator>();
            PlayAnim();
        }
    }

    private void PlayAnim()
    {
        animator.SetTrigger("Play");
    }
}
