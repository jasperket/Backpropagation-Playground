namespace ValleceraBackPropagation
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
            this.txtInput0 = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnCreateBPNN = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHNeurons = new System.Windows.Forms.TextBox();
            this.txtEpochsPress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalEpochs = new System.Windows.Forms.Label();
            this.lblCurrHNeurons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput0
            // 
            this.txtInput0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput0.Location = new System.Drawing.Point(250, 45);
            this.txtInput0.Name = "txtInput0";
            this.txtInput0.Size = new System.Drawing.Size(237, 39);
            this.txtInput0.TabIndex = 0;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(517, 154);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(237, 39);
            this.txtOutput.TabIndex = 1;
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.Location = new System.Drawing.Point(250, 117);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(237, 39);
            this.txtInput1.TabIndex = 2;
            // 
            // btnCreateBPNN
            // 
            this.btnCreateBPNN.Location = new System.Drawing.Point(115, 345);
            this.btnCreateBPNN.Name = "btnCreateBPNN";
            this.btnCreateBPNN.Size = new System.Drawing.Size(146, 58);
            this.btnCreateBPNN.TabIndex = 3;
            this.btnCreateBPNN.Text = "Create BPNN";
            this.btnCreateBPNN.UseVisualStyleBackColor = true;
            this.btnCreateBPNN.Click += new System.EventHandler(this.btnCreateBPNN_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Enabled = false;
            this.btnTrain.Location = new System.Drawing.Point(333, 345);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(184, 58);
            this.btnTrain.TabIndex = 4;
            this.btnTrain.Text = "Train Neural Network";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(584, 345);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(116, 58);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.Location = new System.Drawing.Point(250, 189);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(237, 39);
            this.txtInput2.TabIndex = 6;
            // 
            // txtInput3
            // 
            this.txtInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput3.Location = new System.Drawing.Point(250, 259);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(237, 39);
            this.txtInput3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "No. of H Neurons:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Inputs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Settings:";
            // 
            // txtHNeurons
            // 
            this.txtHNeurons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHNeurons.Location = new System.Drawing.Point(41, 140);
            this.txtHNeurons.Name = "txtHNeurons";
            this.txtHNeurons.Size = new System.Drawing.Size(143, 39);
            this.txtHNeurons.TabIndex = 12;
            this.txtHNeurons.TextChanged += new System.EventHandler(this.txtHNeurons_TextChanged);
            // 
            // txtEpochsPress
            // 
            this.txtEpochsPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpochsPress.Location = new System.Drawing.Point(41, 212);
            this.txtEpochsPress.Name = "txtEpochsPress";
            this.txtEpochsPress.Size = new System.Drawing.Size(143, 39);
            this.txtEpochsPress.TabIndex = 14;
            this.txtEpochsPress.TextChanged += new System.EventHandler(this.txtEpochsPress_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Epochs per Press:";
            // 
            // lblTotalEpochs
            // 
            this.lblTotalEpochs.AutoSize = true;
            this.lblTotalEpochs.Location = new System.Drawing.Point(517, 243);
            this.lblTotalEpochs.Name = "lblTotalEpochs";
            this.lblTotalEpochs.Size = new System.Drawing.Size(106, 20);
            this.lblTotalEpochs.TabIndex = 15;
            this.lblTotalEpochs.Text = "Total Epochs:";
            // 
            // lblCurrHNeurons
            // 
            this.lblCurrHNeurons.AutoSize = true;
            this.lblCurrHNeurons.Location = new System.Drawing.Point(517, 212);
            this.lblCurrHNeurons.Name = "lblCurrHNeurons";
            this.lblCurrHNeurons.Size = new System.Drawing.Size(196, 20);
            this.lblCurrHNeurons.TabIndex = 16;
            this.lblCurrHNeurons.Text = "Current No. of H Neurons: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lblCurrHNeurons);
            this.Controls.Add(this.lblTotalEpochs);
            this.Controls.Add(this.txtEpochsPress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHNeurons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnCreateBPNN);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput0);
            this.Name = "Form1";
            this.Text = "Backpropagation Playground";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput0;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Button btnCreateBPNN;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHNeurons;
        private System.Windows.Forms.TextBox txtEpochsPress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalEpochs;
        private System.Windows.Forms.Label lblCurrHNeurons;
    }
}

