namespace HandInputFunction
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.expressionTextBox = new System.Windows.Forms.RichTextBox();
            this.polishTextBox = new System.Windows.Forms.RichTextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.inputInfoLabel = new System.Windows.Forms.Label();
            this.polishLabel = new System.Windows.Forms.Label();
            this.resultBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // expressionTextBox
            // 
            this.expressionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expressionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expressionTextBox.Location = new System.Drawing.Point(159, 59);
            this.expressionTextBox.Name = "expressionTextBox";
            this.expressionTextBox.Size = new System.Drawing.Size(221, 61);
            this.expressionTextBox.TabIndex = 0;
            this.expressionTextBox.Text = "3+4*2/(1-5)^2";
            // 
            // polishTextBox
            // 
            this.polishTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.polishTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.polishTextBox.Location = new System.Drawing.Point(159, 154);
            this.polishTextBox.Name = "polishTextBox";
            this.polishTextBox.Size = new System.Drawing.Size(221, 58);
            this.polishTextBox.TabIndex = 1;
            this.polishTextBox.Text = "";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startBtn.FlatAppearance.BorderSize = 2;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.startBtn.Font = new System.Drawing.Font("BERNIER Shade", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(0, 339);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(736, 66);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Font = new System.Drawing.Font("Mistral", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(159, 252);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(221, 58);
            this.resultBox.TabIndex = 3;
            this.resultBox.Text = "";
            // 
            // inputInfoLabel
            // 
            this.inputInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputInfoLabel.AutoSize = true;
            this.inputInfoLabel.Font = new System.Drawing.Font("BERNIER Shade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputInfoLabel.Location = new System.Drawing.Point(386, 74);
            this.inputInfoLabel.Name = "inputInfoLabel";
            this.inputInfoLabel.Size = new System.Drawing.Size(257, 32);
            this.inputInfoLabel.TabIndex = 5;
            this.inputInfoLabel.Text = "вираз для обчислення";
            // 
            // polishLabel
            // 
            this.polishLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.polishLabel.AutoSize = true;
            this.polishLabel.Font = new System.Drawing.Font("BERNIER Shade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polishLabel.Location = new System.Drawing.Point(386, 165);
            this.polishLabel.Name = "polishLabel";
            this.polishLabel.Size = new System.Drawing.Size(203, 32);
            this.polishLabel.TabIndex = 6;
            this.polishLabel.Text = "Польський запис";
            // 
            // resultBtn
            // 
            this.resultBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBtn.AutoSize = true;
            this.resultBtn.Font = new System.Drawing.Font("BERNIER Shade", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBtn.Location = new System.Drawing.Point(386, 265);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(339, 32);
            this.resultBtn.TabIndex = 7;
            this.resultBtn.Text = "Результат обчислення виразу";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(736, 405);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.polishLabel);
            this.Controls.Add(this.inputInfoLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.polishTextBox);
            this.Controls.Add(this.expressionTextBox);
            this.Name = "MainForm";
            this.Text = "ExpressionCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox expressionTextBox;
        private System.Windows.Forms.RichTextBox polishTextBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label inputInfoLabel;
        private System.Windows.Forms.Label polishLabel;
        private System.Windows.Forms.Label resultBtn;
    }
}

