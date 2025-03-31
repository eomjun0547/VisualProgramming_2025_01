namespace _015
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
            this.lblTatle = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTatle
            // 
            this.lblTatle.AutoSize = true;
            this.lblTatle.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTatle.Location = new System.Drawing.Point(312, 37);
            this.lblTatle.Name = "lblTatle";
            this.lblTatle.Size = new System.Drawing.Size(152, 37);
            this.lblTatle.TabIndex = 0;
            this.lblTatle.Text = "온도변환기";
            this.lblTatle.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(72, 152);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(150, 21);
            this.txtC.TabIndex = 1;
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(487, 153);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(153, 21);
            this.txtF.TabIndex = 2;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblC.Location = new System.Drawing.Point(258, 152);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(42, 21);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "섭씨";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblF.Location = new System.Drawing.Point(687, 153);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(42, 21);
            this.lblF.TabIndex = 4;
            this.lblF.Text = "화씨";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChange.Location = new System.Drawing.Point(319, 217);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(161, 32);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "변환하기";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(68, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "섭씨 = (화씨-32) * 5 / 9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(68, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "화씨 = 섭씨 * 9/5 + 32";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblTatle);
            this.Name = "Form1";
            this.Text = "온도변환기 v.0.1 by 엄예준";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTatle;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

