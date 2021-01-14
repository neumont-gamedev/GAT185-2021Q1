using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
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
	}
}
