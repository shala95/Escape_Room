using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{   
    public Timer timer ;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public string nextScene;

    void Start()
    {
        timer.SetDuration(20).Begin();    
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        if (timer.remainingDuration<=0){
            SceneManager.LoadScene(nextScene); 
        }
    }

    // FixedUpdate is called once per physics update
    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
