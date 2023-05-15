using UnityEngine;
using System.Collections;

public class MenuBallSpawner : MonoBehaviour
{
	public GameObject BallPrefab;

	int randomPosX;
	int randomPosY;

	void Start()
	{
		Spawn();
	}

	void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Spawn();
		}
	}

	void CreateRandomPosition(int xMax, int yMax)
	{
		randomPosX = Random.Range(-xMax, 5);
		randomPosY = Random.Range(-yMax, 2);
	}

	void Spawn()
	{
		CreateRandomPosition(5, -2);

		Instantiate(BallPrefab, new Vector3(randomPosX, randomPosY, 0), Quaternion.identity);
	}
}