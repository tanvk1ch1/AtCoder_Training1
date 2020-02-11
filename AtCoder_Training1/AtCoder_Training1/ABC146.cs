// A - Can't Wait for Holiday / 
// 実行時間制限: 2 sec / メモリ制限: 1024 MB
// 配点 : 100点
//
// 問題文
// 今日の曜日を表す文字列 S が与えられます。
// S は SUN,MON,TUE,WED,THU,FRI,SAT のいずれかであり、それぞれ日曜日、月曜日、火曜日、水曜日、木曜日、金曜日、土曜日を表します。
// 次の日曜日 (あす以降) が何日後か求めてください。
//
// 制約
// S は SUN,MON,TUE,WED,THU,FRI,SAT のいずれか
// 入力
// 入力は以下の形式で標準入力から与えられる。
// S
//
// 出力
// 次の日曜日が何日後か出力せよ。
//
// 入力例 1
// SAT
// 出力例 1
// 1
// 今日は土曜日です。よって、次の日曜日は 1日後です。
//
// 入力例 2
// SUN
// 出力例 2
// 7
// 今日は日曜日です。よって、次の日曜日は 7日後です。

using System;

class ABC146_A
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        if (str == "SUN")
        {
            Console.WriteLine(7);
        }
        else if (str == "MON")
        {
            Console.WriteLine(6);
        }
        else if (str == "TUE")
        {
            Console.WriteLine(5);
        }
        else if (str == "WED")
        {
            Console.WriteLine(4);
        }
        else if (str == "THU")
        {
            Console.WriteLine(3);
        }
        else if (str == "FRI")
        {
            Console.WriteLine(2);
        }
        else if (str == "SAT")
        {
            Console.WriteLine(1);
        }
    }
}
