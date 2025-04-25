using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CVValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int HighlightField(TextBox field, Func<string, bool> isValid, string fieldName)
        {
            if (!isValid(field.Text))
            {
                field.BackColor = Color.MistyRose;
                return 0;
            }
            else
            {
                field.BackColor = Color.Honeydew;
                return 1;
            }
        }

        private void btnValidateForm_Click(object sender, EventArgs e)
        {
            int score = 0;
            score += HighlightField(txtName, s => !string.IsNullOrWhiteSpace(s), "Name");
            score += HighlightField(txtEmail, s => Regex.IsMatch(s, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"), "Email");
            score += HighlightField(txtPhone, s => Regex.IsMatch(s, @"^\d{10,15}$"), "Phone");
            score += HighlightField(txtPassword, s => s.Length >= 6, "Password");
            score += HighlightField(txtAddress, s => !string.IsNullOrWhiteSpace(s), "Address");
            score += HighlightField(txtPostal, s => Regex.IsMatch(s, @"^\d{5,}$"), "Postal Code");

            string message = score switch
            {
                6 => "كل البيانات ممتازة! ✅",
                >= 4 => "أغلب البيانات صحيحة، راجع الباقي 💡",
                _ => "في بيانات ناقصة أو غير صحيحة ❌"
            };

            MessageBox.Show(message, "نتيجة الفحص", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnParseCV_Click(object sender, EventArgs e)
        {
            string cvText = txtCV.Text;
            if (string.IsNullOrWhiteSpace(cvText))
            {
                MessageBox.Show("يرجى إدخال السيرة الذاتية أولاً!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = Regex.Match(cvText, @"\b([A-Za-z]+ [A-Za-z]+)\b").Value;
            string phone = Regex.Match(cvText, @"\b\d{10,15}\b").Value;
            string email = Regex.Match(cvText, @"^[^@\s]+@[^@\s]+\.[^@\s]+$").Value;
            string skills = Regex.Match(cvText, @"(C\#|Java|SQL)").Value;
            string yearsOfExperience = Regex.Match(cvText, @"\d+\s(years|عام)").Value;

            string summary = $"📄 الاسم: {fullName}\n" +
                             $"📞 الهاتف: {phone}\n" +
                             $"📧 البريد الإلكتروني: {email}\n" +
                             $"🛠 المهارات: {skills}\n" +
                             $"📅 سنوات الخبرة: {yearsOfExperience}";

            MessageBox.Show(summary, "تحليل السيرة الذاتية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveResults_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "احفظ النتائج في ملف"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    writer.WriteLine("الاسم,البريد الإلكتروني,رقم الهاتف,كلمة المرور,العنوان,الرمز البريدي,السيرة الذاتية");
                    writer.WriteLine($"{txtName.Text},{txtEmail.Text},{txtPhone.Text},{txtPassword.Text},{txtAddress.Text},{txtPostal.Text},{txtCV.Text.Replace(",", " ")}");
                }

                MessageBox.Show("✅ تم حفظ البيانات بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
