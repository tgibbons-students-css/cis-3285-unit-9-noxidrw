using System.Collections.Generic;


/**
     * Added my changes to Git
     * 
     * @author William Dixon
     * @version Assignment part 2
     */
namespace SingleResponsibilityPrinciple.Contracts
{
    public interface IURLDataProvider
    {
        IEnumerable<string> GetTradeData(string url);
    }
}