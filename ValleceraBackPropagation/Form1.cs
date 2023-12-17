using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace ValleceraBackPropagation
{
    public partial class Form1 : Form
    {
        NeuralNet nn;
        private int hNeurons;
        private int epochsPerPress;
        private int totalEpochs;
        public Form1()
        {
            InitializeComponent();
        }

        private void learnInputs(double in0, double in1, double in2, double in3)
        {
            nn.setInputs(0, in0);
            nn.setInputs(1, in1);
            nn.setInputs(2, in2);
            nn.setInputs(3, in3);
            if(in0 == 1.0 && in1 == 1.0 && in2 == 1.0 && in3 == 1.0)
                nn.setDesiredOutput(0, 1.0);
            else
                nn.setDesiredOutput(0, 0.0);
            nn.learn();
        }

        private void btnCreateBPNN_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(4, hNeurons, 1);
            totalEpochs = 0;
            lblTotalEpochs.Text = "Total Epochs: " + totalEpochs.ToString();
            lblCurrHNeurons.Text = "Current Hidden Neurons: " + hNeurons.ToString();
            btnTrain.Enabled = true;
            btnTest.Enabled = true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(txtInput0.Text));
            nn.setInputs(1, Convert.ToDouble(txtInput1.Text));
            nn.setInputs(2, Convert.ToDouble(txtInput2.Text));
            nn.setInputs(3, Convert.ToDouble(txtInput3.Text));
            nn.run();
            txtOutput.Text = nn.getOuputData(0).ToString();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < epochsPerPress; i++)
            {
                learnInputs(0.0, 0.0, 0.0, 0.0);
                learnInputs(0.0, 0.0, 0.0, 1.0);
                learnInputs(0.0, 0.0, 1.0, 0.0);
                learnInputs(0.0, 0.0, 1.0, 1.0);
                learnInputs(0.0, 1.0, 0.0, 0.0);
                learnInputs(0.0, 1.0, 0.0, 1.0);
                learnInputs(0.0, 1.0, 1.0, 0.0);
                learnInputs(0.0, 1.0, 1.0, 1.0);
                learnInputs(1.0, 0.0, 0.0, 0.0);
                learnInputs(1.0, 0.0, 0.0, 1.0);
                learnInputs(1.0, 0.0, 1.0, 0.0);
                learnInputs(1.0, 0.0, 1.0, 1.0);
                learnInputs(1.0, 1.0, 0.0, 0.0);
                learnInputs(1.0, 1.0, 0.0, 1.0);
                learnInputs(1.0, 1.0, 1.0, 0.0);
                learnInputs(1.0, 1.0, 1.0, 1.0);
                totalEpochs++;
            }
            lblTotalEpochs.Text = "Total Epochs: " + totalEpochs.ToString();
        }

        private void txtHNeurons_TextChanged(object sender, EventArgs e)
        {
            if(txtHNeurons.Text != "")
                hNeurons = Convert.ToInt32(txtHNeurons.Text);
        }

        private void txtEpochsPress_TextChanged(object sender, EventArgs e)
        {
            if(txtEpochsPress.Text != "")
                epochsPerPress = Convert.ToInt32(txtEpochsPress.Text);
        }
    }
}
