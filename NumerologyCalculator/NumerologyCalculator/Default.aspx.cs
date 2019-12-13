using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NumerologyCalculator
{
    public partial class _Default : Page
    {
        DateTime date;
        protected void Page_Load(object sender, EventArgs e)
        {
            FillDropDownYear();
            FillDropDownDay();
            FillDropDownMonth();
           
        }

        public void Calendar1_SelectionChanged(object sender, EventArgs e)

        {
             TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
            


        }

        protected async void ButtonCalculate_Click(object sender, EventArgs e)
        {

            string shortDateString = Calendar1.SelectedDate.ToShortDateString();
            string justNumbersFromDate = new String(shortDateString.Where(Char.IsDigit).ToArray());
            int numerologyNumber = CalculateNumerologyNumber(justNumbersFromDate);

            TextBoxCalculatedValue.Text = numerologyNumber.ToString();
            string description = await startCrawlerAsync(numerologyNumber);
            PlaceHolder1.Controls.Add(new Literal() { Text = "<div>" + description + "</div>" });


        }


        protected void Calendar1_DayRender(object sender, System.Web.UI.WebControls.DayRenderEventArgs e)
        {

            DateTime date1 = new DateTime(1920, 1, 1);
            if (e.Day.Date >= DateTime.Now || e.Day.Date <= date1)
            {
                e.Cell.BackColor = ColorTranslator.FromHtml("#A9A9A9");
                e.Day.IsSelectable = false;
            }
        }

        private async Task<string> startCrawlerAsync(int numerologyNumber)
        {

            string url = @"http://www.horoskopius.com/numerologija/numeroloski-profil-za-broj-" + numerologyNumber;
            HttpClient httpClient = new HttpClient();
            string html = await httpClient.GetStringAsync(url);
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            HtmlNode article = htmlDocument.DocumentNode
                 .Descendants("div").Where(node => node.GetAttributeValue("class", "")
                 .Equals("thirteen columns alpha omega article-write")).FirstOrDefault().Descendants("article")
                 .FirstOrDefault();

            return article.InnerHtml;


        }


        private int CalculateNumerologyNumber(string justNumbers)
        {
            int[] intArray = Array.ConvertAll(justNumbers.ToCharArray(),
                c => (int)Char.GetNumericValue(c));
            int intArraySum = intArray.Sum();

            if (intArraySum < 10 || intArraySum == 11 || intArraySum == 22)
            {
                return intArraySum;
            }

            return CalculateNumerologyNumber(intArraySum.ToString());
        }


        private void FillDropDownYear()
        {

            int[] arr = Enumerable.Range(1920, DateTime.Now.Year - 1919).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                DropDownListYear.Items.Add(arr[i].ToString());
            }
        }
        private void FillDropDownDay()
        {

            int[] arr = Enumerable.Range(1, 31).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                DropDownListDay.Items.Add(arr[i].ToString());
            }
        }


       
        private void FillDropDownMonth()
        {
            Dictionary<int, string> months = new Dictionary<int, string>()
        {
           { 1,"January" }, {2, "February"  },{ 3,"March"}, { 4,"April"},{ 5,"May" }, { 6,"June" },{ 7,"July" }, {8, "August" },
             {9, "September" }, { 10,"October" },
                { 11,"November" }, { 12,"December" }
        };

            foreach (KeyValuePair<int, string> month in months)
            {
                DropDownListMonth.Items.Add(month.Value);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int year =Convert.ToInt32(DropDownListYear.SelectedValue);
       
            int month = Convert.ToInt32(DropDownListMonth.SelectedIndex + 1);
            int day = Convert.ToInt32(DropDownListDay.SelectedValue);

            date= new DateTime(year, month, day);
            
            TextBox2.Text = date.ToShortDateString();
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(TextBox2.Text);
            Calendar1.VisibleDate = date;
            this.Calendar1.SelectedDate = this.Calendar1.VisibleDate = date;
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        }
    }

}
          
    

