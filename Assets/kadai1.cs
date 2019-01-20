using UnityEngine;
using System.Collections;

public class kadai1 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		//要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください。
		int[] array = { 1, 3, 5, 7, 9 };

		//for文を使い、配列の各要素の値を順番に表示してください
		for (int i = 0; i < array.Length; i++) {


			Debug.Log (array [i]);
		}
		for (int i = array.Length - 1; 0 <= i; i--) {

			Debug.Log (array [i]);
		}
	}
	// Update is called once per frame
	void Update ()
	{
	}
}