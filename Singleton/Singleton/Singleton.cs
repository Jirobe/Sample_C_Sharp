using System.Text;

namespace Singleton
{
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
}
