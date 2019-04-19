using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyText : MonoBehaviour {

    public Text txt;

	void Update () {
        txt.text = Money.wallet.ToString();
	}
}
