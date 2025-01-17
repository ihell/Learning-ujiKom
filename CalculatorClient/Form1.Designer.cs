namespace CalculatorClient
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();

            // txtNumber1
            this.txtNumber1.Location = new System.Drawing.Point(12, 12);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 23);

            // txtNumber2
            this.txtNumber2.Location = new System.Drawing.Point(12, 41);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 23);

            // cbOperation
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.Items.AddRange(new object[] { "Add", "Subtract", "Multiply", "Divide" });
            this.cbOperation.Location = new System.Drawing.Point(118, 26);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(100, 23);

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(224, 26);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.Text = "Hitung";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(12, 70);
            this.lblResult.Size = new System.Drawing.Size(200, 23);
            this.lblResult.Text = "Hasil: ";

            // Form1
            this.ClientSize = new System.Drawing.Size(311, 100);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Calculator";
        }
    }
}
