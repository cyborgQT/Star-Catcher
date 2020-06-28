using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    
    public Camera cam;
    public GameObject star;
    public float timeLeft;
    public Text timerTxt;
    private float maxWidth;
    public GameObject gameOverTxt, restartBttn, startBttn, instructions;
    private bool playing;
    public BasketController basketController;
    


    private void Start()
    {
        
        
        if(cam == null)
        {
            cam = Camera.main;
        }
        playing = false;
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = cam.ScreenToWorldPoint(upperCorner);
        float starWidth = star.GetComponent<Renderer>().bounds.extents.x;
        maxWidth = targetWidth.x - starWidth;
        UpdateTxt(); 
    }
    void FixedUpdate()
    {
        if (playing)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                timeLeft = 0;
            }
            UpdateTxt();
        }
    }
    public void StartGame()
    {
        startBttn.SetActive(false);
        basketController.ToggleControl(true);
        instructions.SetActive(false);
        StartCoroutine(Spawn());

    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2.0f);
        playing = true;
        while (timeLeft > 0)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth), transform.position.y, 0.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(star, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(Random.Range(1.0f, 2.0f)); 
        }
        yield return new WaitForSeconds(2.0f);
        gameOverTxt.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        restartBttn.SetActive(true);
    }
    void UpdateTxt()
    {
        timerTxt.text = "Time: " + Mathf.RoundToInt(timeLeft);
    }
    }


