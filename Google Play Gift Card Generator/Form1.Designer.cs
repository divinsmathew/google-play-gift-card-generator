namespace GooglePlayGiftCardGenerator
{
    partial class Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ItemBox = new System.Windows.Forms.TextBox();
            this.PromoCodeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IconPathBox = new System.Windows.Forms.TextBox();
            this.UpdatePreviewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PicIconButton = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(84, 348);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(296, 20);
            this.TitleBox.TabIndex = 1;
            // 
            // ItemBox
            // 
            this.ItemBox.Location = new System.Drawing.Point(84, 377);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(296, 20);
            this.ItemBox.TabIndex = 2;
            // 
            // PromoCodeBox
            // 
            this.PromoCodeBox.Location = new System.Drawing.Point(84, 404);
            this.PromoCodeBox.Name = "PromoCodeBox";
            this.PromoCodeBox.Size = new System.Drawing.Size(296, 20);
            this.PromoCodeBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Promo Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Icon : ";
            // 
            // IconPathBox
            // 
            this.IconPathBox.Location = new System.Drawing.Point(84, 320);
            this.IconPathBox.Name = "IconPathBox";
            this.IconPathBox.ReadOnly = true;
            this.IconPathBox.Size = new System.Drawing.Size(223, 20);
            this.IconPathBox.TabIndex = 8;
            // 
            // UpdatePreviewButton
            // 
            this.UpdatePreviewButton.Location = new System.Drawing.Point(394, 318);
            this.UpdatePreviewButton.Name = "UpdatePreviewButton";
            this.UpdatePreviewButton.Size = new System.Drawing.Size(83, 44);
            this.UpdatePreviewButton.TabIndex = 9;
            this.UpdatePreviewButton.Text = "Update Preview";
            this.UpdatePreviewButton.UseVisualStyleBackColor = true;
            this.UpdatePreviewButton.Click += new System.EventHandler(this.UpdatePreviewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(394, 370);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(83, 55);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save!";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PicIconButton
            // 
            this.PicIconButton.Location = new System.Drawing.Point(313, 318);
            this.PicIconButton.Name = "PicIconButton";
            this.PicIconButton.Size = new System.Drawing.Size(67, 23);
            this.PicIconButton.TabIndex = 11;
            this.PicIconButton.Text = "Browse..";
            this.PicIconButton.UseVisualStyleBackColor = true;
            this.PicIconButton.Click += new System.EventHandler(this.PicIconButton_Click);
            // 
            // Preview
            // 
            this.Preview.Image = global::GooglePlayGiftCardGenerator.Properties.Resources.GiftCardFrame;
            this.Preview.Location = new System.Drawing.Point(12, 11);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(465, 293);
            this.Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Preview.TabIndex = 0;
            this.Preview.TabStop = false;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(490, 435);
            this.Controls.Add(this.PicIconButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.UpdatePreviewButton);
            this.Controls.Add(this.IconPathBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PromoCodeBox);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.Preview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Play Gift Card Genarator";
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Preview;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox ItemBox;
        private System.Windows.Forms.TextBox PromoCodeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IconPathBox;
        private System.Windows.Forms.Button UpdatePreviewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button PicIconButton;
    }
}

