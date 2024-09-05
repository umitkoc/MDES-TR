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
            SuspendLayout();
            // 
            // tokenizeBtn
            // 
            tokenizeBtn.Location = new Point(12, 200);
            tokenizeBtn.Name = "tokenizeBtn";
            tokenizeBtn.Size = new Size(159, 46);
            tokenizeBtn.TabIndex = 0;
            tokenizeBtn.Text = "Tokenize";
            tokenizeBtn.UseVisualStyleBackColor = true;
            tokenizeBtn.Click += tokenizeBtn_Click;
            // 
            // responseText
            // 
            responseText.Location = new Point(777, 408);
            responseText.Multiline = true;
            responseText.Name = "responseText";
            responseText.Size = new Size(644, 376);
            responseText.TabIndex = 1;
            // 
            // requestText
            // 
            requestText.Location = new Point(777, 8);
            requestText.Multiline = true;
            requestText.Name = "requestText";
            requestText.Size = new Size(644, 394);
            requestText.TabIndex = 2;
            // 
            // DigitazeBtn
            // 
            DigitazeBtn.Enabled = false;
            DigitazeBtn.Location = new Point(12, 148);
            DigitazeBtn.Name = "DigitazeBtn";
            DigitazeBtn.Size = new Size(159, 46);
            DigitazeBtn.TabIndex = 3;
            DigitazeBtn.Text = "Digitaze";
            DigitazeBtn.UseVisualStyleBackColor = true;
            DigitazeBtn.Click += DigitazeBtn_Click;
            // 
            // TransactBtn
            // 
            TransactBtn.Location = new Point(12, 252);
            TransactBtn.Name = "TransactBtn";
            TransactBtn.Size = new Size(159, 46);
            TransactBtn.TabIndex = 4;
            TransactBtn.Text = "Transact";
            TransactBtn.UseVisualStyleBackColor = true;
            TransactBtn.Click += TransactBtn_Click;
            // 
            // NotifyTokenUpdatedBtn
            // 
            NotifyTokenUpdatedBtn.Location = new Point(12, 304);
            NotifyTokenUpdatedBtn.Name = "NotifyTokenUpdatedBtn";
            NotifyTokenUpdatedBtn.Size = new Size(159, 46);
            NotifyTokenUpdatedBtn.TabIndex = 5;
            NotifyTokenUpdatedBtn.Text = "Notify Token Updated";
            NotifyTokenUpdatedBtn.UseVisualStyleBackColor = true;
            NotifyTokenUpdatedBtn.Click += NotifyTokenUpdatedBtn_Click;
            // 
            // SuspendBtn
            // 
            SuspendBtn.Location = new Point(12, 408);
            SuspendBtn.Name = "SuspendBtn";
            SuspendBtn.Size = new Size(159, 46);
            SuspendBtn.TabIndex = 7;
            SuspendBtn.Text = "Suspend";
            SuspendBtn.UseVisualStyleBackColor = true;
            SuspendBtn.Click += SuspendBtn_Click;
            // 
            // GetAssetBtn
            // 
            GetAssetBtn.Location = new Point(12, 356);
            GetAssetBtn.Name = "GetAssetBtn";
            GetAssetBtn.Size = new Size(159, 46);
            GetAssetBtn.TabIndex = 6;
            GetAssetBtn.Text = "Get Asset";
            GetAssetBtn.UseVisualStyleBackColor = true;
            GetAssetBtn.Click += GetAssetBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(12, 512);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(159, 46);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UnsuspendBtn
            // 
            UnsuspendBtn.Location = new Point(12, 460);
            UnsuspendBtn.Name = "UnsuspendBtn";
            UnsuspendBtn.Size = new Size(159, 46);
            UnsuspendBtn.TabIndex = 8;
            UnsuspendBtn.Text = "Unsuspend";
            UnsuspendBtn.UseVisualStyleBackColor = true;
            UnsuspendBtn.Click += UnsuspendBtn_Click;
            // 
            // GetTokenBtn
            // 
            GetTokenBtn.Location = new Point(12, 668);
            GetTokenBtn.Name = "GetTokenBtn";
            GetTokenBtn.Size = new Size(159, 46);
            GetTokenBtn.TabIndex = 12;
            GetTokenBtn.Text = "Get Token";
            GetTokenBtn.UseVisualStyleBackColor = true;
            GetTokenBtn.Click += GetTokenBtn_Click;
            // 
            // SearchTokensBtn
            // 
            SearchTokensBtn.Location = new Point(12, 616);
            SearchTokensBtn.Name = "SearchTokensBtn";
            SearchTokensBtn.Size = new Size(159, 46);
            SearchTokensBtn.TabIndex = 11;
            SearchTokensBtn.Text = "Search Tokens";
            SearchTokensBtn.UseVisualStyleBackColor = true;
            SearchTokensBtn.Click += SearchTokensBtn_Click;
            // 
            // GetTaskStatusBtn
            // 
            GetTaskStatusBtn.Location = new Point(12, 564);
            GetTaskStatusBtn.Name = "GetTaskStatusBtn";
            GetTaskStatusBtn.Size = new Size(159, 46);
            GetTaskStatusBtn.TabIndex = 10;
            GetTaskStatusBtn.Text = "Get Task Status";
            GetTaskStatusBtn.UseVisualStyleBackColor = true;
            GetTaskStatusBtn.Click += GetTaskStatusBtn_Click;
            // 
            responseText.Location = new Point(497, 138);
            responseText.Multiline = true;
            responseText.Name = "responseText";
            responseText.Size = new Size(259, 241);
            responseText.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 787);
            Controls.Add(GetTokenBtn);
            Controls.Add(SearchTokensBtn);
            Controls.Add(GetTaskStatusBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UnsuspendBtn);
            Controls.Add(SuspendBtn);
            Controls.Add(GetAssetBtn);
            Controls.Add(NotifyTokenUpdatedBtn);
            Controls.Add(TransactBtn);
            Controls.Add(DigitazeBtn);
            Controls.Add(requestText);
            ClientSize = new Size(800, 450);
            Controls.Add(responseText);
            Controls.Add(tokenizeBtn);
            Name = "Form1";
            Text = "Form1";
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
    }
}
