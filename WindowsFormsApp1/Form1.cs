using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        private enum TLoginType { LtMail, LtUsername };
        private TLoginType LoginType = TLoginType.LtMail;

        private const string DbMailAddress = "mail";
        private const string DbPassword1 = "password";

        private TLoginType LoginType2 = TLoginType.LtUsername;
        private const string DbUsername = "admin";
        private const string DbPassword2 = "password";


        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string Username, Password, MailAddress;

            if (LoginType == TLoginType.LtMail)
            {

                if (TxtMail.Text.Trim() == "" || TxtPassword.Text.Trim() == "")
                    MessageBox.Show("Mail adresi veya şifre boş olamaz.");
                else
                {
                    MailAddress = TxtMail.Text.Trim();
                    Password = TxtPassword.Text.Trim();

                    if (DbMailAddress != MailAddress)
                        MessageBox.Show("Giriş bilgileri hatalı");
                    else
                    {
                        if (DbPassword1 != Password)
                            MessageBox.Show("Giriş bilgileri hatalı");
                        else
                        {
                            if (DbMailAddress == MailAddress && DbPassword1 == Password)
                                MessageBox.Show("Giriş başarılı");
                        }
                    }



                }

            }

            if (LoginType2 == TLoginType.LtUsername)
            {
                if (TxtUserName.Text.Trim() == "" || TxtUserPassword.Text.Trim() == "")
                    MessageBox.Show("Kullanıcı Adı veya Şifresi Boş Olamaz...");
                else
                {
                    Username = TxtUserName.Text.Trim();
                    Password= TxtUserPassword.Text.Trim();

                    if (DbUsername != Username)
                        MessageBox.Show("Giriş bilgileri hatalı");
                    else
                    {
                        if (DbPassword2 != Password)
                            MessageBox.Show("Giriş bilgileri hatalı");
                        else
                        {
                            if(DbUsername == Username && DbPassword2 == Password)
                                MessageBox.Show("Tebrikler Giriş Başarılı");
                        }


                    }




                }
            }

        }
        private void TabLoginBox_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabLoginBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabLoginBox.SelectedIndex == 0)
                LoginType = TLoginType.LtMail;
            else if (TabLoginBox.SelectedIndex == 1)
                LoginType = TLoginType.LtUsername;
        }
    }
}
