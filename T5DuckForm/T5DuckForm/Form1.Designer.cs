namespace T5DuckForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDecoyDuck = new System.Windows.Forms.RadioButton();
            this.rdoRubberDuck = new System.Windows.Forms.RadioButton();
            this.rdoRedHeadDuck = new System.Windows.Forms.RadioButton();
            this.rdoMallardDuck = new System.Windows.Forms.RadioButton();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnFly = new System.Windows.Forms.Button();
            this.btnQuack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFlyNoWay = new System.Windows.Forms.RadioButton();
            this.rdoFlyWithWings = new System.Windows.Forms.RadioButton();
            this.rdoNotChange = new System.Windows.Forms.RadioButton();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duck Simulator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDecoyDuck);
            this.groupBox1.Controls.Add(this.rdoRubberDuck);
            this.groupBox1.Controls.Add(this.rdoRedHeadDuck);
            this.groupBox1.Controls.Add(this.rdoMallardDuck);
            this.groupBox1.Location = new System.Drawing.Point(38, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 187);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Duck Type";
            // 
            // rdoDecoyDuck
            // 
            this.rdoDecoyDuck.AutoSize = true;
            this.rdoDecoyDuck.Location = new System.Drawing.Point(27, 137);
            this.rdoDecoyDuck.Name = "rdoDecoyDuck";
            this.rdoDecoyDuck.Size = new System.Drawing.Size(85, 17);
            this.rdoDecoyDuck.TabIndex = 3;
            this.rdoDecoyDuck.TabStop = true;
            this.rdoDecoyDuck.Text = "Decoy Duck";
            this.rdoDecoyDuck.UseVisualStyleBackColor = true;
            this.rdoDecoyDuck.CheckedChanged += new System.EventHandler(this.rdoDecoyDuck_CheckedChanged);
            // 
            // rdoRubberDuck
            // 
            this.rdoRubberDuck.AutoSize = true;
            this.rdoRubberDuck.Location = new System.Drawing.Point(27, 101);
            this.rdoRubberDuck.Name = "rdoRubberDuck";
            this.rdoRubberDuck.Size = new System.Drawing.Size(89, 17);
            this.rdoRubberDuck.TabIndex = 2;
            this.rdoRubberDuck.TabStop = true;
            this.rdoRubberDuck.Text = "Rubber Duck";
            this.rdoRubberDuck.UseVisualStyleBackColor = true;
            this.rdoRubberDuck.CheckedChanged += new System.EventHandler(this.rdoRubberDuck_CheckedChanged);
            // 
            // rdoRedHeadDuck
            // 
            this.rdoRedHeadDuck.AutoSize = true;
            this.rdoRedHeadDuck.Location = new System.Drawing.Point(27, 65);
            this.rdoRedHeadDuck.Name = "rdoRedHeadDuck";
            this.rdoRedHeadDuck.Size = new System.Drawing.Size(103, 17);
            this.rdoRedHeadDuck.TabIndex = 1;
            this.rdoRedHeadDuck.TabStop = true;
            this.rdoRedHeadDuck.Text = "Red Head Duck";
            this.rdoRedHeadDuck.UseVisualStyleBackColor = true;
            this.rdoRedHeadDuck.CheckedChanged += new System.EventHandler(this.rdoRedHeadDuck_CheckedChanged);
            // 
            // rdoMallardDuck
            // 
            this.rdoMallardDuck.AutoSize = true;
            this.rdoMallardDuck.Location = new System.Drawing.Point(27, 29);
            this.rdoMallardDuck.Name = "rdoMallardDuck";
            this.rdoMallardDuck.Size = new System.Drawing.Size(88, 17);
            this.rdoMallardDuck.TabIndex = 0;
            this.rdoMallardDuck.TabStop = true;
            this.rdoMallardDuck.Text = "Mallard Duck";
            this.rdoMallardDuck.UseVisualStyleBackColor = true;
            this.rdoMallardDuck.CheckedChanged += new System.EventHandler(this.rdoMallardDuck_CheckedChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(227, 112);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnFly
            // 
            this.btnFly.Location = new System.Drawing.Point(227, 164);
            this.btnFly.Name = "btnFly";
            this.btnFly.Size = new System.Drawing.Size(75, 23);
            this.btnFly.TabIndex = 3;
            this.btnFly.Text = "Fly";
            this.btnFly.UseVisualStyleBackColor = true;
            this.btnFly.Click += new System.EventHandler(this.btnFly_Click);
            // 
            // btnQuack
            // 
            this.btnQuack.Location = new System.Drawing.Point(227, 216);
            this.btnQuack.Name = "btnQuack";
            this.btnQuack.Size = new System.Drawing.Size(75, 23);
            this.btnQuack.TabIndex = 4;
            this.btnQuack.Text = "Quack";
            this.btnQuack.UseVisualStyleBackColor = true;
            this.btnQuack.Click += new System.EventHandler(this.btnQuack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoFlyNoWay);
            this.groupBox2.Controls.Add(this.rdoFlyWithWings);
            this.groupBox2.Controls.Add(this.rdoNotChange);
            this.groupBox2.Location = new System.Drawing.Point(334, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 187);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dynamically Change";
            // 
            // rdoFlyNoWay
            // 
            this.rdoFlyNoWay.AutoSize = true;
            this.rdoFlyNoWay.Location = new System.Drawing.Point(30, 133);
            this.rdoFlyNoWay.Name = "rdoFlyNoWay";
            this.rdoFlyNoWay.Size = new System.Drawing.Size(80, 17);
            this.rdoFlyNoWay.TabIndex = 2;
            this.rdoFlyNoWay.TabStop = true;
            this.rdoFlyNoWay.Text = "Fly No Way";
            this.rdoFlyNoWay.UseVisualStyleBackColor = true;
            this.rdoFlyNoWay.CheckedChanged += new System.EventHandler(this.rdoFlyNoWay_CheckedChanged);
            // 
            // rdoFlyWithWings
            // 
            this.rdoFlyWithWings.AutoSize = true;
            this.rdoFlyWithWings.Location = new System.Drawing.Point(30, 84);
            this.rdoFlyWithWings.Name = "rdoFlyWithWings";
            this.rdoFlyWithWings.Size = new System.Drawing.Size(96, 17);
            this.rdoFlyWithWings.TabIndex = 1;
            this.rdoFlyWithWings.TabStop = true;
            this.rdoFlyWithWings.Text = "Fly With Wings";
            this.rdoFlyWithWings.UseVisualStyleBackColor = true;
            this.rdoFlyWithWings.CheckedChanged += new System.EventHandler(this.rdoFlyWithWings_CheckedChanged);
            // 
            // rdoNotChange
            // 
            this.rdoNotChange.AutoSize = true;
            this.rdoNotChange.Location = new System.Drawing.Point(30, 35);
            this.rdoNotChange.Name = "rdoNotChange";
            this.rdoNotChange.Size = new System.Drawing.Size(82, 17);
            this.rdoNotChange.TabIndex = 0;
            this.rdoNotChange.TabStop = true;
            this.rdoNotChange.Text = "Not Change";
            this.rdoNotChange.UseVisualStyleBackColor = true;
            this.rdoNotChange.CheckedChanged += new System.EventHandler(this.rdoNotChange_CheckedChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(195, 281);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 20);
            this.lblDisplay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 336);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnQuack);
            this.Controls.Add(this.btnFly);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDecoyDuck;
        private System.Windows.Forms.RadioButton rdoRubberDuck;
        private System.Windows.Forms.RadioButton rdoRedHeadDuck;
        private System.Windows.Forms.RadioButton rdoMallardDuck;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.Button btnQuack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoFlyNoWay;
        private System.Windows.Forms.RadioButton rdoFlyWithWings;
        private System.Windows.Forms.RadioButton rdoNotChange;
        private System.Windows.Forms.Label lblDisplay;
    }
}

