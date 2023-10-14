using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int Keys = 0;
    public int Coins = 0;
    public float speed = 10.0f;

    public Text keyAmount;
    public Text CoinAmount;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.LeftArrow))
       {
           transform.Translate(-speed * Time.deltaTime , 0,0);
       }
       if(Input.GetKey(KeyCode.RightArrow))
       {
           transform.Translate(speed * Time.deltaTime , 0,0);        
       }
       if(Input.GetKey(KeyCode.UpArrow))
       {
           transform.Translate(0, speed * Time.deltaTime, 0);        
       }
       if(Input.GetKey(KeyCode.DownArrow))
       {
           transform.Translate(0, -speed * Time.deltaTime, 0);        
       }

       if (Keys == 3)
       {
            Destroy(Door);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {   //Destroy Key and Count score
        if(collision.gameObject.tag == "Keys")
        {
            Keys++;
            keyAmount.text = "Keys: " + Keys;
            Destroy(collision.gameObject);
            SoundManagerScript.PlaySound("key");
        }
        //Destroy and score coins
        if(collision.gameObject.tag == "Coins")
        {
            Coins++;
            CoinAmount.text = ": " + Coins; 
            Destroy(collision.gameObject);
            SoundManagerScript.PlaySound("coin");
        }
        // Load Next Level once player touches Exit
        if (collision.gameObject.tag == "Exit")
        {
            SceneManager.LoadScene("Level2");
        }
        // Load Next Level once player touches Exit
        if (collision.gameObject.tag == "Exit1")
        {
            SceneManager.LoadScene("Level3");
        }
        // Load Next Level once player touches Exit
        if (collision.gameObject.tag == "Exit2")
        {
            SceneManager.LoadScene("Level4");
        }
        // Load Next Level once player touches Exit
        if (collision.gameObject.tag == "Exit3")
        {
            SceneManager.LoadScene("Level5");
        }
        if (collision.gameObject.tag == "Exit4")
        {
            SceneManager.LoadScene("Level6");
        }
        if (collision.gameObject.tag == "Exit5")
        {
            SceneManager.LoadScene("Level7");
        }
        if (collision.gameObject.tag == "Exit6")
        {
            SceneManager.LoadScene("Level8");
        }
        if (collision.gameObject.tag == "Exit7")
        {
            SceneManager.LoadScene("work");
        }
        if (collision.gameObject.tag == "Exit8")
        {
            SceneManager.LoadScene("SampleScene");
        }
        //Enemy kills player and scene/game is reloaded
        if (collision.gameObject.tag == "Enemies")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SoundManagerScript.PlaySound("playerDeath");
        }
        //Beam/laser Kills player and scene/game is reloaded
        if (collision.gameObject.tag == "beam")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SoundManagerScript.PlaySound("playerDeath");
        }
        //Bullet kills player and scene/game is reloaded
        if (collision.gameObject.tag == "bullets")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SoundManagerScript.PlaySound("playerDeath");
        }
        //How to bounce off walls
        if (collision.gameObject.tag == "walls")
        {
            if(Input.GetKey(KeyCode.LeftArrow))
                   {
                       transform.Translate(speed * Time.deltaTime , 0,0);
                   }
                   if(Input.GetKey(KeyCode.RightArrow))
                   {
                       transform.Translate(-speed * Time.deltaTime , 0,0);        
                   }
                   if(Input.GetKey(KeyCode.UpArrow))
                   {
                       transform.Translate(0, -speed * Time.deltaTime, 0);        
                   }
                   if(Input.GetKey(KeyCode.DownArrow))
                   {
                       transform.Translate(0, speed * Time.deltaTime, 0);        
                   }

        }
      
    }
    
}
