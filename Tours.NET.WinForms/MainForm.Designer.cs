namespace Tours.NET.WinForms
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.numericUpDownMaxPeople = new System.Windows.Forms.NumericUpDown();
      this.textBoxTourName = new System.Windows.Forms.TextBox();
      this.textBoxRegion = new System.Windows.Forms.TextBox();
      this.textBoxDescription = new System.Windows.Forms.TextBox();
      this.dataGridViewTips = new System.Windows.Forms.DataGridView();
      this.dataGridViewTestimonials = new System.Windows.Forms.DataGridView();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPeople)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTips)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestimonials)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1198, 889);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.textBoxDescription);
      this.tabPage1.Controls.Add(this.textBoxRegion);
      this.tabPage1.Controls.Add(this.textBoxTourName);
      this.tabPage1.Controls.Add(this.numericUpDownMaxPeople);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.listBox1);
      this.tabPage1.Location = new System.Drawing.Point(4, 29);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage1.Size = new System.Drawing.Size(1190, 856);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Tours";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.dataGridViewTips);
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage2.Size = new System.Drawing.Size(1190, 856);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Tips";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.dataGridViewTestimonials);
      this.tabPage3.Location = new System.Drawing.Point(4, 29);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(1190, 856);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Testimonial";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(51, 46);
      this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(514, 144);
      this.listBox1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(51, 244);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(91, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Tour Name:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(51, 282);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Region:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(51, 323);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(93, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "Description:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(472, 244);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(159, 20);
      this.label4.TabIndex = 7;
      this.label4.Text = "Max People Per Tour:";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // numericUpDownMaxPeople
      // 
      this.numericUpDownMaxPeople.Location = new System.Drawing.Point(637, 245);
      this.numericUpDownMaxPeople.Name = "numericUpDownMaxPeople";
      this.numericUpDownMaxPeople.Size = new System.Drawing.Size(120, 26);
      this.numericUpDownMaxPeople.TabIndex = 8;
      // 
      // textBoxTourName
      // 
      this.textBoxTourName.Location = new System.Drawing.Point(162, 244);
      this.textBoxTourName.Name = "textBoxTourName";
      this.textBoxTourName.Size = new System.Drawing.Size(268, 26);
      this.textBoxTourName.TabIndex = 9;
      // 
      // textBoxRegion
      // 
      this.textBoxRegion.Location = new System.Drawing.Point(162, 282);
      this.textBoxRegion.Name = "textBoxRegion";
      this.textBoxRegion.Size = new System.Drawing.Size(268, 26);
      this.textBoxRegion.TabIndex = 10;
      // 
      // textBoxDescription
      // 
      this.textBoxDescription.Location = new System.Drawing.Point(162, 323);
      this.textBoxDescription.Multiline = true;
      this.textBoxDescription.Name = "textBoxDescription";
      this.textBoxDescription.Size = new System.Drawing.Size(268, 139);
      this.textBoxDescription.TabIndex = 11;
      // 
      // dataGridViewTips
      // 
      this.dataGridViewTips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTips.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewTips.Location = new System.Drawing.Point(4, 5);
      this.dataGridViewTips.Name = "dataGridViewTips";
      this.dataGridViewTips.Size = new System.Drawing.Size(1182, 846);
      this.dataGridViewTips.TabIndex = 0;
      // 
      // dataGridViewTestimonials
      // 
      this.dataGridViewTestimonials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTestimonials.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridViewTestimonials.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewTestimonials.Name = "dataGridViewTestimonials";
      this.dataGridViewTestimonials.Size = new System.Drawing.Size(1190, 856);
      this.dataGridViewTestimonials.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1198, 889);
      this.Controls.Add(this.tabControl1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPeople)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTips)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestimonials)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numericUpDownMaxPeople;
    private System.Windows.Forms.TextBox textBoxTourName;
    private System.Windows.Forms.TextBox textBoxRegion;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.DataGridView dataGridViewTips;
    private System.Windows.Forms.DataGridView dataGridViewTestimonials;
  }
}