//UnityやC＃にはあらかじめ用意されているプログラムがあり、それを使うことを記述しています。
using UnityEngine;  //「UnityEngine」プログラムが使用できるようになります。
using System.Collections; //「System.Collections」プログラムが使用できるようになります。

//このスクリプトに「PlayerController」という名前をつけています。
public class PlayerController : MonoBehaviour { //ここから…★

    public float speed; //「speed」という名前の 変数 を宣言しています。

    private Rigidbody rb; //「rb」という名前の 変数 を宣言しています。

    //「Start」という名前の 関数 を宣言しています。
    void Start ()
    { //…ここから●

        rb = GetComponent<Rigidbody>();

    } //●ここまでが「Start」関数の中身です。

} //★ここまでが「PlayerController」の中身です。
