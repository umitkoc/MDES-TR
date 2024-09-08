namespace form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tokenizeBtn = new Button();
            responseText = new TextBox();
            requestText = new TextBox();
            TransactBtn = new Button();
            NotifyTokenUpdatedBtn = new Button();
            SuspendBtn = new Button();
            GetAssetBtn = new Button();
            DeleteBtn = new Button();
            UnsuspendBtn = new Button();
            GetTokenBtn = new Button();
            SearchTokensBtn = new Button();
            GetTaskStatusBtn = new Button();
            DeliverAuthenticationCodeBtn = new Button();
            DeliverActivationCodeBtn = new Button();
            groupBox1 = new GroupBox();
            RequestActivationMethodsBtn = new Button();
            NotifyServiceActivatedBtn = new Button();
            AuthorizeServiceBtn = new Button();
            groupBox2 = new GroupBox();
            GetAccountInformationBtn = new Button();
            ValidateActivationCodeBtn = new Button();
            groupBox3 = new GroupBox();
            NotifySuspiciousEventsBtn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tokenizeBtn
            // 
            tokenizeBtn.Location = new Point(6, 74);
            tokenizeBtn.Name = "tokenizeBtn";
            tokenizeBtn.Size = new Size(159, 46);
            tokenizeBtn.TabIndex = 0;
            tokenizeBtn.Text = "Tokenize";
            tokenizeBtn.UseVisualStyleBackColor = true;
            tokenizeBtn.Click += TokenizeBtn_Click;
            // 
            // responseText
            // 
            responseText.Font = new Font("Consolas", 14F, FontStyle.Bold);
            responseText.Location = new Point(663, 408);
            responseText.Multiline = true;
            responseText.Name = "responseText";
            responseText.ReadOnly = true;
            responseText.ScrollBars = ScrollBars.Vertical;
            responseText.Size = new Size(758, 374);
            responseText.TabIndex = 1;
            // 
            // requestText
            // 
            requestText.Font = new Font("Consolas", 14F, FontStyle.Bold);
            requestText.Location = new Point(663, 8);
            requestText.Multiline = true;
            requestText.Name = "requestText";
            requestText.ReadOnly = true;
            requestText.ScrollBars = ScrollBars.Vertical;
            requestText.Size = new Size(758, 394);
            requestText.TabIndex = 2;
            // 
            // TransactBtn
            // 
            TransactBtn.Location = new Point(6, 126);
            TransactBtn.Name = "TransactBtn";
            TransactBtn.Size = new Size(159, 46);
            TransactBtn.TabIndex = 4;
            TransactBtn.Text = "Transact";
            TransactBtn.UseVisualStyleBackColor = true;
            TransactBtn.Click += TransactBtn_Click;
            // 
            // NotifyTokenUpdatedBtn
            // 
            NotifyTokenUpdatedBtn.Location = new Point(6, 178);
            NotifyTokenUpdatedBtn.Name = "NotifyTokenUpdatedBtn";
            NotifyTokenUpdatedBtn.Size = new Size(159, 46);
            NotifyTokenUpdatedBtn.TabIndex = 5;
            NotifyTokenUpdatedBtn.Text = "Notify Token Updated";
            NotifyTokenUpdatedBtn.UseVisualStyleBackColor = true;
            NotifyTokenUpdatedBtn.Click += NotifyTokenUpdatedBtn_Click;
            // 
            // SuspendBtn
            // 
            SuspendBtn.Location = new Point(6, 232);
            SuspendBtn.Name = "SuspendBtn";
            SuspendBtn.Size = new Size(159, 46);
            SuspendBtn.TabIndex = 7;
            SuspendBtn.Text = "Suspend";
            SuspendBtn.UseVisualStyleBackColor = true;
            SuspendBtn.Click += SuspendBtn_Click;
            // 
            // GetAssetBtn
            // 
            GetAssetBtn.Location = new Point(6, 234);
            GetAssetBtn.Name = "GetAssetBtn";
            GetAssetBtn.Size = new Size(159, 46);
            GetAssetBtn.TabIndex = 6;
            GetAssetBtn.Text = "Get Asset";
            GetAssetBtn.UseVisualStyleBackColor = true;
            GetAssetBtn.Click += GetAssetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(6, 22);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(159, 46);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UnsuspendBtn
            // 
            UnsuspendBtn.Location = new Point(6, 284);
            UnsuspendBtn.Name = "UnsuspendBtn";
            UnsuspendBtn.Size = new Size(159, 46);
            UnsuspendBtn.TabIndex = 8;
            UnsuspendBtn.Text = "Unsuspend";
            UnsuspendBtn.UseVisualStyleBackColor = true;
            UnsuspendBtn.Click += UnsuspendBtn_Click;
            // 
            // GetTokenBtn
            // 
            GetTokenBtn.Location = new Point(6, 438);
            GetTokenBtn.Name = "GetTokenBtn";
            GetTokenBtn.Size = new Size(159, 46);
            GetTokenBtn.TabIndex = 12;
            GetTokenBtn.Text = "Get Token";
            GetTokenBtn.UseVisualStyleBackColor = true;
            GetTokenBtn.Click += GetTokenBtn_Click;
            // 
            // SearchTokensBtn
            // 
            SearchTokensBtn.Location = new Point(6, 386);
            SearchTokensBtn.Name = "SearchTokensBtn";
            SearchTokensBtn.Size = new Size(159, 46);
            SearchTokensBtn.TabIndex = 11;
            SearchTokensBtn.Text = "Search Tokens";
            SearchTokensBtn.UseVisualStyleBackColor = true;
            SearchTokensBtn.Click += SearchTokensBtn_Click;
            // 
            // GetTaskStatusBtn
            // 
            GetTaskStatusBtn.Location = new Point(6, 334);
            GetTaskStatusBtn.Name = "GetTaskStatusBtn";
            GetTaskStatusBtn.Size = new Size(159, 46);
            GetTaskStatusBtn.TabIndex = 10;
            GetTaskStatusBtn.Text = "Get Task Status";
            GetTaskStatusBtn.UseVisualStyleBackColor = true;
            GetTaskStatusBtn.Click += GetTaskStatusBtn_Click;
            // 
            // DeliverAuthenticationCodeBtn
            // 
            DeliverAuthenticationCodeBtn.Location = new Point(6, 26);
            DeliverAuthenticationCodeBtn.Name = "DeliverAuthenticationCodeBtn";
            DeliverAuthenticationCodeBtn.Size = new Size(159, 46);
            DeliverAuthenticationCodeBtn.TabIndex = 13;
            DeliverAuthenticationCodeBtn.Text = "Deliver Authentication Code";
            DeliverAuthenticationCodeBtn.UseVisualStyleBackColor = true;
            DeliverAuthenticationCodeBtn.Click += DeliverAuthenticationCodeBtn_Click;
            // 
            // DeliverActivationCodeBtn
            // 
            DeliverActivationCodeBtn.Location = new Point(6, 78);
            DeliverActivationCodeBtn.Name = "DeliverActivationCodeBtn";
            DeliverActivationCodeBtn.Size = new Size(159, 46);
            DeliverActivationCodeBtn.TabIndex = 14;
            DeliverActivationCodeBtn.Text = "Deliver Activation Code";
            DeliverActivationCodeBtn.UseVisualStyleBackColor = true;
            DeliverActivationCodeBtn.Click += DeliverActivationCodeBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NotifyServiceActivatedBtn);
            groupBox1.Controls.Add(DeliverAuthenticationCodeBtn);
            groupBox1.Controls.Add(DeliverActivationCodeBtn);
            groupBox1.Controls.Add(GetAssetBtn);
            groupBox1.Location = new Point(457, 370);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 412);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Send to Issuer";
            // 
            // RequestActivationMethodsBtn
            // 
            RequestActivationMethodsBtn.Location = new Point(6, 596);
            RequestActivationMethodsBtn.Name = "RequestActivationMethodsBtn";
            RequestActivationMethodsBtn.Size = new Size(159, 46);
            RequestActivationMethodsBtn.TabIndex = 10;
            RequestActivationMethodsBtn.Text = "Request Activation Methods";
            RequestActivationMethodsBtn.UseVisualStyleBackColor = true;
            RequestActivationMethodsBtn.Click += RequestActivationMethodsBtn_Click;
            // 
            // NotifyServiceActivatedBtn
            // 
            NotifyServiceActivatedBtn.Location = new Point(6, 182);
            NotifyServiceActivatedBtn.Name = "NotifyServiceActivatedBtn";
            NotifyServiceActivatedBtn.Size = new Size(159, 46);
            NotifyServiceActivatedBtn.TabIndex = 20;
            NotifyServiceActivatedBtn.Text = "Notify Service Activated";
            NotifyServiceActivatedBtn.UseVisualStyleBackColor = true;
            NotifyServiceActivatedBtn.Click += NotifyServiceActivatedBtn_Click;
            // 
            // AuthorizeServiceBtn
            // 
            AuthorizeServiceBtn.Location = new Point(6, 22);
            AuthorizeServiceBtn.Name = "AuthorizeServiceBtn";
            AuthorizeServiceBtn.Size = new Size(159, 46);
            AuthorizeServiceBtn.TabIndex = 20;
            AuthorizeServiceBtn.Text = "Authorize Service";
            AuthorizeServiceBtn.UseVisualStyleBackColor = true;
            AuthorizeServiceBtn.Click += AuthorizeServiceBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RequestActivationMethodsBtn);
            groupBox2.Controls.Add(AuthorizeServiceBtn);
            groupBox2.Controls.Add(GetAccountInformationBtn);
            groupBox2.Controls.Add(ValidateActivationCodeBtn);
            groupBox2.Controls.Add(GetTokenBtn);
            groupBox2.Controls.Add(tokenizeBtn);
            groupBox2.Controls.Add(TransactBtn);
            groupBox2.Controls.Add(NotifyTokenUpdatedBtn);
            groupBox2.Controls.Add(SearchTokensBtn);
            groupBox2.Controls.Add(GetTaskStatusBtn);
            groupBox2.Controls.Add(SuspendBtn);
            groupBox2.Controls.Add(UnsuspendBtn);
            groupBox2.Location = new Point(12, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 705);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tokenize From MDES-TR";
            // 
            // GetAccountInformationBtn
            // 
            GetAccountInformationBtn.Location = new Point(6, 544);
            GetAccountInformationBtn.Name = "GetAccountInformationBtn";
            GetAccountInformationBtn.Size = new Size(159, 46);
            GetAccountInformationBtn.TabIndex = 20;
            GetAccountInformationBtn.Text = "Get Account Information";
            GetAccountInformationBtn.UseVisualStyleBackColor = true;
            GetAccountInformationBtn.Click += GetAccountInformationBtn_Click;
            // 
            // ValidateActivationCodeBtn
            // 
            ValidateActivationCodeBtn.Location = new Point(6, 492);
            ValidateActivationCodeBtn.Name = "ValidateActivationCodeBtn";
            ValidateActivationCodeBtn.Size = new Size(159, 46);
            ValidateActivationCodeBtn.TabIndex = 19;
            ValidateActivationCodeBtn.Text = "Validate Activation Code";
            ValidateActivationCodeBtn.UseVisualStyleBackColor = true;
            ValidateActivationCodeBtn.Click += ValidateActivationCodeBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(NotifySuspiciousEventsBtn);
            groupBox3.Controls.Add(DeleteBtn);
            groupBox3.Location = new Point(254, 538);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 226);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "From Issuer";
            // 
            // NotifySuspiciousEventsBtn
            // 
            NotifySuspiciousEventsBtn.Location = new Point(6, 74);
            NotifySuspiciousEventsBtn.Name = "NotifySuspiciousEventsBtn";
            NotifySuspiciousEventsBtn.Size = new Size(159, 46);
            NotifySuspiciousEventsBtn.TabIndex = 10;
            NotifySuspiciousEventsBtn.Text = "Notify Suspicious Events";
            NotifySuspiciousEventsBtn.UseVisualStyleBackColor = true;
            NotifySuspiciousEventsBtn.Click += NotifySuspiciousEventsBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 794);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(requestText);
            Controls.Add(responseText);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tokenizeBtn;
        private TextBox responseText;
        private TextBox requestText;
        private Button TransactBtn;
        private Button NotifyTokenUpdatedBtn;
        private Button SuspendBtn;
        private Button GetAssetBtn;
        private Button DeleteBtn;
        private Button UnsuspendBtn;
        private Button GetTokenBtn;
        private Button SearchTokensBtn;
        private Button GetTaskStatusBtn;
        private Button DeliverAuthenticationCodeBtn;
        private Button DeliverActivationCodeBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button ValidateActivationCodeBtn;
        private Button AuthorizeServiceBtn;
        private Button NotifyServiceActivatedBtn;
        private GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button RequestActivationMethodsBtn;
        private Button GetAccountInformationBtn;
        private Button NotifySuspiciousEventsBtn;
    }
}
