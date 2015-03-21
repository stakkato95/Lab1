using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task2 : System.Web.UI.Page
{
    private const String EMPTY_STRING = "";
    private double mTempValue;

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

    static List<TextBox> sTextBoxes;
    static Task2()
    {
        sTextBoxes = new List<TextBox>();
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (sTextBoxes.Count == 0)
        {
            sTextBoxes.Add(TextBoxKg);
            sTextBoxes.Add(TextBoxFunt);
            sTextBoxes.Add(TextBoxUnc);
            sTextBoxes.Add(TextBoxDrahma);
            sTextBoxes.Add(TextBoxGran);
            sTextBoxes.Add(TextBoxStoun);
        }
    }

    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        foreach (TextBox textBox in sTextBoxes)
        {
            textBox.Text = EMPTY_STRING;
        }
    }

    protected void MassValidator_ServerValidate(object source, ServerValidateEventArgs args)
    {
        foreach (TextBox textBox in sTextBoxes)
        {
            if (textBox.Text.Length != 0)
            {
                args.IsValid = true;
            }
        }
        args.IsValid = false;
    }

    protected void TextBoxGran_TextChanged(object sender, EventArgs e)
    {
        if (TextBoxGran.Text.Length != 0)
        {
            mTempValue = double.Parse(TextBoxGran.Text, CultureInfo.InvariantCulture);
            TextBoxKg.Text = (mTempValue * GraToKg).ToString();
            TextBoxFunt.Text = (mTempValue * GraToFunt).ToString();
            TextBoxUnc.Text = (mTempValue * GraToUnc).ToString();
            TextBoxDrahma.Text = (mTempValue * GraToDrahma).ToString();
            TextBoxStoun.Text = (mTempValue * GraToStoun).ToString();
        }
    }
    protected void TextBoxKg_TextChanged(object sender, EventArgs e)
    {
        if (TextBoxKg.Text.Length != 0)
        {
            mTempValue = double.Parse(TextBoxKg.Text, CultureInfo.InvariantCulture);
            TextBoxGran.Text = (mTempValue * KgToGra).ToString();
            TextBoxFunt.Text = (mTempValue * KgToFunt).ToString();
            TextBoxUnc.Text = (mTempValue * KgToUnc).ToString();
            TextBoxDrahma.Text = (mTempValue * KgToDrahma).ToString();
            TextBoxStoun.Text = (mTempValue * KgToStoun).ToString();
        }
    }
    protected void TextBoxFunt_TextChanged(object sender, EventArgs e)
    {
        if (TextBoxFunt.Text.Length != 0)
        {
            mTempValue = double.Parse(TextBoxFunt.Text, CultureInfo.InvariantCulture);
            TextBoxGran.Text = (mTempValue * FuntToGra).ToString();
            TextBoxKg.Text = (mTempValue * FuntToKg).ToString();
            TextBoxUnc.Text = (mTempValue * FuntToUnc).ToString();
            TextBoxDrahma.Text = (mTempValue * FuntToDrahma).ToString();
            TextBoxStoun.Text = (mTempValue * FuntToStoun).ToString();
        }
    }
    protected void TextBoxUnc_TextChanged(object sender, EventArgs e)
    {
        if (TextBoxUnc.Text.Length != 0)
        {
            mTempValue = double.Parse(TextBoxUnc.Text, CultureInfo.InvariantCulture);
            TextBoxGran.Text = (mTempValue * UncToGra).ToString();
            TextBoxKg.Text = (mTempValue * UncToKg).ToString();
            TextBoxFunt.Text = (mTempValue * UncToFunt).ToString();
            TextBoxDrahma.Text = (mTempValue * UncToDrahma).ToString();
            TextBoxStoun.Text = (mTempValue * UncToStoun).ToString();
        }
    }
    protected void TextBoxStoun_TextChanged(object sender, EventArgs e)
    {
        if (TextBoxStoun.Text.Length != 0)
        {
            mTempValue = double.Parse(TextBoxStoun.Text, CultureInfo.InvariantCulture);
            TextBoxGran.Text = (mTempValue * StounToGra).ToString();
            TextBoxKg.Text = (mTempValue * StounToKg).ToString();
            TextBoxFunt.Text = (mTempValue * StounToFunt).ToString();
            TextBoxDrahma.Text = (mTempValue * StounToDrahma).ToString();
            TextBoxUnc.Text = (mTempValue * StounToUnc).ToString();
        }
    }
    protected void TextBoxDrahma_TextChanged(object sender, EventArgs e)
    {
        if (TextBoxDrahma.Text.Length != 0)
        {
            mTempValue = double.Parse(TextBoxDrahma.Text, CultureInfo.InvariantCulture);
            TextBoxGran.Text = (mTempValue * DrahmaToGra).ToString();
            TextBoxKg.Text = (mTempValue * DrahmaToKg).ToString();
            TextBoxFunt.Text = (mTempValue * DrahmaToFunt).ToString();
            TextBoxStoun.Text = (mTempValue * DrahmaToStoun).ToString();
            TextBoxUnc.Text = (mTempValue * DrahmaToUnc).ToString();
        }
    }

}

