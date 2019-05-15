---?color=#3A8FB7

@snap[headline]

@snap[byline headline-detail color4]
@size[0.75em](つくるUOZUプロジェクト)
@snapend

# ゲーム開発エンジンUnityとC#の基礎を学ぶ講座
@snapend

---?color=#3A8FB7

## 講師　松本 有生

* バンタンゲームアカデミー高等部　講師
* 合同会社ザワッグル　デザイナー・エンジニア
* アステリソフト合同会社　エンジニア


---

### @css[slide-title](講座の流れ)

@snap[slide-contents]

@ol[numberlist numberlist-color1](false)
- Unityの基礎  @css[detail-comment](Unityのインストールと使いかた)
- Visual Studioについて	@css[detail-comment](Visual Studioのダウンロードと使いかた)
- 学習の進めかた @css[detail-comment](Unityでプログラミングしながら学習する方法)
- おすすめする勉強サイト	@css[detail-comment](独学におすすめなWebページ一覧)
- C#の基礎 @css[detail-comment](C#の基礎文法)
@olend

@snapend


---?color=#3A8FB7

@snap[breadcrumbs-wrap bluescale]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [1. Unityの基礎](#/)
@olend
@snapend

@snap[west headline]
## Unityの基礎
@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [1. Unityの基礎](#/)
- [1. Unityとは](#/)
@olend
@snapend

### @css[slide-title](Unityとは)

@snap[slide-contents]

@snap[quote-wrap]
@quote[<ul><li>世界で最も使われているゲームエンジン（ゲーム開発に便利なソフトウェア）</li><li>1回ビルドするだけで、どのプラットフォームにも展開可能</li><li>世の中のVRとARの3分の2以上で利用</li></ul>](https://unity3d.com/jp/unity)
@snapend

[Unity公式サイト](https://unity3d.com/jp/) **（「unity 製品」で検索）**

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [1. Unityの基礎](#/)
- [2. Unityのインストール](#/)
@olend
@snapend

### @css[slide-title](Unityのインストール)

@snap[slide-contents]

@box[rounded box-style](まずUnity Hubをインストールし、<br>Unity HubからUnityをインストールします)

@ol[numberlist numberlist-color4](true)
- <u>[Unity Personalで今すぐスタート](https://store.unity.com/ja/download?ref=personal)</u>にアクセスします。 **（つくるUOZUプロジェクトの本イベントページにあるリンク、または「unity Personal」で検索）**
- **条件に同意する** をチェックします。
- **Unity Hubをダウンロード** をクリックしてインストールします。
- Unity Hubを起動します。
- **Installs** または　**インストール** の文字をクリックします。
- **Official Releases** または **インストール** をクリックします。
- **Unity 2018.4.0f1 LTS** を選択してインストールします。
@olend

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [1. Unityの基礎](#/)
- [3. Unityの使い方](#/)
@olend
@snapend

### @css[slide-title](Unityの使い方)

@snap[slide-contents]

@box[rounded box-style](Unityの使い方を学ぶには、<br>公式のマニュアルとチュートリアルが効果的です)

* [マニュアル](https://docs.unity3d.com/ja/current/Manual/UnityManual.html) **（「unity マニュアル」で検索）**
  * Unityについて詳しく説明されています。
* [チュートリアル](https://unity3d.com/jp/learn/tutorials) **（「unity チュートリアル」で検索）**
   * ゲームを作りながらUnityを学べます。

@snapend

---?color=#3A8FB7

@snap[breadcrumbs-wrap bluescale]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [2. Visual Studioについて](#/)
@olend
@snapend

@snap[west headline]
## Visual Studioについて
@snapend
  
---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [2. Visual Studioについて](#/)
- [1. Visual Studioとは](#/)
@olend
@snapend

### @css[slide-title](Visual Studioとは)

@snap[slide-contents]

@snap[quote-wrap]
@quote[<ul><li>統合開発環境（コードの記述からプログラムの実行までできるソフトウェア）</li><li>複数の言語に対応（C#、C++、JavaScriptほか）</li></ul>](https://docs.microsoft.com/ja-jp/visualstudio/ide/?view=vs-2019)
@snapend

[Visual Studio IDE ドキュメント](https://docs.microsoft.com/ja-jp/visualstudio/ide/?view=vs-2019) **（「visual studio ドキュメント 学習」で検索）**

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [2. Visual Studioについて](#/)
- [2. Visual Studioのダウンロード](#/)
@olend
@snapend

### @css[slide-title](Visual Studioのインストール)

@snap[slide-contents]

@box[rounded box-style](Visual Studioをインストールします)

@ol[numberlist numberlist-color4](true)
- <u>[Visual Studio のインストール](https://docs.microsoft.com/ja-jp/visualstudio/install/install-visual-studio?view=vs-2019)</u>にアクセスします。 **（「visual studio ダウンロード」で検索）**
- ページの記述にしたがってインストールします。
@olend

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [2. Visual Studioについて](#/)
- [3. Visual Studioの使い方](#/)
@olend
@snapend

### @css[slide-title](Visual Studioの使い方)

@snap[slide-contents]

@box[rounded box-style](Visual StudioとUnityを連携します)

@ol[numberlist numberlist-color4](true)
- <u>[Visual Studio Tools for Unity の使用を開始する](https://docs.microsoft.com/ja-jp/visualstudio/cross-platform/getting-started-with-visual-studio-tools-for-unity?view=vs-2019)</u>にアクセスします。 **（「visual studio unity」で検索）**
- **手動インストール** の手順で **Unity によるゲーム開発** をインストールします。
- **Visual Studio で使用するために Unity を構成する** の手順で設定します。
@olend

@snapend

---?color=#3A8FB7

@snap[breadcrumbs-wrap bluescale]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [3. 学習の進めかた](#/)
@olend
@snapend

@snap[west headline]
## 学習の進めかた
@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [3. 学習の進めかた](#/)
- [1. Unityの学び方](#/)
@olend
@snapend

### @css[slide-title](Unityの学び方)

@snap[slide-contents]

@box[rounded box-style](Unityは公式のチュートリアルが充実しています。チュートリアルに沿ってゲーム制作を行いながらUnityを学ぶのが効率的です。)

@ul
- <u>[Unityチュートリアル](https://unity3d.com/jp/learn/tutorials)（「unity チュートリアル」で検索）
@ulend


@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [3. 学習の進めかた](#/)
- [2. C#の学び方](#/)
@olend
@snapend

### @css[slide-title](C#の学び方)

@snap[slide-contents]

@box[rounded box-style](Unityの公式チュートリアルを進めていくと、C#のスクリプトについても同時に学べます。)

その他に興味のある方は、専門書や専門サイトなどで勉強すると知識が深まります。

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [3. 学習の進めかた](#/)
- [3. Unityスクリプトリファレンスの使い方](#/)
@olend
@snapend

### @css[slide-title](Unityスクリプトリファレンスの使い方)

@snap[slide-contents]

@box[rounded box-style](Unityでスクリプトを書いていて知りたいワードが出てきたときは、公式のスクリプトリファレンスで検索して学びます。)

@ol
- <u>[Unityスクリプトリファレンスへようこそ](https://docs.unity3d.com/ja/current/ScriptReference/index.html)にアクセスします。（「unity スクリプトリファレンス」で検索）
- 検索ボックスに知りたいワードを記入して検索します。
- 該当するページを開いて学びます。
@ulend

@snapend

---?color=#3A8FB7

@snap[breadcrumbs-wrap bluescale]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C#の基礎](#/)
@olend
@snapend

@snap[west headline]
## C#の基礎
@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C#の基礎](#/)
- [1. コードの読み方](#/)
@olend
@snapend

### @css[slide-title](コードの読み方)

@snap[slide-contents]

[Unityチュートリアル「玉転がし」「プレイヤーの移動」](https://unity3d.com/jp/learn/tutorials/projects/roll-ball-tutorial/moving-player?playlist=45990)から転載
```C#
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }
}
```
@[1-2]1-2行目：UnityやC#にはあらかじめ用意されているプログラムがあります。このように記述すると例えば「UnityEngine」プログラムが使用できるようになります。
@[4]4行目：このスクリプトに「PlayerController」という名前をつけています。これに続く`{`から最終行の`}`までがこのスクリプトの中身です。
@[6]6行目：**変数**の宣言部分です。同様に8行目も別の変数の宣言をしています。
@[10]10行目：**関数**の宣言部分です。これに続く`{`から13行目の`}`までがこの関数の中身です。
@[15-23]行目：別の関数の、宣言と中身の定義です。

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C#の基礎](#/)
- [2. 変数と関数とは](#/)
@olend
@snapend

### @css[slide-title](変数と関数とは)

@snap[slide-contents]

@box[rounded box-style](プログラムは「データ」と「処理」でできています。)

@ul
- データを保存する部分：**変数**
- 処理する部分：**関数**
@ulend

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C#の基礎](#/)
- [3. 変数と関数の見分け方](#/)
@olend
@snapend

### @css[slide-title](変数について)

@snap[slide-contents]

@box[rounded box-style](変数とはデータを保存するための箱、とイメージするとわかりやすいです。<br>変数には3つの概念があります。)

@ul
- データの種類：**型**（整数・文字列などあらかじめ決められているものと、自分で作るものとがあります）
- データの名前：**識別子**（ルールにしたがって自分でつけます）
- データの中身：**値**（右辺から左辺にある識別子に代入するという形で中身を保存します）
@ulend

```C#
型    識別子           代入  値                           文の終わりを示す
float moveHorizontal   =   Input.GetAxis ("Horizontal") ;
```
@snapend
