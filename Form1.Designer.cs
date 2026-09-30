namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            plus = new Button();
            minus = new Button();
            mult = new Button();
            split = new Button();
            clear = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            equ = new Button();
            seven = new Button();
            eight = new Button();
            nine = new Button();
            zero = new Button();
            drob = new Button();
            label1 = new Label();
            memory = new Button();
            SuspendLayout();
            // 
            // plus
            // 
            plus.FlatStyle = FlatStyle.System;
            plus.Font = new Font("Segoe UI", 16F);
            plus.Location = new Point(12, 169);
            plus.Name = "plus";
            plus.Size = new Size(50, 47);
            plus.TabIndex = 0;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.FlatStyle = FlatStyle.System;
            minus.Font = new Font("Segoe UI", 16F);
            minus.Location = new Point(78, 169);
            minus.Name = "minus";
            minus.Size = new Size(50, 47);
            minus.TabIndex = 1;
            minus.Text = "–";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // mult
            // 
            mult.FlatStyle = FlatStyle.System;
            mult.Font = new Font("Segoe UI", 16F);
            mult.Location = new Point(143, 169);
            mult.Name = "mult";
            mult.Size = new Size(50, 47);
            mult.TabIndex = 2;
            mult.Text = "х";
            mult.UseVisualStyleBackColor = true;
            mult.Click += mult_Click;
            // 
            // split
            // 
            split.FlatStyle = FlatStyle.System;
            split.Font = new Font("Segoe UI", 16F);
            split.Location = new Point(209, 169);
            split.Name = "split";
            split.Size = new Size(50, 47);
            split.TabIndex = 3;
            split.Text = "/";
            split.UseVisualStyleBackColor = true;
            split.Click += split_Click;
            // 
            // clear
            // 
            clear.FlatStyle = FlatStyle.System;
            clear.Font = new Font("Segoe UI", 16F);
            clear.Location = new Point(209, 234);
            clear.Name = "clear";
            clear.Size = new Size(50, 47);
            clear.TabIndex = 4;
            clear.Text = "С";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // one
            // 
            one.FlatStyle = FlatStyle.System;
            one.Font = new Font("Segoe UI", 16F);
            one.Location = new Point(12, 234);
            one.Name = "one";
            one.Size = new Size(50, 47);
            one.TabIndex = 5;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            two.FlatStyle = FlatStyle.System;
            two.Font = new Font("Segoe UI", 16F);
            two.Location = new Point(78, 234);
            two.Name = "two";
            two.Size = new Size(50, 47);
            two.TabIndex = 6;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            three.FlatStyle = FlatStyle.System;
            three.Font = new Font("Segoe UI", 16F);
            three.Location = new Point(143, 234);
            three.Name = "three";
            three.Size = new Size(50, 47);
            three.TabIndex = 7;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            // 
            // four
            // 
            four.FlatStyle = FlatStyle.System;
            four.Font = new Font("Segoe UI", 16F);
            four.Location = new Point(12, 301);
            four.Name = "four";
            four.Size = new Size(50, 47);
            four.TabIndex = 8;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            // 
            // five
            // 
            five.FlatStyle = FlatStyle.System;
            five.Font = new Font("Segoe UI", 16F);
            five.Location = new Point(78, 301);
            five.Name = "five";
            five.Size = new Size(50, 47);
            five.TabIndex = 9;
            five.Text = "5";
            five.UseVisualStyleBackColor = true;
            // 
            // six
            // 
            six.FlatStyle = FlatStyle.System;
            six.Font = new Font("Segoe UI", 16F);
            six.Location = new Point(143, 301);
            six.Name = "six";
            six.Size = new Size(50, 47);
            six.TabIndex = 10;
            six.Text = "6";
            six.UseVisualStyleBackColor = true;
            // 
            // equ
            // 
            equ.FlatStyle = FlatStyle.System;
            equ.Font = new Font("Segoe UI", 16F);
            equ.Location = new Point(143, 429);
            equ.Name = "equ";
            equ.Size = new Size(50, 47);
            equ.TabIndex = 11;
            equ.Text = "=";
            equ.UseVisualStyleBackColor = true;
            equ.Click += equ_Click;
            // 
            // seven
            // 
            seven.FlatStyle = FlatStyle.System;
            seven.Font = new Font("Segoe UI", 16F);
            seven.Location = new Point(12, 365);
            seven.Name = "seven";
            seven.Size = new Size(50, 47);
            seven.TabIndex = 12;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = true;
            // 
            // eight
            // 
            eight.FlatStyle = FlatStyle.System;
            eight.Font = new Font("Segoe UI", 16F);
            eight.Location = new Point(78, 365);
            eight.Name = "eight";
            eight.Size = new Size(50, 47);
            eight.TabIndex = 13;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = true;
            // 
            // nine
            // 
            nine.FlatStyle = FlatStyle.System;
            nine.Font = new Font("Segoe UI", 16F);
            nine.Location = new Point(143, 365);
            nine.Name = "nine";
            nine.Size = new Size(50, 47);
            nine.TabIndex = 14;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            zero.FlatStyle = FlatStyle.System;
            zero.Font = new Font("Segoe UI", 16F);
            zero.Location = new Point(78, 429);
            zero.Name = "zero";
            zero.Size = new Size(50, 47);
            zero.TabIndex = 15;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            // 
            // drob
            // 
            drob.FlatStyle = FlatStyle.System;
            drob.Font = new Font("Segoe UI", 16F);
            drob.Location = new Point(12, 429);
            drob.Name = "drob";
            drob.Size = new Size(50, 47);
            drob.TabIndex = 16;
            drob.Text = ",";
            drob.UseVisualStyleBackColor = true;
            drob.Click += drob_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(247, 147);
            label1.TabIndex = 17;
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // memory
            // 
            memory.FlatStyle = FlatStyle.System;
            memory.Font = new Font("Segoe UI", 16F);
            memory.Location = new Point(209, 301);
            memory.Name = "memory";
            memory.Size = new Size(50, 47);
            memory.TabIndex = 18;
            memory.Text = "М";
            memory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 497);
            Controls.Add(memory);
            Controls.Add(label1);
            Controls.Add(drob);
            Controls.Add(zero);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            Controls.Add(equ);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(clear);
            Controls.Add(split);
            Controls.Add(mult);
            Controls.Add(minus);
            Controls.Add(plus);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Button plus;
        private Button minus;
        private Button mult;
        private Button split;
        private Button clear;
        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button equ;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button zero;
        private Button drob;
        private Label label1;
        private Button memory;
    }
}
