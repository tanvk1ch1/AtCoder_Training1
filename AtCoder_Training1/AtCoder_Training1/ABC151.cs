// A - Next Alphabet / 
// 実行時間制限: 2 sec / メモリ制限: 1024 MB
//
// 配点 : 100点
//
// 問題文
// z でない英小文字 C が与えられます。
// アルファベット順で C の次の文字を出力してください。
//
// 制約
// C は z でない英小文字
// 入力
// 入力は以下の形式で標準入力から与えられる。
// C
//
// 出力
// アルファベット順で 
// C
// の次の文字を出力せよ。
//
// 入力例 1
// a
// 出力例 1
// b
// a の次は b です。
//
// 入力例 2
// y
// 出力例 2
// z
// y の次は z です。

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] str = Console.ReadLine().Split(' ');
        char a = char.Parse(str[0]);
        int b = a + 1;

        Console.WriteLine((char) b);
    }
}