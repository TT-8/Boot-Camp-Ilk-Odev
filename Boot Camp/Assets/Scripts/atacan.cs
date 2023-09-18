using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atacan : MonoBehaviour
{
	public int[] rakamlar = new int[9];

	void Start()
	{
		foreach (int rakam in rakamlar) // TÜM
		{
			rakamlar[rakam] = Random.Range(-99999, 99999);
			Debug.Log(rakamlar[rakam]);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}
