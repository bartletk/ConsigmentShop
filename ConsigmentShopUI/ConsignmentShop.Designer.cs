namespace ConsigmentShopUI
{
    partial class ConsignmentShop
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
            this.HeaderText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.cartListboxLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.vendorListLabel = new System.Windows.Forms.Label();
            this.vendorListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(57, 51);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(405, 37);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Consignment Shop Demo";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(64, 163);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(339, 204);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabel.Location = new System.Drawing.Point(60, 131);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.itemsListBoxLabel.TabIndex = 2;
            this.itemsListBoxLabel.Text = "Store Items";
            // 
            // addToCart
            // 
            this.addToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCart.Location = new System.Drawing.Point(409, 230);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(154, 59);
            this.addToCart.TabIndex = 4;
            this.addToCart.Text = "Add To Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // cartListboxLabel
            // 
            this.cartListboxLabel.AutoSize = true;
            this.cartListboxLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartListboxLabel.Location = new System.Drawing.Point(575, 131);
            this.cartListboxLabel.Name = "cartListboxLabel";
            this.cartListboxLabel.Size = new System.Drawing.Size(43, 20);
            this.cartListboxLabel.TabIndex = 6;
            this.cartListboxLabel.Text = "Cart";
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 20;
            this.cartListBox.Location = new System.Drawing.Point(579, 163);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(339, 204);
            this.cartListBox.TabIndex = 5;
            // 
            // makePurchase
            // 
            this.makePurchase.BackColor = System.Drawing.SystemColors.Window;
            this.makePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makePurchase.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.makePurchase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.makePurchase.Location = new System.Drawing.Point(764, 393);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.makePurchase.Size = new System.Drawing.Size(154, 44);
            this.makePurchase.TabIndex = 7;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = false;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Location = new System.Drawing.Point(427, 432);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 43);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // vendorListLabel
            // 
            this.vendorListLabel.AutoSize = true;
            this.vendorListLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.vendorListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListLabel.Location = new System.Drawing.Point(60, 501);
            this.vendorListLabel.Name = "vendorListLabel";
            this.vendorListLabel.Size = new System.Drawing.Size(76, 20);
            this.vendorListLabel.TabIndex = 10;
            this.vendorListLabel.Text = "Vendors";
            // 
            // vendorListBox
            // 
            this.vendorListBox.FormattingEnabled = true;
            this.vendorListBox.ItemHeight = 20;
            this.vendorListBox.Location = new System.Drawing.Point(64, 524);
            this.vendorListBox.Name = "vendorListBox";
            this.vendorListBox.Size = new System.Drawing.Size(339, 204);
            this.vendorListBox.TabIndex = 9;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.Location = new System.Drawing.Point(575, 501);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(106, 20);
            this.storeProfitLabel.TabIndex = 12;
            this.storeProfitLabel.Text = "Store Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.Location = new System.Drawing.Point(698, 501);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(54, 20);
            this.storeProfitValue.TabIndex = 13;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 772);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListLabel);
            this.Controls.Add(this.vendorListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.cartListboxLabel);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShop";
            this.Text = "ConsigmentShopDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label cartListboxLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label vendorListLabel;
        private System.Windows.Forms.ListBox vendorListBox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

