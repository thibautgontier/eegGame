using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountMenu : MonoBehaviour
{
    public Text counter;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = MissionCounter.MissionCount.ToString();
    }
}