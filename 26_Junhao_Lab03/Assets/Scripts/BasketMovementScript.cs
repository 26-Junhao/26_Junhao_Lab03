using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;

    public GameObject scoreText;

    private AudioSource collectSound;
    public AudioSource deadSound;

    int score = 0;

    public GameObject TimeText;
    float time = 10f;
    int timeCount;
    // Start is called before the first frame update
    void Start()
    {
        collectSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);

        time -= Time.deltaTime;
        timeCount = Mathf.RoundToInt(time);
        TimeText.GetComponent<Text>().text = "Time: " + timeCount;
        if (time <= 0)
        {
            TimeText.GetComponent<Text>().text = "0";
            SceneManager.LoadScene("GamePlay_Level 2");
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Healthy"))
        {
            score += 10;
            scoreText.GetComponent<Text>().text = "Score: " + score;
            Destroy(collision.gameObject);
            collectSound.Play();
        }
        else if (collision.gameObject.CompareTag("Unhealthy"))
        {
            deadSound.Play();
            Destroy(collision.gameObject,1f);
            SceneManager.LoadScene("GameLoseScene");
        }
    }





}
