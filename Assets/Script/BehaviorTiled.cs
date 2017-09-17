using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BehaviorTiled : MonoBehaviour {

	public Sprite image1;
	public Sprite image2;
	public Image[] tileds;

	int count = 0;

	// Use this for initialization
	void Start () {
		// StartCoroutine(updateImage());
	}
	
	// Update is called once per frame
	void Update () {
		// yield return new WaitForSecond(3);
	}

	IEnumerator updateImage() {
		while (count < tileds.Length) {
			tileds [count].sprite = image2;
			count++;
			Debug.Log (count);
			yield return new WaitForSeconds (3);
		}
	}

	public void test(Image tmp) {
		int index = System.Array.IndexOf (tileds, tmp);
		if (index % 3 == 0) {
			if (index + 1 < tileds.Length) {
				if (tileds [index + 1].sprite == image1) {
					tileds [index + 1].sprite = image2;
				} else {
					tileds [index + 1].sprite = image1;
				}
			}
			if (index - 3 >= 0) {
				if (tileds [index - 3].sprite == image1) {
					tileds [index - 3].sprite = image2;
				} else {
					tileds [index - 3].sprite = image1;
				}
			}
			if (index + 3 < tileds.Length) {
				if (tileds [index + 3].sprite == image1) {
					tileds [index + 3].sprite = image2;
				} else {
					tileds [index + 3].sprite = image1;
				}
			}
		} else {
			if (index + 1 < tileds.Length && (index % 3 != 2)) {
				if (tileds [index + 1].sprite == image1) {
					tileds [index + 1].sprite = image2;
				} else {
					tileds [index + 1].sprite = image1;
				}
			}
			if (index - 1 >= 0) {
				if (tileds [index - 1].sprite == image1) {
					tileds [index - 1].sprite = image2;
				} else {
					tileds [index - 1].sprite = image1;
				}
			}
			if (index - 3 >= 0) {
				if (tileds [index - 3].sprite == image1) {
					tileds [index - 3].sprite = image2;
				} else {
					tileds [index - 3].sprite = image1;
				}
			}
			if (index + 3 < tileds.Length) {
				if (tileds [index + 3].sprite == image1) {
					tileds [index + 3].sprite = image2;
				} else {
					tileds [index + 3].sprite = image1;
				}
			}
		}
	}
}
