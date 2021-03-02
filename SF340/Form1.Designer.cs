namespace SF340
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
            this.choice1_button = new System.Windows.Forms.Button();
            this.choice2_button = new System.Windows.Forms.Button();
            this.choice3_button = new System.Windows.Forms.Button();
            this.choice4_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.question_label = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choice1_button
            // 
            this.choice1_button.Location = new System.Drawing.Point(256, 290);
            this.choice1_button.Name = "choice1_button";
            this.choice1_button.Size = new System.Drawing.Size(90, 40);
            this.choice1_button.TabIndex = 0;
            this.choice1_button.Text = "button1";
            this.choice1_button.UseVisualStyleBackColor = true;
            this.choice1_button.Click += new System.EventHandler(this.button_Click);
            // 
            // choice2_button
            // 
            this.choice2_button.Location = new System.Drawing.Point(461, 290);
            this.choice2_button.Name = "choice2_button";
            this.choice2_button.Size = new System.Drawing.Size(90, 40);
            this.choice2_button.TabIndex = 1;
            this.choice2_button.Text = "button2";
            this.choice2_button.UseVisualStyleBackColor = true;
            this.choice2_button.Click += new System.EventHandler(this.button_Click);
            // 
            // choice3_button
            // 
            this.choice3_button.Location = new System.Drawing.Point(256, 352);
            this.choice3_button.Name = "choice3_button";
            this.choice3_button.Size = new System.Drawing.Size(90, 40);
            this.choice3_button.TabIndex = 2;
            this.choice3_button.Text = "button3";
            this.choice3_button.UseVisualStyleBackColor = true;
            this.choice3_button.Click += new System.EventHandler(this.button_Click);
            // 
            // choice4_button
            // 
            this.choice4_button.Location = new System.Drawing.Point(461, 352);
            this.choice4_button.Name = "choice4_button";
            this.choice4_button.Size = new System.Drawing.Size(90, 40);
            this.choice4_button.TabIndex = 3;
            this.choice4_button.Text = "button4";
            this.choice4_button.UseVisualStyleBackColor = true;
            this.choice4_button.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // question_label
            // 
            this.question_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.question_label.Location = new System.Drawing.Point(454, 108);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(44, 20);
            this.question_label.TabIndex = 4;
            this.question_label.Text = "label";
            this.question_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(649, 42);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(53, 17);
            this.score.TabIndex = 5;
            this.score.Text = "Score: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "What is synonym of";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choice4_button);
            this.Controls.Add(this.choice3_button);
            this.Controls.Add(this.choice2_button);
            this.Controls.Add(this.choice1_button);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choice1_button;
        private System.Windows.Forms.Button choice2_button;
        private System.Windows.Forms.Button choice3_button;
        private System.Windows.Forms.Button choice4_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label2;
    }
}

