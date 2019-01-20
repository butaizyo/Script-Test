using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai2 : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
		//Magicクラスの変数を宣言しインスタンスを代入
		Boss b = new Boss ();

		//マジック関数を呼び出し

		//11回繰り返し
		for (int i = 0; i < 11; i++) {
			b.Magic (5);

		}
	}
	// Update is called once per frame
	void Update ()
	{

	}
}

public class Boss
{
	private int mp = 53;
	//MP

	//残りMP用の関数
	public void Magic (int a)
	{ 
		if (mp >= a) {
			mp -= a;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}
