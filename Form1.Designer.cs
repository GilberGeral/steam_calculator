namespace steamEarnsCalc
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalComments = new System.Windows.Forms.NumericUpDown();
            this.gamePrice = new System.Windows.Forms.NumericUpDown();
            this.gamePercentOp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gameDateReleased = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gameTax = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.steamPercentage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.boxResults = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totalComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePercentOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steamPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Insert total comments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Price of game (USD)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(50, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 49);
            this.label7.TabIndex = 2;
            this.label7.Text = "Percentage of players who usually give their opinion";
            // 
            // totalComments
            // 
            this.totalComments.Location = new System.Drawing.Point(160, 45);
            this.totalComments.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.totalComments.Name = "totalComments";
            this.totalComments.Size = new System.Drawing.Size(120, 20);
            this.totalComments.TabIndex = 3;
            // 
            // gamePrice
            // 
            this.gamePrice.DecimalPlaces = 2;
            this.gamePrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gamePrice.Location = new System.Drawing.Point(160, 98);
            this.gamePrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(120, 20);
            this.gamePrice.TabIndex = 4;
            // 
            // gamePercentOp
            // 
            this.gamePercentOp.DecimalPlaces = 1;
            this.gamePercentOp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gamePercentOp.Location = new System.Drawing.Point(160, 147);
            this.gamePercentOp.Name = "gamePercentOp";
            this.gamePercentOp.Size = new System.Drawing.Size(120, 20);
            this.gamePercentOp.TabIndex = 5;
            this.gamePercentOp.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(54, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 40);
            this.label8.TabIndex = 6;
            this.label8.Text = "Release date (day-month-year)";
            // 
            // gameDateReleased
            // 
            this.gameDateReleased.CustomFormat = "dd-MM-yyyy";
            this.gameDateReleased.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gameDateReleased.Location = new System.Drawing.Point(160, 305);
            this.gameDateReleased.Name = "gameDateReleased";
            this.gameDateReleased.Size = new System.Drawing.Size(120, 20);
            this.gameDateReleased.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(50, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Applicable tax ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.IndianRed;
            this.label10.Location = new System.Drawing.Point(49, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "after steam discount";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(50, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 23);
            this.label11.TabIndex = 10;
            this.label11.Text = "can be 0.0";
            // 
            // gameTax
            // 
            this.gameTax.DecimalPlaces = 2;
            this.gameTax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gameTax.Location = new System.Drawing.Point(157, 366);
            this.gameTax.Name = "gameTax";
            this.gameTax.Size = new System.Drawing.Size(120, 20);
            this.gameTax.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(53, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(54, 473);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 44);
            this.label12.TabIndex = 13;
            this.label12.Text = "This is an estimated value, it does not take into account discounts and promotion" +
    "s.";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.IndianRed;
            this.label13.Location = new System.Drawing.Point(50, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 36);
            this.label13.TabIndex = 14;
            this.label13.Text = "taken from various studies, you can change it, it will be saved for future calcul" +
    "ations";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Percentage of the game that Steam takes";
            // 
            // steamPercentage
            // 
            this.steamPercentage.DecimalPlaces = 1;
            this.steamPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.steamPercentage.Location = new System.Drawing.Point(160, 236);
            this.steamPercentage.Name = "steamPercentage";
            this.steamPercentage.Size = new System.Drawing.Size(120, 20);
            this.steamPercentage.TabIndex = 16;
            this.steamPercentage.UseWaitCursor = true;
            this.steamPercentage.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Results :";
            // 
            // boxResults
            // 
            this.boxResults.Location = new System.Drawing.Point(382, 63);
            this.boxResults.Name = "boxResults";
            this.boxResults.Size = new System.Drawing.Size(439, 442);
            this.boxResults.TabIndex = 19;
            this.boxResults.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(331, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "created by bitmo software";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(733, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "https://bitmo.co/";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(833, 549);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.steamPercentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gameTax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gameDateReleased);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gamePercentOp);
            this.Controls.Add(this.gamePrice);
            this.Controls.Add(this.totalComments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Steam earnings calculator";
            ((System.ComponentModel.ISupportInitialize)(this.totalComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePercentOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steamPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown totalComments;
        private System.Windows.Forms.NumericUpDown gamePrice;
        private System.Windows.Forms.NumericUpDown gamePercentOp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker gameDateReleased;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown gameTax;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown steamPercentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox boxResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

