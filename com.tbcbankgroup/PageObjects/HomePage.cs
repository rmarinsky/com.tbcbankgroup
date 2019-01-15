using NSelene;
using static NSelene.Selene;

namespace com.tbcbankgroup.PageObjects
{
    public class HomePage
    {
        public SeleneElement SearchButton = S("#header_search_input_desk");
        public SeleneElement SearchInput = S("#page_search_input");

        public void SearchByRequest(string searchRequest)
        {
            SearchButton.Click();
            SearchInput.SetValue(searchRequest)
                .PressEnter();
        }
    }
}