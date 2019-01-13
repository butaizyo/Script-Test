using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;
	private int mp = 53; //MP
	private int power = 25; //攻撃力

	//残りMP用の関数
	public void MP(int a, int b) { 
		 mp = a - b;
		if (mp >= 5) {
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	//Magic関数内でmpを5減らし、コンソールに「魔法攻撃をした。残りMPは〇〇。」
	//と表示してください。mpが足りない場合、「MPが足りないため魔法が使えな
	//い。」と表示してください
	// 攻撃用の関数
	}
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	//防御用の関数
	public void Defence (int damage)
	{
		Debug.Log (damage + "のダメージを受けた");
		//残りhpを減らす
		this.hp -= damage;
	}
	}

public class Scripttest : MonoBehaviour {

	void Start () {
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		//MP消費用の関数を呼び出す
		lastboss.MP(53, 5);
		//lastboss.Magic (20);
		//攻撃用の関数を呼び出す
		lastboss.Attack();
		//防御用の関数を呼び出す
		lastboss.Defence (56);
	}
}
	// Use this for initialization
/*
	void Start () {
		//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください。
		int [] array = { 1, 3, 5, 7, 9 };

		//for文を使い、配列の各要素の値を順番に表示してください
		for (int i = 0; i < array.Length; i++) {
				
			if (array [i] >= 0) {

				Debug.Log (array [i]);
			}
		}
		for (int i = array.Length - 1; 0 <= i; i--) {

			if (array [i] >= 0) {

				Debug.Log (array [i]);
			}
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}


/*質問
(1)C#課題
for (int i = array.Length - 1; 0 <= i; i--) {
上記のプログラムで配列を逆順にすることは出来たが、どういう仕組みで逆順になったのか知りたい。

(2)C#課題
public class Scripttest : MonoBehaviour を使用するときには、
void Start ()は利用できないのか？

*/