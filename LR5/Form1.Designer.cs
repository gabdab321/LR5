namespace LR5
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClassicBurger = new Button();
            btnChickenBurger = new Button();
            txtBurgerDetails = new TextBox();
            btnCloneBurger = new Button();
            txtClonedBurgers = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClassicBurger
            // 
            btnClassicBurger.Location = new Point(12, 352);
            btnClassicBurger.Name = "btnClassicBurger";
            btnClassicBurger.Size = new Size(137, 23);
            btnClassicBurger.TabIndex = 0;
            btnClassicBurger.Text = "Classic Burger";
            btnClassicBurger.UseVisualStyleBackColor = true;
            btnClassicBurger.Click += btnClassicBurger_Click_1;
            // 
            // btnChickenBurger
            // 
            btnChickenBurger.Location = new Point(12, 381);
            btnChickenBurger.Name = "btnChickenBurger";
            btnChickenBurger.Size = new Size(137, 23);
            btnChickenBurger.TabIndex = 1;
            btnChickenBurger.Text = "Chicken Burger";
            btnChickenBurger.UseVisualStyleBackColor = true;
            btnChickenBurger.Click += btnChickenBurger_Click_1;
            // 
            // txtBurgerDetails
            // 
            txtBurgerDetails.Location = new Point(12, 12);
            txtBurgerDetails.Multiline = true;
            txtBurgerDetails.Name = "txtBurgerDetails";
            txtBurgerDetails.ReadOnly = true;
            txtBurgerDetails.Size = new Size(384, 334);
            txtBurgerDetails.TabIndex = 2;
            txtBurgerDetails.Click += btnCloneBurger_Click;
            // 
            // btnCloneBurger
            // 
            btnCloneBurger.Location = new Point(12, 415);
            btnCloneBurger.Name = "btnCloneBurger";
            btnCloneBurger.RightToLeft = RightToLeft.Yes;
            btnCloneBurger.Size = new Size(203, 23);
            btnCloneBurger.TabIndex = 3;
            btnCloneBurger.Text = "Clone Burger";
            btnCloneBurger.UseVisualStyleBackColor = true;
            btnCloneBurger.Click += btnCloneBurger_Click_1;
            // 
            // txtClonedBurgers
            // 
            txtClonedBurgers.Location = new Point(432, 33);
            txtClonedBurgers.Multiline = true;
            txtClonedBurgers.Name = "txtClonedBurgers";
            txtClonedBurgers.ReadOnly = true;
            txtClonedBurgers.Size = new Size(280, 297);
            txtClonedBurgers.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(432, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 5;
            label1.Text = "Cloned";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtClonedBurgers);
            Controls.Add(btnCloneBurger);
            Controls.Add(txtBurgerDetails);
            Controls.Add(btnChickenBurger);
            Controls.Add(btnClassicBurger);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClassicBurger;
        private Button btnChickenBurger;
        private TextBox txtBurgerDetails;
        private Button btnCloneBurger;
        private TextBox txtClonedBurgers;
        private Label label1;
    }
}
