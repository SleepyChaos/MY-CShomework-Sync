namespace WinFormsApp1;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        button1 = new System.Windows.Forms.Button();
        lappland = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)lappland).BeginInit();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(93, 295);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(331, 42);
        button1.TabIndex = 0;
        button1.Text = "点一下试试";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // lappland
        // 
        lappland.Image = ((System.Drawing.Image)resources.GetObject("lappland.Image"));
        lappland.Location = new System.Drawing.Point(16, 12);
        lappland.Name = "lappland";
        lappland.Size = new System.Drawing.Size(473, 264);
        lappland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        lappland.TabIndex = 1;
        lappland.TabStop = false;
        lappland.Visible = false;
        lappland.Click += pictureBox1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(501, 349);
        Controls.Add(lappland);
        Controls.Add(button1);
        Text = "点击小狼";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)lappland).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox lappland;

    private System.Windows.Forms.Button button1;

    #endregion
}