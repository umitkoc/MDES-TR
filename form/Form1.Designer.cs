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
            DigitazeBtn = new Button();
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
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tokenizeBtn
            // 
            tokenizeBtn.Location = new Point(6, 34);
            tokenizeBtn.Name = "tokenizeBtn";
            tokenizeBtn.Size = new Size(159, 46);
            tokenizeBtn.TabIndex = 0;
            tokenizeBtn.Text = "Tokenize";
            tokenizeBtn.UseVisualStyleBackColor = true;
            tokenizeBtn.Click += tokenizeBtn_Click;
            // 
            // responseText
            // 
            responseText.Location = new Point(663, 408);
            responseText.Multiline = true;
            responseText.Name = "responseText";
            responseText.Size = new Size(758, 374);
            responseText.TabIndex = 1;
            // 
            // requestText
            // 
            requestText.Location = new Point(663, 8);
            requestText.Multiline = true;
            requestText.Name = "requestText";
            requestText.Size = new Size(758, 394);
            requestText.TabIndex = 2;
            // 
            // DigitazeBtn
            // 
            DigitazeBtn.Enabled = false;
            DigitazeBtn.Location = new Point(12, 14);
            DigitazeBtn.Name = "DigitazeBtn";
            DigitazeBtn.Size = new Size(159, 46);
            DigitazeBtn.TabIndex = 3;
            DigitazeBtn.Text = "Digitaze";
            DigitazeBtn.UseVisualStyleBackColor = true;
            DigitazeBtn.Click += DigitazeBtn_Click;
            // 
            // TransactBtn
            // 
            TransactBtn.Location = new Point(6, 86);
            TransactBtn.Name = "TransactBtn";
            TransactBtn.Size = new Size(159, 46);
            TransactBtn.TabIndex = 4;
            TransactBtn.Text = "Transact";
            TransactBtn.UseVisualStyleBackColor = true;
            TransactBtn.Click += TransactBtn_Click;
            // 
            // NotifyTokenUpdatedBtn
            // 
            NotifyTokenUpdatedBtn.Location = new Point(6, 138);
            NotifyTokenUpdatedBtn.Name = "NotifyTokenUpdatedBtn";
            NotifyTokenUpdatedBtn.Size = new Size(159, 46);
            NotifyTokenUpdatedBtn.TabIndex = 5;
            NotifyTokenUpdatedBtn.Text = "Notify Token Updated";
            NotifyTokenUpdatedBtn.UseVisualStyleBackColor = true;
            NotifyTokenUpdatedBtn.Click += NotifyTokenUpdatedBtn_Click;
            // 
            // SuspendBtn
            // 
            SuspendBtn.Location = new Point(6, 242);
            SuspendBtn.Name = "SuspendBtn";
            SuspendBtn.Size = new Size(159, 46);
            SuspendBtn.TabIndex = 7;
            SuspendBtn.Text = "Suspend";
            SuspendBtn.UseVisualStyleBackColor = true;
            SuspendBtn.Click += SuspendBtn_Click;
            // 
            // GetAssetBtn
            // 
            GetAssetBtn.Location = new Point(6, 190);
            GetAssetBtn.Name = "GetAssetBtn";
            GetAssetBtn.Size = new Size(159, 46);
            GetAssetBtn.TabIndex = 6;
            GetAssetBtn.Text = "Get Asset";
            GetAssetBtn.UseVisualStyleBackColor = true;
            GetAssetBtn.Click += GetAssetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(6, 346);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(159, 46);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UnsuspendBtn
            // 
            UnsuspendBtn.Location = new Point(6, 294);
            UnsuspendBtn.Name = "UnsuspendBtn";
            UnsuspendBtn.Size = new Size(159, 46);
            UnsuspendBtn.TabIndex = 8;
            UnsuspendBtn.Text = "Unsuspend";
            UnsuspendBtn.UseVisualStyleBackColor = true;
            UnsuspendBtn.Click += UnsuspendBtn_Click;
            // 
            // GetTokenBtn
            // 
            GetTokenBtn.Location = new Point(6, 502);
            GetTokenBtn.Name = "GetTokenBtn";
            GetTokenBtn.Size = new Size(159, 46);
            GetTokenBtn.TabIndex = 12;
            GetTokenBtn.Text = "Get Token";
            GetTokenBtn.UseVisualStyleBackColor = true;
            GetTokenBtn.Click += GetTokenBtn_Click;
            // 
            // SearchTokensBtn
            // 
            SearchTokensBtn.Location = new Point(6, 450);
            SearchTokensBtn.Name = "SearchTokensBtn";
            SearchTokensBtn.Size = new Size(159, 46);
            SearchTokensBtn.TabIndex = 11;
            SearchTokensBtn.Text = "Search Tokens";
            SearchTokensBtn.UseVisualStyleBackColor = true;
            SearchTokensBtn.Click += SearchTokensBtn_Click;
            // 
            // GetTaskStatusBtn
            // 
            GetTaskStatusBtn.Location = new Point(6, 398);
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
            DeliverActivationCodeBtn.Location = new Point(273, 434);
            DeliverActivationCodeBtn.Name = "DeliverActivationCodeBtn";
            DeliverActivationCodeBtn.Size = new Size(159, 46);
            DeliverActivationCodeBtn.TabIndex = 14;
            DeliverActivationCodeBtn.Text = "Deliver Activation Code";
            DeliverActivationCodeBtn.UseVisualStyleBackColor = true;
            DeliverActivationCodeBtn.Click += DeliverActivationCodeBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DeliverAuthenticationCodeBtn);
            groupBox1.Location = new Point(457, 408);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 374);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Send to Issuer";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(GetTokenBtn);
            groupBox2.Controls.Add(tokenizeBtn);
            groupBox2.Controls.Add(TransactBtn);
            groupBox2.Controls.Add(NotifyTokenUpdatedBtn);
            groupBox2.Controls.Add(SearchTokensBtn);
            groupBox2.Controls.Add(GetAssetBtn);
            groupBox2.Controls.Add(GetTaskStatusBtn);
            groupBox2.Controls.Add(SuspendBtn);
            groupBox2.Controls.Add(DeleteBtn);
            groupBox2.Controls.Add(UnsuspendBtn);
            groupBox2.Location = new Point(12, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(188, 561);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tokenize From MDES-TR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 794);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(DeliverActivationCodeBtn);
            Controls.Add(DigitazeBtn);
            Controls.Add(requestText);
            Controls.Add(responseText);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tokenizeBtn;
        private TextBox responseText;
        private TextBox requestText;
        private Button DigitazeBtn;
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
    }
}
