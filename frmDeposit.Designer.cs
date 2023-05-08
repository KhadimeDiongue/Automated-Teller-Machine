
namespace ATM
{
    partial class frmDeposit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposit));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.PbInsetCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button8 = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCardless = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccNr = new System.Windows.Forms.MaskedTextBox();
            this.txtDepAmt = new System.Windows.Forms.MaskedTextBox();
            this.txtReference = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbInsetCard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnDelete.Location = new System.Drawing.Point(354, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 67);
            this.btnDelete.TabIndex = 87;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.Green;
            this.btnCancel.Location = new System.Drawing.Point(136, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 67);
            this.btnCancel.TabIndex = 86;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Green;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccept.ForeColor = System.Drawing.Color.Green;
            this.btnAccept.Location = new System.Drawing.Point(557, 404);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(160, 67);
            this.btnAccept.TabIndex = 85;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // PbInsetCard
            // 
            this.PbInsetCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbInsetCard.BackgroundImage")));
            this.PbInsetCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbInsetCard.Location = new System.Drawing.Point(793, 207);
            this.PbInsetCard.Name = "PbInsetCard";
            this.PbInsetCard.Size = new System.Drawing.Size(125, 162);
            this.PbInsetCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbInsetCard.TabIndex = 84;
            this.PbInsetCard.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Reference:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(205, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 82;
            this.label7.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "Account Nr:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(183, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(432, 317);
            this.listView1.TabIndex = 81;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(621, 334);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 34);
            this.button8.TabIndex = 79;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(621, 254);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(122, 34);
            this.btnDeposit.TabIndex = 77;
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(621, 162);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 34);
            this.button6.TabIndex = 76;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(55, 335);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(122, 34);
            this.btnReport.TabIndex = 75;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnCardless
            // 
            this.btnCardless.Location = new System.Drawing.Point(55, 254);
            this.btnCardless.Name = "btnCardless";
            this.btnCardless.Size = new System.Drawing.Size(122, 34);
            this.btnCardless.TabIndex = 74;
            this.btnCardless.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 34);
            this.button2.TabIndex = 73;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 34);
            this.button1.TabIndex = 72;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(621, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 34);
            this.button5.TabIndex = 78;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 31);
            this.label3.TabIndex = 88;
            this.label3.Text = "               Deposit               ";
            // 
            // txtAccNr
            // 
            this.txtAccNr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNr.Location = new System.Drawing.Point(363, 156);
            this.txtAccNr.Mask = "000000000000";
            this.txtAccNr.Name = "txtAccNr";
            this.txtAccNr.Size = new System.Drawing.Size(181, 24);
            this.txtAccNr.TabIndex = 92;
            this.txtAccNr.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtAccNr_MaskInputRejected);
            this.txtAccNr.TextChanged += new System.EventHandler(this.txtAccNr_TextChanged);
            // 
            // txtDepAmt
            // 
            this.txtDepAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepAmt.Location = new System.Drawing.Point(363, 272);
            this.txtDepAmt.Mask = "0000";
            this.txtDepAmt.Name = "txtDepAmt";
            this.txtDepAmt.Size = new System.Drawing.Size(181, 24);
            this.txtDepAmt.TabIndex = 93;
            this.txtDepAmt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDepAmt_MaskInputRejected);
            this.txtDepAmt.TextChanged += new System.EventHandler(this.txtDepAmt_TextChanged);
            // 
            // txtReference
            // 
            this.txtReference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(363, 217);
            this.txtReference.Mask = "aaaaaaaaaa";
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(181, 24);
            this.txtReference.TabIndex = 94;
            this.txtReference.TextChanged += new System.EventHandler(this.txtReference_TextChanged);
            // 
            // frmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 634);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtDepAmt);
            this.Controls.Add(this.txtAccNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.PbInsetCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCardless);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Name = "frmDeposit";
            this.Text = "frmDeposit";
            this.Load += new System.EventHandler(this.frmDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbInsetCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox PbInsetCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCardless;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtAccNr;
        private System.Windows.Forms.MaskedTextBox txtDepAmt;
        private System.Windows.Forms.MaskedTextBox txtReference;
    }
}