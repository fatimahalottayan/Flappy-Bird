using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerMovment : MonoBehaviour
{
    public int counter = 3;
    public Text countertx;
    public Rigidbody2D rb;
    public CharacterController controller;
    public float runspeed = 0f;
    //float horizontalMove = 0f;
    public float jumpAmount = 1.5f;
    //private Sprite img1;
    public GameObject gameovaer;
    public GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        gameovaer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       // rb.AddForce(Vector2.right * runspeed, ForceMode2D.Impulse);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }

        if (counter == 0)
        {
            //MyImage.AddComponent(typeof(Image));
            //img1 = Resources.Load<Sprite>("Assets/Sprites/GAME.jpeg");
            //MyImage.GetComponent<Image>().sprite = img1;
            //Debug.Log("Test script started");
            gameovaer.SetActive(true);
            bird.SetActive(false);
           // SceneManager.LoadScene(3);
           // Application.Quit();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(counter);
        if (collision.gameObject.name != "Square")
        {
           counter= counter-1;
            countertx.text = counter.ToString();
        }
    }
  

}
