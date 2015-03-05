using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task2 : System.Web.UI.Page
{
    private const String EMPTY_STRING = "";
    private static double lastKgValue;
    private static double lastDrahmaValue;
    private static double lastFuntValue;
    private static double lastGranValue;
    private static double lastUncValue;
    private static double lastStounValue;
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
        double KgToStoun = 0.1575;

        double FuntToKg = 0.4536;
        double FuntToDrahma = 256;
        double FuntToGra = 7000;
        double FuntToUnc = 16;
        double FuntToStoun = 0.07143;

        double UncToKg = 0.02835;
        double UncToDrahma = 16;
        double UncToGra = 437.5;
        double UncToFunt = 0.0625;
        double UncToStoun = 0.004464;

        double DrahmaToKg = 0.001772;
        double DrahmaToFunt = 0.003906;
        double DrahmaToGra = 27.34;
        double DrahmaToUnc = 0.0625;
        double DrahmaToStoun = 0.000279;

        double GraToKg = 0.0000648;
        double GraToDrahma = 0.03657;
        double GraToFunt = 0.0001429;
        double GraToUnc = 0.002286;
        double GraToStoun = 0.0000102;

        double StounToKg = 6.35;
        double StounToDrahma = 3584;
        double StounToFunt = 14;
        double StounToUnc = 224;
        double StounToGra = 98000;


        if (TextBoxKg.Text != lastKgValue.ToString() && TextBoxKg.Text != EMPTY_STRING)
        {
            double source = double.Parse(TextBoxKg.Text);
            TextBoxStoun.Text = (source * KgToStoun).ToString();
            TextBoxFunt.Text = (source * KgToFunt).ToString();
            TextBoxGran.Text = (source * KgToGra).ToString();
            TextBoxDrahma.Text = (source * KgToDrahma).ToString();
            TextBoxUnc.Text = (source * KgToUnc).ToString();

            lastKgValue = source;
            
            double.TryParse(TextBoxDrahma.Text, out lastDrahmaValue);
            double.TryParse(TextBoxFunt.Text, out lastFuntValue);
            double.TryParse(TextBoxGran.Text, out lastGranValue);
            double.TryParse(TextBoxUnc.Text, out lastUncValue);
            double.TryParse(TextBoxStoun.Text, out lastStounValue);
        }
        else if (TextBoxDrahma.Text != lastDrahmaValue.ToString() && TextBoxDrahma.Text != EMPTY_STRING)
        {
            double source = double.Parse(TextBoxDrahma.Text);
            TextBoxKg.Text = (source * DrahmaToKg).ToString();
            TextBoxFunt.Text = (source * DrahmaToFunt).ToString();
            TextBoxGran.Text = (source * DrahmaToGra).ToString();
            TextBoxStoun.Text = (source * DrahmaToStoun).ToString();
            TextBoxUnc.Text = (source * DrahmaToUnc).ToString();

            lastDrahmaValue = source;

            double.TryParse(TextBoxKg.Text, out lastKgValue);
            double.TryParse(TextBoxFunt.Text, out lastFuntValue);
            double.TryParse(TextBoxGran.Text, out lastGranValue);
            double.TryParse(TextBoxUnc.Text, out lastUncValue);
            double.TryParse(TextBoxStoun.Text, out lastStounValue);
        }
        else if (TextBoxFunt.Text != lastFuntValue.ToString() && TextBoxFunt.Text != EMPTY_STRING)
        {
            double source = double.Parse(TextBoxFunt.Text);
            TextBoxKg.Text = (source * FuntToKg).ToString();
            TextBoxDrahma.Text = (source * FuntToDrahma).ToString();
            TextBoxGran.Text = (source * FuntToGra).ToString();
            TextBoxStoun.Text = (source * FuntToStoun).ToString();
            TextBoxUnc.Text = (source * FuntToUnc).ToString();

            lastFuntValue = source;

            double.TryParse(TextBoxDrahma.Text, out lastDrahmaValue);
            double.TryParse(TextBoxKg.Text, out lastKgValue);
            double.TryParse(TextBoxGran.Text, out lastGranValue);
            double.TryParse(TextBoxUnc.Text, out lastUncValue);
            double.TryParse(TextBoxStoun.Text, out lastStounValue);
        }
        else if (TextBoxGran.Text != lastGranValue.ToString() && TextBoxGran.Text != EMPTY_STRING)
        {
            double source = double.Parse(TextBoxGran.Text);
            TextBoxKg.Text = (source * GraToKg).ToString();
            TextBoxDrahma.Text = (source * GraToDrahma).ToString();
            TextBoxFunt.Text = (source * GraToFunt).ToString();
            TextBoxStoun.Text = (source * GraToStoun).ToString();
            TextBoxUnc.Text = (source * GraToUnc).ToString();

            lastGranValue = source;

            double.TryParse(TextBoxDrahma.Text, out lastDrahmaValue);
            double.TryParse(TextBoxFunt.Text, out lastFuntValue);
            double.TryParse(TextBoxKg.Text, out lastKgValue);
            double.TryParse(TextBoxUnc.Text, out lastUncValue);
            double.TryParse(TextBoxStoun.Text, out lastStounValue);
        }
        else if (TextBoxUnc.Text != lastUncValue.ToString() && TextBoxUnc.Text != EMPTY_STRING)
        {
            double source = double.Parse(TextBoxUnc.Text);
            TextBoxKg.Text = (source * UncToKg).ToString();
            TextBoxDrahma.Text = (source * UncToDrahma).ToString();
            TextBoxGran.Text = (source * UncToGra).ToString();
            TextBoxFunt.Text = (source * UncToFunt).ToString();
            TextBoxStoun.Text = (source * UncToStoun).ToString();

            lastUncValue = source;

            double.TryParse(TextBoxDrahma.Text, out lastDrahmaValue);
            double.TryParse(TextBoxFunt.Text, out lastFuntValue);
            double.TryParse(TextBoxGran.Text, out lastGranValue);
            double.TryParse(TextBoxKg.Text, out lastKgValue);
            double.TryParse(TextBoxStoun.Text, out lastStounValue);
        }
        else if (TextBoxStoun.Text != lastStounValue.ToString() && TextBoxStoun.Text != EMPTY_STRING)
        {
            double source = double.Parse(TextBoxStoun.Text);
            TextBoxKg.Text = (source * StounToKg).ToString();
            TextBoxDrahma.Text = (source * StounToDrahma).ToString();
            TextBoxGran.Text = (source * StounToGra).ToString();
            TextBoxFunt.Text = (source * StounToFunt).ToString();
            TextBoxUnc.Text = (source * StounToUnc).ToString();

            lastStounValue = source;

            double.TryParse(TextBoxDrahma.Text, out lastDrahmaValue);
            double.TryParse(TextBoxFunt.Text, out lastFuntValue);
            double.TryParse(TextBoxGran.Text, out lastGranValue);
            double.TryParse(TextBoxUnc.Text, out lastUncValue);
            double.TryParse(TextBoxKg.Text, out lastKgValue);
        }


    }



    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxKg.Text = "";
        TextBoxGran.Text = "";
        TextBoxFunt.Text = "";
        TextBoxStoun.Text = "";
        TextBoxUnc.Text = "";
        TextBoxDrahma.Text = "";
    }





    protected void MassValidator_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = TextBoxDrahma.Text != EMPTY_STRING ||
            TextBoxFunt.Text != EMPTY_STRING ||
            TextBoxGran.Text != EMPTY_STRING ||
            TextBoxKg.Text != EMPTY_STRING ||
            TextBoxStoun.Text != EMPTY_STRING||
            TextBoxUnc.Text != EMPTY_STRING;
    }
}

