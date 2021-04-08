using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public float spawnRate = 5.0f;
    public TextMeshProUGUI scoreText;
    public float totalPopCount = 0.0f;
    public bool frenzy = false;
    public int frenzyThreshold = 20;
    public float frenzyLength = 100.0f;
    public TextMeshProUGUI gameOverText;
    public bool canGameOver = true;
    public bool gameOver = false;
    public Button restartButton;

    private int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartGame()
    {
        StartCoroutine(SpawnTarget());
	score = 0;
	UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (totalPopCount > frenzyThreshold && !frenzy) {
		canGameOver = false;
		spawnRate = 0.1f;
		frenzy = true;
		totalPopCount = 0.0f;
		StartCoroutine(FrenzyTime());
	}
    }

    public void GameOver()
    {
	gameOverText.gameObject.SetActive(true);
	restartButton.gameObject.SetActive(true);
	gameOver = true;
    }

    public void RestartGame()
    {
	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator FrenzyTime()
    {
	yield return new WaitForSeconds(frenzyLength);
	totalPopCount = 0.0f;
	spawnRate = 5.0f;
	frenzy = false;
	yield return new WaitForSeconds(5);
	canGameOver = true;
    }

    IEnumerator SpawnTarget()
    {
	while (!gameOver) {
		yield return new WaitForSeconds(spawnRate);
		int index = Random.Range(0, targets.Count);
		Instantiate(targets[index]);
	}
    }

    public void UpdateScore(int scoreToAdd)
    {
	score += scoreToAdd;
	scoreText.text = "Score: " + score;
    }
}
