using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorKiri;
    public Text skorKanan;

    public ScoreManager scoreManager;

    // Update is called once per frame
    void Update()
    {
        skorKiri.text = "0"+scoreManager.rightScore.ToString();
        skorKanan.text = "0"+scoreManager.leftScore.ToString();
    }
}
