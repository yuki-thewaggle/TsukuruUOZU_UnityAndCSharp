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
- Unityの基礎  @css[detail-comment](Unityについての基本的な情報と使い方)
- Visual Studioについて	@css[detail-comment](Unityで使うプログラミングのコードを記述するソフトウェア)
- 学習の進めかた @css[detail-comment](効率的にUnityとC#のスキルを獲得できる学習方法)
- C＃の基礎 @css[detail-comment](プログラミングの知識を簡単に)
- 実演 @css[detail-comment](独学をしていくためのイメージトレーニング)
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
@quote[<ul><li>世界で最も使われているゲームエンジン<ul><li>ゲーム開発に必要な機能が揃った能率的なソフトウェア</li></ul></li><li>1回ビルドするだけで、どのプラットフォームにも展開可能<ul><li>プラットフォーム：ソフトウェアが動作する環境</li><li>ビルド：完成したゲームが動作するように仕上げる作業</li></ul></li><li>世の中のVRとARの3分の2以上で利用<ul><li>VR（仮想現実）：ゴーグルを装着すると中にバーチャルの世界が広がっている</li><li>AR（拡張現実）：現実世界をカメラで写すと現実にないものが存在する</li></ul></li></ul>](https://unity3d.com/jp/unity)
@snapend

<u>[The world’s leading
real-time creation platform](https://unity3d.com/jp/unity)</u>  @css[detail-comment](「unity 製品」で検索)

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

@ol[numberlist numberlist-color4](false)
- <u>[Unity Personalで今すぐスタート](https://store.unity.com/ja/download?ref=personal)</u>にアクセスします。 <br>@css[detail-comment](つくるUOZUプロジェクトの本イベントページにあるリンク、または「unity Personal」で検索)
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

* <u>[マニュアル](https://docs.unity3d.com/ja/current/Manual/UnityManual.html) </u>@css[detail-comment](「unity マニュアル」で検索)
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
@quote[<ul><li>統合開発環境<ul><li>コードの記述からプログラムの実行までできるソフトウェア</li></ul></li><li>複数の言語に対応（C＃、C++、JavaScriptほか）</li></ul>](https://docs.microsoft.com/ja-jp/visualstudio/ide/?view=vs-2019)
@snapend

<u>[Visual Studio IDE ドキュメント](https://docs.microsoft.com/ja-jp/visualstudio/ide/?view=vs-2019)</u> @css[detail-comment](「visual studio ドキュメント 学習」で検索)

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

@ol[numberlist numberlist-color4](false)
- <u>[Visual Studio のインストール](https://docs.microsoft.com/ja-jp/visualstudio/install/install-visual-studio?view=vs-2019)</u>にアクセスします。<br>@css[detail-comment](「visual studio ダウンロード」で検索)
- ページの記述にしたがってインストールします。<br>@css[detail-comment](ほかにもダウンロードを促されるものがあれば追加でインストールします。)
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

@ol[numberlist numberlist-color4](false)
- Windowsの場合：<u>[Visual Studio Tools for Unity の使用を開始する](https://docs.microsoft.com/ja-jp/visualstudio/cross-platform/getting-started-with-visual-studio-tools-for-unity?view=vs-2019)</u><br>にアクセスします。@css[detail-comment](「visual studio unity」で検索)
- Macの場合：<u>[Visual Studio for Mac Tools for Unityを設定する](https://docs.microsoft.com/ja-jp/visualstudio/mac/setup-vsmac-tools-unity?view=vsmac-2019)</u><br>にアクセスします。@css[detail-comment](「visual studio **mac** unity」で検索)
- ページの記述にしたがって設定します。
@olend

@snapend

---?color=#3A8FB7

@snap[breadcrumbs-wrap bluescale]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [ここまでのまとめ](#/)
@olend
@snapend

@snap[west headline]
## ここまでのまとめ
@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [ここまでのまとめ](#/)
@olend
@snapend

### @css[slide-title](ここまでのまとめ)

@snap[slide-contents]

@box[rounded box-style](この４つを持ち帰ると<br>1人でもゲーム開発の環境作りができるようになります。)

@ol[numberlist numberlist-color4](false)
- <u>[Unity Hubのインストール](https://store.unity.com/ja/download?ref=personal)</u><br>@css[detail-comment](「Unity personal」で検索)
- <u>[Unity2018.4.0のインストール](https://docs.unity3d.com/ja/current/Manual/UnityManual.html)</u><br>@css[detail-comment](「Unity マニュアル」で検索)
- <u>[VisualStudioのインストール](https://docs.microsoft.com/ja-jp/visualstudio/install/install-visual-studio?view=vs-2019)</u><br>@css[detail-comment](「VisualStudio ダウンロード」で検索)
- UnityとVisualStudioの連携（<u>[Windows](https://docs.microsoft.com/ja-jp/visualstudio/cross-platform/getting-started-with-visual-studio-tools-for-unity?view=vs-2019)</u>・<u>[Mac](https://docs.microsoft.com/ja-jp/visualstudio/mac/setup-vsmac-tools-unity?view=vsmac-2019)</u>）<br>@css[detail-comment](Windowsの場合は「VisualStudio Unity」、Macの場合は「VisualStudio Mac Unity」で検索)<br>
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

- <u>[Unityチュートリアル](https://unity3d.com/jp/learn/tutorials)</u>@css[detail-comment](「unity チュートリアル」で検索)
- <u>[はじめてのUnity](http://tutorial.unity3d.jp/)</u>@css[detail-comment](「はじめてのunity」で検索)

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
- [3. 疑問の解決方法](#/)
@olend
@snapend

### @css[slide-title](疑問の解決方法)

@snap[slide-contents]

@box[rounded box-style](疑問が出てきたら、該当する公式ページを調べて解決します。)

<p>**Unity**についての疑問：<u>[Unityマニュアル](https://docs.unity3d.com/ja/current/Manual/index.html)</u></p>
<p>**スクリプト**についての疑問：<ol class="numberlist numberlist-color4"><li><u>[Unityスクリプトリファレンスへようこそ](https://docs.unity3d.com/ja/current/ScriptReference/index.html)</u><br>@css[detail-comment](「unity スクリプトリファレンス」で検索)</li><li><u>[C# リファレンス](https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/)</u><br>@css[detail-comment](「C# リファレンス」で検索)</li></ol></p>

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

- データを保存する部分：**変数**
- 処理する部分：**関数**

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

- データの種類：**型** @css[detail-comment](（整数・文字列などあらかじめ決められているものと、自分で作るものとがあります）)
- データの名前：**識別子** @css[detail-comment](（ルールにしたがって自分でつけます）)
- データの中身：**値** @css[detail-comment](指定した型にあった中身でないと入れられない）)

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
float   moveHorizontal     =     Input.GetAxis("Horizontal")   ;
↓
＜型＞ ＜識別子＞ ＜代入＞ ＜値＞ ＜;は文の終わりを示す＞
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

### @css[slide-title](関数について)

@snap[slide-contents]

@box[rounded box-style](関数では、データをどのように処理させるかを指定します。<br>関数には4つの概念があります。)

- 関数の種類：**関数の型** @css[detail-comment](（処理した結果どのような種類の値を返すのかを表します）)
- 関数の名前：**識別子** @css[detail-comment](（ルールにしたがって自分でつけます）)
- 処理させたいデータ：**引数** @css[detail-comment](（処理させたいデータがあるときに指定します）)
- 関数の中身：**定義** @css[detail-comment](（どのように処理しどのような結果を返すのかを記述します）)

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
    var rb = GetComponent<Rigidbody>();
}
↓
＜関数の型＞ ＜識別子＞  ( ＜引数＞ )
{
    ＜定義＞
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
[Unityチュートリアル「玉転がし」>「プレイヤーの移動」](https://unity3d.com/jp/learn/tutorials/projects/roll-ball-tutorial/moving-player?playlist=45990)から一部転載
@snapend

@img[goal-image to-center](/template/img/PlayerController.png)

@snapend

@snapend


---?color=#3A8FB7

@snap[breadcrumbs-wrap bluescale]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [学習についてのまとめ](#/)
@olend
@snapend

@snap[west headline]
## 学習についてのまとめ
@snapend

---
@snap[breadcrumbs-wrap]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [学習についてのまとめ](#/)
@olend
@snapend

### @css[slide-title](学習についてのまとめ)

@snap[slide-contents]

@box[rounded box-style](この４つを持ち帰ると<br>独学でUnityとC＃の学習ができるようになります。)

@ol[numberlist numberlist-color4](false)
- <u>[Unity チュートリアル](https://unity3d.com/jp/learn/tutorials)</u><br>@css[detail-comment](「Unity チュートリアル」で検索)
- <u>[はじめてのUnity](http://tutorial.unity3d.jp/)</u><br>@css[detail-comment](「はじめてのUnity」で検索)
- <u>[Unityスクリプトリファレンス](https://docs.unity3d.com/ja/current/ScriptReference/index.html)</u><br>@css[detail-comment](「Unity スクリプトリファレンス」で検索)
- [C#リファレンス](https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/)</u><br>@css[detail-comment](「C# リファレンス」で検索)<br>
@olend

@snapend


---?color=#3A8FB7

@snap[breadcrumbs-wrap bluescale]
@ol[breadcrumbs](false)
- [講座の流れ](#/2)
- [5. 実演](#/)
@olend
@snapend

@snap[west headline]
## 実演
@snapend

