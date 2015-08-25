namespace MiniProjet_Stéganographie
{
    partial class Stegano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stegano));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEncode = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMsgDecoder = new System.Windows.Forms.TextBox();
            this.btnDecoder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(12, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(489, 20);
            this.txtPath.TabIndex = 1;
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(6, 6);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(499, 79);
            this.txtMessage.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 117);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 91);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encoder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncode.Image = global::MiniProjet_Stéganographie.Properties.Resources.document_save_as;
            this.btnEncode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncode.Location = new System.Drawing.Point(511, 36);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(80, 25);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encoder";
            this.btnEncode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMsgDecoder);
            this.tabPage2.Controls.Add(this.btnDecoder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 91);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decoder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMsgDecoder
            // 
            this.txtMsgDecoder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsgDecoder.Location = new System.Drawing.Point(6, 6);
            this.txtMsgDecoder.Multiline = true;
            this.txtMsgDecoder.Name = "txtMsgDecoder";
            this.txtMsgDecoder.Size = new System.Drawing.Size(499, 79);
            this.txtMsgDecoder.TabIndex = 4;
            // 
            // btnDecoder
            // 
            this.btnDecoder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecoder.Image = ((System.Drawing.Image)(resources.GetObject("btnDecoder.Image")));
            this.btnDecoder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecoder.Location = new System.Drawing.Point(511, 36);
            this.btnDecoder.Name = "btnDecoder";
            this.btnDecoder.Size = new System.Drawing.Size(80, 25);
            this.btnDecoder.TabIndex = 2;
            this.btnDecoder.Text = "Decoder";
            this.btnDecoder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDecoder.UseVisualStyleBackColor = true;
            this.btnDecoder.Click += new System.EventHandler(this.btnDecoder_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::MiniProjet_Stéganographie.Properties.Resources.yellow_folder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(507, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ouvrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(3, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Stegano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stegano";
            this.Text = "Stéganographie";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecoder;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtMsgDecoder;
    }
}

