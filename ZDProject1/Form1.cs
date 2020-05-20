using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace ZDProject1
{
    public partial class Form1 : Form
    {
        string PK_store_path = ".\\PK";
        public static string current_user;
        ECDsaCng ecdsaCng;
        public Form1()
        {
            InitializeComponent();
            Auth();
        }

        private void reset_form()
        {
            Text = "Новый документ - " + current_user + " - " + Application.ProductName;
            textBox_Name.Text = current_user;
            textBox_Text.Text = "";
            label_Info.Text = "";
            textBox_Text.ReadOnly = false;
            сохранитьToolStripMenuItem.Enabled = true;
        }

        private void Auth()
        {
            UserChoose userChoose = new UserChoose();
            if (userChoose.ShowDialog() == DialogResult.OK)
            {
                if (CngKey.Exists(current_user))
                {
                    CngKey ck = CngKey.Open(current_user);
                    ecdsaCng = new ECDsaCng(ck);
                }
                else
                {
                    CngKey ck = CngKey.Create(CngAlgorithm.ECDsaP256, current_user);
                    ecdsaCng = new ECDsaCng(ck);
                }
                
                if (!Directory.Exists(PK_store_path)) Directory.CreateDirectory(PK_store_path);
                if (!Directory.Exists(PK_store_path + "\\" + current_user)) Directory.CreateDirectory(PK_store_path + "\\" + current_user);
                reset_form();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_Text.Text == "" || MessageBox.Show("Текстовое поле будет очищено. Продолжить?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                reset_form();
            }
            this.Text = "Подписанный документ";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void changeUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Будет произведена деавторизация.\nТекстовое поле будет очищено. Продолжить?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Visible = false;
                Auth();
                Visible = true;
            }
        }

        private void Save_Public_Key(string name, byte[] pk_blob)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(PK_store_path + "\\" + current_user + "\\" + name + ".pk", FileMode.OpenOrCreate)))
            {
                byte[] bname = Encoding.Default.GetBytes(name);
                byte[] sign = ecdsaCng.SignData(pk_blob, HashAlgorithmName.SHA256);
                writer.Write(bname.Length);
                writer.Write(pk_blob.Length);
                writer.Write(bname);
                writer.Write(pk_blob);
                writer.Write(sign);
            }
        }

        private byte[] Find_Public_Key(string name)
        {
            if (File.Exists(PK_store_path + "\\" + current_user + "\\" + name + ".pk"))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(PK_store_path + "\\" + current_user + "\\" + name + ".pk", FileMode.Open)))
                {
                    int name_len = reader.ReadInt32();
                    int blob_len = reader.ReadInt32();
                    string readed_name = Encoding.Default.GetString(reader.ReadBytes(name_len));
                    byte[] readed_blob = reader.ReadBytes(blob_len);
                    byte[] readed_sign = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
                    if (name == readed_name && ecdsaCng.VerifyData(readed_blob, readed_sign, HashAlgorithmName.SHA256))
                    {
                        return readed_blob;
                    }
                    else
                    {
                        throw new Exception("bad");
                    }
                }
            }
            else
            {
                return null;
            }
        }

        private void экспортОткрытогоКлючаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Открытый ключ|*.pk";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] name = Encoding.Default.GetBytes(current_user);
                byte[] blob = ecdsaCng.Key.Export(CngKeyBlobFormat.EccPublicBlob);
                using (BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                {
                    writer.Write(name.Length);
                    writer.Write(blob.Length);
                    writer.Write(name);
                    writer.Write(blob);
                }
            }
        }

        private void loadDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Подписанный документ|*.edsd";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string name;
                byte[] sign, text;
                try
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(openFileDialog.FileName, FileMode.Open)))
                    {
                        int name_len = reader.ReadInt32();
                        int sign_len = reader.ReadInt32();
                        name = Encoding.Default.GetString(reader.ReadBytes(name_len));
                        sign = reader.ReadBytes(sign_len);
                        text = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Документ повреждён!", "Ошибка");
                    return;
                }
                ECDsaCng provider = new ECDsaCng();
                byte[] blob;
                if (name != current_user)
                {
                    try
                    {
                        blob = Find_Public_Key(name);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Файл с открытым ключом повреждён!", "Ошибка");
                        return;
                    }
                }
                else
                {
                    blob = ecdsaCng.Key.Export(CngKeyBlobFormat.EccPublicBlob);
                }
                сохранитьToolStripMenuItem.Enabled = false;
                textBox_Text.ReadOnly = true;
                Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                textBox_Text.Text = Encoding.Default.GetString(text);
                textBox_Name.Text = name;
                if (blob != null)
                {
                    provider = new ECDsaCng(CngKey.Import(blob, CngKeyBlobFormat.EccPublicBlob));
                    if (provider.VerifyData(text, sign, HashAlgorithmName.SHA256))
                    {
                        label_Info.ForeColor = Color.Green;
                        label_Info.Text = "Подлинность подтверждена.";
                        Text += " (подлинный) - " + name + " - " + Application.ProductName;
                    }
                    else
                    {
                        label_Info.ForeColor = Color.Red;
                        label_Info.Text = "Подлинность не подтверждена.";
                        Text += " (не подтверждённый) - " + name + " - " + Application.ProductName;
                        MessageBox.Show("Документ не является подлинным!", "Ошибка");
                    }
                }
                else
                {
                    label_Info.ForeColor = Color.Red;
                    label_Info.Text = "Подлинность не подтверждена.";
                    Text += " (не подтверждённый) - " + name + " - " + Application.ProductName;
                    MessageBox.Show("Открытый ключ пользователя " + name + " не найден в хранилище ключей!", "Ошибка");
                }
            }
        }

        private void saveDoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Подписанный документ|*.edsd";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //DSACryptoServiceProvider.SignData использует SHA1 по умолчанию
                byte[] sign = ecdsaCng.SignData(Encoding.Default.GetBytes(textBox_Text.Text), HashAlgorithmName.SHA256);
                byte[] name = Encoding.Default.GetBytes(current_user);
                using (BinaryWriter writer = new BinaryWriter(File.Open(saveFileDialog.FileName, FileMode.Create)))
                {
                    writer.Write(name.Length);
                    writer.Write(sign.Length);
                    writer.Write(name);
                    writer.Write(sign);
                    writer.Write(Encoding.Default.GetBytes(textBox_Text.Text));
                    Text = Path.GetFileNameWithoutExtension(saveFileDialog.FileName) + " - " + current_user + " - " + Application.ProductName;
                }
            }
        }

        private void импортОткрытогоКлючаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Открытый ключ|*.pk";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(openFileDialog.FileName, FileMode.Open)))
                    {
                        int name_len = reader.ReadInt32();
                        int blob_len = reader.ReadInt32();
                        string readed_name = Encoding.Default.GetString(reader.ReadBytes(name_len));
                        byte[] readed_blob = reader.ReadBytes(blob_len);
                        Save_Public_Key(readed_name, readed_blob);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Файл с открытым ключом повреждён!", "Ошибка");
                    return;
                }
            }
        }

        private void удалениеПарыКлючейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Будет удалена пара ключей авторизованного пользователя.\nБудет произведена деавторизация.\nТекстовое поле будет очищено. Продолжить?", "Предупреждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Visible = false;
                DeleteDirectory(PK_store_path + "\\" + current_user);
                ecdsaCng.Key.Delete();
                ecdsaCng.Clear();
                Auth();
                Visible = true;
            }
        }

        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }
    }
}
