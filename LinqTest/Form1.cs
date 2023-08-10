using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LinqTest
{
    public partial class Form1 : Form
    {
        static private List<market> productList = new List<market>()
        {

            new market(){name="휴지", price=18000,rank=2,id=1},

            new market(){name="물티슈", price=2000,rank=6,id=2},

            new market(){name="가나초콜릿", price=1500,rank=8,id=3},

            new market(){name="서울우유", price=1000,rank=12,id=4},

            new market(){name="초코소라빵", price=1800,rank=16,id=5},

            new market(){name="하리보", price=2000,rank=13,id=6},

            new market(){name="기저귀", price=20000,rank=4,id=7},

            new market(){name="치약", price=3000,rank=11,id=8},

            new market(){name="생수", price=700,rank=1,id=9 },

            new market(){name="신라면", price=5000,rank=3,id=10 },

            new market(){name="햇반", price=2300,rank=7,id=11 },

            new market(){name="까르보불닭", price=1700,rank=19,id=12 },

            new market(){name="반팔", price=23000,rank=10,id=13 },

            new market(){name="생리대", price=6000,rank=5,id=14 },

            new market(){name="박스테이프", price=7900,rank=18,id=15 },

            new market(){name="머리끈", price=1000,rank=17,id=16 },

            new market(){name="포카리스웨트", price=1700,rank=15,id=17 },

            new market(){name="허니버터칩", price=1500,rank=14,id=18 },

            new market(){name="칫솔", price=4000,rank=9,id=19 },

            new market(){name="이어폰", price=2300,rank=20,id=20 }


        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            marketBindingSource.DataSource = productList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marketBindingSource.DataSource = productList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marketBindingSource.DataSource = from item in productList
                                          orderby item.name
                                          select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            marketBindingSource.DataSource = from item in productList
                                             orderby item.price ascending
                                             select item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            marketBindingSource.DataSource = from item in productList
                                             orderby item.price descending
                                             select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            marketBindingSource.DataSource = from item in productList
                                             orderby item.rank
                                             select item;
        }
    }
}
