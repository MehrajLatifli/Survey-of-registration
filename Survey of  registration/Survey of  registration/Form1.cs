
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_of__registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void NametextBox1_MouseEnter(object sender, EventArgs e)
        {
            if (NametextBox1.Text == "Name")
            {
                NametextBox1.Text = null;
                NametextBox1.ForeColor = Color.Black;
            }
        }

        private void NametextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (NametextBox1.Text == "")
            {
                NametextBox1.Text = "Name";
                NametextBox1.ForeColor = Color.LightGray;
            }
        }

        private void SurnametextBox2_MouseEnter(object sender, EventArgs e)
        {
            if (SurnametextBox2.Text == "Surname")
            {
                SurnametextBox2.Text = null;
                SurnametextBox2.ForeColor = Color.Black;
            }


        }

        private void SurnametextBox2_MouseLeave(object sender, EventArgs e)
        {
            if (SurnametextBox2.Text == "")
            {
                SurnametextBox2.Text = "Surname";
                SurnametextBox2.ForeColor = Color.LightGray;
            }
        }

        private void FatherNametextBox3_MouseEnter(object sender, EventArgs e)
        {
            if (FatherNametextBox3.Text == "Your Father's name")
            {
                FatherNametextBox3.Text = null;
                FatherNametextBox3.ForeColor = Color.Black;
            }
        }

        private void FatherNametextBox3_MouseLeave(object sender, EventArgs e)
        {
            if (FatherNametextBox3.Text == "")
            {
                FatherNametextBox3.Text = "Your Father's name";
                FatherNametextBox3.ForeColor = Color.LightGray;
            }
        }

        private void SaveAS_MouseLeave(object sender, EventArgs e)
        {
            if (Saveastextbox4.Text == "")
            {
                Saveastextbox4.Text = "Save as";
                Saveastextbox4.ForeColor = Color.LightGray;
            }
        }

        private void SaveAS_MouseEnter(object sender, EventArgs e)
        {
            if (Saveastextbox4.Text == "Save as")
            {
                Saveastextbox4.Text = null;
                Saveastextbox4.ForeColor = Color.Black;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 

                List<Database> databases = new List<Database>();
        private void Savebutton1_Click(object sender, EventArgs e)
        {
            if (NametextBox1.Text == "Name" && SurnametextBox2.Text == "Surname" || FatherNametextBox3.Text == "Your Father's name")
            {

                MessageBox.Show("All sections must be completed");
            }
            else
            {

                if (SubbachelorcheckBox1.Checked)
                {
                    if (SubbachelorcheckBox1.Checked && MinusradioButton1.Checked)
                    {
                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} \n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname =SurnametextBox2.Text,
                                YourFatherName=FatherNametextBox3.Text,
                                DateTime= BithdaydateTimePicker1.Text,
                                EducationDegree =SubbachelorcheckBox1.Text,
                                WorkExperience =MinusradioButton1.Text

                            });

                            SavetoFile();
                     

                        


                        }

                        if (BachelorcheckBox2.Checked)
                        {
                            
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });

                            SavetoFile();


                        }

                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {MastercheckBox3.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";


                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {MastercheckBox3.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });

                            SavetoFile();
                        }


                        if (BachelorcheckBox2.Checked && MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            
                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text + BachelorcheckBox2, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text},{BachelorcheckBox2.Text},{MastercheckBox3.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });

                            SavetoFile();

                        }
                    }

                    if (SubbachelorcheckBox1.Checked && m13radioButton1.Checked)
                    {
                        if (SubbachelorcheckBox1.Checked)
                        {

                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} \n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = SubbachelorcheckBox1.Text,
                                WorkExperience = m13radioButton1.Text

                            });

                            SavetoFile();

                        }

                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                                databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree =$"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2}",
                                WorkExperience = m13radioButton1.Text

                            });

                            SavetoFile();
                    

                        }

                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {MastercheckBox3.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m13radioButton1.Text

                            });

                            SavetoFile();
                        }


                        if (BachelorcheckBox2.Checked && MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m13radioButton1.Text

                            });

                            SavetoFile();
                        }
                    }

                    if (SubbachelorcheckBox1.Checked && m35radioButton2.Checked)
                    {
                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} \n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";
                           
                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text , MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = SubbachelorcheckBox1.Text,
                                WorkExperience = m35radioButton2.Text

                            });

                            SavetoFile();
                        }

                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}\n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}",
                                WorkExperience = m35radioButton2.Text

                            });

                            SavetoFile();
                        }

                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {MastercheckBox3.Text}\n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m35radioButton2.Text

                            });

                            SavetoFile();
                        }


                        if (BachelorcheckBox2.Checked && MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";
                            
                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text + BachelorcheckBox2.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m35radioButton2.Text

                            });

                            SavetoFile();
                        }
                    }

                    if (SubbachelorcheckBox1.Checked && m5radioButton3.Checked)
                    {
                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} \n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text , MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = SubbachelorcheckBox1.Text,
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }

                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text} ",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }

                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {MastercheckBox3.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";


                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {MastercheckBox3.Text} ",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }


                        if (BachelorcheckBox2.Checked && MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}, {MastercheckBox3.Text} ",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }
                    }
                }

                if (BachelorcheckBox2.Checked)
                {
                    if (BachelorcheckBox2.Checked && MinusradioButton1.Checked)
                    {
                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} \n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text , MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = BachelorcheckBox2.Text,
                                WorkExperience = MinusradioButton1.Text

                            });
                            SavetoFile();
                        }

                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });
                            SavetoFile();
                        }

                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });
                            SavetoFile();
                        }


                        if (SubbachelorcheckBox1.Checked && MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text},{MastercheckBox3.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });
                            SavetoFile();
                        }
                    }

                    if (BachelorcheckBox2.Checked && m13radioButton1.Checked)
                    {
                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} \n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = BachelorcheckBox2.Text,
                                WorkExperience = m13radioButton1.Text

                            });
                            SavetoFile();
                        }

                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text + SubbachelorcheckBox1.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, { BachelorcheckBox2.Text }",
                                WorkExperience = m13radioButton1.Text

                            });
                            SavetoFile();
                        }

                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text + MastercheckBox3.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}, { MastercheckBox3.Text }",
                                WorkExperience = m13radioButton1.Text

                            });
                            SavetoFile();
                        }


                        if (SubbachelorcheckBox1.Checked && MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text + MastercheckBox3.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}, { MastercheckBox3.Text }",
                                WorkExperience = m13radioButton1.Text

                            });
                            SavetoFile();
                        }
                    }

                    if (BachelorcheckBox2.Checked && m35radioButton2.Checked)
                    {
                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} \n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text,  BachelorcheckBox2.Text , m35radioButton2.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}",
                                WorkExperience = m35radioButton2.Text

                            });
                            SavetoFile();
                        }

                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}\n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text, m35radioButton2.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}",
                                WorkExperience = m35radioButton2.Text

                            });
                            SavetoFile();
                        }

                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} , {MastercheckBox3.Text} \n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, MastercheckBox3.Text + BachelorcheckBox2.Text, m35radioButton2.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m35radioButton2.Text

                            });
                            SavetoFile();
                        }


                        if (SubbachelorcheckBox1.Checked && MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text + BachelorcheckBox2.Text, m35radioButton2.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m35radioButton2.Text

                            });
                            SavetoFile();
                        }
                    }

                    if (BachelorcheckBox2.Checked && m5radioButton3.Checked)
                    {
                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} \n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";
                        
                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text,  BachelorcheckBox2.Text , m5radioButton3.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }

                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text, m5radioButton3.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text}",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }

                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text + MastercheckBox3.Text, m5radioButton3.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text} , {MastercheckBox3.Text}",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }


                        if (SubbachelorcheckBox1.Checked && MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text + MastercheckBox3.Text, m5radioButton3.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }
                    }
                }

                if (MastercheckBox3.Checked)
                {
                    if (MastercheckBox3.Checked && MinusradioButton1.Checked)
                    {
                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {MastercheckBox3.Text} \n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{MastercheckBox3.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });
                            SavetoFile();
                        }

                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {MastercheckBox3.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1 + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {MastercheckBox3.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });
                            SavetoFile();
                        }

                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2 + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });
                            SavetoFile();
                        }


                        if (SubbachelorcheckBox1.Checked && BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {MinusradioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2 + MastercheckBox3.Text, MinusradioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text},{BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = MinusradioButton1.Text

                            });
                            SavetoFile();
                        }
                    }

                    if (MastercheckBox3.Checked && m13radioButton1.Checked)
                    {
                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {MastercheckBox3.Text} \n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, MastercheckBox3.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{MastercheckBox3.Text}",
                                WorkExperience = m13radioButton1.Text

                            });
                            SavetoFile();
                        }

                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {MastercheckBox3.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m13radioButton1.Text

                            });
                            SavetoFile();
                        }

                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text + MastercheckBox3.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m13radioButton1.Text

                            });
                            SavetoFile();
                        }


                        if (SubbachelorcheckBox1.Checked && BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m13radioButton1.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text + MastercheckBox3.Text, m13radioButton1.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m13radioButton1.Text

                            });
                            SavetoFile();
                        }
                    }

                    if (MastercheckBox3.Checked && m35radioButton2.Checked)
                    {
                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {MastercheckBox3.Text} \n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, MastercheckBox3.Text, m35radioButton2.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{MastercheckBox3.Text}",
                                WorkExperience = m35radioButton2.Text

                            });
                            SavetoFile();
                        }

                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {MastercheckBox3.Text}\n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text, m35radioButton2.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m35radioButton2.Text

                            });
                            SavetoFile();
                        }

                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text + MastercheckBox3.Text, m35radioButton2.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m35radioButton2.Text

                            });
                            SavetoFile();
                        }


                        if (SubbachelorcheckBox1.Checked && BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m35radioButton2.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text + MastercheckBox3.Text, m35radioButton2.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m35radioButton2.Text

                            });
                            SavetoFile();
                        }
                    }

                    if (MastercheckBox3.Checked && m5radioButton3.Checked)
                    {
                        if (MastercheckBox3.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {MastercheckBox3.Text} \n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, MastercheckBox3.Text, m5radioButton3.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{MastercheckBox3.Text}",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }

                        if (SubbachelorcheckBox1.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {MastercheckBox3.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + MastercheckBox3.Text, m5radioButton3.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }

                        if (BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, BachelorcheckBox2.Text + MastercheckBox3.Text, m5radioButton3.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }


                        if (SubbachelorcheckBox1.Checked && BachelorcheckBox2.Checked)
                        {
                            Viewlabel1.Text = $" {NametextBox1.Text} \n {SurnametextBox2.Text} \n {FatherNametextBox3.Text} \n {SubbachelorcheckBox1.Text} , {BachelorcheckBox2.Text} , {MastercheckBox3.Text}\n {m5radioButton3.Text} \n {BithdaydateTimePicker1.Text}";

                            databases.Add(new Database(NametextBox1.Text, SurnametextBox2.Text, FatherNametextBox3.Text, BithdaydateTimePicker1.Text, SubbachelorcheckBox1.Text + BachelorcheckBox2.Text + MastercheckBox3.Text, m5radioButton3.Text)
                            {
                                Name = NametextBox1.Text,
                                Surname = SurnametextBox2.Text,
                                YourFatherName = FatherNametextBox3.Text,
                                DateTime = BithdaydateTimePicker1.Text,
                                EducationDegree = $"{SubbachelorcheckBox1.Text},{BachelorcheckBox2.Text}, {MastercheckBox3.Text}",
                                WorkExperience = m5radioButton3.Text

                            });
                            SavetoFile();
                        }
                    }

                }

       

            



            }




             void SavetoFile()
            {
                var serializer = new JsonSerializer();
                using (var sw = new StreamWriter($"{Saveastextbox4.Text}.json", true))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, databases);
                    }
                }


                Database[] data = null;
                var serializer2 = new JsonSerializer();

                using (var sr = new StreamReader($"{Saveastextbox4.Text}.json"))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        data = serializer2.Deserialize<Database[]>(jr);
                    foreach (var item in databases)
                    {
                        ViewrichTextBox1.Text = $" \n {item.ID.ToString()} \n {item.Name} \n {item.Surname} \n {item.YourFatherName} \n {item.EducationDegree} \n{item.WorkExperience} \n{item.DateTime} \n";
                    }
                    }
                }
            }

        }


   
            void ViewFile()
            {
                Database[] data = null;
                var serializer2 = new JsonSerializer();

                using (var sr = new StreamReader($"{Saveastextbox4.Text}.json"))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        data = serializer2.Deserialize<Database[]>(jr);
                    }
                    foreach (var item in data)
                    {



                        ViewrichTextBox1.Text = $" \n {item.ID.ToString()} \n {item.Name} \n {item.Surname} \n {item.YourFatherName} \n {item.EducationDegree} \n{item.WorkExperience} \n{item.DateTime} \n";
                    }
                }
            }


        private void FieldtextBox1_Click(object sender, EventArgs e)
        {

            if (NametextBox1.Text != "Name" && SurnametextBox2.Text != "Surname" && FatherNametextBox3.Text != "Your Father's name" && NametextBox1.Text != "" && SurnametextBox2.Text != "" && FatherNametextBox3.Text != "" && NametextBox1.Text.Length >= 0 && SurnametextBox2.Text.Length >= 0 && FatherNametextBox3.Text.Length >= 0)
            {
                EducationDegreegroupBox1.Enabled = true;
            }

            if (NametextBox1.Text.Length <= 0 || SurnametextBox2.Text.Length <= 0 || FatherNametextBox3.Text.Length <= 0)
            {
                EducationDegreegroupBox1.Enabled = false;
            }
        }

     
    }
}
