namespace _016_Score
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblK = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtE);
            this.groupBox1.Controls.Add(this.txtM);
            this.groupBox1.Controls.Add(this.txtK);
            this.groupBox1.Controls.Add(this.lblE);
            this.groupBox1.Controls.Add(this.lblM);
            this.groupBox1.Controls.Add(this.lblK);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(40, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "성적입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.lblAverage);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.lblSum);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(288, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(21, 47);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(32, 22);
            this.lblK.TabIndex = 0;
            this.lblK.Text = "국어";
            this.lblK.UseCompatibleTextRendering = true;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(21, 72);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(34, 17);
            this.lblM.TabIndex = 1;
            this.lblM.Text = "수학";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(21, 97);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(34, 17);
            this.lblE.TabIndex = 2;
            this.lblE.Text = "영어";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(76, 39);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 25);
            this.txtK.TabIndex = 3;
            this.txtK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(76, 66);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 25);
            this.txtM.TabIndex = 4;
            this.txtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(76, 93);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(100, 25);
            this.txtE.TabIndex = 5;
            this.txtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(15, 30);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(34, 17);
            this.lblSum.TabIndex = 0;
            this.lblSum.Text = "총점";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 1;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(79, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 25);
            this.textBox5.TabIndex = 3;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(15, 66);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(34, 17);
            this.lblAverage.TabIndex = 2;
            this.lblAverage.Text = "평균";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(409, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 214);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Button button1;
    }
}

