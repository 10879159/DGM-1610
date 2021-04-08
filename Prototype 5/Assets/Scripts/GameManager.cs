using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public float defaultSpawnRate = 5.0f;
    public TextMeshProUGUI scoreText;
    public float totalPopCount = 0.0f;
    public bool frenzy = false;
    public int frenzyThreshold = 20;
    public float frenzyLength = 100.0f;
    public TextMeshProUGUI gameOverText;
    public bool canGameOver = true;
    public bool gameOver = false;
    public Button restartButton;
    public GameObject titleScreen;

    private int score;
    private float spawnRate;
    private int difficultyForFrenzy;

    // Start is called before the first frame update
    void Start()
    {
	
    }

    public void StartGame(int difficulty)
    {
	difficultyForFrenzy = difficulty;
	spawnRate = defaultSpawnRate / difficulty;
        StartCoroutine(SpawnTarget());
	score = 0;
	UpdateScore(0);
	titleScreen.gameObject.SetActive(false);
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
	spawnRate = defaultSpawnRate / difficultyForFrenzy;
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
