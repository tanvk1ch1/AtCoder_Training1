// A - Blackjack / 
// 実行時間制限: 2 sec / メモリ制限: 1024 MB
// 配点 : 100点
//
// 問題文 
// 3個の整数 A1, A2, A3 が与えられます。
// A1 + A2 + A3 が 22以上なら bust、21以下なら win を出力してください。
//
// 制約
// 1 ≤ Ai ≤ 13(i = 1, 2, 3)
// 入力中のすべての値は整数である。
//
// 入力
// 入力は以下の形式で標準入力から与えられる。
// A1 A2 A3
//
// 出力
// A1 + A2 + A3 が 22以上なら bust、21以下なら win を出力せよ。
//
// 入力例 1
// 5 7 9
// 出力例 1
// win
// 5 + 7 + 9 = 21 なので win を出力します。
//
// 入力例 2
// 13 7 2
// 出力例 2
// bust
// 13 + 7 + 2 = 22 なので bust を出力します。

using System;

class ABC147_A
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split(' ');
        int a1 = int.Parse(str[0]);
        int a2 = int.Parse(str[1]);
        int a3 = int.Parse(str[2]);
        int num = a1 + a2 + a3;
        
        if (num >= 22)
        {
            Console.WriteLine("bust");
        }
        else
        {
            Console.WriteLine("win");
        }
    }
}