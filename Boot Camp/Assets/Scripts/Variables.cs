using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
	[Space]
	[Header("(int) �rne�i")]
	[SerializeField] private int ornekSayi = 5;

	[Space]
	[Header("(float) �rne�i")]
	[SerializeField] private float oyuncuHizi = 64.3f;
	// yuksekHiz = 100.0f
	// ortalamaHiz = 64.3f;
	// dusukHiz = 30.5f;

	[Space]
	[Header("(string) �rne�i")]
	[SerializeField] private string[] trafikIsigi = { "K�rm�z�", "Sar�", "Ye�il" };

	void Start()
	{
		// int kullan�m �rne�i
		TekCiftOlcumu(ornekSayi);

		// float kullan�m �rne�i
		HizKontrol(oyuncuHizi);

		// string Kullan�m �rne�i
		TrafikIsigiDegistirme();
	}

	private void TekCiftOlcumu(int _x)
	{
		Debug.Log("---------------------[ INT ORNEGI ]------------------------");
		if (_x % 2 == 0)
		{
			Debug.Log("Girdi�iniz Say� �ift");
		}
		else
		{
			Debug.Log("Girdi�iniz Say� Tek");
		}
	}

	private void HizKontrol(float _hiz)
	{
		Debug.Log("---------------------[ FLOAT ORNEGI ]------------------------");

		switch (_hiz)
		{
			case 100.0f:
				Debug.Log("H�z�n�z Y�ksek!");
				break;
			case 64.3f:
				Debug.Log("H�z�n�z Ortalama");
				break;
			case 30.5f:
				Debug.Log("H�z�n�z D���k");
				break;
			default:
				Debug.Log("H�z de�eriniz beklenenin d���nda");
				break;
		}
	}

	private void TrafikIsigiDegistirme()
	{
		Debug.Log("---------------------[ STRING ORNEGI ]------------------------");
		Debug.Log("\nTrafik I���� Renkleri:");

		int i = 0;

		while (i < 3)
		{
			Debug.Log(trafikIsigi[i]);
			i++;
		}
	}

}
