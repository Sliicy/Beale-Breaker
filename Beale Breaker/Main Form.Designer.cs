namespace Beale_Breaker {
    partial class FrmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.txtKey3 = new System.Windows.Forms.TextBox();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.cmbSortMethod = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 28);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(190, 530);
            this.txtInput.TabIndex = 2;
            this.txtInput.Text = resources.GetString("txtInput.Text");
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // txtKey1
            // 
            this.txtKey1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKey1.Location = new System.Drawing.Point(199, 28);
            this.txtKey1.Multiline = true;
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey1.Size = new System.Drawing.Size(190, 530);
            this.txtKey1.TabIndex = 3;
            this.txtKey1.Text = "Key 1 transposed here";
            // 
            // txtKey3
            // 
            this.txtKey3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKey3.Location = new System.Drawing.Point(591, 28);
            this.txtKey3.Multiline = true;
            this.txtKey3.Name = "txtKey3";
            this.txtKey3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey3.Size = new System.Drawing.Size(190, 530);
            this.txtKey3.TabIndex = 5;
            this.txtKey3.Text = "Key 3 transposed here";
            // 
            // txtKey2
            // 
            this.txtKey2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKey2.Location = new System.Drawing.Point(395, 28);
            this.txtKey2.Multiline = true;
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKey2.Size = new System.Drawing.Size(190, 530);
            this.txtKey2.TabIndex = 4;
            this.txtKey2.Text = "Key 2 transposed here";
            // 
            // cmbSortMethod
            // 
            this.cmbSortMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSortMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortMethod.FormattingEnabled = true;
            this.cmbSortMethod.Items.AddRange(new object[] {
            "First Letter",
            "Last Letter",
            "Whole Word"});
            this.cmbSortMethod.Location = new System.Drawing.Point(3, 3);
            this.cmbSortMethod.Name = "cmbSortMethod";
            this.cmbSortMethod.Size = new System.Drawing.Size(190, 21);
            this.cmbSortMethod.TabIndex = 1;
            this.cmbSortMethod.SelectedIndexChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.cmbSortMethod, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtKey3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtKey2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtKey1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beale Breaker";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.TextBox txtKey3;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.ComboBox cmbSortMethod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

