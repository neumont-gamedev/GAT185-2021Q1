using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
<<<<<<< HEAD
	public int Score { get; set; } = 0;

	static Game instance = null;

	private void Awake()
	{
		instance = this;
	}

	public static Game Instance
	{
		get
		{
			return instance;
		}
	}

	public void AddPoints(int points)
	{
		Score += points;
		Debug.Log(Score);
=======
    public int Score { get; set; } = 0;

    private static Game instance = null;

	private void Awake()
	{
        instance = this;
    }

	public static Game Instance
    {
        get
        {
            return instance;
        }
    }

    public void AddScore(int score)
	{
        Score += score;
        Debug.Log(Score);
>>>>>>> 524de3bf71b08893570fef47ff86d4982b7edc79
	}
}
