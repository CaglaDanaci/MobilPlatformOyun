using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geri : MonoBehaviour {

	public void bolum_geri(int bolum_sistemi)
	{
		Application.LoadLevel (bolum_sistemi);
	}
}