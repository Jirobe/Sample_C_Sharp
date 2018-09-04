using System.Text;

namespace Singleton
{
    class Abbreviation
    {
        public static Abbreviation Current { get; } = new Abbreviation();
        public StringBuilder StringBuilder { get; set; } = new StringBuilder();
    }
}
