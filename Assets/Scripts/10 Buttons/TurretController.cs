using UnityEngine;



public class TurretController : MonoBehaviour
{
    public EmergencyStop emergencyStop;
    public Animator animator;

    public void StartOrResume()
    {
        

        animator.enabled = true;
        animator.SetBool("IsRunning", true);
        animator.speed = 1f;
    }

    public void PauseOrStop()
    {
        animator.speed = 0f;
    }

    public void ResetTool()
    {
        animator.speed = 1f;                  // allow animation to play
        animator.SetBool("IsRunning", false);  // stop cutting
        animator.SetTrigger("ResetTrigger");   // play return animation
    }
}
