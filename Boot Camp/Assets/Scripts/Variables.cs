using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
	[Space]
	[Header("(int) Örneði")]
	[SerializeField] private int ornekSayi = 5;

	[Space]
	[Header("(float) Örneði")]
	[SerializeField] private float oyuncuHizi = 64.3f;
	// yuksekHiz = 100.0f
	// ortalamaHiz = 64.3f;
	// dusukHiz = 30.5f;

	[Space]
	[Header("(string) Örneði")]
	[SerializeField] private string[] trafikIsigi = { "Kýrmýzý", "Sarý", "Yeþil" };

	void Start()
	{
		// int kullaným örneði
		TekCiftOlcumu(ornekSayi);

		// float kullaným örneði
		HizKontrol(oyuncuHizi);

		// string Kullaným örneði
		TrafikIsigiDegistirme();
	}

	private void TekCiftOlcumu(int _x)
	{
		Debug.Log("---------------------[ INT ORNEGI ]------------------------");
		if (_x % 2 == 0)
		{
			Debug.Log("Girdiðiniz Sayý Çift");
		}
		else
		{
			Debug.Log("Girdiðiniz Sayý Tek");
		}
	}

	private void HizKontrol(float _hiz)
	{
		Debug.Log("---------------------[ FLOAT ORNEGI ]------------------------");

		switch (_hiz)
		{
			case 100.0f:
				Debug.Log("Hýzýnýz Yüksek!");
				break;
			case 64.3f:
				Debug.Log("Hýzýnýz Ortalama");
				break;
			case 30.5f:
				Debug.Log("Hýzýnýz Düþük");
				break;
			default:
				Debug.Log("Hýz deðeriniz beklenenin dýþýnda");
				break;
		}
	}

	private void TrafikIsigiDegistirme()
	{
		Debug.Log("---------------------[ STRING ORNEGI ]------------------------");
		Debug.Log("\nTrafik Iþýðý Renkleri:");

		int i = 0;

		while (i < 3)
		{
			Debug.Log(trafikIsigi[i]);
			i++;
		}
	}

}
