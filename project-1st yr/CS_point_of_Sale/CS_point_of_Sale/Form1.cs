using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CS_point_of_Sale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Cost_of_items()
        {
            double sum = 0;
            int i = 0;
            for (i = 0; i < (dataGridView1.Rows.Count);
        i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;

        }

        private void addCost()
        {
            double tax, q;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                //label5.Text = String.Format("{0:c2}", (((Cost_of_items() * tax )/ 100)));
                label5.Text = String.Format(new CultureInfo("En-LK"),"{0:c2}", (((Cost_of_items() * tax) / 100)));
                label7.Text = String.Format(new CultureInfo("En-LK"), "{0:c2}", (Cost_of_items()));
                label7.Text = String.Format(new CultureInfo("En-LK"), "{0:c2}", (Cost_of_items()));
                q = ((Cost_of_items()*tax)/100);
                label6.Text = String.Format(new CultureInfo("En-LK"), "{0:c2}", ((Cost_of_items() + q)));
                label1.Text= Convert.ToString(q+ Cost_of_items());
            }
        }

        private void Change() {
            double tax, q,c ;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((Cost_of_items() * tax )/ 100)+Cost_of_items();
                c= Convert.ToInt32(label10.Text);
                label8.Text = String.Format(new CultureInfo("En-LK"), "{0:c2}", c - q); 
            }
        
        }


        Bitmap bitmap;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            double CostofItem = 360;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cheese loaf"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Cheese loaf", "1", CostofItem);
            addCost();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int height = dataGridView1.Height;
                    dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                    bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                    dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                    printPreviewDialog1.ShowDialog();
                    dataGridView1.Height = height;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
             try 
            {
               // e.Graphics.DrawImage(bitmap, 0, 0);
            }
        
        catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

        }

        private void button39_Click(object sender, EventArgs e)
        {
            try 
            {
                label1.Text="";
                label10.Text="0";
                label8.Text="";
                label7.Text="";
                label5.Text="";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                intvvv.Text="";
        }
        catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
}

        private void Form1_Load(object sender, EventArgs e)
        {
            intvvv.Items.Add("Cash");
            intvvv.Items.Add("Visa Card");
            intvvv.Items.Add("Master Card");
        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (label10.Text == "0")
            {
                label10.Text = "";
                    label10.Text=b.Text;
            }
            else if (b.Text == ".")
            {
                if (! label10.Text.Contains("."))
                {
                    label10.Text = label10.Text + b.Text;
                }
               
            }
            else

                label10.Text = label10.Text + b.Text;
        }

     public void button7_click(object sender, EventArgs e)
        {
           label10.Text = "0";
        }

     private void Form1_Load_1(object sender, EventArgs e)
     {

     }

     private void button37_Click(object sender, EventArgs e)
     {
         if (intvvv.Text == "Cash")
         {
             Change();
         }
         else
         {
             label8.Text = "";
             label10.Text = "0";
         }
     }

     private void button38_Click(object sender, EventArgs e)
     {
         foreach (DataGridViewRow row in this.dataGridView1.SelectedRows) {
             dataGridView1.Rows.Remove(row);
         }

         addCost();
         if (intvvv.Text == "Cash")
         {
             Change();
         }
         else
         {
             label8.Text = "";
             label10.Text = "0";
         }
     }

     private void label7_Click(object sender, EventArgs e)
     {

     }

     private void label5_Click(object sender, EventArgs e)
     {

     }

     private void button13_Click(object sender, EventArgs e)
     {
         double CostofItem = 100.3;
         foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
         {
             if ((bool)(row.Cells[0].Value ="Capp Coffee"))
             {
                row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value+1 )  ;
                row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem  ;
                
             }
         }
         dataGridView1.Rows.Add("Capp Coffee","1",CostofItem);
         addCost();
     }

     private void button14_Click(object sender, EventArgs e)
     {
         double CostofItem = 150;
         foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
         {
             if ((bool)(row.Cells[0].Value ="cappuccino"))
             {
                row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value+1 )  ;
                row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem  ;
                
             }
         }
         dataGridView1.Rows.Add("cappuccino","1",CostofItem);
         addCost();
     }

        

        private void button15_Click(object sender, EventArgs e)
        {
            double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "milkshake"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("milkshake", "1", CostofItem);
            addCost();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double CostofItem = 180;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Woo woo"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Woo woo", "1", CostofItem);
            addCost();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double CostofItem = 160;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "suncrush"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("suncrush", "1", CostofItem);
            addCost();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double CostofItem = 90;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Fanta"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Fanta", "1", CostofItem);
            addCost();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double CostofItem = 140;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "CocaCola"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("CocaCola", "1", CostofItem);
            addCost();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double CostofItem = 250;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Arepa"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Arepa", "1", CostofItem);
            addCost();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double CostofItem = 270;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Baguetee"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Baguetee", "1", CostofItem);
            addCost();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double CostofItem = 400;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Garlic Cheese Bread"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Garlic Cheese Bread", "1", CostofItem);
            addCost();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double CostofItem = 300;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cheese Bun"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Cheese Bun", "1", CostofItem);
            addCost();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double CostofItem = 250;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ham and Cheese sandwich"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Ham and Cheese sandwich", "1", CostofItem);
            addCost();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double CostofItem = 350;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Burger"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Burger", "1", CostofItem);
            addCost();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double CostofItem = 350;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cheese Pasta"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Cheese Pasta", "1", CostofItem);
            addCost();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            double CostofItem = 150;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pomegranate juice"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Pomegranate juice", "1", CostofItem);
            addCost();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            double CostofItem = 250;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pancit luglug"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Pancit luglug", "1", CostofItem);
            addCost();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            double CostofItem = 280;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Spicy noodless"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Spicy noodless", "1", CostofItem);
            addCost();

        }

        private void button35_Click(object sender, EventArgs e)
        {
            double CostofItem = 300;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ramen"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Ramen", "1", CostofItem);
            addCost();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double CostofItem = 400;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Hamburger and Macaroni"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Hamburger and Macaroni", "1", CostofItem);
            addCost();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double CostofItem = 430;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ground Beef Macaroni"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Ground Beef Macaroni", "1", CostofItem);
            addCost();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double CostofItem = 250;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Chicken fries"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Chicken fries", "1", CostofItem);
            addCost();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            double CostofItem = 340;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Thai burgers"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Thai burgers", "1", CostofItem);
            addCost();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double CostofItem = 430;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Smoky Aubergine Burger"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * CostofItem;

                }
            }
            dataGridView1.Rows.Add("Smoky Aubergine Burger", "1", CostofItem);
            addCost();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

     }


}

        

        
    
