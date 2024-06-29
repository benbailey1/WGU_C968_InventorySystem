namespace BenBailey_InventorySystem
{
    partial class AddPartScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.inHouseChecked = new System.Windows.Forms.RadioButton();
            this.outsourcedChecked = new System.Windows.Forms.RadioButton();
            this.partID = new System.Windows.Forms.TextBox();
            this.partName = new System.Windows.Forms.TextBox();
            this.inventory = new System.Windows.Forms.TextBox();
            this.partPrice = new System.Windows.Forms.TextBox();
            this.partMax = new System.Windows.Forms.TextBox();
            this.partMin = new System.Windows.Forms.TextBox();
            this.tbSourceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sourceIDLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // inHouseChecked
            // 
            this.inHouseChecked.AutoSize = true;
            this.inHouseChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inHouseChecked.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.inHouseChecked.Location = new System.Drawing.Point(224, 30);
            this.inHouseChecked.Margin = new System.Windows.Forms.Padding(4);
            this.inHouseChecked.Name = "inHouseChecked";
            this.inHouseChecked.Size = new System.Drawing.Size(87, 20);
            this.inHouseChecked.TabIndex = 1;
            this.inHouseChecked.TabStop = true;
            this.inHouseChecked.Text = "In-House";
            this.inHouseChecked.UseVisualStyleBackColor = true;
            this.inHouseChecked.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // outsourcedChecked
            // 
            this.outsourcedChecked.AutoSize = true;
            this.outsourcedChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outsourcedChecked.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.outsourcedChecked.Location = new System.Drawing.Point(393, 30);
            this.outsourcedChecked.Margin = new System.Windows.Forms.Padding(4);
            this.outsourcedChecked.Name = "outsourcedChecked";
            this.outsourcedChecked.Size = new System.Drawing.Size(104, 20);
            this.outsourcedChecked.TabIndex = 2;
            this.outsourcedChecked.TabStop = true;
            this.outsourcedChecked.Text = "Outsourced";
            this.outsourcedChecked.UseVisualStyleBackColor = true;
            this.outsourcedChecked.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // partID
            // 
            this.partID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.partID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partID.ForeColor = System.Drawing.SystemColors.Window;
            this.partID.Location = new System.Drawing.Point(188, 91);
            this.partID.Margin = new System.Windows.Forms.Padding(4);
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Size = new System.Drawing.Size(241, 22);
            this.partID.TabIndex = 3;
            // 
            // partName
            // 
            this.partName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.partName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partName.ForeColor = System.Drawing.SystemColors.Window;
            this.partName.Location = new System.Drawing.Point(188, 135);
            this.partName.Margin = new System.Windows.Forms.Padding(4);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(241, 22);
            this.partName.TabIndex = 4;
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventory.ForeColor = System.Drawing.SystemColors.Window;
            this.inventory.Location = new System.Drawing.Point(188, 180);
            this.inventory.Margin = new System.Windows.Forms.Padding(4);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(241, 22);
            this.inventory.TabIndex = 5;
            // 
            // partPrice
            // 
            this.partPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.partPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.partPrice.Location = new System.Drawing.Point(188, 224);
            this.partPrice.Margin = new System.Windows.Forms.Padding(4);
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(241, 22);
            this.partPrice.TabIndex = 6;
            // 
            // partMax
            // 
            this.partMax.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.partMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partMax.ForeColor = System.Drawing.SystemColors.Window;
            this.partMax.Location = new System.Drawing.Point(188, 270);
            this.partMax.Margin = new System.Windows.Forms.Padding(4);
            this.partMax.Name = "partMax";
            this.partMax.Size = new System.Drawing.Size(125, 22);
            this.partMax.TabIndex = 7;
            // 
            // partMin
            // 
            this.partMin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.partMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partMin.ForeColor = System.Drawing.SystemColors.Window;
            this.partMin.Location = new System.Drawing.Point(393, 270);
            this.partMin.Margin = new System.Windows.Forms.Padding(4);
            this.partMin.Name = "partMin";
            this.partMin.Size = new System.Drawing.Size(125, 22);
            this.partMin.TabIndex = 8;
            // 
            // tbSourceID
            // 
            this.tbSourceID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSourceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSourceID.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSourceID.Location = new System.Drawing.Point(188, 315);
            this.tbSourceID.Margin = new System.Windows.Forms.Padding(4);
            this.tbSourceID.Name = "tbSourceID";
            this.tbSourceID.Size = new System.Drawing.Size(241, 22);
            this.tbSourceID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(57, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(337, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(57, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(57, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(57, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Inventory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(57, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Price/Cost";
            // 
            // sourceIDLabel
            // 
            this.sourceIDLabel.AutoSize = true;
            this.sourceIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceIDLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sourceIDLabel.Location = new System.Drawing.Point(57, 317);
            this.sourceIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceIDLabel.Name = "sourceIDLabel";
            this.sourceIDLabel.Size = new System.Drawing.Size(84, 16);
            this.sourceIDLabel.TabIndex = 16;
            this.sourceIDLabel.Text = "Machine ID";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(384, 391);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 27);
            this.button3.TabIndex = 17;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(508, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(637, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sourceIDLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSourceID);
            this.Controls.Add(this.partMin);
            this.Controls.Add(this.partMax);
            this.Controls.Add(this.partPrice);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.outsourcedChecked);
            this.Controls.Add(this.inHouseChecked);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPartScreen";
            this.Text = "AddPartForm";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inHouseChecked;
        private System.Windows.Forms.RadioButton outsourcedChecked;
        private System.Windows.Forms.TextBox partID;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox inventory;
        private System.Windows.Forms.TextBox partPrice;
        private System.Windows.Forms.TextBox partMax;
        private System.Windows.Forms.TextBox partMin;
        private System.Windows.Forms.TextBox tbSourceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sourceIDLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1; 
    }
}