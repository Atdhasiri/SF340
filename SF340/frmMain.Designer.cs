namespace QuizApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timeOut = new System.Windows.Forms.Timer(this.components);
            this.lblRound = new System.Windows.Forms.Label();
            this.pnTimeOut = new System.Windows.Forms.Panel();
            this.lblSummaryRound = new System.Windows.Forms.Label();
            this.lblSummaryScore = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.pnTimeOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.btnChoice1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoice1.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.ForeColor = System.Drawing.Color.White;
            this.btnChoice1.Image = global::QuizApp.Properties.Resources.geometry_triangle_32;
            this.btnChoice1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoice1.Location = new System.Drawing.Point(49, 294);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChoice1.Size = new System.Drawing.Size(385, 100);
            this.btnChoice1.TabIndex = 0;
            this.btnChoice1.Text = "Choice 1";
            this.btnChoice1.UseVisualStyleBackColor = false;
            this.btnChoice1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(104)))), ((int)(((byte)(205)))));
            this.btnChoice2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoice2.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.ForeColor = System.Drawing.Color.White;
            this.btnChoice2.Image = global::QuizApp.Properties.Resources.geometry_star_32;
            this.btnChoice2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoice2.Location = new System.Drawing.Point(440, 294);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChoice2.Size = new System.Drawing.Size(385, 100);
            this.btnChoice2.TabIndex = 1;
            this.btnChoice2.Text = "Choice 2";
            this.btnChoice2.UseVisualStyleBackColor = false;
            this.btnChoice2.Click += new System.EventHandler(this.button_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.btnChoice3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoice3.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice3.ForeColor = System.Drawing.Color.White;
            this.btnChoice3.Image = global::QuizApp.Properties.Resources.geometry_circle_32;
            this.btnChoice3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoice3.Location = new System.Drawing.Point(49, 400);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChoice3.Size = new System.Drawing.Size(385, 100);
            this.btnChoice3.TabIndex = 2;
            this.btnChoice3.Text = "Choice 3";
            this.btnChoice3.UseVisualStyleBackColor = false;
            this.btnChoice3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnChoice4
            // 
            this.btnChoice4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(137)))), ((int)(((byte)(12)))));
            this.btnChoice4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChoice4.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice4.ForeColor = System.Drawing.Color.White;
            this.btnChoice4.Image = global::QuizApp.Properties.Resources.geometry_square_32;
            this.btnChoice4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoice4.Location = new System.Drawing.Point(440, 400);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnChoice4.Size = new System.Drawing.Size(385, 100);
            this.btnChoice4.TabIndex = 3;
            this.btnChoice4.Text = "Choice 4";
            this.btnChoice4.UseVisualStyleBackColor = false;
            this.btnChoice4.Click += new System.EventHandler(this.button_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(12, 132);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(851, 46);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "What is synonym of \"..............\" ?";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(756, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(107, 24);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 24);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time: 0 s";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeOut
            // 
            this.timeOut.Interval = 1000;
            this.timeOut.Tick += new System.EventHandler(this.timeOut_Tick);
            // 
            // lblRound
            // 
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.White;
            this.lblRound.Location = new System.Drawing.Point(371, 9);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(133, 24);
            this.lblRound.TabIndex = 10;
            this.lblRound.Text = "Round: 1";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTimeOut
            // 
            this.pnTimeOut.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTimeOut.Controls.Add(this.lblSummaryRound);
            this.pnTimeOut.Controls.Add(this.lblSummaryScore);
            this.pnTimeOut.Controls.Add(this.btnPlayAgain);
            this.pnTimeOut.Controls.Add(this.lblTimeOut);
            this.pnTimeOut.Location = new System.Drawing.Point(87, 48);
            this.pnTimeOut.Name = "pnTimeOut";
            this.pnTimeOut.Size = new System.Drawing.Size(700, 441);
            this.pnTimeOut.TabIndex = 12;
            // 
            // lblSummaryRound
            // 
            this.lblSummaryRound.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryRound.ForeColor = System.Drawing.Color.Black;
            this.lblSummaryRound.Location = new System.Drawing.Point(158, 215);
            this.lblSummaryRound.Name = "lblSummaryRound";
            this.lblSummaryRound.Size = new System.Drawing.Size(385, 46);
            this.lblSummaryRound.TabIndex = 10;
            this.lblSummaryRound.Text = "Round: 1";
            this.lblSummaryRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSummaryScore
            // 
            this.lblSummaryScore.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryScore.ForeColor = System.Drawing.Color.Black;
            this.lblSummaryScore.Location = new System.Drawing.Point(158, 158);
            this.lblSummaryScore.Name = "lblSummaryScore";
            this.lblSummaryScore.Size = new System.Drawing.Size(385, 46);
            this.lblSummaryScore.TabIndex = 9;
            this.lblSummaryScore.Text = "Score: 0";
            this.lblSummaryScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(23)))), ((int)(((byte)(143)))));
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayAgain.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(158, 305);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(385, 100);
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.Text = "Play again !";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))));
            this.lblTimeOut.Location = new System.Drawing.Point(152, 26);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(397, 112);
            this.lblTimeOut.TabIndex = 7;
            this.lblTimeOut.Text = "Time Out";
            this.lblTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(51)))), ((int)(((byte)(53)))));
            this.BackgroundImage = global::QuizApp.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.pnTimeOut);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz App - Vocab (TU-GET)";
            this.pnTimeOut.ResumeLayout(false);
            this.pnTimeOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Button btnChoice4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timeOut;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Panel pnTimeOut;
        private System.Windows.Forms.Label lblSummaryRound;
        private System.Windows.Forms.Label lblSummaryScore;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblTimeOut;
    }
}

