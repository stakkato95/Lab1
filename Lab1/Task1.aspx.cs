using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task1 : System.Web.UI.Page
{
    private const String EMPTY_STRING = "";

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonEncrypt_Click(object sender, EventArgs e)
    {
        if (TextBoxSourse.Text != EMPTY_STRING)
        {
            char[] source = TextBoxSourse.Text.ToCharArray(0, TextBoxSourse.Text.Length);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] += (char)3;
            }
            string s = new string(source);
            TextBoxEncrypted.Text = s;
        }
        else
        {
            char[] source = TextBoxEncrypted.Text.ToCharArray(0, TextBoxEncrypted.Text.Length);
            for (int i = 0; i < source.Length; i++)
            {
                source[i] -= (char)3;
            }
            string s = new string(source);
            TextBoxSourse.Text = s;
        }
    }
    protected void EncryptValidator_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = (TextBoxSourse.Text == EMPTY_STRING && TextBoxEncrypted.Text != EMPTY_STRING) || 
            (TextBoxSourse.Text != EMPTY_STRING && TextBoxEncrypted.Text == EMPTY_STRING);
    }
}