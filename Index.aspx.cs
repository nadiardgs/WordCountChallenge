using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WordCountChallenge
{
    public partial class _Default : Page
    {
        protected readonly string BlankSpace = " ";
        protected readonly string LineFeed = "\n";
        protected readonly string Tab = "\t";
        protected readonly string CarriageReturn = "\r";

        protected void Page_Load(object sender, EventArgs e)
        {
            textBox.Focus();
        }


        protected void ManageResponseLabel(bool visible, string message)
        {
            lblMsg.Visible = visible;
            lblMsg.Text = message;
        }

        protected List<string> RemovePositionalCharacters(string text)
        {
            StringBuilder sb = new StringBuilder(text);

            sb.Replace(LineFeed, BlankSpace);
            sb.Replace(Tab, BlankSpace);
            sb.Replace(CarriageReturn, BlankSpace);

            Char.TryParse(BlankSpace, out char charBlankspace);

            return sb.ToString().Split(charBlankspace).ToList();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            ManageResponseLabel(false, string.Empty);

            if (string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                ManageResponseLabel(true, "Type some input to count the words!");
            }
            else
            {
                var splitText = RemovePositionalCharacters(textBox.Text);

                //remove white spaces
                splitText = splitText.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

                lblMsg.Font.Bold = true;
                ManageResponseLabel(true, $"You typed {splitText.Count} words.");
            }
        }
    }
}