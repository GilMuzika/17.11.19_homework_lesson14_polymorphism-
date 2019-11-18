namespace _17._11._19_homework_lesson14_Vehicles_Itay
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
            this.cmbCreateNew = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.numNumDoorshandbrakes = new System.Windows.Forms.NumericUpDown();
            this.lblNumOfDoordHandbrakes = new System.Windows.Forms.Label();
            this.numNumberOfPassengers = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfPassengers = new System.Windows.Forms.Label();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.cmbVehicles = new System.Windows.Forms.ComboBox();
            this.rtbVehicleDetails = new System.Windows.Forms.RichTextBox();
            this.numNUmberOfWheels = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfWheels = new System.Windows.Forms.Label();
            this.btnPrintAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumDoorshandbrakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNUmberOfWheels)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCreateNew
            // 
            this.cmbCreateNew.FormattingEnabled = true;
            this.cmbCreateNew.Location = new System.Drawing.Point(28, 28);
            this.cmbCreateNew.Name = "cmbCreateNew";
            this.cmbCreateNew.Size = new System.Drawing.Size(165, 21);
            this.cmbCreateNew.TabIndex = 0;
            this.cmbCreateNew.SelectedIndexChanged += new System.EventHandler(this.cmbCreateNew_SelectedIndexChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(93, 77);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 80);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // numNumDoorshandbrakes
            // 
            this.numNumDoorshandbrakes.Location = new System.Drawing.Point(138, 119);
            this.numNumDoorshandbrakes.Name = "numNumDoorshandbrakes";
            this.numNumDoorshandbrakes.Size = new System.Drawing.Size(55, 20);
            this.numNumDoorshandbrakes.TabIndex = 3;
            // 
            // lblNumOfDoordHandbrakes
            // 
            this.lblNumOfDoordHandbrakes.AutoSize = true;
            this.lblNumOfDoordHandbrakes.Location = new System.Drawing.Point(12, 126);
            this.lblNumOfDoordHandbrakes.Name = "lblNumOfDoordHandbrakes";
            this.lblNumOfDoordHandbrakes.Size = new System.Drawing.Size(56, 13);
            this.lblNumOfDoordHandbrakes.TabIndex = 4;
            this.lblNumOfDoordHandbrakes.Text = "Number of";
            // 
            // numNumberOfPassengers
            // 
            this.numNumberOfPassengers.Location = new System.Drawing.Point(139, 202);
            this.numNumberOfPassengers.Name = "numNumberOfPassengers";
            this.numNumberOfPassengers.Size = new System.Drawing.Size(54, 20);
            this.numNumberOfPassengers.TabIndex = 5;
            // 
            // lblNumberOfPassengers
            // 
            this.lblNumberOfPassengers.AutoSize = true;
            this.lblNumberOfPassengers.Location = new System.Drawing.Point(13, 206);
            this.lblNumberOfPassengers.Name = "lblNumberOfPassengers";
            this.lblNumberOfPassengers.Size = new System.Drawing.Size(116, 13);
            this.lblNumberOfPassengers.TabIndex = 6;
            this.lblNumberOfPassengers.Text = "Number of passengers:";
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(118, 243);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(75, 23);
            this.btnCreateNew.TabIndex = 7;
            this.btnCreateNew.Text = "Create";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // cmbVehicles
            // 
            this.cmbVehicles.FormattingEnabled = true;
            this.cmbVehicles.Location = new System.Drawing.Point(526, 28);
            this.cmbVehicles.Name = "cmbVehicles";
            this.cmbVehicles.Size = new System.Drawing.Size(253, 21);
            this.cmbVehicles.TabIndex = 8;
            this.cmbVehicles.SelectedIndexChanged += new System.EventHandler(this.cmbVehicles_SelectedIndexChanged);
            // 
            // rtbVehicleDetails
            // 
            this.rtbVehicleDetails.Location = new System.Drawing.Point(526, 65);
            this.rtbVehicleDetails.Name = "rtbVehicleDetails";
            this.rtbVehicleDetails.Size = new System.Drawing.Size(253, 157);
            this.rtbVehicleDetails.TabIndex = 9;
            this.rtbVehicleDetails.Text = "";
            // 
            // numNUmberOfWheels
            // 
            this.numNUmberOfWheels.Location = new System.Drawing.Point(138, 161);
            this.numNUmberOfWheels.Name = "numNUmberOfWheels";
            this.numNUmberOfWheels.Size = new System.Drawing.Size(55, 20);
            this.numNUmberOfWheels.TabIndex = 10;
            this.numNUmberOfWheels.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblNumberOfWheels
            // 
            this.lblNumberOfWheels.AutoSize = true;
            this.lblNumberOfWheels.Location = new System.Drawing.Point(16, 168);
            this.lblNumberOfWheels.Name = "lblNumberOfWheels";
            this.lblNumberOfWheels.Size = new System.Drawing.Size(97, 13);
            this.lblNumberOfWheels.TabIndex = 11;
            this.lblNumberOfWheels.Text = "NUmber of wheels:";
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(526, 229);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(166, 23);
            this.btnPrintAll.TabIndex = 12;
            this.btnPrintAll.Text = "Print info about all the vehicles";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.lblNumberOfWheels);
            this.Controls.Add(this.numNUmberOfWheels);
            this.Controls.Add(this.rtbVehicleDetails);
            this.Controls.Add(this.cmbVehicles);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.lblNumberOfPassengers);
            this.Controls.Add(this.numNumberOfPassengers);
            this.Controls.Add(this.lblNumOfDoordHandbrakes);
            this.Controls.Add(this.numNumDoorshandbrakes);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cmbCreateNew);
            this.Name = "Form1";
            this.Text = "Polymorphism: vehicles";
            ((System.ComponentModel.ISupportInitialize)(this.numNumDoorshandbrakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfPassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNUmberOfWheels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCreateNew;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.NumericUpDown numNumDoorshandbrakes;
        private System.Windows.Forms.Label lblNumOfDoordHandbrakes;
        private System.Windows.Forms.NumericUpDown numNumberOfPassengers;
        private System.Windows.Forms.Label lblNumberOfPassengers;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ComboBox cmbVehicles;
        private System.Windows.Forms.RichTextBox rtbVehicleDetails;
        private System.Windows.Forms.NumericUpDown numNUmberOfWheels;
        private System.Windows.Forms.Label lblNumberOfWheels;
        private System.Windows.Forms.Button btnPrintAll;
    }
}

