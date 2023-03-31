namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.oneButon = new System.Windows.Forms.Button();
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oneButon
            // 
            this.oneButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oneButon.Location = new System.Drawing.Point(12, 259);
            this.oneButon.Name = "oneButon";
            this.oneButon.Size = new System.Drawing.Size(80, 50);
            this.oneButon.TabIndex = 0;
            this.oneButon.Text = "1";
            this.oneButon.UseVisualStyleBackColor = true;
            this.oneButon.Click += new System.EventHandler(this.oneButon_Click);
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.calculatorDisplay.ForeColor = System.Drawing.Color.White;
            this.calculatorDisplay.Location = new System.Drawing.Point(13, 13);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(337, 70);
            this.calculatorDisplay.TabIndex = 1;
            this.calculatorDisplay.Text = "0";
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twoButton.Location = new System.Drawing.Point(98, 259);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(80, 50);
            this.twoButton.TabIndex = 2;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.threeButton.Location = new System.Drawing.Point(184, 259);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(80, 50);
            this.threeButton.TabIndex = 3;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fourButton.Location = new System.Drawing.Point(12, 203);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(80, 50);
            this.fourButton.TabIndex = 4;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fiveButton.Location = new System.Drawing.Point(98, 203);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(80, 50);
            this.fiveButton.TabIndex = 5;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sixButton.Location = new System.Drawing.Point(184, 203);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(80, 50);
            this.sixButton.TabIndex = 6;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sevenButton.Location = new System.Drawing.Point(12, 147);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(80, 50);
            this.sevenButton.TabIndex = 7;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eightButton.Location = new System.Drawing.Point(98, 147);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(80, 50);
            this.eightButton.TabIndex = 8;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nineButton.Location = new System.Drawing.Point(184, 147);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(80, 50);
            this.nineButton.TabIndex = 9;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zeroButton.Location = new System.Drawing.Point(98, 315);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(80, 50);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divideButton.Location = new System.Drawing.Point(270, 91);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(80, 50);
            this.divideButton.TabIndex = 11;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplyButton.Location = new System.Drawing.Point(270, 147);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(80, 50);
            this.multiplyButton.TabIndex = 12;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.subtractButton.Location = new System.Drawing.Point(270, 203);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(80, 50);
            this.subtractButton.TabIndex = 13;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(270, 259);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 50);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equalButton.Location = new System.Drawing.Point(184, 315);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(166, 50);
            this.equalButton.TabIndex = 16;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Location = new System.Drawing.Point(12, 91);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(252, 50);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decimalButton.Location = new System.Drawing.Point(12, 315);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(80, 50);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 379);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.oneButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oneButon;
        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button decimalButton;
    }
}

