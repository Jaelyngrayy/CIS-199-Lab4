
namespace Lab4
{
    partial class admissionCheck
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
            this.gpaLbl = new System.Windows.Forms.Label();
            this.testScoreLbl = new System.Windows.Forms.Label();
            this.GPAtxt = new System.Windows.Forms.TextBox();
            this.testScoretxt = new System.Windows.Forms.TextBox();
            this.decisionOutput = new System.Windows.Forms.Label();
            this.resultsButton = new System.Windows.Forms.Button();
            this.acceptedLabel = new System.Windows.Forms.Label();
            this.acceptedOutputLbl = new System.Windows.Forms.Label();
            this.rejectedLabel = new System.Windows.Forms.Label();
            this.rejectedOutputLbl = new System.Windows.Forms.Label();
            this.counterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLbl
            // 
            this.gpaLbl.AutoSize = true;
            this.gpaLbl.Location = new System.Drawing.Point(31, 37);
            this.gpaLbl.Name = "gpaLbl";
            this.gpaLbl.Size = new System.Drawing.Size(93, 13);
            this.gpaLbl.TabIndex = 0;
            this.gpaLbl.Text = "High School GPA:";
            // 
            // testScoreLbl
            // 
            this.testScoreLbl.AutoSize = true;
            this.testScoreLbl.Location = new System.Drawing.Point(34, 71);
            this.testScoreLbl.Name = "testScoreLbl";
            this.testScoreLbl.Size = new System.Drawing.Size(112, 13);
            this.testScoreLbl.TabIndex = 1;
            this.testScoreLbl.Text = "Admission Test Score:";
            // 
            // GPAtxt
            // 
            this.GPAtxt.Location = new System.Drawing.Point(157, 34);
            this.GPAtxt.Name = "GPAtxt";
            this.GPAtxt.Size = new System.Drawing.Size(100, 20);
            this.GPAtxt.TabIndex = 2;
            // 
            // testScoretxt
            // 
            this.testScoretxt.Location = new System.Drawing.Point(157, 71);
            this.testScoretxt.Name = "testScoretxt";
            this.testScoretxt.Size = new System.Drawing.Size(100, 20);
            this.testScoretxt.TabIndex = 3;
            // 
            // decisionOutput
            // 
            this.decisionOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.decisionOutput.Location = new System.Drawing.Point(63, 155);
            this.decisionOutput.Name = "decisionOutput";
            this.decisionOutput.Size = new System.Drawing.Size(174, 59);
            this.decisionOutput.TabIndex = 4;
            this.decisionOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsButton
            // 
            this.resultsButton.Location = new System.Drawing.Point(109, 108);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.Size = new System.Drawing.Size(75, 23);
            this.resultsButton.TabIndex = 5;
            this.resultsButton.Text = "Results";
            this.resultsButton.UseVisualStyleBackColor = true;
            this.resultsButton.Click += new System.EventHandler(this.decisionButton_Click);
            // 
            // acceptedLabel
            // 
            this.acceptedLabel.AutoSize = true;
            this.acceptedLabel.Location = new System.Drawing.Point(85, 267);
            this.acceptedLabel.Name = "acceptedLabel";
            this.acceptedLabel.Size = new System.Drawing.Size(56, 13);
            this.acceptedLabel.TabIndex = 6;
            this.acceptedLabel.Text = "Accepted:";
            // 
            // acceptedOutputLbl
            // 
            this.acceptedOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptedOutputLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.acceptedOutputLbl.Location = new System.Drawing.Point(140, 264);
            this.acceptedOutputLbl.Name = "acceptedOutputLbl";
            this.acceptedOutputLbl.Size = new System.Drawing.Size(72, 21);
            this.acceptedOutputLbl.TabIndex = 7;
            // 
            // rejectedLabel
            // 
            this.rejectedLabel.AutoSize = true;
            this.rejectedLabel.Location = new System.Drawing.Point(88, 299);
            this.rejectedLabel.Name = "rejectedLabel";
            this.rejectedLabel.Size = new System.Drawing.Size(53, 13);
            this.rejectedLabel.TabIndex = 8;
            this.rejectedLabel.Text = "Rejected:";
            // 
            // rejectedOutputLbl
            // 
            this.rejectedOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectedOutputLbl.Location = new System.Drawing.Point(140, 296);
            this.rejectedOutputLbl.Name = "rejectedOutputLbl";
            this.rejectedOutputLbl.Size = new System.Drawing.Size(72, 21);
            this.rejectedOutputLbl.TabIndex = 9;
            // 
            // counterLbl
            // 
            this.counterLbl.AutoSize = true;
            this.counterLbl.Location = new System.Drawing.Point(76, 233);
            this.counterLbl.Name = "counterLbl";
            this.counterLbl.Size = new System.Drawing.Size(143, 13);
            this.counterLbl.TabIndex = 10;
            this.counterLbl.Text = "Application Decision Counter";
            // 
            // admissionCheck
            // 
            this.AcceptButton = this.resultsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 369);
            this.Controls.Add(this.counterLbl);
            this.Controls.Add(this.rejectedOutputLbl);
            this.Controls.Add(this.rejectedLabel);
            this.Controls.Add(this.acceptedOutputLbl);
            this.Controls.Add(this.acceptedLabel);
            this.Controls.Add(this.resultsButton);
            this.Controls.Add(this.decisionOutput);
            this.Controls.Add(this.testScoretxt);
            this.Controls.Add(this.GPAtxt);
            this.Controls.Add(this.testScoreLbl);
            this.Controls.Add(this.gpaLbl);
            this.Name = "admissionCheck";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLbl;
        private System.Windows.Forms.Label testScoreLbl;
        private System.Windows.Forms.TextBox GPAtxt;
        private System.Windows.Forms.TextBox testScoretxt;
        private System.Windows.Forms.Label decisionOutput;
        private System.Windows.Forms.Button resultsButton;
        private System.Windows.Forms.Label acceptedLabel;
        private System.Windows.Forms.Label acceptedOutputLbl;
        private System.Windows.Forms.Label rejectedLabel;
        private System.Windows.Forms.Label rejectedOutputLbl;
        private System.Windows.Forms.Label counterLbl;
    }
}

