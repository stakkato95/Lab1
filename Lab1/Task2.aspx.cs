using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonConvert_Click(object sender, EventArgs e)
    {
        string empty = "";

        double KgToDrahma = 564.4;
        double KgToFunt = 2.205;
        double KgToGra = 15340;
        double KgToUnc = 35.27;
        double KgToTroja = 0.1575;
        if (TextBoxKg.Text != empty)
        {
            double source = double.Parse(TextBoxKg.Text);
            TextBoxDrahma.Text = (source * KgToDrahma).ToString();
            TextBoxFunt.Text = (source * KgToFunt).ToString();
            TextBoxGran.Text = (source * KgToGra).ToString();
            TextBoxTroja.Text = (source * KgToTroja).ToString();
            TextBoxUnc.Text = (source * KgToUnc).ToString();
        }
        else if (TextBoxDrahma.Text != empty)
        {
        }
        else if (TextBoxFunt.Text != empty)
        {
        }
        else if (TextBoxGran.Text != empty)
        {
        }
        else if (TextBoxUnc.Text != empty)
        {
        }
        else if (TextBoxTroja.Text != empty)
        {
        }

    }
}