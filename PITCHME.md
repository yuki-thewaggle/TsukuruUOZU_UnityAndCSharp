---?color=#3A8FB7

@snap[headline]

@snap[byline headline-detail color4]
@size[0.75em](つくるUOZUプロジェクト)
@snapend

# ゲーム開発エンジンUnityとC＃の基礎を学ぶ講座
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
- C＃の基礎 @css[detail-comment](C＃の基礎文法)
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
@quote[<ul><li>世界で最も使われているゲームエンジン（ゲーム開発に便利なソフトウェア）</li><li>1回ビルドするだけで、どのプラットフォーム（ソフトウェアが動作する環境）にも展開可能</li><li>世の中のVRとARの3分の2以上で利用</li></ul>](https://unity3d.com/jp/unity)
@snapend

<u>[The world’s leading
real-time creation platform](https://unity3d.com/jp/unity)</u>  @css[detail-comment](**「unity 製品」で検索**)

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

@box[rounded box-style](まずUnity Hubをインストールし、<br>Unity HubからUnityをインストールします。)

@ol[numberlist numberlist-color4](true)
- <u>[Unity Personalで今すぐスタート](https://store.unity.com/ja/download?ref=personal)</u>にアクセスします。 <br>@css[detail-comment](**つくるUOZUプロジェクトの本イベントページにあるリンク、または「unity Personal」で検索**)
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

@box[rounded box-style](Unityの使い方については、<br>公式のマニュアルがもっとも信頼できる情報です。)

* <u>[マニュアル](https://docs.unity3d.com/ja/current/Manual/UnityManual.html) </u>@css[detail-comment](**「unity マニュアル」で検索**)
  * Unityについて詳しく説明されています。

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
@quote[<ul><li>統合開発環境（コードの記述からプログラムの実行までできるソフトウェア）</li><li>複数の言語に対応（C＃、C++、JavaScriptほか）</li></ul>](https://docs.microsoft.com/ja-jp/visualstudio/ide/?view=vs-2019)
@snapend

<u>[Visual Studio IDE ドキュメント](https://docs.microsoft.com/ja-jp/visualstudio/ide/?view=vs-2019)</u> @css[detail-comment](**「visual studio ドキュメント 学習」で検索**)

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

@box[rounded box-style](Visual Studioをインストールします。)

@ol[numberlist numberlist-color4](true)
- <u>[Visual Studio のインストール](https://docs.microsoft.com/ja-jp/visualstudio/install/install-visual-studio?view=vs-2019)</u>にアクセスします。<br>@css[detail-comment](**「visual studio ダウンロード」で検索**)
- ページの記述にしたがってインストールします。
@olend

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [2. Visual Studioについて](#/)
- [3. Visual StudioとUnityの連携](#/)
@olend
@snapend

### @css[slide-title](Visual StudioとUnityの連携)

@snap[slide-contents]

@box[rounded box-style](Visual StudioとUnityを連携します。)

@ol[numberlist numberlist-color4](true)
- <u>[Visual Studio Tools for Unity の使用を開始する](https://docs.microsoft.com/ja-jp/visualstudio/cross-platform/getting-started-with-visual-studio-tools-for-unity?view=vs-2019)</u>にアクセスします。<br>@css[detail-comment](**「visual studio unity」で検索**)
- **手動インストール** の手順で<br>**Unity によるゲーム開発** をインストールします。
- **Visual Studioで使用するためにUnityを構成する** の手順で<br>設定します。
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

@box[rounded box-style](Unityは公式のチュートリアルが充実しています。<br>チュートリアルに沿ってゲーム制作を行いながら<br>Unityを学ぶのが効率的です。)

@ul
- <u>[Unityチュートリアル](https://unity3d.com/jp/learn/tutorials)</u>@css[detail-comment](**「unity チュートリアル」で検索**)
- <u>[はじめてのUnity](http://tutorial.unity3d.jp/)</u>@css[detail-comment](**「はじめてのunity」で検索**)
@ulend

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [3. 学習の進めかた](#/)
- [2. C＃の学び方](#/)
@olend
@snapend

### @css[slide-title](C＃の学び方)

@snap[slide-contents]

@box[rounded box-style](Unityの公式チュートリアルを進めていくと、<br>C＃のスクリプトについても同時に学べます。)

その他に興味のある方は、<br>専門書や専門サイトなどで勉強すると知識が深まります。

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [3. 学習の進めかた](#/)
- [3. スクリプトリファレンスの使い方](#/)
@olend
@snapend

### @css[slide-title](スクリプトリファレンスの使い方)

@snap[slide-contents]

@box[rounded box-style](Unityのスクリプトで知りたいワードが出てきたときは、<br>公式のスクリプトリファレンスで検索して学びます。)

@ol[numberlist numberlist-color4](true)
- <u>[Unityスクリプトリファレンスへようこそ](https://docs.unity3d.com/ja/current/ScriptReference/index.html)</u>にアクセスします。@css[detail-comment](**「unity スクリプトリファレンス」で検索**)
- 検索ボックスに知りたいワードを記入して検索します。
- 該当するページを開いて学びます。
@olend

@snapend

---?color=#3A8FB7

@snap[breadcrumbs-wrap bluescale]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C＃の基礎](#/)
@olend
@snapend

@snap[west headline]
## C＃の基礎
@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C＃の基礎](#/)
- [1. 変数と関数とは](#/)
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
- [4. C＃の基礎](#/)
- [2. 変数について](#/)
@olend
@snapend

### @css[slide-title](変数について)

@snap[slide-contents]

@box[rounded box-style](変数とはデータを保存するための箱である、<br>とイメージするとわかりやすいです。<br>変数には3つの概念があります。)

@ul
- データの種類：**型** @css[detail-comment](（整数・文字列などあらかじめ決められているものと、自分で作るものとがあります）)
- データの名前：**識別子** @css[detail-comment](（ルールにしたがって自分でつけます）)
- データの中身：**値** @css[detail-comment](（右辺から左辺にある識別子に代入するという形で中身を保存します）)
@ulend

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C＃の基礎](#/)
- [3. 変数の書き方](#/)
@olend
@snapend

### @css[slide-title](変数の書き方)

@snap[slide-contents]

@box[rounded box-style](変数は「** 型 識別子 = 値 ; **」のように書きます。)

```
float moveHorizontal   =   Input.GetAxis("Horizontal") ;
↓
float＜型＞ moveHorizontal＜識別子＞ =＜代入＞ Input.GetAxis("Horizontal")＜値＞ ;＜文の終わりを示す＞
```
@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C＃の基礎](#/)
- [4. 関数について](#/)
@olend
@snapend

### @css[slide-title](変数について)

@snap[slide-contents]

@box[rounded box-style](関数では、データをどのように処理させるかを指定します。<br>関数には4つの概念があります。)

@ul
- 関数の種類：**関数の型** @css[detail-comment](（処理した結果どのような種類の値を返すのかを表します）)
- 関数の名前：**識別子** @css[detail-comment](（ルールにしたがって自分でつけます）)
- 処理させたいデータ：**引数** @css[detail-comment](（処理させたいデータがあるときに指定します）)
- 関数の中身：**定義** @css[detail-comment](（`{`と`}`で囲った中に記述します）)
@ulend

@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C＃の基礎](#/)
- [5. 関数の書き方](#/)
@olend
@snapend

### @css[slide-title](関数の書き方)

@snap[slide-contents]

@box[rounded box-style](関数は「** 関数の型 識別子 ( 引数 ) { 定義 } **」のように書きます。)

```
void Start ()
{
    rb = GetComponent<Rigidbody>();
}
↓
void＜関数の型＞ Start＜識別子＞ ()＜引数：空のカッコの場合は引数なし＞
{
    rb = GetComponent<Rigidbody>();＜定義＞
}
```
@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [4. C＃の基礎](#/)
- [4. コードの読み方](#/)
@olend
@snapend

### @css[slide-title](コードの読み方)

@snap[slide-contents]

@snap[detail-comment]
[Unityチュートリアル「玉転がし」>「プレイヤーの移動」](https://unity3d.com/jp/learn/tutorials/projects/roll-ball-tutorial/moving-player?playlist=45990)から転載
@snapend

@img[goal-image to-center](/template/img/PlayerController.png)

@snapend

@snapend

