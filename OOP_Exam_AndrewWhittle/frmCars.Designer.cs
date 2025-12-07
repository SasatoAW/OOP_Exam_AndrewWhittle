namespace OOP_Exam_AndrewWhittle
{
    partial class frmCars
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.engineTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.availableChkBox = new System.Windows.Forms.CheckBox();
            this.recordTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bowman Car Hire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle Registration Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Make";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engine Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Registered";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rental Per Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Available";
            // 
            // regTextBox
            // 
            this.regTextBox.Location = new System.Drawing.Point(244, 95);
            this.regTextBox.Name = "regTextBox";
            this.regTextBox.Size = new System.Drawing.Size(185, 22);
            this.regTextBox.TabIndex = 0;
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(244, 140);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(186, 22);
            this.makeTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.makeTextBox, "Enter the make of the vehicle");
            // 
            // engineTextBox
            // 
            this.engineTextBox.Location = new System.Drawing.Point(244, 184);
            this.engineTextBox.Name = "engineTextBox";
            this.engineTextBox.Size = new System.Drawing.Size(187, 22);
            this.engineTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.engineTextBox, "Enter the engine size of the vehicle");
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(244, 231);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(186, 22);
            this.dateTextBox.TabIndex = 4;
            // 
            // rentTextBox
            // 
            this.rentTextBox.Location = new System.Drawing.Point(244, 267);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(186, 22);
            this.rentTextBox.TabIndex = 5;
            this.rentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.rentTextBox, "Enter the rental price of the vehicle");
            // 
            // availableChkBox
            // 
            this.availableChkBox.AutoSize = true;
            this.availableChkBox.Location = new System.Drawing.Point(243, 303);
            this.availableChkBox.Name = "availableChkBox";
            this.availableChkBox.Size = new System.Drawing.Size(18, 17);
            this.availableChkBox.TabIndex = 6;
            this.availableChkBox.UseVisualStyleBackColor = true;
            // 
            // recordTextBox
            // 
            this.recordTextBox.Location = new System.Drawing.Point(296, 390);
            this.recordTextBox.Name = "recordTextBox";
            this.recordTextBox.Size = new System.Drawing.Size(183, 22);
            this.recordTextBox.TabIndex = 13;
            this.recordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(635, 131);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 43);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(635, 85);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(100, 43);
            this.upButton.TabIndex = 7;
            this.upButton.Text = "&Update";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(635, 180);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 43);
            this.delButton.TabIndex = 9;
            this.delButton.Text = "&Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(635, 230);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(100, 43);
            this.searchbutton.TabIndex = 10;
            this.searchbutton.Text = "&Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(635, 277);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 43);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(635, 323);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 43);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(497, 380);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 43);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(603, 380);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(100, 43);
            this.lastButton.TabIndex = 17;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(73, 380);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(100, 43);
            this.firstButton.TabIndex = 14;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(179, 380);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(100, 43);
            this.prevButton.TabIndex = 15;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.recordTextBox);
            this.Controls.Add(this.availableChkBox);
            this.Controls.Add(this.rentTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.engineTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(this.regTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCars";
            this.Text = "Task A Andrew Whittle C&G reg: ******* 03/12/2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox regTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox engineTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.CheckBox availableChkBox;
        private System.Windows.Forms.TextBox recordTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

