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

