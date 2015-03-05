using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task2 : System.Web.UI.Page
{
    private const String EMPTY_STRING = "";

    private const double KgToDrahma = 564.4;
    private const double KgToFunt = 2.205;
    private const double KgToGra = 15340;
    private const double KgToUnc = 35.27;
    private const double KgToStoun = 0.1575;

    private const double FuntToKg = 0.4536;
    private const double FuntToDrahma = 256;
    private const double FuntToGra = 7000;
    private const double FuntToUnc = 16;
    private const double FuntToStoun = 0.07143;

    private const double UncToKg = 0.02835;
    private const double UncToDrahma = 16;
    private const double UncToGra = 437.5;
    private const double UncToFunt = 0.0625;
    private const double UncToStoun = 0.004464;

    private const double DrahmaToKg = 0.001772;
    private const double DrahmaToFunt = 0.003906;
    private const double DrahmaToGra = 27.34;
    private const double DrahmaToUnc = 0.0625;
    private const double DrahmaToStoun = 0.000279;

    private const double GraToKg = 0.0000648;
    private const double GraToDrahma = 0.03657;
    private const double GraToFunt = 0.0001429;
    private const double GraToUnc = 0.002286;
    private const double GraToStoun = 0.0000102;

    private const double StounToKg = 6.35;
    private const double StounToDrahma = 3584;
    private const double StounToFunt = 14;
    private const double StounToUnc = 224;
    private const double StounToGra = 98000;

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
        if (TextBoxKg.Text != lastKgValue.ToString() && TextBoxKg.Text != EMPTY_STRING)
        {
            lastKgValue = double.Parse(TextBoxKg.Text);
            TextBoxStoun.Text = (lastStounValue = lastKgValue * KgToStoun).ToString();
            TextBoxFunt.Text = (lastFuntValue = lastKgValue * KgToFunt).ToString();
            TextBoxGran.Text = (lastGranValue = lastKgValue * KgToGra).ToString();
            TextBoxDrahma.Text = (lastDrahmaValue = lastKgValue * KgToDrahma).ToString();
            TextBoxUnc.Text = (lastUncValue = lastKgValue * KgToUnc).ToString();
        }
        else if (TextBoxDrahma.Text != lastDrahmaValue.ToString() && TextBoxDrahma.Text != EMPTY_STRING)
        {
            lastDrahmaValue = lastDrahmaValue = double.Parse(TextBoxDrahma.Text);
            TextBoxKg.Text = (lastKgValue = lastDrahmaValue * DrahmaToKg).ToString();
            TextBoxFunt.Text = (lastFuntValue = lastDrahmaValue * DrahmaToFunt).ToString();
            TextBoxGran.Text = (lastGranValue = lastDrahmaValue * DrahmaToGra).ToString();
            TextBoxStoun.Text = (lastStounValue = lastDrahmaValue * DrahmaToStoun).ToString();
            TextBoxUnc.Text = (lastUncValue = lastDrahmaValue * DrahmaToUnc).ToString();
        }
        else if (TextBoxFunt.Text != lastFuntValue.ToString() && TextBoxFunt.Text != EMPTY_STRING)
        {
            lastFuntValue = double.Parse(TextBoxFunt.Text);
            TextBoxKg.Text = (lastFuntValue = lastFuntValue * FuntToKg).ToString();
            TextBoxDrahma.Text = (lastFuntValue = lastFuntValue * FuntToDrahma).ToString();
            TextBoxGran.Text = (lastFuntValue = lastFuntValue * FuntToGra).ToString();
            TextBoxStoun.Text = (lastFuntValue = lastFuntValue * FuntToStoun).ToString();
            TextBoxUnc.Text = (lastFuntValue = lastFuntValue * FuntToUnc).ToString();
        }
        else if (TextBoxGran.Text != lastGranValue.ToString() && TextBoxGran.Text != EMPTY_STRING)
        {
            lastGranValue = double.Parse(TextBoxGran.Text);
            TextBoxKg.Text = (lastGranValue = lastGranValue * GraToKg).ToString();
            TextBoxDrahma.Text = (lastGranValue = lastGranValue * GraToDrahma).ToString();
            TextBoxFunt.Text = (lastGranValue = lastGranValue * GraToFunt).ToString();
            TextBoxStoun.Text = (lastGranValue = lastGranValue * GraToStoun).ToString();
            TextBoxUnc.Text = (lastGranValue = lastGranValue * GraToUnc).ToString();
        }
        else if (TextBoxUnc.Text != lastUncValue.ToString() && TextBoxUnc.Text != EMPTY_STRING)
        {
            lastUncValue = double.Parse(TextBoxUnc.Text);
            TextBoxKg.Text = (lastUncValue = lastUncValue * UncToKg).ToString();
            TextBoxDrahma.Text = (lastUncValue = lastUncValue * UncToDrahma).ToString();
            TextBoxGran.Text = (lastUncValue = lastUncValue * UncToGra).ToString();
            TextBoxFunt.Text = (lastUncValue = lastUncValue * UncToFunt).ToString();
            TextBoxStoun.Text = (lastUncValue = lastUncValue * UncToStoun).ToString();
        }
        else if (TextBoxStoun.Text != lastStounValue.ToString() && TextBoxStoun.Text != EMPTY_STRING)
        {
            lastStounValue = double.Parse(TextBoxStoun.Text);
            TextBoxKg.Text = (lastStounValue = lastStounValue * StounToKg).ToString();
            TextBoxDrahma.Text = (lastStounValue = lastStounValue * StounToDrahma).ToString();
            TextBoxGran.Text = (lastStounValue = lastStounValue * StounToGra).ToString();
            TextBoxFunt.Text = (lastStounValue = lastStounValue * StounToFunt).ToString();
            TextBoxUnc.Text = (lastStounValue = lastStounValue * StounToUnc).ToString();
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
        lastDrahmaValue = lastFuntValue = lastGranValue = lastKgValue = lastStounValue = lastUncValue = 0;
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

