using UnityEngine;

public class ToolBodyController : MonoBehaviour
{
    public Animator animator;

    public void StartOrResume()
    {
        animator.enabled = true;
        animator.SetBool("IsRunning", true);
        animator.speed = 1f;
        Debug.Log("Start / Resume");
    }

    public void PauseOrStop()
    {
        animator.speed = 0f;
        Debug.Log("Pause / Stop");
    }

    public void ResetTool()
    {
        animator.SetBool("IsRunning", false);
        animator.Rebind();
        animator.Update(0f);
        animator.speed = 0f;
        Debug.Log("Reset to home");
    }
}
