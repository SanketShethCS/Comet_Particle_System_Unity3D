using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

	float[] t = new float[32] { 0.0f, 1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f, 10.0f, 11.0f, 12.0f, 13.0f, 14.0f, 15.0f, 16.0f, 17.0f, 18.0f, 19.0f, 20.0f, 21.0f, 22.0f, 23.0f, 24.0f,25.0f, 26.0f, 27.0f, 28.0f, 29.0f,30.0f,31.0f };
	float[] x = new float[32] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, -18.0f, -25.0f, -32.0f, -25.0f, -18.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
	float[] y = new float[32] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 10.0f, 20.0f, 30.0f, 40.0f, 30.0f, 20.0f, 10.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
	float[] z = new float[32] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, -5.0f, -10.0f, -15.0f, -20.0f, -25.0f, -30.0f, -35.0f, -40.0f, -45.0f, -50.0f, -55.0f, -60.0f, -65.0f, -70.0f, -75.0f, -80.0f, -85.0f, -90.0f, -95.0f, -100.0f, -105.0f, -110.0f, -115.0f, -120.0f };
	float[] xa = new float[32] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
	float[] ya = new float[32] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
	float[] za = new float[32] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
	float[] theta = new float[32] { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f };
	int i = 1;
	float currentTime;
	float lerptime;

	void Start()
	{
		currentTime = t[i - 1];
		transform.position = new Vector3(x[i - 1], y[i - 1], z[i - 1]);
	}

	// Update is called once per frame
	void Update()
	{
		if (i <= 31)
		{
			Debug.Log(i);
			currentTime = currentTime + Time.deltaTime;

			//print(currentTime + " " + "Value 1");
			lerptime = t[i] - t[i - 1];
			//print("Lerp time" + " " + lerptime);
			float perc = (currentTime - t[i - 1]) / lerptime;
			if (Time.deltaTime >= lerptime)
			{
				currentTime = lerptime;
			}
			Vector3 start = new Vector3(x[i - 1], y[i - 1], z[i - 1]);
			Vector3 end = new Vector3(x[i], y[i], z[i]);
			Vector3 from = new Vector3(xa[i - 1] * theta[i - 1], ya[i - 1] * theta[i - 1], za[i - 1] * theta[i - 1]);
			Vector3 to = new Vector3(xa[i] * theta[i], ya[i] * theta[i], za[i] * theta[i]);
			Quaternion fromq = Quaternion.Euler(from);
			Quaternion toq = Quaternion.Euler(to);
			transform.rotation = Quaternion.Slerp(fromq, toq, perc);
			transform.position = Vector3.Lerp(start, end, perc);


			//print(perc);
			if (perc >= 1)
			{
				i = i + 1;
				currentTime = t[i - 1];
			}

		}
		else
		{
			Debug.Log(i);
			i = 1;
			currentTime = t[i - 1];
			//transform.position = new Vector3(x[i - 1], y[i - 1], z[i - 1]);
		}

	}
}
