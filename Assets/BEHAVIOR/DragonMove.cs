using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class DragonMove : MonoBehaviour
{
    public float speed = 5;

    public bool goingUp = true;

    //Rat and Fireball timers.
    private float ratWait = 1, fireballWait = 2,biggerballsWait = 2;

    private float ratTimer = 0, fireballTimer = 0 ,biggerballsTimer = 2;


    public GameObject fireball;
    public GameObject rat;

    public GameObject biggerballs;

    // Update is called once per frame

    void Update()
    {
        // spawning
        ratTimer += Time.deltaTime;
        fireballTimer += Time.deltaTime;
        biggerballsTimer += Time.deltaTime;

        if (ratTimer > ratWait)
        {
            Instantiate(rat, transform.position, Quaternion.identity);
            ratTimer = 0;
            ratWait = Random.Range(1f, 2f);
        }
        if (fireballTimer > fireballWait)
        {
            Instantiate(fireball, transform.position, Quaternion.identity);
            fireballTimer = 0;
            fireballWait = Random.Range(2f, 3f);
        }
        if (biggerballsTimer > biggerballsWait)
        {
            Instantiate(biggerballs, transform.position, Quaternion.identity);
            biggerballsTimer = 0;
            biggerballsWait = Random.Range(1f, 2f);
        }
        transform.Translate(transform.up * speed * Time.deltaTime);

        if (transform.position.y > 4 && goingUp == true)
        {
            goingUp = false;
            speed *= -1;
        }

        if (transform.position.y < -4 && goingUp == false)
        {
            goingUp = true;
            speed *= -1;

        }

    }
}