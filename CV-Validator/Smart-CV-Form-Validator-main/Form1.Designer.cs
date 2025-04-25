namespace CVValidator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtName, txtEmail, txtPhone, txtPassword, txtAddress, txtPostal, txtCV;
        private Button btnValidateForm, btnParseCV, btnSaveResults;
        private Label lblTitle;
        private GroupBox groupUserData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            txtPostal = new TextBox();
            txtCV = new TextBox();
            btnValidateForm = new Button();
            btnParseCV = new Button();
            lblTitle = new Label();
            btnSaveResults = new Button();
            groupUserData = new GroupBox();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(120, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 40);
            lblTitle.Text = "Smart CV & Info Validator";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // groupUserData
            // 
            groupUserData.Location = new Point(20, 65);
            groupUserData.Size = new Size(250, 240);
            groupUserData.Text = "Your Information";
            groupUserData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupUserData.ForeColor = Color.DarkSlateGray;

            // TextBoxes inside group
            txtName.Location = new Point(15, 30);
            txtName.Size = new Size(210, 23);
            txtName.PlaceholderText = "Full Name";

            txtEmail.Location = new Point(15, 60);
            txtEmail.Size = new Size(210, 23);
            txtEmail.PlaceholderText = "Email";

            txtPhone.Location = new Point(15, 90);
            txtPhone.Size = new Size(210, 23);
            txtPhone.PlaceholderText = "Phone";

            txtPassword.Location = new Point(15, 120);
            txtPassword.Size = new Size(210, 23);
            txtPassword.PlaceholderText = "Password";

            txtAddress.Location = new Point(15, 150);
            txtAddress.Size = new Size(210, 23);
            txtAddress.PlaceholderText = "Address";

            txtPostal.Location = new Point(15, 180);
            txtPostal.Size = new Size(210, 23);
            txtPostal.PlaceholderText = "Postal Code";

            groupUserData.Controls.AddRange(new Control[] {
                txtName, txtEmail, txtPhone, txtPassword, txtAddress, txtPostal
            });

            // 
            // txtCV
            // 
            txtCV.Location = new Point(290, 70);
            txtCV.Multiline = true;
            txtCV.Size = new Size(280, 170);
            txtCV.PlaceholderText = "Insert your CV here...";
            txtCV.ScrollBars = ScrollBars.Vertical;

            // 
            // btnValidateForm
            // 
            btnValidateForm.Location = new Point(290, 250);
            btnValidateForm.Size = new Size(280, 30);
            btnValidateForm.Text = "Validate Information";
            btnValidateForm.BackColor = Color.LightCyan;
            btnValidateForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnValidateForm.Click += btnValidateForm_Click;

            // 
            // btnParseCV
            // 
            btnParseCV.Location = new Point(290, 290);
            btnParseCV.Size = new Size(280, 30);
            btnParseCV.Text = "Parse CV Details";
            btnParseCV.BackColor = Color.LemonChiffon;
            btnParseCV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnParseCV.Click += btnParseCV_Click;

            // 
            // btnSaveResults
            // 
            btnSaveResults.Location = new Point(20, 320);
            btnSaveResults.Size = new Size(550, 35);
            btnSaveResults.Text = "Save Summary";
            btnSaveResults.BackColor = Color.Honeydew;
            btnSaveResults.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveResults.Click += btnSaveResults_Click;

            // 
            // Form1
            // 
            ClientSize = new Size(600, 380);
            Controls.Add(lblTitle);
            Controls.Add(groupUserData);
            Controls.Add(txtCV);
            Controls.Add(btnValidateForm);
            Controls.Add(btnParseCV);
            Controls.Add(btnSaveResults);
            Name = "Form1";
            Text = "CV & Data Analyzer";
            BackColor = Color.White;
            ResumeLayout(false);
        }
    }
}
