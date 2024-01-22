namespace WindowsFormsDraft
{
    partial class AddShapeDropDown
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addHexagonBtn = new WindowsFormsDraft.RippleButton();
            this.addTriangleBtn = new WindowsFormsDraft.RippleButton();
            this.addRectangleBtn = new WindowsFormsDraft.RippleButton();
            this.addCircleBtn = new WindowsFormsDraft.RippleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.addHexagonBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.addTriangleBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addRectangleBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addCircleBtn, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addHexagonBtn
            // 
            this.addHexagonBtn.BackColor = System.Drawing.Color.Gray;
            this.addHexagonBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addHexagonBtn.FlatAppearance.BorderSize = 0;
            this.addHexagonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHexagonBtn.ForeColor = System.Drawing.Color.White;
            this.addHexagonBtn.Location = new System.Drawing.Point(3, 153);
            this.addHexagonBtn.Name = "addHexagonBtn";
            this.addHexagonBtn.Size = new System.Drawing.Size(194, 44);
            this.addHexagonBtn.TabIndex = 3;
            this.addHexagonBtn.Text = "Add Hexagon";
            this.addHexagonBtn.UseVisualStyleBackColor = false;
            this.addHexagonBtn.Click += new System.EventHandler(this.addHexagonBtn_Click);
            // 
            // addTriangleBtn
            // 
            this.addTriangleBtn.BackColor = System.Drawing.Color.Gray;
            this.addTriangleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTriangleBtn.FlatAppearance.BorderSize = 0;
            this.addTriangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTriangleBtn.ForeColor = System.Drawing.Color.White;
            this.addTriangleBtn.Location = new System.Drawing.Point(3, 103);
            this.addTriangleBtn.Name = "addTriangleBtn";
            this.addTriangleBtn.Size = new System.Drawing.Size(194, 44);
            this.addTriangleBtn.TabIndex = 2;
            this.addTriangleBtn.Text = "Add Triangle";
            this.addTriangleBtn.UseVisualStyleBackColor = false;
            this.addTriangleBtn.Click += new System.EventHandler(this.addTriangleBtn_Click);
            // 
            // addRectangleBtn
            // 
            this.addRectangleBtn.BackColor = System.Drawing.Color.Gray;
            this.addRectangleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRectangleBtn.FlatAppearance.BorderSize = 0;
            this.addRectangleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRectangleBtn.ForeColor = System.Drawing.Color.White;
            this.addRectangleBtn.Location = new System.Drawing.Point(3, 53);
            this.addRectangleBtn.Name = "addRectangleBtn";
            this.addRectangleBtn.Size = new System.Drawing.Size(194, 44);
            this.addRectangleBtn.TabIndex = 1;
            this.addRectangleBtn.Text = "Add Rectangle";
            this.addRectangleBtn.UseVisualStyleBackColor = false;
            this.addRectangleBtn.Click += new System.EventHandler(this.addRectangleBtn_Click);
            // 
            // addCircleBtn
            // 
            this.addCircleBtn.BackColor = System.Drawing.Color.Gray;
            this.addCircleBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCircleBtn.FlatAppearance.BorderSize = 0;
            this.addCircleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCircleBtn.ForeColor = System.Drawing.Color.White;
            this.addCircleBtn.Location = new System.Drawing.Point(3, 3);
            this.addCircleBtn.Name = "addCircleBtn";
            this.addCircleBtn.Size = new System.Drawing.Size(194, 44);
            this.addCircleBtn.TabIndex = 0;
            this.addCircleBtn.Text = "Add Circle";
            this.addCircleBtn.UseVisualStyleBackColor = false;
            this.addCircleBtn.Click += new System.EventHandler(this.addCircleBtn_Click);
            // 
            // AddShapeDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddShapeDropDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddShapeDropDown";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RippleButton addHexagonBtn;
        private RippleButton addTriangleBtn;
        private RippleButton addRectangleBtn;
        private RippleButton addCircleBtn;
    }
}