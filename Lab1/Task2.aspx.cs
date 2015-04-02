using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task2 : System.Web.UI.Page
{
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

    static Dictionary<string,Dictionary<string, double>> sTextBoxes;
    static Task2()
    {
        sTextBoxes = new Dictionary<string, Dictionary<string, double>>();
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (sTextBoxes.Count == 0)
        {
            sTextBoxes.Add(TextBoxKg.ID, new Dictionary<string, double>() {
                {TextBoxDrahma.ID,KgToDrahma},
                {TextBoxFunt.ID,KgToFunt},
                {TextBoxGran.ID,KgToGra},
                {TextBoxUnc.ID,KgToUnc},
                {TextBoxStoun.ID,KgToStoun}
            });
            sTextBoxes.Add(TextBoxFunt.ID, new Dictionary<string, double>() {
                {TextBoxKg.ID,FuntToKg},
                {TextBoxDrahma.ID,FuntToDrahma},
                {TextBoxGran.ID,FuntToGra},
                {TextBoxUnc.ID,FuntToUnc},
                {TextBoxStoun.ID,FuntToStoun}
            });
            sTextBoxes.Add(TextBoxUnc.ID, new Dictionary<string, double>() {
                {TextBoxKg.ID,UncToKg},
                {TextBoxDrahma.ID,UncToDrahma},
                {TextBoxGran.ID,UncToGra},
                {TextBoxFunt.ID,UncToFunt},
                {TextBoxStoun.ID,UncToStoun}
            });
            sTextBoxes.Add(TextBoxDrahma.ID, new Dictionary<string, double>() {
                {TextBoxKg.ID,DrahmaToKg},
                {TextBoxFunt.ID,DrahmaToFunt},
                {TextBoxGran.ID,DrahmaToGra},
                {TextBoxUnc.ID,DrahmaToUnc},
                {TextBoxStoun.ID,DrahmaToStoun}
            });
            sTextBoxes.Add(TextBoxGran.ID, new Dictionary<string, double>() {
                {TextBoxKg.ID,GraToKg},
                {TextBoxDrahma.ID,GraToDrahma},
                {TextBoxFunt.ID,GraToFunt},
                {TextBoxUnc.ID,GraToUnc},
                {TextBoxStoun.ID,GraToStoun}
            });
            sTextBoxes.Add(TextBoxStoun.ID, new Dictionary<string, double>() {
                {TextBoxKg.ID,StounToKg},
                {TextBoxDrahma.ID,StounToDrahma},
                {TextBoxFunt.ID,StounToFunt},
                {TextBoxUnc.ID,StounToUnc},
                {TextBoxGran.ID,StounToGra}
            });
        }
    }

    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        foreach (string textBoxId in sTextBoxes.Keys)
        {
            (ContainerPanel.FindControl(textBoxId) as TextBox).Text = string.Empty;
        }
    }

    protected void MassValidator_ServerValidate(object source, ServerValidateEventArgs args)
    {
        foreach (string textBoxId in sTextBoxes.Keys)
        {
            if ((ContainerPanel.FindControl(textBoxId) as TextBox).Text.Length != 0)
            {
                args.IsValid = true;
                return;
            }
        }
        args.IsValid = false;
    }

    protected void Unified_TextChanged(object sender, EventArgs e)
    {
        TextBox textBoxSender = ContainerPanel.FindControl((sender as TextBox).ID) as TextBox;
        TextBox configurableTextBox;

        foreach (string textBoxId in sTextBoxes.Keys)
        {
            configurableTextBox = ContainerPanel.FindControl(textBoxId) as TextBox;
            if (configurableTextBox == textBoxSender)
            {
                continue;
            }
            configurableTextBox.Text = (double.Parse(textBoxSender.Text, CultureInfo.InvariantCulture) * sTextBoxes[textBoxSender.ID][configurableTextBox.ID]).ToString();
        }
    }

}

