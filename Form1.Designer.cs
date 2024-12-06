namespace Factorial_prime_factorial_series_calculator_demo;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new System.Windows.Forms.Panel();
        button3 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox1 = new System.Windows.Forms.TextBox();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(textBox1);
        panel1.Location = new System.Drawing.Point(102, 38);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(575, 367);
        panel1.TabIndex = 0;
        // 
        // button3
        // 
        button3.Location = new System.Drawing.Point(308, 236);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(127, 26);
        button3.TabIndex = 6;
        button3.Text = "Factorial Series";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(150, 236);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(102, 26);
        button2.TabIndex = 5;
        button2.Text = "Factorial";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(233, 178);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(102, 26);
        button1.TabIndex = 4;
        button1.Text = "Prime";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(150, 93);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(83, 24);
        label2.TabIndex = 3;
        label2.Text = "Output";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(150, 24);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(83, 24);
        label1.TabIndex = 2;
        label1.Text = "Input";
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(150, 120);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new System.Drawing.Size(285, 27);
        textBox2.TabIndex = 1;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(150, 51);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(285, 27);
        textBox1.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel1);
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}