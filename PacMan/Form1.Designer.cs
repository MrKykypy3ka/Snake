
namespace Snakes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.map = new System.Windows.Forms.PictureBox();
            this.Board = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SandyBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(520, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Очки:";
            // 
            // map
            // 
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(510, 510);
            this.map.TabIndex = 1;
            this.map.TabStop = false;
            // 
            // Board
            // 
            this.Board.Location = new System.Drawing.Point(509, 0);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(147, 510);
            this.Board.TabIndex = 6;
            this.Board.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SandyBrown;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(617, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SandyBrown;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(520, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Скорость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SandyBrown;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(617, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.Board);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Хочу 5 за экзамен";
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Board;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

