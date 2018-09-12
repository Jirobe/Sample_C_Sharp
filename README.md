# Sample_C_Sharp
C#のサンプル置き場

# AbstractClassSample
抽象クラスのサンプル
![抽象クラス_セミ](https://raw.githubusercontent.com/Jirobe/Sample_C_Sharp/master/AbstractClassSample/%E3%82%BB%E3%83%9F.jpg)

# Singleton
C#のシングルトン  

Javaライクなもの  
```C#:Singleton.cs
    class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public StringBuilder StringBuilder { get; set; } = new StringBuilder();

        public static  Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }
```

静的なもの  
```C#:Abbreviation.cs
    class Abbreviation
    {
        public static Abbreviation Current { get; } = new Abbreviation();
        public StringBuilder StringBuilder { get; set; } = new StringBuilder();
    }
```

# Now
バッチ処理のサンプル  
引数に対してLinq使用サンプル

実行例
```
C:\work>now
2018/09/07 0:23:50

C:\work>now /?

現在時刻を表示します。

引数なしの場合、yyyy/MM/dd HH:mm:ssで表示します。
引数は順不同

/m  yyyy/MM/dd HH:mm:ss.ff形式で表示します。
/n [0-99] 指定した回数だけ表示を繰り返します。
```

[引数に対してLinq使用サンプル](https://github.com/Jirobe/Sample_C_Sharp/blob/f68d0aa5da5828a7fe103deb6c6a76be5c79566c/Now/Now/Program.cs#L19-L31)
```C#
                #region 引数判別
                bool isMillisecond = args.Where(s => s == "/m").Count() > 0;
  
                var query = args
                            .Select((v, i) => new { Value = v, Index = i })
                            .Where(s => s.Value == "/n")
                            .Select(s => s.Index);


                int nOptIndex = 0;
                if (query.Count() > 0) nOptIndex = query.First();


                bool isLoop = args.Length > nOptIndex + 1 && query.Count() > 0;
                #endregion 引数判別
```

# HelpEvent
イベントハンドラの利用サンプル


