using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _bird.ScoreChenged += OnScoreChenged;
    }

    private void OnDisable()
    {
        _bird.ScoreChenged -= OnScoreChenged;
    }

    private void OnScoreChenged(int score)
    {
        _score.text = score.ToString();
    }
}
