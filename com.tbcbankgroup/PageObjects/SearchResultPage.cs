using NSelene;
using static NSelene.Selene;

namespace com.tbcbankgroup.PageObjects
{
    public class SearchResultPage
    {
        public SeleneCollection SearchResultItems = SS("#search-results-container h2 a");

        public SeleneElement SearchResultItemByText(string searchResultItemText)
        {
            return SearchResultItems
                .FindBy(Have.Text(searchResultItemText));
        }
    }
}