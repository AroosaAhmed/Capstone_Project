using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{


    public float speed;
    public static int Score = 0;
    public Text ScoreUI;
    public Text LivesUI;
    public static int Lives = 5;

    private float verticalInput;
    public float turnSpeed;
    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputviakeyboard();
        ScoreUI.text = Score.ToString();
        LivesUI.text = Lives.ToString();
        if(Lives == 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

   

    void inputviakeyboard()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

      
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

}
