using Patterns.Behavioral.ChainOfResponsibility.Banknotes;

namespace Patterns.Behavioral.ChainOfResponsibility
{
    public class ChainUsage
    {
        public static void ConfigureAndRun(int cash)
        {
            var banknotes = new AtmMachine[]
            {
                new Banknote1(),
                new Banknote2(),
                new Banknote5(),
                new Banknote10(),
                new Banknote20(),
                new Banknote50(),
                new Banknote100(),
                new Banknote200(),
                new Banknote500(),
                new Banknote1000()
            };

            for (var i = banknotes.Length - 1; i > 0; i--)
            {
                banknotes[i].SetNext(banknotes[i - 1]);
            }

            banknotes[banknotes.Length - 1].HandlerRequest(cash);
        }
    }
}