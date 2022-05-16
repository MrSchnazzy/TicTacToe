namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boardPanel = new System.Windows.Forms.Panel();
            this.square8 = new System.Windows.Forms.Label();
            this.square5 = new System.Windows.Forms.Label();
            this.square2 = new System.Windows.Forms.Label();
            this.square7 = new System.Windows.Forms.Label();
            this.square6 = new System.Windows.Forms.Label();
            this.square4 = new System.Windows.Forms.Label();
            this.square3 = new System.Windows.Forms.Label();
            this.square1 = new System.Windows.Forms.Label();
            this.square0 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.winLabel = new System.Windows.Forms.Label();
            this.boardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boardPanel.Controls.Add(this.square8);
            this.boardPanel.Controls.Add(this.square5);
            this.boardPanel.Controls.Add(this.square2);
            this.boardPanel.Controls.Add(this.square7);
            this.boardPanel.Controls.Add(this.square6);
            this.boardPanel.Controls.Add(this.square4);
            this.boardPanel.Controls.Add(this.square3);
            this.boardPanel.Controls.Add(this.square1);
            this.boardPanel.Controls.Add(this.square0);
            this.boardPanel.Location = new System.Drawing.Point(12, 12);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(420, 421);
            this.boardPanel.TabIndex = 0;
            // 
            // square8
            // 
            this.square8.BackColor = System.Drawing.SystemColors.Control;
            this.square8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square8.Location = new System.Drawing.Point(294, 294);
            this.square8.Name = "square8";
            this.square8.Size = new System.Drawing.Size(125, 125);
            this.square8.TabIndex = 0;
            this.square8.Text = "X";
            this.square8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square8.Click += new System.EventHandler(this.Square_Click);
            // 
            // square5
            // 
            this.square5.BackColor = System.Drawing.SystemColors.Control;
            this.square5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square5.Location = new System.Drawing.Point(294, 147);
            this.square5.Name = "square5";
            this.square5.Size = new System.Drawing.Size(125, 125);
            this.square5.TabIndex = 0;
            this.square5.Text = "O";
            this.square5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square5.Click += new System.EventHandler(this.Square_Click);
            // 
            // square2
            // 
            this.square2.BackColor = System.Drawing.SystemColors.Control;
            this.square2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square2.Location = new System.Drawing.Point(294, 0);
            this.square2.Name = "square2";
            this.square2.Size = new System.Drawing.Size(125, 125);
            this.square2.TabIndex = 0;
            this.square2.Text = "X";
            this.square2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square2.Click += new System.EventHandler(this.Square_Click);
            // 
            // square7
            // 
            this.square7.BackColor = System.Drawing.SystemColors.Control;
            this.square7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square7.Location = new System.Drawing.Point(147, 294);
            this.square7.Name = "square7";
            this.square7.Size = new System.Drawing.Size(125, 125);
            this.square7.TabIndex = 0;
            this.square7.Text = "O";
            this.square7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square7.Click += new System.EventHandler(this.Square_Click);
            // 
            // square6
            // 
            this.square6.BackColor = System.Drawing.SystemColors.Control;
            this.square6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square6.Location = new System.Drawing.Point(0, 294);
            this.square6.Name = "square6";
            this.square6.Size = new System.Drawing.Size(125, 125);
            this.square6.TabIndex = 0;
            this.square6.Text = "X";
            this.square6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square6.Click += new System.EventHandler(this.Square_Click);
            // 
            // square4
            // 
            this.square4.BackColor = System.Drawing.SystemColors.Control;
            this.square4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square4.Location = new System.Drawing.Point(147, 147);
            this.square4.Name = "square4";
            this.square4.Size = new System.Drawing.Size(125, 125);
            this.square4.TabIndex = 0;
            this.square4.Text = "X";
            this.square4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square4.Click += new System.EventHandler(this.Square_Click);
            // 
            // square3
            // 
            this.square3.BackColor = System.Drawing.SystemColors.Control;
            this.square3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square3.Location = new System.Drawing.Point(0, 147);
            this.square3.Name = "square3";
            this.square3.Size = new System.Drawing.Size(125, 125);
            this.square3.TabIndex = 0;
            this.square3.Text = "O";
            this.square3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square3.Click += new System.EventHandler(this.Square_Click);
            // 
            // square1
            // 
            this.square1.BackColor = System.Drawing.SystemColors.Control;
            this.square1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square1.Location = new System.Drawing.Point(147, 0);
            this.square1.Name = "square1";
            this.square1.Size = new System.Drawing.Size(125, 125);
            this.square1.TabIndex = 0;
            this.square1.Text = "O";
            this.square1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square1.Click += new System.EventHandler(this.Square_Click);
            // 
            // square0
            // 
            this.square0.BackColor = System.Drawing.SystemColors.Control;
            this.square0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.square0.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.square0.Location = new System.Drawing.Point(0, 0);
            this.square0.Name = "square0";
            this.square0.Size = new System.Drawing.Size(125, 125);
            this.square0.TabIndex = 0;
            this.square0.Text = "X";
            this.square0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.square0.Click += new System.EventHandler(this.Square_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(85, 502);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(123, 52);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(234, 502);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(123, 52);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.SystemColors.Control;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(12, 432);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(420, 67);
            this.winLabel.TabIndex = 0;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Click += new System.EventHandler(this.Square_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.newGameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.quitButton;
            this.ClientSize = new System.Drawing.Size(447, 566);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.winLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.boardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label square8;
        private System.Windows.Forms.Label square5;
        private System.Windows.Forms.Label square2;
        private System.Windows.Forms.Label square7;
        private System.Windows.Forms.Label square6;
        private System.Windows.Forms.Label square4;
        private System.Windows.Forms.Label square3;
        private System.Windows.Forms.Label square1;
        private System.Windows.Forms.Label square0;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label winLabel;
    }
}

