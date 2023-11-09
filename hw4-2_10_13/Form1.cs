namespace hw4_2_10_13 {
    public partial class Form1 : Form {
        enum Tools { NONE, WATER, SEED, MUCK, SICKLE }
        Tools nowTool = Tools.NONE;
        MyBtn[,] fields = new MyBtn[3, 4];
        int[] stock = { 5, 5, 0 };
        int money = 100;

        public class MyBtn : Button {
            public bool watered { get; set; }
            public bool mucked { get; set; }
        }

        public Form1() {
            InitializeComponent();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    fields[i, j] = new MyBtn {
                        AutoSize = true,
                        Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                        Location = new Point(10 + 110 * i, 10 + 110 * j),
                        Name = $"Field{i}{j}",
                        Size = new Size(100, 100),
                        TabIndex = 0,
                        TabStop = true,
                        Text = "",
                        UseVisualStyleBackColor = true,
                        ImageList = Farm_imgs,
                        ImageIndex = 0,
                        watered = false,
                        mucked = false
                    };
                    fields[i, j].Click += Farm_Click;
                    Farm.Controls.Add(fields[i, j]);
                }
            }
        }

        private void Upgrade(MyBtn b) {
            b.ImageIndex++;
            b.watered = false; b.mucked = false;
        }

        private void Farm_Click(object sender, EventArgs e) {
            MyBtn tmp = (MyBtn)sender;
            switch (nowTool) {
            case Tools.WATER:
                if (Math.Abs(tmp.ImageIndex - 1.5) >= 1) break;
                tmp.watered = true;
                if (tmp.mucked) Upgrade(tmp);
                break;
            case Tools.SEED:
                if (tmp.ImageIndex != 0) break;
                if (stock[0] > 0) {
                    Upgrade(tmp);
                    stock[0]--;
                    SeedLabel.Text = $"擁有: {stock[0]}";
                }
                if (stock[0] == 0) MessageBox.Show("種子用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            case Tools.MUCK:
                if (Math.Abs(tmp.ImageIndex - 1.5) >= 1) break;
                if (!tmp.mucked && stock[1] > 0) {
                    tmp.mucked = true;
                    stock[1]--;
                    MuckLabel.Text = $"擁有: {stock[1]}";
                    if (tmp.watered) Upgrade(tmp);
                }
                if (stock[1] == 0) MessageBox.Show("肥料用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            case Tools.SICKLE:
                if (tmp.ImageIndex == 3) {
                    Upgrade(tmp);
                    tmp.ImageIndex = 0;
                    stock[2]++;
                    FruitLabel.Text = $"擁有: {stock[2]}";
                }
                break;
            default: break;
            }
        }

        private void WaterBtn_Click(object sender, EventArgs e) {
            nowTool = Tools.WATER;
        }

        private void SeedBtn_Click(object sender, EventArgs e) {
            nowTool = Tools.SEED;
        }

        private void MuckBtn_Click(object sender, EventArgs e) {
            nowTool = Tools.MUCK;
        }

        private void SickleBtn_Click(object sender, EventArgs e) {
            nowTool = Tools.SICKLE;
        }

        private void BuyBtn_Click(object sender, EventArgs e) {
            if (FruitCheckBox.Checked && stock[2] > 0) {
                stock[2]--; money += 40;
                FruitLabel.Text = $"擁有: {stock[2]}";
            }

            if (SeedCheckBox.Checked && money >= 10) {
                stock[0]++; money -= 10;
                SeedLabel.Text = $"擁有: {stock[0]}";
            }

            if (MuckCheckBox.Checked && money >= 10) {
                stock[1]++; money -= 10;
                MuckLabel.Text = $"擁有: {stock[1]}";
            }

            MoneyLabel.Text = $"金錢: {money}";
        }
    }
}