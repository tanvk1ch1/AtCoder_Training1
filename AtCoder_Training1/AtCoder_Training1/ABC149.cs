// A - Strings / 
// 実行時間制限: 2 sec / メモリ制限: 1024 MB
//
// 配点 : 100点
//
// 問題文
// 英小文字のみからなる 2つの文字列 S, T が与えられます。
// これらの文字列を T, S の順に空白を空けずに連結し、できる文字列を出力してください。
//
// 制約
// S, T は英小文字のみからなる文字列 
// S, T の長さは 1以上 100以下
//
// 入力 
// 入力は以下の形式で標準入力から与えられる。
// S T
//
// 出力
// できる文字列を出力せよ。
// 入力例 1
// oder atc
// 出力例 1
// atcoder
// S = oder, T = atc のとき、T, S の順に連結してできる文字列は atcoder です。
//
// 入力例 2
// humu humu
// 出力例 2
// humuhumu

using System;

class ABC149_A
{
    static void Main(string[] args)
    {
        string[] str1 = Console.ReadLine().Split(' ');
        string str2 = str1[1] + str1[0];
        Console.WriteLine(str2);
    }
}