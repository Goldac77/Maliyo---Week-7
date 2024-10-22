using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI txtScore;
    [SerializeField] private TextMeshProUGUI txtBest;

    void Update()
    {
        txtBest.text = "Best: " + GameManager.singleton.best;
        txtScore.text = "Score: " + GameManager.singleton.score;
    }
}
