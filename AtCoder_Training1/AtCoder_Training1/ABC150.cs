// A - 500 Yen Coins / 
// 実行時間制限: 2 sec / メモリ制限: 1024 MB
// 配点 : 100点
//
// 問題文 
// 高橋君は 500円玉を K 枚持っています。
// これらの総額が X 円以上である場合は Yes を、そうでない場合は No を出力してください。
//
// 制約
// 1≤K≤100
// 1≤X≤10の5乗
//
// 入力
// 入力は以下の形式で標準入力から与えられる。
// K X
//
// 出力
// 総額が X 円以上である場合は Yes を、そうでない場合は No を出力せよ。
//
// 入力例 1
// 2 900
// 出力例 1
// Yes
// 500円玉が 2枚なので総額は 1000円であり、これは X = 900円以上です。
//
// 入力例 2
// 1 501
// 出力例 2
// No
// 500円玉が 1枚なので総額は 500円であり、これは X = 501円未満です。
//
// 入力例 3
// 4 2000
// 出力例 3
// Yes
// 500円玉が 4枚なので総額は 2000円であり、これは X = 2000円以上です。

using System;

class ABC150_A
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split(' ');
        int k = int.Parse(str[0]);
        int x = int.Parse(str[1]);

        if (500 * k >= x)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
