
namespace classProject
{
    partial class frmEnhancedInvoiceTotal
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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.lblNumberOfInvoices = new System.Windows.Forms.Label();
            this.lblTotalOfInvoices = new System.Windows.Forms.Label();
            this.lblInvoiceAverage = new System.Windows.Forms.Label();
            this.txtNumberOfinvoices = new System.Windows.Forms.TextBox();
            this.txtTotalOfInovices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAverage = new System.Windows.Forms.TextBox();
            this.lblEnterSubtotal = new System.Windows.Forms.Label();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.txtSmallestInvoice = new System.Windows.Forms.TextBox();
            this.lblcustomerType = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(30, 102);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(96, 22);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal: ";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Percent: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(196, 102);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(144, 22);
            this.txtSubtotal.TabIndex = 1;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Location = new System.Drawing.Point(196, 186);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.ReadOnly = true;
            this.txtDiscountPercent.Size = new System.Drawing.Size(144, 22);
            this.txtDiscountPercent.TabIndex = 1;
            this.txtDiscountPercent.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(346, 344);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 30);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount &Amount: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(196, 223);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(144, 22);
            this.txtDiscountAmount.TabIndex = 2;
            this.txtDiscountAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(196, 259);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(144, 22);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(600, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 30);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Location = new System.Drawing.Point(477, 344);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(96, 30);
            this.btnClearTotals.TabIndex = 21;
            this.btnClearTotals.Text = "C&lear";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // lblNumberOfInvoices
            // 
            this.lblNumberOfInvoices.AutoSize = true;
            this.lblNumberOfInvoices.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfInvoices.Location = new System.Drawing.Point(391, 186);
            this.lblNumberOfInvoices.Name = "lblNumberOfInvoices";
            this.lblNumberOfInvoices.Size = new System.Drawing.Size(151, 16);
            this.lblNumberOfInvoices.TabIndex = 14;
            this.lblNumberOfInvoices.Text = "Number of invoices: ";
            // 
            // lblTotalOfInvoices
            // 
            this.lblTotalOfInvoices.AutoSize = true;
            this.lblTotalOfInvoices.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOfInvoices.Location = new System.Drawing.Point(391, 224);
            this.lblTotalOfInvoices.Name = "lblTotalOfInvoices";
            this.lblTotalOfInvoices.Size = new System.Drawing.Size(133, 16);
            this.lblTotalOfInvoices.TabIndex = 16;
            this.lblTotalOfInvoices.Text = "Total of invoices: ";
            // 
            // lblInvoiceAverage
            // 
            this.lblInvoiceAverage.AutoSize = true;
            this.lblInvoiceAverage.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceAverage.Location = new System.Drawing.Point(393, 259);
            this.lblInvoiceAverage.Name = "lblInvoiceAverage";
            this.lblInvoiceAverage.Size = new System.Drawing.Size(123, 16);
            this.lblInvoiceAverage.TabIndex = 18;
            this.lblInvoiceAverage.Text = "Invoice average: ";
            // 
            // txtNumberOfinvoices
            // 
            this.txtNumberOfinvoices.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfinvoices.Location = new System.Drawing.Point(548, 179);
            this.txtNumberOfinvoices.Name = "txtNumberOfinvoices";
            this.txtNumberOfinvoices.ReadOnly = true;
            this.txtNumberOfinvoices.Size = new System.Drawing.Size(144, 23);
            this.txtNumberOfinvoices.TabIndex = 15;
            // 
            // txtTotalOfInovices
            // 
            this.txtTotalOfInovices.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOfInovices.Location = new System.Drawing.Point(548, 216);
            this.txtTotalOfInovices.Name = "txtTotalOfInovices";
            this.txtTotalOfInovices.ReadOnly = true;
            this.txtTotalOfInovices.Size = new System.Drawing.Size(144, 23);
            this.txtTotalOfInovices.TabIndex = 17;
            // 
            // txtInvoiceAverage
            // 
            this.txtInvoiceAverage.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceAverage.Location = new System.Drawing.Point(548, 252);
            this.txtInvoiceAverage.Name = "txtInvoiceAverage";
            this.txtInvoiceAverage.ReadOnly = true;
            this.txtInvoiceAverage.Size = new System.Drawing.Size(144, 23);
            this.txtInvoiceAverage.TabIndex = 19;
            // 
            // lblEnterSubtotal
            // 
            this.lblEnterSubtotal.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSubtotal.Location = new System.Drawing.Point(30, 68);
            this.lblEnterSubtotal.Name = "lblEnterSubtotal";
            this.lblEnterSubtotal.Size = new System.Drawing.Size(133, 22);
            this.lblEnterSubtotal.TabIndex = 0;
            this.lblEnterSubtotal.Text = "&Enter Subtotal:";
            this.lblEnterSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.AcceptsTab = true;
            this.txtEnterSubtotal.Location = new System.Drawing.Point(196, 68);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(144, 22);
            this.txtEnterSubtotal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Largest invoice: ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Smallest invoice:";
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLargestInvoice.Location = new System.Drawing.Point(550, 72);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(144, 23);
            this.txtLargestInvoice.TabIndex = 11;
            // 
            // txtSmallestInvoice
            // 
            this.txtSmallestInvoice.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmallestInvoice.Location = new System.Drawing.Point(550, 105);
            this.txtSmallestInvoice.Name = "txtSmallestInvoice";
            this.txtSmallestInvoice.ReadOnly = true;
            this.txtSmallestInvoice.Size = new System.Drawing.Size(144, 23);
            this.txtSmallestInvoice.TabIndex = 13;
            // 
            // lblcustomerType
            // 
            this.lblcustomerType.Font = new System.Drawing.Font("Lucida Bright", 7.932204F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerType.Location = new System.Drawing.Point(30, 33);
            this.lblcustomerType.Name = "lblcustomerType";
            this.lblcustomerType.Size = new System.Drawing.Size(130, 23);
            this.lblcustomerType.TabIndex = 23;
            this.lblcustomerType.Text = "Customer &type:";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(196, 29);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(144, 22);
            this.txtCustomerType.TabIndex = 24;
            // 
            // frmEnhancedInvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(251)))), ((int)(((byte)(229)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(731, 397);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.lblcustomerType);
            this.Controls.Add(this.txtSmallestInvoice);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.lblEnterSubtotal);
            this.Controls.Add(this.txtInvoiceAverage);
            this.Controls.Add(this.txtTotalOfInovices);
            this.Controls.Add(this.txtNumberOfinvoices);
            this.Controls.Add(this.lblInvoiceAverage);
            this.Controls.Add(this.lblTotalOfInvoices);
            this.Controls.Add(this.lblNumberOfInvoices);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSubtotal);
            this.Name = "frmEnhancedInvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Label lblNumberOfInvoices;
        private System.Windows.Forms.Label lblTotalOfInvoices;
        private System.Windows.Forms.Label lblInvoiceAverage;
        private System.Windows.Forms.TextBox txtNumberOfinvoices;
        private System.Windows.Forms.TextBox txtTotalOfInovices;
        private System.Windows.Forms.TextBox txtInvoiceAverage;
        private System.Windows.Forms.Label lblEnterSubtotal;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.TextBox txtSmallestInvoice;
        private System.Windows.Forms.Label lblcustomerType;
        private System.Windows.Forms.TextBox txtCustomerType;
    }
}

