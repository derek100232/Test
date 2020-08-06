using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add : MonoBehaviour
{
	int num1 = 1;
	int num2 = 3;

	float num1_f = 1.1f;
	float num2_f = 2.3f;

	int DoAdd(int a,int b)
	{
		int sum = a + b;
		
		return sum;
	}

	float DoAdd(float a, float b)
	{
		float sum = a + b;

		return sum;
	}

	void Start()
    {
		Debug.Log("Result1： " + DoAdd(num1, num2));
		Debug.Log("Result2： " + DoAdd(num1_f, num2_f));
	}

   
}
