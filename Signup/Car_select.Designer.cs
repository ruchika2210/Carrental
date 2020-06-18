namespace Signup
{
    partial class Car_select
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
            this.comboBox_car = new System.Windows.Forms.ComboBox();
            this.button_select = new System.Windows.Forms.Button();
            this.dataGrid_car = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_car)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(363, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Car";
            // 
            // comboBox_car
            // 
            this.comboBox_car.FormattingEnabled = true;
            this.comboBox_car.Location = new System.Drawing.Point(377, 168);
            this.comboBox_car.Name = "comboBox_car";
            this.comboBox_car.Size = new System.Drawing.Size(345, 24);
            this.comboBox_car.TabIndex = 1;
            this.comboBox_car.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_select
            // 
            this.button_select.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_select.Location = new System.Drawing.Point(486, 240);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(123, 51);
            this.button_select.TabIndex = 2;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // dataGrid_car
            // 
            this.dataGrid_car.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid_car.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_car.Location = new System.Drawing.Point(377, 363);
            this.dataGrid_car.Name = "dataGrid_car";
            this.dataGrid_car.RowTemplate.Height = 24;
            this.dataGrid_car.Size = new System.Drawing.Size(399, 212);
            this.dataGrid_car.TabIndex = 4;
            this.dataGrid_car.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_car_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(505, 673);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Car_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(1158, 823);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid_car);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.comboBox_car);
            this.Controls.Add(this.label1);
            this.Name = "Car_select";
            this.Text = "Car_select";
            this.Load += new System.EventHandler(this.Car_select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_car;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.DataGridView dataGrid_car;
        private System.Windows.Forms.Button button1;
    }
}