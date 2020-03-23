using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamlEssentialsPage : ContentPage
    {
        private string[] Quotes = { "Quote 01", "Quote 02", "Quote 03", "Quote 04" };
        private int index;
        public XamlEssentialsPage()
        {
            InitializeComponent();
            index = 0;
            lblQuotes.Text = Quotes[index];
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            index = index == Quotes.Length - 1 ? 0 : index + 1;

            lblQuotes.Text = Quotes[index];
        }
    }
}