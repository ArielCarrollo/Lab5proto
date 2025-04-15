using UnityEngine;

public class DodgeFeedback : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void OnEnable()
    {
        DodgeController.OnDodge += ShowRollEffect;
    }

    void OnDisable()
    {
        DodgeController.OnDodge -= ShowRollEffect;
    }

    private void ShowRollEffect()
    {
        if (animator != null)
            animator.SetTrigger("Roll"); 
        Debug.Log("🎬 Animación de esquive activada.");
    }
}
