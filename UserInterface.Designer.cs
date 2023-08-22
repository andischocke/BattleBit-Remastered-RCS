namespace BattleBit_Remastered_RCS
{
    partial class UserInterface
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
            WeaponListBox = new ListBox();
            GameGroupBox = new GroupBox();
            FieldOfViewLabel = new Label();
            SensitivityLabel = new Label();
            GameNameLabel = new Label();
            SensitivityNumericUpDown = new NumericUpDown();
            FieldOfViewNumericUpDown = new NumericUpDown();
            WeaponGroupBox = new GroupBox();
            FireRateLabel = new Label();
            VerticalRecoilLabel = new Label();
            WeaponNameLabel = new Label();
            VerticalRecoilNumericUpDown = new NumericUpDown();
            FireRateNumericUpDown = new NumericUpDown();
            SettingsGroupBox = new GroupBox();
            SmoothingLabel = new Label();
            RandomnessLabel = new Label();
            RandomnessNumericUpDown = new NumericUpDown();
            SmoothingNumericUpDown = new NumericUpDown();
            ActivationCheckBox = new CheckBox();
            GameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SensitivityNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FieldOfViewNumericUpDown).BeginInit();
            WeaponGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VerticalRecoilNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FireRateNumericUpDown).BeginInit();
            SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RandomnessNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SmoothingNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // WeaponListBox
            // 
            WeaponListBox.Dock = DockStyle.Left;
            WeaponListBox.FormattingEnabled = true;
            WeaponListBox.ItemHeight = 15;
            WeaponListBox.Location = new Point(0, 0);
            WeaponListBox.Name = "WeaponListBox";
            WeaponListBox.Size = new Size(120, 411);
            WeaponListBox.TabIndex = 1;
            WeaponListBox.SelectedIndexChanged += WeaponListBox_SelectedIndexChanged;
            // 
            // GameGroupBox
            // 
            GameGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            GameGroupBox.Controls.Add(FieldOfViewLabel);
            GameGroupBox.Controls.Add(SensitivityLabel);
            GameGroupBox.Controls.Add(GameNameLabel);
            GameGroupBox.Controls.Add(SensitivityNumericUpDown);
            GameGroupBox.Controls.Add(FieldOfViewNumericUpDown);
            GameGroupBox.Location = new Point(147, 12);
            GameGroupBox.Name = "GameGroupBox";
            GameGroupBox.Size = new Size(200, 100);
            GameGroupBox.TabIndex = 0;
            GameGroupBox.TabStop = false;
            GameGroupBox.Text = "Game";
            // 
            // FieldOfViewLabel
            // 
            FieldOfViewLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FieldOfViewLabel.AutoSize = true;
            FieldOfViewLabel.Location = new Point(6, 44);
            FieldOfViewLabel.Name = "FieldOfViewLabel";
            FieldOfViewLabel.Size = new Size(74, 15);
            FieldOfViewLabel.TabIndex = 0;
            FieldOfViewLabel.Text = "Field of View";
            // 
            // SensitivityLabel
            // 
            SensitivityLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SensitivityLabel.AutoSize = true;
            SensitivityLabel.Location = new Point(6, 73);
            SensitivityLabel.Name = "SensitivityLabel";
            SensitivityLabel.Size = new Size(60, 15);
            SensitivityLabel.TabIndex = 0;
            SensitivityLabel.Text = "Sensitivity";
            // 
            // GameNameLabel
            // 
            GameNameLabel.Dock = DockStyle.Top;
            GameNameLabel.Location = new Point(3, 19);
            GameNameLabel.Name = "GameNameLabel";
            GameNameLabel.Size = new Size(194, 15);
            GameNameLabel.TabIndex = 0;
            GameNameLabel.Text = "Game Name";
            GameNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SensitivityNumericUpDown
            // 
            SensitivityNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SensitivityNumericUpDown.Location = new Point(119, 71);
            SensitivityNumericUpDown.Name = "SensitivityNumericUpDown";
            SensitivityNumericUpDown.Size = new Size(75, 23);
            SensitivityNumericUpDown.TabIndex = 3;
            // 
            // FieldOfViewNumericUpDown
            // 
            FieldOfViewNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FieldOfViewNumericUpDown.Location = new Point(119, 42);
            FieldOfViewNumericUpDown.Name = "FieldOfViewNumericUpDown";
            FieldOfViewNumericUpDown.Size = new Size(75, 23);
            FieldOfViewNumericUpDown.TabIndex = 2;
            // 
            // WeaponGroupBox
            // 
            WeaponGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WeaponGroupBox.Controls.Add(FireRateLabel);
            WeaponGroupBox.Controls.Add(VerticalRecoilLabel);
            WeaponGroupBox.Controls.Add(WeaponNameLabel);
            WeaponGroupBox.Controls.Add(VerticalRecoilNumericUpDown);
            WeaponGroupBox.Controls.Add(FireRateNumericUpDown);
            WeaponGroupBox.Location = new Point(147, 118);
            WeaponGroupBox.Name = "WeaponGroupBox";
            WeaponGroupBox.Size = new Size(200, 100);
            WeaponGroupBox.TabIndex = 0;
            WeaponGroupBox.TabStop = false;
            WeaponGroupBox.Text = "Weapon";
            // 
            // FireRateLabel
            // 
            FireRateLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FireRateLabel.AutoSize = true;
            FireRateLabel.Location = new Point(6, 44);
            FireRateLabel.Name = "FireRateLabel";
            FireRateLabel.Size = new Size(52, 15);
            FireRateLabel.TabIndex = 0;
            FireRateLabel.Text = "Fire Rate";
            // 
            // VerticalRecoilLabel
            // 
            VerticalRecoilLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VerticalRecoilLabel.AutoSize = true;
            VerticalRecoilLabel.Location = new Point(6, 73);
            VerticalRecoilLabel.Name = "VerticalRecoilLabel";
            VerticalRecoilLabel.Size = new Size(80, 15);
            VerticalRecoilLabel.TabIndex = 0;
            VerticalRecoilLabel.Text = "Vertical Recoil";
            // 
            // WeaponNameLabel
            // 
            WeaponNameLabel.Dock = DockStyle.Top;
            WeaponNameLabel.Location = new Point(3, 19);
            WeaponNameLabel.Name = "WeaponNameLabel";
            WeaponNameLabel.Size = new Size(194, 15);
            WeaponNameLabel.TabIndex = 0;
            WeaponNameLabel.Text = "Weapon Name";
            WeaponNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VerticalRecoilNumericUpDown
            // 
            VerticalRecoilNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            VerticalRecoilNumericUpDown.DecimalPlaces = 2;
            VerticalRecoilNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 131072 });
            VerticalRecoilNumericUpDown.Location = new Point(119, 71);
            VerticalRecoilNumericUpDown.Name = "VerticalRecoilNumericUpDown";
            VerticalRecoilNumericUpDown.Size = new Size(75, 23);
            VerticalRecoilNumericUpDown.TabIndex = 5;
            // 
            // FireRateNumericUpDown
            // 
            FireRateNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FireRateNumericUpDown.Location = new Point(119, 42);
            FireRateNumericUpDown.Maximum = new decimal(new int[] { 1200, 0, 0, 0 });
            FireRateNumericUpDown.Name = "FireRateNumericUpDown";
            FireRateNumericUpDown.Size = new Size(75, 23);
            FireRateNumericUpDown.TabIndex = 4;
            // 
            // SettingsGroupBox
            // 
            SettingsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SettingsGroupBox.Controls.Add(SmoothingLabel);
            SettingsGroupBox.Controls.Add(RandomnessLabel);
            SettingsGroupBox.Controls.Add(RandomnessNumericUpDown);
            SettingsGroupBox.Controls.Add(SmoothingNumericUpDown);
            SettingsGroupBox.Location = new Point(147, 224);
            SettingsGroupBox.Name = "SettingsGroupBox";
            SettingsGroupBox.Size = new Size(200, 100);
            SettingsGroupBox.TabIndex = 0;
            SettingsGroupBox.TabStop = false;
            SettingsGroupBox.Text = "Settings";
            // 
            // SmoothingLabel
            // 
            SmoothingLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SmoothingLabel.AutoSize = true;
            SmoothingLabel.Location = new Point(6, 44);
            SmoothingLabel.Name = "SmoothingLabel";
            SmoothingLabel.Size = new Size(66, 15);
            SmoothingLabel.TabIndex = 0;
            SmoothingLabel.Text = "Smoothing";
            // 
            // RandomnessLabel
            // 
            RandomnessLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RandomnessLabel.AutoSize = true;
            RandomnessLabel.Location = new Point(6, 73);
            RandomnessLabel.Name = "RandomnessLabel";
            RandomnessLabel.Size = new Size(75, 15);
            RandomnessLabel.TabIndex = 0;
            RandomnessLabel.Text = "Randomness";
            // 
            // RandomnessNumericUpDown
            // 
            RandomnessNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RandomnessNumericUpDown.Location = new Point(119, 71);
            RandomnessNumericUpDown.Name = "RandomnessNumericUpDown";
            RandomnessNumericUpDown.Size = new Size(75, 23);
            RandomnessNumericUpDown.TabIndex = 7;
            // 
            // SmoothingNumericUpDown
            // 
            SmoothingNumericUpDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SmoothingNumericUpDown.Location = new Point(119, 42);
            SmoothingNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SmoothingNumericUpDown.Name = "SmoothingNumericUpDown";
            SmoothingNumericUpDown.Size = new Size(75, 23);
            SmoothingNumericUpDown.TabIndex = 6;
            SmoothingNumericUpDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // ActivationCheckBox
            // 
            ActivationCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ActivationCheckBox.Appearance = Appearance.Button;
            ActivationCheckBox.Location = new Point(147, 374);
            ActivationCheckBox.Name = "ActivationCheckBox";
            ActivationCheckBox.Size = new Size(200, 25);
            ActivationCheckBox.TabIndex = 8;
            ActivationCheckBox.Text = "Deactivated";
            ActivationCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            ActivationCheckBox.UseVisualStyleBackColor = true;
            ActivationCheckBox.CheckedChanged += ActivationCheckBox_CheckedChanged;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 411);
            Controls.Add(ActivationCheckBox);
            Controls.Add(SettingsGroupBox);
            Controls.Add(WeaponGroupBox);
            Controls.Add(GameGroupBox);
            Controls.Add(WeaponListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UserInterface";
            Text = "BBR-RCS";
            GameGroupBox.ResumeLayout(false);
            GameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SensitivityNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FieldOfViewNumericUpDown).EndInit();
            WeaponGroupBox.ResumeLayout(false);
            WeaponGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)VerticalRecoilNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FireRateNumericUpDown).EndInit();
            SettingsGroupBox.ResumeLayout(false);
            SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RandomnessNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SmoothingNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox WeaponListBox;
        private GroupBox GameGroupBox;
        private Label GameNameLabel;
        private NumericUpDown FieldOfViewNumericUpDown;
        private NumericUpDown SensitivityNumericUpDown;
        private Label FieldOfViewLabel;
        private Label SensitivityLabel;
        private GroupBox WeaponGroupBox;
        private Label FireRateLabel;
        private Label VerticalRecoilLabel;
        private Label WeaponNameLabel;
        private NumericUpDown VerticalRecoilNumericUpDown;
        private NumericUpDown FireRateNumericUpDown;
        private GroupBox SettingsGroupBox;
        private Label SmoothingLabel;
        private Label RandomnessLabel;
        private NumericUpDown RandomnessNumericUpDown;
        private NumericUpDown SmoothingNumericUpDown;
        private CheckBox ActivationCheckBox;
    }
}