namespace AssessedExercise2
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
            this.InsertIntLabel = new System.Windows.Forms.Label();
            this.InsertIntTextBox = new System.Windows.Forms.TextBox();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.TotalItemsTextBox = new System.Windows.Forms.TextBox();
            this.InsertIntButton = new System.Windows.Forms.Button();
            this.InOrderButton = new System.Windows.Forms.Button();
            this.PreOrderButton = new System.Windows.Forms.Button();
            this.PostOrderButton = new System.Windows.Forms.Button();
            this.PreOrderTextBox = new System.Windows.Forms.TextBox();
            this.InOrderTextBox = new System.Windows.Forms.TextBox();
            this.PostOrderTextBox = new System.Windows.Forms.TextBox();
            this.insertCustomerLabel = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerAgeTextBox = new System.Windows.Forms.TextBox();
            this.CustomerAddressTextbox = new System.Windows.Forms.TextBox();
            this.amountOwedTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerAgeLabel = new System.Windows.Forms.Label();
            this.CustomerAddressLabel = new System.Windows.Forms.Label();
            this.AmountOwedLabel = new System.Windows.Forms.Label();
            this.InsertCustomerButton = new System.Windows.Forms.Button();
            this.TotalCustomersLabel = new System.Windows.Forms.Label();
            this.TotalCustomersTextbox = new System.Windows.Forms.TextBox();
            this.findCustomerLabel = new System.Windows.Forms.Label();
            this.FindCustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameSearchTextbox = new System.Windows.Forms.TextBox();
            this.CustomerSearchResultTextbox = new System.Windows.Forms.TextBox();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.intTreeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preOrderCustomerButton = new System.Windows.Forms.Button();
            this.postOrderCustomerButton = new System.Windows.Forms.Button();
            this.preOrderCustomerTextbox = new System.Windows.Forms.TextBox();
            this.inOrderCustomerTextbox = new System.Windows.Forms.TextBox();
            this.postOrderCustomerTextbox = new System.Windows.Forms.TextBox();
            this.inOrderCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertIntLabel
            // 
            this.InsertIntLabel.AutoSize = true;
            this.InsertIntLabel.Location = new System.Drawing.Point(26, 62);
            this.InsertIntLabel.Name = "InsertIntLabel";
            this.InsertIntLabel.Size = new System.Drawing.Size(48, 13);
            this.InsertIntLabel.TabIndex = 0;
            this.InsertIntLabel.Text = "Insert Int";
            this.InsertIntLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // InsertIntTextBox
            // 
            this.InsertIntTextBox.Location = new System.Drawing.Point(5, 88);
            this.InsertIntTextBox.Name = "InsertIntTextBox";
            this.InsertIntTextBox.Size = new System.Drawing.Size(100, 20);
            this.InsertIntTextBox.TabIndex = 1;
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.Location = new System.Drawing.Point(123, 62);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(98, 13);
            this.TotalItemsLabel.TabIndex = 2;
            this.TotalItemsLabel.Text = "Total Items in Tree:";
            // 
            // TotalItemsTextBox
            // 
            this.TotalItemsTextBox.Location = new System.Drawing.Point(126, 88);
            this.TotalItemsTextBox.Name = "TotalItemsTextBox";
            this.TotalItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalItemsTextBox.TabIndex = 3;
            // 
            // InsertIntButton
            // 
            this.InsertIntButton.Location = new System.Drawing.Point(16, 129);
            this.InsertIntButton.Name = "InsertIntButton";
            this.InsertIntButton.Size = new System.Drawing.Size(75, 23);
            this.InsertIntButton.TabIndex = 4;
            this.InsertIntButton.Text = "Submit";
            this.InsertIntButton.UseVisualStyleBackColor = true;
            this.InsertIntButton.Click += new System.EventHandler(this.InsertIntButton_Click);
            // 
            // InOrderButton
            // 
            this.InOrderButton.Location = new System.Drawing.Point(135, 178);
            this.InOrderButton.Name = "InOrderButton";
            this.InOrderButton.Size = new System.Drawing.Size(75, 23);
            this.InOrderButton.TabIndex = 5;
            this.InOrderButton.Text = "InOrder";
            this.InOrderButton.UseVisualStyleBackColor = true;
            this.InOrderButton.Click += new System.EventHandler(this.InOrderButton_Click);
            // 
            // PreOrderButton
            // 
            this.PreOrderButton.Location = new System.Drawing.Point(16, 178);
            this.PreOrderButton.Name = "PreOrderButton";
            this.PreOrderButton.Size = new System.Drawing.Size(75, 23);
            this.PreOrderButton.TabIndex = 6;
            this.PreOrderButton.Text = "PreOrder";
            this.PreOrderButton.UseVisualStyleBackColor = true;
            this.PreOrderButton.Click += new System.EventHandler(this.PreOrderButton_Click);
            // 
            // PostOrderButton
            // 
            this.PostOrderButton.Location = new System.Drawing.Point(73, 317);
            this.PostOrderButton.Name = "PostOrderButton";
            this.PostOrderButton.Size = new System.Drawing.Size(75, 23);
            this.PostOrderButton.TabIndex = 7;
            this.PostOrderButton.Text = "PostOrder";
            this.PostOrderButton.UseVisualStyleBackColor = true;
            this.PostOrderButton.Click += new System.EventHandler(this.PostOrderButton_Click);
            // 
            // PreOrderTextBox
            // 
            this.PreOrderTextBox.Location = new System.Drawing.Point(5, 207);
            this.PreOrderTextBox.Multiline = true;
            this.PreOrderTextBox.Name = "PreOrderTextBox";
            this.PreOrderTextBox.Size = new System.Drawing.Size(100, 92);
            this.PreOrderTextBox.TabIndex = 8;
            // 
            // InOrderTextBox
            // 
            this.InOrderTextBox.Location = new System.Drawing.Point(121, 207);
            this.InOrderTextBox.Multiline = true;
            this.InOrderTextBox.Name = "InOrderTextBox";
            this.InOrderTextBox.Size = new System.Drawing.Size(100, 92);
            this.InOrderTextBox.TabIndex = 9;
            // 
            // PostOrderTextBox
            // 
            this.PostOrderTextBox.Location = new System.Drawing.Point(62, 346);
            this.PostOrderTextBox.Multiline = true;
            this.PostOrderTextBox.Name = "PostOrderTextBox";
            this.PostOrderTextBox.Size = new System.Drawing.Size(100, 92);
            this.PostOrderTextBox.TabIndex = 10;
            // 
            // insertCustomerLabel
            // 
            this.insertCustomerLabel.AutoSize = true;
            this.insertCustomerLabel.Location = new System.Drawing.Point(385, 72);
            this.insertCustomerLabel.Name = "insertCustomerLabel";
            this.insertCustomerLabel.Size = new System.Drawing.Size(83, 13);
            this.insertCustomerLabel.TabIndex = 11;
            this.insertCustomerLabel.Text = "Insert Customer:";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(321, 116);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerNameTextBox.TabIndex = 12;
            // 
            // customerAgeTextBox
            // 
            this.customerAgeTextBox.Location = new System.Drawing.Point(436, 116);
            this.customerAgeTextBox.Name = "customerAgeTextBox";
            this.customerAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerAgeTextBox.TabIndex = 13;
            // 
            // CustomerAddressTextbox
            // 
            this.CustomerAddressTextbox.Location = new System.Drawing.Point(321, 171);
            this.CustomerAddressTextbox.Name = "CustomerAddressTextbox";
            this.CustomerAddressTextbox.Size = new System.Drawing.Size(100, 20);
            this.CustomerAddressTextbox.TabIndex = 14;
            // 
            // amountOwedTextBox
            // 
            this.amountOwedTextBox.Location = new System.Drawing.Point(436, 171);
            this.amountOwedTextBox.Name = "amountOwedTextBox";
            this.amountOwedTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountOwedTextBox.TabIndex = 15;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(328, 100);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(85, 13);
            this.CustomerNameLabel.TabIndex = 16;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // CustomerAgeLabel
            // 
            this.CustomerAgeLabel.AutoSize = true;
            this.CustomerAgeLabel.Location = new System.Drawing.Point(433, 100);
            this.CustomerAgeLabel.Name = "CustomerAgeLabel";
            this.CustomerAgeLabel.Size = new System.Drawing.Size(76, 13);
            this.CustomerAgeLabel.TabIndex = 17;
            this.CustomerAgeLabel.Text = "Customer Age:";
            // 
            // CustomerAddressLabel
            // 
            this.CustomerAddressLabel.AutoSize = true;
            this.CustomerAddressLabel.Location = new System.Drawing.Point(318, 155);
            this.CustomerAddressLabel.Name = "CustomerAddressLabel";
            this.CustomerAddressLabel.Size = new System.Drawing.Size(95, 13);
            this.CustomerAddressLabel.TabIndex = 18;
            this.CustomerAddressLabel.Text = "Customer Address:";
            // 
            // AmountOwedLabel
            // 
            this.AmountOwedLabel.AutoSize = true;
            this.AmountOwedLabel.Location = new System.Drawing.Point(433, 155);
            this.AmountOwedLabel.Name = "AmountOwedLabel";
            this.AmountOwedLabel.Size = new System.Drawing.Size(77, 13);
            this.AmountOwedLabel.TabIndex = 19;
            this.AmountOwedLabel.Text = "Amount Owed:";
            // 
            // InsertCustomerButton
            // 
            this.InsertCustomerButton.Location = new System.Drawing.Point(393, 206);
            this.InsertCustomerButton.Name = "InsertCustomerButton";
            this.InsertCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.InsertCustomerButton.TabIndex = 20;
            this.InsertCustomerButton.Text = "Submit";
            this.InsertCustomerButton.UseVisualStyleBackColor = true;
            this.InsertCustomerButton.Click += new System.EventHandler(this.InsertCustomerButton_Click);
            // 
            // TotalCustomersLabel
            // 
            this.TotalCustomersLabel.AutoSize = true;
            this.TotalCustomersLabel.Location = new System.Drawing.Point(582, 212);
            this.TotalCustomersLabel.Name = "TotalCustomersLabel";
            this.TotalCustomersLabel.Size = new System.Drawing.Size(100, 13);
            this.TotalCustomersLabel.TabIndex = 21;
            this.TotalCustomersLabel.Text = "Customers in tree = ";
            // 
            // TotalCustomersTextbox
            // 
            this.TotalCustomersTextbox.Location = new System.Drawing.Point(688, 209);
            this.TotalCustomersTextbox.Name = "TotalCustomersTextbox";
            this.TotalCustomersTextbox.Size = new System.Drawing.Size(100, 20);
            this.TotalCustomersTextbox.TabIndex = 22;
            // 
            // findCustomerLabel
            // 
            this.findCustomerLabel.AutoSize = true;
            this.findCustomerLabel.Location = new System.Drawing.Point(659, 72);
            this.findCustomerLabel.Name = "findCustomerLabel";
            this.findCustomerLabel.Size = new System.Drawing.Size(83, 13);
            this.findCustomerLabel.TabIndex = 23;
            this.findCustomerLabel.Text = "Find a Customer";
            // 
            // FindCustomerNameLabel
            // 
            this.FindCustomerNameLabel.AutoSize = true;
            this.FindCustomerNameLabel.Location = new System.Drawing.Point(561, 100);
            this.FindCustomerNameLabel.Name = "FindCustomerNameLabel";
            this.FindCustomerNameLabel.Size = new System.Drawing.Size(110, 13);
            this.FindCustomerNameLabel.TabIndex = 24;
            this.FindCustomerNameLabel.Text = "Enter Customer Name";
            // 
            // CustomerNameSearchTextbox
            // 
            this.CustomerNameSearchTextbox.Location = new System.Drawing.Point(564, 116);
            this.CustomerNameSearchTextbox.Name = "CustomerNameSearchTextbox";
            this.CustomerNameSearchTextbox.Size = new System.Drawing.Size(100, 20);
            this.CustomerNameSearchTextbox.TabIndex = 25;
            // 
            // CustomerSearchResultTextbox
            // 
            this.CustomerSearchResultTextbox.Location = new System.Drawing.Point(688, 100);
            this.CustomerSearchResultTextbox.Multiline = true;
            this.CustomerSearchResultTextbox.Name = "CustomerSearchResultTextbox";
            this.CustomerSearchResultTextbox.Size = new System.Drawing.Size(100, 92);
            this.CustomerSearchResultTextbox.TabIndex = 26;
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Location = new System.Drawing.Point(578, 150);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.customerSearchButton.TabIndex = 27;
            this.customerSearchButton.Text = "Submit";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            this.customerSearchButton.Click += new System.EventHandler(this.customerSearchButton_Click);
            // 
            // intTreeLabel
            // 
            this.intTreeLabel.AutoSize = true;
            this.intTreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intTreeLabel.Location = new System.Drawing.Point(69, 9);
            this.intTreeLabel.Name = "intTreeLabel";
            this.intTreeLabel.Size = new System.Drawing.Size(82, 24);
            this.intTreeLabel.TabIndex = 28;
            this.intTreeLabel.Text = "Int Tree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Customer Tree";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // preOrderCustomerButton
            // 
            this.preOrderCustomerButton.Location = new System.Drawing.Point(380, 285);
            this.preOrderCustomerButton.Name = "preOrderCustomerButton";
            this.preOrderCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.preOrderCustomerButton.TabIndex = 30;
            this.preOrderCustomerButton.Text = "PreOrder";
            this.preOrderCustomerButton.UseVisualStyleBackColor = true;
            this.preOrderCustomerButton.Click += new System.EventHandler(this.preOrderCustomerButton_Click);
            // 
            // postOrderCustomerButton
            // 
            this.postOrderCustomerButton.Location = new System.Drawing.Point(518, 285);
            this.postOrderCustomerButton.Name = "postOrderCustomerButton";
            this.postOrderCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.postOrderCustomerButton.TabIndex = 32;
            this.postOrderCustomerButton.Text = "PostOrder";
            this.postOrderCustomerButton.UseVisualStyleBackColor = true;
            this.postOrderCustomerButton.Click += new System.EventHandler(this.postOrderCustomerButton_Click);
            // 
            // preOrderCustomerTextbox
            // 
            this.preOrderCustomerTextbox.Location = new System.Drawing.Point(371, 334);
            this.preOrderCustomerTextbox.Multiline = true;
            this.preOrderCustomerTextbox.Name = "preOrderCustomerTextbox";
            this.preOrderCustomerTextbox.Size = new System.Drawing.Size(100, 92);
            this.preOrderCustomerTextbox.TabIndex = 33;
            // 
            // inOrderCustomerTextbox
            // 
            this.inOrderCustomerTextbox.Location = new System.Drawing.Point(640, 334);
            this.inOrderCustomerTextbox.Multiline = true;
            this.inOrderCustomerTextbox.Name = "inOrderCustomerTextbox";
            this.inOrderCustomerTextbox.Size = new System.Drawing.Size(100, 92);
            this.inOrderCustomerTextbox.TabIndex = 34;
            // 
            // postOrderCustomerTextbox
            // 
            this.postOrderCustomerTextbox.Location = new System.Drawing.Point(505, 334);
            this.postOrderCustomerTextbox.Multiline = true;
            this.postOrderCustomerTextbox.Name = "postOrderCustomerTextbox";
            this.postOrderCustomerTextbox.Size = new System.Drawing.Size(100, 92);
            this.postOrderCustomerTextbox.TabIndex = 35;
            // 
            // inOrderCustomerButton
            // 
            this.inOrderCustomerButton.Location = new System.Drawing.Point(653, 285);
            this.inOrderCustomerButton.Name = "inOrderCustomerButton";
            this.inOrderCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.inOrderCustomerButton.TabIndex = 36;
            this.inOrderCustomerButton.Text = "InOrder";
            this.inOrderCustomerButton.UseVisualStyleBackColor = true;
            this.inOrderCustomerButton.Click += new System.EventHandler(this.inOrderCustomerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inOrderCustomerButton);
            this.Controls.Add(this.postOrderCustomerTextbox);
            this.Controls.Add(this.inOrderCustomerTextbox);
            this.Controls.Add(this.preOrderCustomerTextbox);
            this.Controls.Add(this.postOrderCustomerButton);
            this.Controls.Add(this.preOrderCustomerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intTreeLabel);
            this.Controls.Add(this.customerSearchButton);
            this.Controls.Add(this.CustomerSearchResultTextbox);
            this.Controls.Add(this.CustomerNameSearchTextbox);
            this.Controls.Add(this.FindCustomerNameLabel);
            this.Controls.Add(this.findCustomerLabel);
            this.Controls.Add(this.TotalCustomersTextbox);
            this.Controls.Add(this.TotalCustomersLabel);
            this.Controls.Add(this.InsertCustomerButton);
            this.Controls.Add(this.AmountOwedLabel);
            this.Controls.Add(this.CustomerAddressLabel);
            this.Controls.Add(this.CustomerAgeLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.amountOwedTextBox);
            this.Controls.Add(this.CustomerAddressTextbox);
            this.Controls.Add(this.customerAgeTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.insertCustomerLabel);
            this.Controls.Add(this.PostOrderTextBox);
            this.Controls.Add(this.InOrderTextBox);
            this.Controls.Add(this.PreOrderTextBox);
            this.Controls.Add(this.PostOrderButton);
            this.Controls.Add(this.PreOrderButton);
            this.Controls.Add(this.InOrderButton);
            this.Controls.Add(this.InsertIntButton);
            this.Controls.Add(this.TotalItemsTextBox);
            this.Controls.Add(this.TotalItemsLabel);
            this.Controls.Add(this.InsertIntTextBox);
            this.Controls.Add(this.InsertIntLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsertIntLabel;
        private System.Windows.Forms.TextBox InsertIntTextBox;
        private System.Windows.Forms.Label TotalItemsLabel;
        private System.Windows.Forms.TextBox TotalItemsTextBox;
        private System.Windows.Forms.Button InsertIntButton;
        private System.Windows.Forms.Button InOrderButton;
        private System.Windows.Forms.Button PreOrderButton;
        private System.Windows.Forms.Button PostOrderButton;
        private System.Windows.Forms.TextBox PreOrderTextBox;
        private System.Windows.Forms.TextBox InOrderTextBox;
        private System.Windows.Forms.TextBox PostOrderTextBox;
        private System.Windows.Forms.Label insertCustomerLabel;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox customerAgeTextBox;
        private System.Windows.Forms.TextBox CustomerAddressTextbox;
        private System.Windows.Forms.TextBox amountOwedTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CustomerAgeLabel;
        private System.Windows.Forms.Label CustomerAddressLabel;
        private System.Windows.Forms.Label AmountOwedLabel;
        private System.Windows.Forms.Button InsertCustomerButton;
        private System.Windows.Forms.Label TotalCustomersLabel;
        private System.Windows.Forms.TextBox TotalCustomersTextbox;
        private System.Windows.Forms.Label findCustomerLabel;
        private System.Windows.Forms.Label FindCustomerNameLabel;
        private System.Windows.Forms.TextBox CustomerNameSearchTextbox;
        private System.Windows.Forms.TextBox CustomerSearchResultTextbox;
        private System.Windows.Forms.Button customerSearchButton;
        private System.Windows.Forms.Label intTreeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button preOrderCustomerButton;
        private System.Windows.Forms.Button postOrderCustomerButton;
        private System.Windows.Forms.TextBox preOrderCustomerTextbox;
        private System.Windows.Forms.TextBox inOrderCustomerTextbox;
        private System.Windows.Forms.TextBox postOrderCustomerTextbox;
        private System.Windows.Forms.Button inOrderCustomerButton;
    }
}

