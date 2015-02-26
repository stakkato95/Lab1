using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Task1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonEncrypt_Click(object sender, EventArgs e)
    {
        if (TextBoxSourse.Text != "")
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
}