using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {
    private float numKills = 0;
    private float timePast = 0;
    public float timeLimit = 300.0f;
    // Use this for initialization
    void Start () {
        Slider timeSlider = FindObjectOfType<Slider>();
        timeSlider.maxValue = timeLimit;
    }

    // Update is called once per frame
    void Update () {
        timePast += Time.deltaTime;
        Slider timeSlider = FindObjectOfType<Slider>();
        timeSlider.value = timePast;
        if (timePast >= timeLimit)
        {
            //load scene
        }
    }

    public void AddNumKills() {
        this.numKills = this.numKills + 1;
        GameObject scoreObject = GameObject.Find("NumKills");
        Text scoreText = scoreObject.GetComponent<Text>();
        scoreText.text = "Score: " + numKills;
    }
}
