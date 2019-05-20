namespace DFA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AlphabetInputLabel = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.FileLoad = new System.Windows.Forms.Button();
            this.StringInput = new System.Windows.Forms.TextBox();
            this.StringInputLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.AlphabetLabel = new System.Windows.Forms.Label();
            this.AlphabetShow = new System.Windows.Forms.Label();
            this.PositionCheck = new System.Windows.Forms.Button();
            this.RefreshAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlphabetInputLabel
            // 
            this.AlphabetInputLabel.AutoSize = true;
            this.AlphabetInputLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlphabetInputLabel.Location = new System.Drawing.Point(30, 40);
            this.AlphabetInputLabel.Name = "AlphabetInputLabel";
            this.AlphabetInputLabel.Size = new System.Drawing.Size(187, 28);
            this.AlphabetInputLabel.TabIndex = 1;
            this.AlphabetInputLabel.Text = "Input ur alphabet";
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(35, 71);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(139, 20);
            this.InputBox.TabIndex = 2;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmButton.Location = new System.Drawing.Point(35, 108);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(157, 36);
            this.ConfirmButton.TabIndex = 3;
            this.ConfirmButton.Text = "confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // FileLoad
            // 
            this.FileLoad.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileLoad.Location = new System.Drawing.Point(35, 150);
            this.FileLoad.Name = "FileLoad";
            this.FileLoad.Size = new System.Drawing.Size(235, 36);
            this.FileLoad.TabIndex = 4;
            this.FileLoad.Text = "download a file";
            this.FileLoad.UseVisualStyleBackColor = true;
            this.FileLoad.Click += new System.EventHandler(this.FileLoad_Click);
            // 
            // StringInput
            // 
            this.StringInput.Location = new System.Drawing.Point(35, 244);
            this.StringInput.Name = "StringInput";
            this.StringInput.Size = new System.Drawing.Size(139, 20);
            this.StringInput.TabIndex = 5;
            // 
            // StringInputLabel
            // 
            this.StringInputLabel.AutoSize = true;
            this.StringInputLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StringInputLabel.Location = new System.Drawing.Point(35, 213);
            this.StringInputLabel.Name = "StringInputLabel";
            this.StringInputLabel.Size = new System.Drawing.Size(157, 28);
            this.StringInputLabel.TabIndex = 6;
            this.StringInputLabel.Text = "Input ur string";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplyButton.Location = new System.Drawing.Point(35, 270);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(125, 40);
            this.ApplyButton.TabIndex = 7;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.Location = new System.Drawing.Point(645, 464);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(33, 33);
            this.PositionLabel.TabIndex = 9;
            this.PositionLabel.Text = ":p";
            // 
            // AlphabetLabel
            // 
            this.AlphabetLabel.AutoSize = true;
            this.AlphabetLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphabetLabel.Location = new System.Drawing.Point(35, 464);
            this.AlphabetLabel.Name = "AlphabetLabel";
            this.AlphabetLabel.Size = new System.Drawing.Size(104, 28);
            this.AlphabetLabel.TabIndex = 10;
            this.AlphabetLabel.Text = "Alphabet";
            // 
            // AlphabetShow
            // 
            this.AlphabetShow.AutoSize = true;
            this.AlphabetShow.Font = new System.Drawing.Font("Nirmala UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlphabetShow.Location = new System.Drawing.Point(174, 464);
            this.AlphabetShow.Name = "AlphabetShow";
            this.AlphabetShow.Size = new System.Drawing.Size(0, 30);
            this.AlphabetShow.TabIndex = 11;
            // 
            // PositionCheck
            // 
            this.PositionCheck.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionCheck.Location = new System.Drawing.Point(417, 462);
            this.PositionCheck.Name = "PositionCheck";
            this.PositionCheck.Size = new System.Drawing.Size(222, 36);
            this.PositionCheck.TabIndex = 12;
            this.PositionCheck.Text = "Check ur position";
            this.PositionCheck.UseVisualStyleBackColor = true;
            this.PositionCheck.Click += new System.EventHandler(this.PositionCheck_Click);
            // 
            // RefreshAll
            // 
            this.RefreshAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshAll.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshAll.Location = new System.Drawing.Point(594, 30);
            this.RefreshAll.Name = "RefreshAll";
            this.RefreshAll.Size = new System.Drawing.Size(139, 38);
            this.RefreshAll.TabIndex = 13;
            this.RefreshAll.Text = "Refresh all";
            this.RefreshAll.UseVisualStyleBackColor = true;
            this.RefreshAll.Click += new System.EventHandler(this.RefreshAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DFA.Properties.Resources.DFA_Logo_OG1;
            this.ClientSize = new System.Drawing.Size(745, 513);
            this.Controls.Add(this.RefreshAll);
            this.Controls.Add(this.PositionCheck);
            this.Controls.Add(this.AlphabetShow);
            this.Controls.Add(this.AlphabetLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.StringInputLabel);
            this.Controls.Add(this.StringInput);
            this.Controls.Add(this.FileLoad);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.AlphabetInputLabel);
            this.Name = "Form1";
            this.Text = "DFA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AlphabetInputLabel;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button FileLoad;
        private System.Windows.Forms.TextBox StringInput;
        private System.Windows.Forms.Label StringInputLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label AlphabetLabel;
        private System.Windows.Forms.Label AlphabetShow;
        private System.Windows.Forms.Button PositionCheck;
        private System.Windows.Forms.Button RefreshAll;
    }
}

