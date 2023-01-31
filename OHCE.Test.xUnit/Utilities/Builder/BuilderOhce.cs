using OHCE.Test.xUnit.Utilities.DoubleTest;

namespace OHCE.Test.xUnit.Utilities.Builders
{
    internal class OhceBuilder
    {
        private ILangue _langue = new MockLangue();

        public static Ohce Base => new OhceBuilder().Build();

        public Ohce Build() => new Ohce(_langue);

        public OhceBuilder AyantPourLangue(ILangue langue)
        {
            _langue = langue;
            return this;
        }
    }
}