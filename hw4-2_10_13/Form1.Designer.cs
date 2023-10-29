namespace hw4_2_10_13 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Farm_imgs = new ImageList(components);
            TabsContral = new TabControl();
            Farm = new TabPage();
            ToolChunk = new GroupBox();
            SickleBtn = new RadioButton();
            MuckBtn = new RadioButton();
            SeedBtn = new RadioButton();
            WaterBtn = new RadioButton();
            Shop = new TabPage();
            BuyBtn = new Button();
            FruitCheckBox = new CheckBox();
            MuckCheckBox = new CheckBox();
            SeedCheckBox = new CheckBox();
            FruitLabel = new Label();
            MuckLabel = new Label();
            SeedLabel = new Label();
            MoneyLabel = new Label();
            TabsContral.SuspendLayout();
            Farm.SuspendLayout();
            ToolChunk.SuspendLayout();
            Shop.SuspendLayout();
            SuspendLayout();
            // 
            // Farm_imgs
            // 
            Farm_imgs.ColorDepth = ColorDepth.Depth32Bit;
            Farm_imgs.ImageStream = (ImageListStreamer)resources.GetObject("Farm_imgs.ImageStream");
            Farm_imgs.TransparentColor = Color.Transparent;
            Farm_imgs.Images.SetKeyName(0, "dirt.jpeg");
            Farm_imgs.Images.SetKeyName(1, "seed.jpg");
            Farm_imgs.Images.SetKeyName(2, "crop.jpg");
            Farm_imgs.Images.SetKeyName(3, "watermelon.jpg");
            // 
            // TabsContral
            // 
            TabsContral.Controls.Add(Farm);
            TabsContral.Controls.Add(Shop);
            TabsContral.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TabsContral.Location = new Point(12, 12);
            TabsContral.Name = "TabsContral";
            TabsContral.SelectedIndex = 0;
            TabsContral.Size = new Size(560, 487);
            TabsContral.TabIndex = 0;
            // 
            // Farm
            // 
            Farm.Controls.Add(ToolChunk);
            Farm.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Farm.Location = new Point(4, 34);
            Farm.Name = "Farm";
            Farm.Padding = new Padding(3);
            Farm.Size = new Size(552, 449);
            Farm.TabIndex = 0;
            Farm.Text = "農場";
            Farm.UseVisualStyleBackColor = true;
            // 
            // ToolChunk
            // 
            ToolChunk.Controls.Add(SickleBtn);
            ToolChunk.Controls.Add(MuckBtn);
            ToolChunk.Controls.Add(SeedBtn);
            ToolChunk.Controls.Add(WaterBtn);
            ToolChunk.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ToolChunk.Location = new Point(356, 228);
            ToolChunk.Name = "ToolChunk";
            ToolChunk.Size = new Size(190, 215);
            ToolChunk.TabIndex = 0;
            ToolChunk.TabStop = false;
            ToolChunk.Text = "工具";
            // 
            // SickleBtn
            // 
            SickleBtn.AutoSize = true;
            SickleBtn.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SickleBtn.Location = new Point(16, 175);
            SickleBtn.Name = "SickleBtn";
            SickleBtn.Size = new Size(79, 34);
            SickleBtn.TabIndex = 3;
            SickleBtn.TabStop = true;
            SickleBtn.Text = "鐮刀";
            SickleBtn.UseVisualStyleBackColor = true;
            SickleBtn.Click += SickleBtn_Click;
            // 
            // MuckBtn
            // 
            MuckBtn.AutoSize = true;
            MuckBtn.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MuckBtn.Location = new Point(16, 130);
            MuckBtn.Name = "MuckBtn";
            MuckBtn.Size = new Size(79, 34);
            MuckBtn.TabIndex = 2;
            MuckBtn.TabStop = true;
            MuckBtn.Text = "肥料";
            MuckBtn.UseVisualStyleBackColor = true;
            MuckBtn.Click += MuckBtn_Click;
            // 
            // SeedBtn
            // 
            SeedBtn.AutoSize = true;
            SeedBtn.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SeedBtn.Location = new Point(16, 85);
            SeedBtn.Name = "SeedBtn";
            SeedBtn.Size = new Size(79, 34);
            SeedBtn.TabIndex = 1;
            SeedBtn.TabStop = true;
            SeedBtn.Text = "種子";
            SeedBtn.UseVisualStyleBackColor = true;
            SeedBtn.Click += SeedBtn_Click;
            // 
            // WaterBtn
            // 
            WaterBtn.AutoSize = true;
            WaterBtn.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            WaterBtn.Location = new Point(16, 40);
            WaterBtn.Name = "WaterBtn";
            WaterBtn.Size = new Size(103, 34);
            WaterBtn.TabIndex = 0;
            WaterBtn.TabStop = true;
            WaterBtn.Text = "澆水壺";
            WaterBtn.UseVisualStyleBackColor = true;
            WaterBtn.Click += WaterBtn_Click;
            // 
            // Shop
            // 
            Shop.Controls.Add(BuyBtn);
            Shop.Controls.Add(FruitCheckBox);
            Shop.Controls.Add(MuckCheckBox);
            Shop.Controls.Add(SeedCheckBox);
            Shop.Controls.Add(FruitLabel);
            Shop.Controls.Add(MuckLabel);
            Shop.Controls.Add(SeedLabel);
            Shop.Controls.Add(MoneyLabel);
            Shop.Location = new Point(4, 34);
            Shop.Name = "Shop";
            Shop.Padding = new Padding(3);
            Shop.Size = new Size(552, 449);
            Shop.TabIndex = 1;
            Shop.Text = "商店";
            Shop.UseVisualStyleBackColor = true;
            // 
            // BuyBtn
            // 
            BuyBtn.Location = new Point(230, 374);
            BuyBtn.Name = "BuyBtn";
            BuyBtn.Size = new Size(80, 35);
            BuyBtn.TabIndex = 7;
            BuyBtn.Text = "買/賣";
            BuyBtn.UseVisualStyleBackColor = true;
            BuyBtn.Click += BuyBtn_Click;
            // 
            // FruitCheckBox
            // 
            FruitCheckBox.AutoSize = true;
            FruitCheckBox.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            FruitCheckBox.Location = new Point(142, 294);
            FruitCheckBox.Name = "FruitCheckBox";
            FruitCheckBox.Size = new Size(88, 39);
            FruitCheckBox.TabIndex = 6;
            FruitCheckBox.Text = "果實";
            FruitCheckBox.UseVisualStyleBackColor = true;
            // 
            // MuckCheckBox
            // 
            MuckCheckBox.AutoSize = true;
            MuckCheckBox.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MuckCheckBox.Location = new Point(142, 208);
            MuckCheckBox.Name = "MuckCheckBox";
            MuckCheckBox.Size = new Size(88, 39);
            MuckCheckBox.TabIndex = 5;
            MuckCheckBox.Text = "肥料";
            MuckCheckBox.UseVisualStyleBackColor = true;
            // 
            // SeedCheckBox
            // 
            SeedCheckBox.AutoSize = true;
            SeedCheckBox.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SeedCheckBox.Location = new Point(142, 123);
            SeedCheckBox.Name = "SeedCheckBox";
            SeedCheckBox.Size = new Size(88, 39);
            SeedCheckBox.TabIndex = 4;
            SeedCheckBox.Text = "種子";
            SeedCheckBox.UseVisualStyleBackColor = true;
            // 
            // FruitLabel
            // 
            FruitLabel.AutoSize = true;
            FruitLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            FruitLabel.Location = new Point(308, 298);
            FruitLabel.Name = "FruitLabel";
            FruitLabel.Size = new Size(98, 35);
            FruitLabel.TabIndex = 3;
            FruitLabel.Text = "擁有: 0";
            // 
            // MuckLabel
            // 
            MuckLabel.AutoSize = true;
            MuckLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MuckLabel.Location = new Point(308, 212);
            MuckLabel.Name = "MuckLabel";
            MuckLabel.Size = new Size(98, 35);
            MuckLabel.TabIndex = 2;
            MuckLabel.Text = "擁有: 5";
            // 
            // SeedLabel
            // 
            SeedLabel.AutoSize = true;
            SeedLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SeedLabel.Location = new Point(308, 127);
            SeedLabel.Name = "SeedLabel";
            SeedLabel.Size = new Size(98, 35);
            SeedLabel.TabIndex = 1;
            SeedLabel.Text = "擁有: 5";
            // 
            // MoneyLabel
            // 
            MoneyLabel.AutoSize = true;
            MoneyLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MoneyLabel.Location = new Point(212, 39);
            MoneyLabel.Name = "MoneyLabel";
            MoneyLabel.Size = new Size(130, 35);
            MoneyLabel.TabIndex = 0;
            MoneyLabel.Text = "金錢: 100";
            MoneyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 511);
            Controls.Add(TabsContral);
            Name = "Form1";
            Text = "Form1";
            TabsContral.ResumeLayout(false);
            Farm.ResumeLayout(false);
            ToolChunk.ResumeLayout(false);
            ToolChunk.PerformLayout();
            Shop.ResumeLayout(false);
            Shop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList Farm_imgs;
        private TabControl TabsContral;
        private TabPage Farm;
        private TabPage Shop;
        private GroupBox ToolChunk;
        private RadioButton SickleBtn;
        private RadioButton MuckBtn;
        private RadioButton SeedBtn;
        private RadioButton WaterBtn;
        private Label MoneyLabel;
        private Label FruitLabel;
        private Label MuckLabel;
        private Label SeedLabel;
        private CheckBox MuckCheckBox;
        private CheckBox SeedCheckBox;
        private Button BuyBtn;
        private CheckBox FruitCheckBox;
    }
}