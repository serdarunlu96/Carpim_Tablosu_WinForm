namespace Carpim_Tablosu_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarpimTablosuYap();
        }

        private void CarpimTablosuYap()
        {
            for (int i = 1; i <= 5; i++)
            {
                object[] dizi = new object[5];
                for (int j = 1; j <= 5; j++)
                {
                    dizi[j - 1] = $" {i} * {j} = {i * j}";
                }
                dgvCarpim.Rows.Add(dizi);
            }
        }
    }
}