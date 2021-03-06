## ⚠️ GakujoGUIは最新ではありません．

2022年よりGakujoGUI-WPFに移行しました．  
[https://github.com/xyzyxJP/GakujoGUI-WPF](https://github.com/xyzyxJP/GakujoGUI-WPF)

# GakujoGUI

静岡大学 学務情報システム

## Documentation

### Installation

[最新バージョン](https://github.com/xyzyxJP/GakujoGUI/releases/latest)

#### Recommended

1. Releaseのページから該当バージョンをダウンロード
2. ファイルを展開後、`GakujoGUI.exe`を起動
3. `静大ID`, `パスワード`, `氏名`, `学籍番号`を入力、ログイン

#### Latest

1. [Code](https://github.com/xyzyxJP/GakujoGUI/archive/refs/heads/main.zip)をダウンロード
2. ファイルを展開後、`Visual Studio 2019`でコンパイル
3. `GakujoGUI.exe`を起動
4. `静大ID`, `パスワード`, `氏名`, `学籍番号`を入力、ログイン

### Usage

#### ログイン

##### 通常ログイン

- `静大ID`, `パスワード`, `氏名`, `学籍番号`をもとに、通常の学務情報システムへのログインと同様の通信を行う
- CSSファイルや画像ファイルの通信は行わないため、ブラウザ上でのログインより高速である

##### キャッシュログイン

- `cookies`, `apacheToken`をもとに、ログイン状態を再現し、学務情報システムのホーム画面の取得を行う
- クッキーの期限が切れている場合やログイン状態が上書きされた場合などは、ログインできない

#### 保存データ

##### ログイン情報

`静大ID`, `パスワード`, `氏名`, `学籍番号`を`account.json`に保存

```
{"userId":"\l{2}\d{6}","passWord":"[\u\l\d]{1,}","studentName":"山田　太郎","studentCode":"\d{8}","apacheToken":"[\u\l\d]{32}"}
```

##### クッキー

- `httpClientHandler`の`CookieContainer`を`cookies`に保存
- `apacheToken`については`account.json`に保存

##### 授業連絡, レポート, 小テスト, 学内連絡, 授業共有ファイル, 学内共有ファイル

- 授業連絡 `classContact.json`
- レポート `report.json`
- 小テスト `quiz.json`
- 学内連絡 `schoolContact.json`
- 授業共有ファイル `classSharedFile.json`
- 学内共有ファイル `schoolSharedFile.json`

#### 起動オプション

| 引数      | オプション | デフォルト値 |                                            | 
| :-------: | :--------: | :----------: | :----------------------------------------: | 
| -nodialog | なし       | なし         | ダイアログを非表示にする                   | 
| +year     | int型      | 2021         | 取得年度を設定する                         | 
| +semester | int型      | 2            | 取得学期を設定する<br>前期 : 1<br>後期 : 2 | 
| -debug    | なし       | なし         | ログ出力を有効にする                       | 

---

#### 学務情報システム

- 授業連絡
	- 一覧表示
		- 授業科目
		- タイトル
		- 連絡日時
	- 詳細表示
		- 内容
		- ファイル
- レポート
	- 一覧表示
		- 授業科目
		- タイトル
		- 状態
		- 提出期間
		- 最終提出日時
	- 詳細表示
		- 評価方法
		- 説明
		- 参考資料(ダウンロード不可)
		- 伝達事項
		- 催促通知
		- レポート提出履歴
	- 提出開始(単一ファイルのみ, コメント不可)
	- 提出取消
- 小テスト
	- 一覧表示
		- 授業科目
		- タイトル
		- 状態
		- 提出期間
		- 提出状況
	- 詳細表示
		- 設問数
		- 評価方法
		- 説明
		- 参考資料(ダウンロード不可)
		- 伝達事項
		- 催促通知
		- 設問
	- 提出開始
	- 提出取消
- 学内連絡
	- 一覧表示
		- カテゴリ
		- タイトル
		- 連絡日時
	- 詳細表示
		- 内容
		- ファイル
- 授業共有ファイル
	- 一覧表示
		- 授業科目
		- タイトル
		- 更新日時
	- 詳細表示
		- 内容
		- ファイル
- 学内共有ファイル
	- 一覧表示
		- カテゴリ
		- タイトル
		- 更新日時
	- 詳細表示
		- 内容
		- ファイル

---

#### 教務システム

- 履修関連
	- ~~抽選履修登録~~
	- 抽選履修登録結果(実装予定)
	- ~~一般講義履修登録~~
	- ~~集中講義履修登録~~
	- ~~取得希望資格登録~~
	- ~~教職履修カルテ~~
	- ~~キャリア履修カルテ~~
- 時間割関連
	- 個人時間割(実装予定)
	- ~~試験時間割~~
	- ~~全試験時間割~~
	- 全時間割(実装予定)
- 成績情報関連
	- 成績情報の参照
	- 単位習得情報の参照
	- カリキュラムの参照
- 学生情報関連
	- 学籍情報の参照
	- ~~学籍情報の更新~~
- Web掲示板
	- ~~掲示板の参照~~
- 授業料免除等
	- ~~授業料免除~~
- その他
	- シラバス参照
	- ~~授業パッケージシラバス参照~~
	- ~~学内スケジュール~~

---

[@xyzyxJP](https://twitter.com/xyzyxJP)
