using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// What I Added //
using System.IO;//
//////////////////

/// <summary>
/// To Do:
///1. able to change text+links on the footer.
/// </summary>

namespace Click_To_Website
{
    // What Template Number is //
    //    1 = MDI Text Only    //
    //    2 =                  //
    //    3 =                  //
    //    4 =                  //
    //    5 =                  //
    //    6 =                  //
    //    7 =                  //
    //    8 =                  //
    //    9 =                  //
    //    10 =                 //
    /////////////////////////////

    public partial class Materialize_Setup : Form
    {
        //Itn's used to make sure everything have been completed
        public int TemplateUsed = 0;
        public int PagesFail = 0;
        public int Pages = 0;
        public int AllFilledIn = 0;
        public int R = 81;
        public int G = 45;
        public int B = 168;
        public int Paragraph1 = 0;
        public int Paragraph2 = 0;
        public int Paragraph3 = 0;
        public int Paragraph4 = 0;
        public int PagesDone = 0;

        #region Paragraph Content+Titles
        public string Paragraph1_Title_Pageone = "";
        public string Paragraph1_Content_Pageone = "";
        public string Paragraph2_Title_Pageone = "";
        public string Paragraph2_Content_Pageone = "";
        public string Paragraph3_Title_Pageone = "";
        public string Paragraph3_Content_Pageone = "";
        public string Paragraph4_Title_Pageone = "";
        public string Paragraph4_Content_Pageone = "";

        public string Paragraph1_Title_Pagetwo = "";
        public string Paragraph1_Content_Pagetwo = "";
        public string Paragraph2_Title_Pagetwo = "";
        public string Paragraph2_Content_Pagetwo = "";
        public string Paragraph3_Title_Pagetwo = "";
        public string Paragraph3_Content_Pagetwo = "";
        public string Paragraph4_Title_Pagetwo = "";
        public string Paragraph4_Content_Pagetwo = "";

        public string Paragraph1_Title_Pagethree = "";
        public string Paragraph1_Content_Pagethree = "";
        public string Paragraph2_Title_Pagethree = "";
        public string Paragraph2_Content_Pagethree = "";
        public string Paragraph3_Title_Pagethree = "";
        public string Paragraph3_Content_Pagethree = "";
        public string Paragraph4_Title_Pagethree = "";
        public string Paragraph4_Content_Pagethree = "";

        public string Paragraph1_Title_Pagefour = "";
        public string Paragraph1_Content_Pagefour = "";
        public string Paragraph2_Title_Pagefour = "";
        public string Paragraph2_Content_Pagefour = "";
        public string Paragraph3_Title_Pagefour = "";
        public string Paragraph3_Content_Pagefour = "";
        public string Paragraph4_Title_Pagefour = "";
        public string Paragraph4_Content_Pagefour = "";

        public string Content_List_Pageone = "";
        public string Content_List_Pagetwo = "";
        public string Content_List_Pagethree = "";
        public string Content_List_Pagefour = "";
        #endregion

        public Materialize_Setup()
        {
            InitializeComponent();
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            if (Website_Look_Ask.Visible && comboBox_Select_Template.Visible && Website_Picture.Visible == true)
            {
                if (comboBox_Select_Template.Text.Length >= 1)
                {
                    //Making what on the screen go away
                    Website_Look_Ask.Visible = false;
                    comboBox_Select_Template.Visible = false;
                    Website_Picture.Visible = false;
                    NavBar_preview.Visible = false;
                    Top_preview.Visible = false;
                    navbar_colour_Button.Visible = false;

                    if (comboBox_Select_Template.SelectedItem == "MDI Text Only")
                    {
                        //Making what I need to be on the screen... Well be on the screen!
                        TextBar_1.Visible = true;
                        TextBar_2.Visible = true;
                        TextBar_3.Visible = true;
                        Description_Ask.Visible = true;
                        Description_TextBox.Visible = true;
                        Title_Ask.Visible = true;
                        Title_TextBox.Visible = true;
                        Pages_Ask.Visible = true;
                        Pages_TextBox.Visible = true;
                        TemplateUsed = 1;

                        //Making evrything where it should be and resizing the form
                        Next_Button.Location = new Point(12, 135);
                        Next_Button.Size = new Size(215, 23);
                        this.Size = new Size(255, 210);
                    }
                    //Add else if(...) when starting another Template//
                }
                else
                {
                    MessageBox.Show("You need to choose a design that your website will end up being", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Description_Ask.Visible && Description_TextBox.Visible == true)
            {
                if (Description_TextBox.Text.Length == 0 && Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Put in a name for your Website and a description", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Description_TextBox.Text.Length == 0 && Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Put in a description", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Title_TextBox.Text.Length == 0 && Description_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Put in a name for your Website", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Making Number input into a int so it can be used by the program
                try
                {
                    if (Pages_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("You need to put in how much pages you what (as long it less then 4 pages)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        PagesFail = 1;
                    }
                    else
                    {
                        Pages = Convert.ToInt32(Pages_TextBox.Text);
                        PagesFail = 0;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Put in a (number) for how much pages you what", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PagesFail = 1;
                }
                catch (OverflowException)
                {
                    MessageBox.Show("THAT IS WAYYYYYYY TO MUCH PAGES!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PagesFail = 1;
                }

                if (PagesFail == 0)
                {
                    if (Pages >= 5)
                    {
                        MessageBox.Show("You can only do 4 pages (For now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Pages == 0 && Pages_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("You can't have no pages!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (Description_TextBox.Text.Length >= 1 && Title_TextBox.Text.Length >= 1)
                    {
                        //Taking stuff off the screen...
                        Description_Ask.Visible = false;
                        Description_TextBox.Visible = false;
                        Title_Ask.Visible = false;
                        Title_TextBox.Visible = false;
                        Pages_Ask.Visible = false;
                        Pages_TextBox.Visible = false;

                        //Seeing how much pages the user whats and changes to how much they what
                        if (Pages == 1)
                        {
                            TextBar_2.Visible = false;
                            TextBar_3.Visible = false;
                            Page1_Name_Ask.Visible = true;
                            Page1_Name_TextBox.Visible = true;
                            Next_Button.Location = new Point(12, 50);
                            this.Size = new Size(255, 120);
                        }
                        else if (Pages == 2)
                        {
                            TextBar_3.Visible = false;
                            Page1_Name_Ask.Visible = true;
                            Page1_Name_TextBox.Visible = true;
                            Page2_Name_Ask.Visible = true;
                            Page2_Name_TextBox.Visible = true;
                            Next_Button.Location = new Point(12, 95);
                            this.Size = new Size(255, 170);
                        }
                        else if (Pages == 3)
                        {
                            Page1_Name_Ask.Visible = true;
                            Page1_Name_TextBox.Visible = true;
                            Page2_Name_Ask.Visible = true;
                            Page2_Name_TextBox.Visible = true;
                            Page3_Name_Ask.Visible = true;
                            Page3_Name_TextBox.Visible = true;
                        }
                        else if (Pages == 4)
                        {
                            TextBar_4.Visible = true;
                            Page1_Name_Ask.Visible = true;
                            Page1_Name_TextBox.Visible = true;
                            Page2_Name_Ask.Visible = true;
                            Page2_Name_TextBox.Visible = true;
                            Page3_Name_Ask.Visible = true;
                            Page3_Name_TextBox.Visible = true;
                            Page4_Name_Ask.Visible = true;
                            Page4_Name_TextBox.Visible = true;
                            Next_Button.Location = new Point(12, 170);
                            this.Size = new Size(255, 240);
                        }
                    }
                }
            }
            else if (Page1_Name_TextBox.Visible == true && Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Visible == false && Page3_Name_TextBox.Visible == false && Page4_Name_TextBox.Visible == false)
            {
                Page1_Name_Ask.Visible = false;
                Page1_Name_TextBox.Visible = false;
                Paragraph_Ask_Firstpage.Visible = true;
                Paragraph_TextBox_Firstpage.Visible = true;
            }
            else if (Page1_Name_TextBox.Visible == true && Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Visible == true && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Visible == false && Page4_Name_TextBox.Visible == false)
            {
                this.Size = new Size(275, 170);
                Page1_Name_Ask.Visible = false;
                Page1_Name_TextBox.Visible = false;
                Page2_Name_Ask.Visible = false;
                Page2_Name_TextBox.Visible = false;
                Paragraph_Ask_Firstpage.Visible = true;
                Paragraph_TextBox_Firstpage.Visible = true;
                Paragraph_Ask_Secondpage.Visible = true;
                Paragraph_TextBox_Secondpage.Visible = true;
            }
            else if (Page1_Name_TextBox.Visible == true && Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Visible == true && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Visible == true && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Visible == false)
            {
                this.Size = new Size(275, 205);
                Page1_Name_Ask.Visible = false;
                Page1_Name_TextBox.Visible = false;
                Page2_Name_Ask.Visible = false;
                Page2_Name_TextBox.Visible = false;
                Page3_Name_Ask.Visible = false;
                Page3_Name_TextBox.Visible = false;
                Paragraph_Ask_Firstpage.Visible = true;
                Paragraph_TextBox_Firstpage.Visible = true;
                Paragraph_Ask_Secondpage.Visible = true;
                Paragraph_TextBox_Secondpage.Visible = true;
                Paragraph_Ask_Thirdpage.Visible = true;
                Paragraph_TextBox_Thirdpage.Visible = true;
            }
            else if (Page1_Name_TextBox.Visible == true && Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Visible == true && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Visible == true && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Visible == true && Page4_Name_TextBox.Text.Length >= 1)
            {
                this.Size = new Size(275, 240);
                Page1_Name_Ask.Visible = false;
                Page1_Name_TextBox.Visible = false;
                Page2_Name_Ask.Visible = false;
                Page2_Name_TextBox.Visible = false;
                Page3_Name_Ask.Visible = false;
                Page3_Name_TextBox.Visible = false;
                Page4_Name_Ask.Visible = false;
                Page4_Name_TextBox.Visible = false;
                Paragraph_Ask_Firstpage.Visible = true;
                Paragraph_TextBox_Firstpage.Visible = true;
                Paragraph_Ask_Secondpage.Visible = true;
                Paragraph_TextBox_Secondpage.Visible = true;
                Paragraph_Ask_Thirdpage.Visible = true;
                Paragraph_TextBox_Thirdpage.Visible = true;
                Paragraph_Ask_Fourthpage.Visible = true;
                Paragraph_TextBox_Fourthpage.Visible = true;
            }
            else if (Paragraph_Ask_Firstpage.Visible == true && Paragraph_TextBox_Firstpage.Visible == true && Paragraph_Ask_Secondpage.Visible == false)
            {
                try
                {
                    if (Paragraph_TextBox_Firstpage.Text.Length >= 1)
                    {
                        Paragraph1 = Convert.ToInt32(Paragraph_TextBox_Firstpage.Text);
                    }
                    if (Paragraph_TextBox_Firstpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1 == 0)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Paragraph_Ask_Firstpage.Visible = false;
                        Paragraph_TextBox_Firstpage.Visible = false;
                        if (Paragraph1 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                        }
                        if (Paragraph1 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                        }
                        if (Paragraph1 == 3)
                        {
                            this.Size = new Size(850, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Put in a number", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("THAT IS WAYYYYYYY TO MUCH PARAGRAPHS!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Paragraph_Ask_Firstpage.Visible == true && Paragraph_TextBox_Firstpage.Visible == true && Paragraph_Ask_Secondpage.Visible == true && Paragraph_TextBox_Thirdpage.Visible == false)
            {
                try
                {
                    if (Paragraph_TextBox_Firstpage.Text.Length >=1)
                    {
                        Paragraph1 = Convert.ToInt32(Paragraph_TextBox_Firstpage.Text);
                    }
                    if (Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        Paragraph2 = Convert.ToInt32(Paragraph_TextBox_Secondpage.Text);
                    }
                    if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page two", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one and two", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph2 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1 == 0)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph2 == 0)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Paragraph_Ask_Firstpage.Visible = false;
                        Paragraph_TextBox_Firstpage.Visible = false;
                        Paragraph_Ask_Secondpage.Visible = false;
                        Paragraph_TextBox_Secondpage.Visible = false;
                        TextBar_2.Visible = false;

                        if (Paragraph1 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                        }
                        if (Paragraph1 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                        }
                        if (Paragraph1 == 3)
                        {
                            this.Size = new Size(850, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Title_TextBox.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Put in a number", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("THAT IS WAYYYYYYY TO MUCH PARAGRAPHS!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Paragraph_Ask_Firstpage.Visible == true && Paragraph_TextBox_Firstpage.Visible == true && Paragraph_Ask_Secondpage.Visible == true && Paragraph_Ask_Thirdpage.Visible == true && Paragraph_TextBox_Firstpage.Visible == true && Paragraph_TextBox_Fourthpage.Visible == false)
            {
                try
                {
                    if (Paragraph_TextBox_Firstpage.Text.Length >= 1)
                    {
                        Paragraph1 = Convert.ToInt32(Paragraph_TextBox_Firstpage.Text);
                    }
                    if (Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        Paragraph2 = Convert.ToInt32(Paragraph_TextBox_Secondpage.Text);
                    }
                    if (Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        Paragraph3 = Convert.ToInt32(Paragraph_TextBox_Thirdpage.Text);
                    }
                    if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page two", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page second and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one and two", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one, two and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph2 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph3 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1 == 0 && Paragraph_TextBox_Firstpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph2 == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph3 == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Paragraph_Ask_Firstpage.Visible = false;
                        Paragraph_TextBox_Firstpage.Visible = false;
                        Paragraph_Ask_Secondpage.Visible = false;
                        Paragraph_TextBox_Secondpage.Visible = false;
                        TextBar_2.Visible = false;
                        TextBar_3.Visible = false;
                        Paragraph_Ask_Thirdpage.Visible = false;
                        Paragraph_TextBox_Thirdpage.Visible = false;

                        if (Paragraph1 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                        }
                        if (Paragraph1 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                        }
                        if (Paragraph1 == 3)
                        {
                            this.Size = new Size(850, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Put in a number", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("THAT IS WAYYYYYYY TO MUCH PARAGRAPHS!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Paragraph_Ask_Firstpage.Visible == true && Paragraph_TextBox_Firstpage.Visible == true && Paragraph_Ask_Secondpage.Visible == true && Paragraph_Ask_Thirdpage.Visible == true && Paragraph_TextBox_Firstpage.Visible == true && Paragraph_TextBox_Fourthpage.Visible == true)
            {
                try
                {
                    if (Paragraph_TextBox_Firstpage.Text.Length >= 1)
                    {
                        Paragraph1 = Convert.ToInt32(Paragraph_TextBox_Firstpage.Text);
                    }
                    if (Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        Paragraph2 = Convert.ToInt32(Paragraph_TextBox_Secondpage.Text);
                    }
                    if (Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        Paragraph3 = Convert.ToInt32(Paragraph_TextBox_Thirdpage.Text);
                    }
                    if (Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        Paragraph4 = Convert.ToInt32(Paragraph_TextBox_Fourthpage.Text);
                    }
                    if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page two", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page second and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one and two", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one, two and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one, two, three and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page three and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page two and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page two, three and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one, three and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one ,two and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page one ,two and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBox.Show("You need to tell be how much paragraphs you what in page four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph2 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph3 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph4 >= 4)
                    {
                        MessageBox.Show("You can't do more then 3 paragraphs (for now...)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1 == 0 && Paragraph_TextBox_Firstpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph2 == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph3 == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph4 == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBox.Show("You can't no paragraphs!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Paragraph_Ask_Firstpage.Visible = false;
                        Paragraph_TextBox_Firstpage.Visible = false;
                        Paragraph_Ask_Secondpage.Visible = false;
                        Paragraph_TextBox_Secondpage.Visible = false;
                        TextBar_2.Visible = false;
                        TextBar_3.Visible = false;
                        TextBar_4.Visible = false;
                        Paragraph_Ask_Thirdpage.Visible = false;
                        Paragraph_TextBox_Thirdpage.Visible = false;
                        Paragraph_Ask_Fourthpage.Visible = false;
                        Paragraph_TextBox_Fourthpage.Visible = false;

                        if (Paragraph1 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                        }
                        if (Paragraph1 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                        }
                        if (Paragraph1 == 3)
                        {
                            this.Size = new Size(850, 290);
                            Next_Button.Location = new Point(12, 217);
                            Next_Button.Size = new Size(260, 23);
                            Paragraph1_Title_Ask.Visible = true;
                            Paragraph1_Title_TextBox.Visible = true;
                            Paragraph1_Content_Ask.Visible = true;
                            Paragraph1_Content_TextBox.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Put in a number", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("THAT IS WAYYYYYYY TO MUCH PARAGRAPHS!", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Paragraph1_Content_Ask.Visible == true && Paragraph1_Content_TextBox.Visible == true && Paragraph2_Content_Ask.Visible == false)
            {
                if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title and the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Fill in the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Pages == 2 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 2 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                    <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 3 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 3 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph3 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else if (Paragraph3 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 3 && PagesDone == 2)
                    {
                        Paragraph1_Title_Pagethree = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagethree = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagethree = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagethree = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagethree = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagethree = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                    <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        Content_List_Pagethree =
"                <a href =\"#" + Paragraph1_Title_Pagethree.Replace(" ", " ").ToLower() + "1_3\">" + Paragraph1_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagethree.Replace(" ", " ").ToLower() + "2_3\">" + Paragraph2_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_3\">" + Paragraph3_Title_Pagethree.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 4 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph3 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else if (Paragraph3 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 2)
                    {
                        Paragraph1_Title_Pagethree = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagethree = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagethree = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagethree = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagethree = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagethree = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph4 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                        else if (Paragraph4 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph2_Title_TextBox.Visible = true;
                            Paragraph2_Content_TextBox.Visible = true;
                            Paragraph2_Title_Ask.Visible = true;
                            Paragraph2_Content_Ask.Visible = true;
                            TextBar_2.Visible = true;
                            TextBar_2.Location = new Point(280, 38);
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 3)
                    {
                        Paragraph1_Title_Pagefour = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagefour = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagefour = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagefour = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagefour = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagefour = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        Content_List_Pagethree =
"                <a href =\"#" + Paragraph1_Title_Pagethree.Replace(" ", " ").ToLower() + "1_3\">" + Paragraph1_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagethree.Replace(" ", " ").ToLower() + "2_3\">" + Paragraph2_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_3\">" + Paragraph3_Title_Pagethree.Replace(" ", " ") + "</a>";

                        Content_List_Pagefour =
"                <a href =\"#" + Paragraph1_Title_Pagefour.Replace(" ", " ").ToLower() + "1_4\">" + Paragraph1_Title_Pagefour.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagefour.Replace(" ", " ").ToLower() + "2_4\">" + Paragraph2_Title_Pagefour.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagefour.Replace(" ", " ").ToLower() + "3_4\">" + Paragraph3_Title_Pagefour.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 1 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();
                    }
                    else
                    {
                        Paragraph1_Title_Ask.Visible = false;
                        Paragraph1_Title_TextBox.Visible = false;
                        Paragraph1_Content_Ask.Visible = false;
                        Paragraph1_Content_TextBox.Visible = false;
                        TextBar_1.Visible = false;

                        ios_png_ask.Visible = true;
                        ios_png_button.Visible = true;
                        android_png_ask.Visible = true;
                        android_png_button.Visible = true;
                        favicon_png_ask.Visible = true;
                        favicon_png_button.Visible = true;
                        Next_Button.Text = "Make your Website!";
                        //Making evrything where it should be and resizing the form
                        Next_Button.Location = new Point(12, 135);
                        Next_Button.Size = new Size(215, 23);
                        this.Size = new Size(255, 210);
                    }
                }
            }
            else if (Paragraph1_Content_Ask.Visible == true && Paragraph1_Content_TextBox.Visible == true && Paragraph2_Content_Ask.Visible == true && Paragraph2_Title_Ask.Visible == true && Paragraph3_Content_Ask.Visible == false)
            {
                if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Fill in the title and the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Fill in the title for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Fill in the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title and the content for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Fill in the content for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title and the content for the first and second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title and the content of the second paragraph and the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Fill in the title and the content for the first paragraph and the content for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title and the content for the second paragraph and the title for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title and the content for the first paragraph and the title for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Fill in the title for the first paragraph and the content for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title for the second paragraph and the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("Fill in the title for the first and second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("Fill in the content for the first and second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (Pages == 2 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 2 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                    <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 3 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 3 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph3 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else if (Paragraph3 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 3 && PagesDone == 2)
                    {
                        Paragraph1_Title_Pagethree = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagethree = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagethree = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagethree = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagethree = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagethree = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                    <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        Content_List_Pagethree =
"                <a href =\"#" + Paragraph1_Title_Pagethree.Replace(" ", " ").ToLower() + "1_3\">" + Paragraph1_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagethree.Replace(" ", " ").ToLower() + "2_3\">" + Paragraph2_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_3\">" + Paragraph3_Title_Pagethree.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 4 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph3 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else if (Paragraph3 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 2)
                    {
                        Paragraph1_Title_Pagethree = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagethree = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagethree = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagethree = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagethree = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagethree = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph4 == 3)
                        {
                            this.Size = new Size(840, 290);
                            Paragraph3_Title_TextBox.Visible = true;
                            Paragraph3_Content_TextBox.Visible = true;
                            Paragraph3_Title_Ask.Visible = true;
                            Paragraph3_Content_Ask.Visible = true;
                            TextBar_3.Visible = true;
                            TextBar_3.Location = new Point(550, 38);
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                        else if (Paragraph4 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 3)
                    {
                        Paragraph1_Title_Pagefour = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagefour = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagefour = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagefour = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagefour = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagefour = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        Content_List_Pagethree =
"                <a href =\"#" + Paragraph1_Title_Pagethree.Replace(" ", " ").ToLower() + "1_3\">" + Paragraph1_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagethree.Replace(" ", " ").ToLower() + "2_3\">" + Paragraph2_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_3\">" + Paragraph3_Title_Pagethree.Replace(" ", " ") + "</a>";

                        Content_List_Pagefour =
"                <a href =\"#" + Paragraph1_Title_Pagefour.Replace(" ", " ").ToLower() + "1_4\">" + Paragraph1_Title_Pagefour.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagefour.Replace(" ", " ").ToLower() + "2_4\">" + Paragraph2_Title_Pagefour.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagefour.Replace(" ", " ").ToLower() + "3_4\">" + Paragraph3_Title_Pagefour.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 1 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();
                    }
                    else
                    {
                        Paragraph1_Title_Ask.Visible = false;
                        Paragraph1_Title_TextBox.Visible = false;
                        Paragraph1_Content_Ask.Visible = false;
                        Paragraph1_Content_TextBox.Visible = false;
                        TextBar_1.Visible = false;
                        Paragraph2_Title_Ask.Visible = false;
                        Paragraph2_Title_TextBox.Visible = false;
                        Paragraph2_Content_Ask.Visible = false;
                        Paragraph2_Content_TextBox.Visible = false;
                        TextBar_2.Visible = false;

                        ios_png_ask.Visible = true;
                        ios_png_button.Visible = true;
                        android_png_ask.Visible = true;
                        android_png_button.Visible = true;
                        favicon_png_ask.Visible = true;
                        favicon_png_button.Visible = true;
                        Next_Button.Text = "Make your Website!";
                        //Making evrything where it should be and resizing the form
                        Next_Button.Location = new Point(12, 135);
                        Next_Button.Size = new Size(215, 23);
                        this.Size = new Size(255, 210);
                    }
                }
            }
            else if (Paragraph1_Content_Ask.Visible == true && Paragraph1_Content_TextBox.Visible == true && Paragraph2_Content_Ask.Visible == true && Paragraph2_Title_Ask.Visible == true && Paragraph3_Content_Ask.Visible == true && Paragraph3_Title_Ask.Visible == true)
            {
                    if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and the content for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and the content for the first and second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and the content for the second paragraph and the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and the content for the first paragraph and the content for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and the content for the second paragraph and the title for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and the content for the first paragraph and the title for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title for the first paragraph and the content for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title for the second paragraph and the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title for the first and second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the first and second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content and title for the first, second and third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content and title for the second and third paragraph and fill in the content for the first paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content and title for the second and third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content and title for the third paragraph and just the content of the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content and title for the third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the first and third paragraph and the title for the second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content for the second paragraph and the title for the first and third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content for the first and second paragraph and the title for the third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content for the first paragraph and the title for the third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the first and third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content for the first paragraph and the title and content for the third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title and content for the third paragraph and fill in the content for the first and second paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the first, second and third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content for the first paragraph, fill in the title for the second paragraph and fill the title and content third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the second paragraph and fill in the title and content for the third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title for the second paragraph and fill in the content for the third paragraph", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the first paragraph and fill in the title and content for the second and third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the second paragraph and fill in the title and content for the first and third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content for the second paragraph and fill in the title and content for the first and third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the third paragraph and fill in the title and content for the first and second paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the third paragraph and fill in the title and content for the first and second paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the third paragraph, fill in the content for the first paragraph and fill in the title and content for the second paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title for the first and third paragraph and fill in the title and content for the second paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the first and second paragraph and fill in the title and content for the third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the first paragraph ,fill in the content for the second paragraph and fill in the title and content for the third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the first and third paragraph and fill in the title and content for the second paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title for the first paragraph ,fill in the title and content for the second paragraph and fill in the content for the third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the third paragraph ,fill in the title and content for the first paragraph and fill in the content for the second paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title and content for the first and third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and content for the first paragraph and fill in the content for the second and third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title and content for the first paragraph and fill in the title for the second and third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and content for the first paragraph ,fill in the title for the second paragraph and fill in the content for the third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the title and content for the second paragraph and fill in the content for the third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title and content for the second paragraph and fill in the title for the third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content for the second paragraph and fill in the title for the second and third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title and content for the third paragraph and fill in the title for the first paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the second and third paragraph and fill in the title for the first paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for all the paragraphs");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the title for the third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Fill in the content for the second paragraph and fill in the title for the third paragraph");
                    }
                    else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                    {
                        MessageBox.Show("Fill in the content for the second and third paragraph");
                    }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {

                    if (Pages == 2 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 2 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                    <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";
                        
                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 3 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        { 
                        MessageBox.Show("Now input the content for the second page");
                        PagesDone++;
                        }
                    }
                    else if (Pages == 3 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph3 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else if (Paragraph3 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 3 && PagesDone == 2)
                    {
                        Paragraph1_Title_Pagethree = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagethree = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagethree = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagethree = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagethree = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagethree = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                    <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        Content_List_Pagethree =
"                <a href =\"#" + Paragraph1_Title_Pagethree.Replace(" ", " ").ToLower() + "1_3\">" + Paragraph1_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagethree.Replace(" ", " ").ToLower() + "2_3\">" + Paragraph2_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_3\">" + Paragraph3_Title_Pagethree.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 4 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph2 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else if (Paragraph2 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 1)
                    {
                        Paragraph1_Title_Pagetwo = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagetwo = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagetwo = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagetwo = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagetwo = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagetwo = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph3 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else if (Paragraph3 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 2)
                    {
                        Paragraph1_Title_Pagethree = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagethree = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagethree = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagethree = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagethree = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagethree = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        if (Paragraph4 == 2)
                        {
                            this.Size = new Size(570, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                        else if (Paragraph4 == 1)
                        {
                            this.Size = new Size(300, 290);
                            Paragraph3_Title_TextBox.Visible = false;
                            Paragraph3_Content_TextBox.Visible = false;
                            Paragraph3_Title_Ask.Visible = false;
                            Paragraph3_Content_Ask.Visible = false;
                            Paragraph2_Title_TextBox.Visible = false;
                            Paragraph2_Content_TextBox.Visible = false;
                            Paragraph2_Title_Ask.Visible = false;
                            Paragraph2_Content_Ask.Visible = false;
                            TextBar_3.Visible = false;
                            TextBar_2.Visible = false;
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the fourth page");
                            PagesDone++;
                        }
                    }
                    else if (Pages == 4 && PagesDone == 3)
                    {
                        Paragraph1_Title_Pagefour = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pagefour = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pagefour = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pagefour = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pagefour = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pagefour = Paragraph3_Content_TextBox.Text.ToString();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        Content_List_Pagetwo =
"                <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        Content_List_Pagethree =
"                <a href =\"#" + Paragraph1_Title_Pagethree.Replace(" ", " ").ToLower() + "1_3\">" + Paragraph1_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagethree.Replace(" ", " ").ToLower() + "2_3\">" + Paragraph2_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_3\">" + Paragraph3_Title_Pagethree.Replace(" ", " ") + "</a>";

                        Content_List_Pagefour =
"                <a href =\"#" + Paragraph1_Title_Pagefour.Replace(" ", " ").ToLower() + "1_4\">" + Paragraph1_Title_Pagefour.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagefour.Replace(" ", " ").ToLower() + "2_4\">" + Paragraph2_Title_Pagefour.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagefour.Replace(" ", " ").ToLower() + "3_4\">" + Paragraph3_Title_Pagefour.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
                    }
                    else if (Pages == 1 && PagesDone == 0)
                    {
                        Paragraph1_Title_Pageone = Paragraph1_Title_TextBox.Text.ToString();
                        Paragraph1_Content_Pageone = Paragraph1_Content_TextBox.Text.ToString();
                        Paragraph2_Title_Pageone = Paragraph2_Title_TextBox.Text.ToString();
                        Paragraph2_Content_Pageone = Paragraph2_Content_TextBox.Text.ToString();
                        Paragraph3_Title_Pageone = Paragraph3_Title_TextBox.Text.ToString();
                        Paragraph3_Content_Pageone = Paragraph3_Content_TextBox.Text.ToString();

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();

                        Paragraph1_Title_TextBox.ResetText();
                        Paragraph1_Content_TextBox.ResetText();
                        Paragraph2_Title_TextBox.ResetText();
                        Paragraph2_Content_TextBox.ResetText();
                        Paragraph3_Title_TextBox.ResetText();
                        Paragraph3_Content_TextBox.ResetText();
                    }
                    else
                    {
                        Paragraph1_Title_Ask.Visible = false;
                        Paragraph1_Title_TextBox.Visible = false;
                        Paragraph1_Content_Ask.Visible = false;
                        Paragraph1_Content_TextBox.Visible = false;
                        TextBar_1.Visible = false;
                        Paragraph2_Title_Ask.Visible = false;
                        Paragraph2_Title_TextBox.Visible = false;
                        Paragraph2_Content_Ask.Visible = false;
                        Paragraph2_Content_TextBox.Visible = false;
                        TextBar_2.Visible = false;
                        Paragraph3_Title_Ask.Visible = false;
                        Paragraph3_Title_TextBox.Visible = false;
                        Paragraph3_Content_Ask.Visible = false;
                        Paragraph3_Content_TextBox.Visible = false;
                        TextBar_3.Visible = false;

                        ios_png_ask.Visible = true;
                        ios_png_button.Visible = true;
                        android_png_ask.Visible = true;
                        android_png_button.Visible = true;
                        favicon_png_ask.Visible = true;
                        favicon_png_button.Visible = true;
                        Next_Button.Text = "Make your Website!";
                        //Making evrything where it should be and resizing the form
                        Next_Button.Location = new Point(12, 135);
                        Next_Button.Size = new Size(215, 23);
                        this.Size = new Size(255, 210);
                    }
                }
            }
            else if (TemplateUsed == 1 && PagesFail == 0 && AllFilledIn == 1)
            {
                //Making Everything that user has put in into strings and starts to make the website!
                string DescriptionText = Description_TextBox.Text;
                string Description = "\"" + DescriptionText + "\"";
                string Title = Title_TextBox.Text;
                string TileColour = "#3372DF";
                string PageName1 = Page1_Name_TextBox.Text;
                string PageName2 = Page2_Name_TextBox.Text;
                string PageName3 = Page3_Name_TextBox.Text;
                string PageName4 = Page4_Name_TextBox.Text;
                string WebsiteNav = "";

                //Website Pages
                string[] Webpage =   {
"        <div class=\"mdl-layout__tab-panel\" id=\"" + PageName1.Replace(" ","").ToLower() + "_1" + "\">",
"          <section class=\"section--center mdl-grid mdl-grid--no-spacing\">",
"            <div class=\"mdl-cell mdl-cell--12-col\">",
"              <h4>"+PageName1.Replace(" ","") +"</h4>",
"              <p></p>",
"              <ul class=\"toc\">",
"                <h4>Contents of page</h4>",
Content_List_Pageone,
"              </ul>",
"              <h5 id=\""+ Paragraph1_Title_Pageone.Replace(" ", " ").ToLower()+ "1_1\">"+ Paragraph1_Title_Pageone.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph1_Content_Pageone.Replace(" ", " ").ToLower() +"</p>",
"              <h5 id=\""+ Paragraph2_Title_Pageone.Replace(" ", " ").ToLower()+ "2_1\">"+ Paragraph2_Title_Pageone.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph2_Content_Pageone.Replace(" ", " ") +"</p>",
"              <h5 id=\""+ Paragraph3_Title_Pageone.Replace(" ", " ").ToLower()+ "3_1\">"+ Paragraph3_Title_Pageone.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph3_Content_Pageone.Replace(" ", " ") +"</p>",
"            </div>",
"          </section>",
"        </div>",
};
                string[] Webpage2 = {
string.Join("",Webpage),
"        <div class=\"mdl-layout__tab-panel\" id=\"" + PageName2.Replace(" ","").ToLower() + "_2" + "\">",
"          <section class=\"section--center mdl-grid mdl-grid--no-spacing\">",
"            <div class=\"mdl-cell mdl-cell--12-col\">",
"              <ul class=\"toc\">",
"                <h4>Contents of page</h4>",
Content_List_Pagetwo,
"              </ul>",
"              <h5 id=\""+ Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower()+ "1_2\">"+ Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph1_Content_Pagetwo.Replace(" ", " ").ToLower() +"</p>",
"              <h5 id=\""+ Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower()+ "2_2\">"+ Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph2_Content_Pagetwo.Replace(" ", " ") +"</p>",
"              <h5 id=\""+ Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower()+ "3_2\">"+ Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph3_Content_Pagetwo.Replace(" ", " ") +"</p>",
"              <h5 id=\""+ Paragraph4_Title_Pagetwo.Replace(" ", " ").ToLower()+ "3_2\">"+ Paragraph4_Title_Pagetwo.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph4_Content_Pagetwo.Replace(" ", " ") +"</p>",
"            </div>",
"          </section>",
"        </div>",
};
                string[] Webpage3 = {
string.Join("",Webpage),
string.Join("",Webpage2),
"        <div class=\"mdl-layout__tab-panel\" id=\"" + PageName3.Replace(" ","").ToLower() + "_3" + "\">",
"          <section class=\"section--center mdl-grid mdl-grid--no-spacing\">",
"            <div class=\"mdl-cell mdl-cell--12-col\">",
"              <ul class=\"toc\">",
"                <h4>Contents of page</h4>",
Content_List_Pagethree,
"              </ul>",
"              <h5 id=\""+ Paragraph1_Title_Pagethree.Replace(" ", " ").ToLower()+ "1_3\">"+ Paragraph1_Title_Pagethree.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph1_Content_Pagethree.Replace(" ", " ").ToLower() +"</p>",
"              <h5 id=\""+ Paragraph2_Title_Pagethree.Replace(" ", " ").ToLower()+ "2_3\">"+ Paragraph2_Title_Pagethree.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph2_Content_Pagethree.Replace(" ", " ") +"</p>",
"              <h5 id=\""+ Paragraph3_Title_Pagethree.Replace(" ", " ").ToLower()+ "3_3\">"+ Paragraph3_Title_Pagethree.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph3_Content_Pagethree.Replace(" ", " ") +"</p>",
"              <h5 id=\""+ Paragraph4_Title_Pagethree.Replace(" ", " ").ToLower()+ "3_3\">"+ Paragraph4_Title_Pagethree.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph4_Content_Pagethree.Replace(" ", " ") +"</p>",
"            </div>",
"          </section>",
"        </div>",
};
                string[] Webpage4 = {
string.Join("",Webpage),
string.Join("",Webpage2),
string.Join("",Webpage3),
"        <div class=\"mdl-layout__tab-panel\" id=\"" + PageName4.Replace(" ","").ToLower() + "_4" + "\">",
"          <section class=\"section--center mdl-grid mdl-grid--no-spacing\">",
"            <div class=\"mdl-cell mdl-cell--12-col\">",
"              <ul class=\"toc\">",
"                <h4>Contents of page</h4>",
Content_List_Pagefour,
"              </ul>",
"              <h5 id=\""+ Paragraph1_Title_Pagefour.Replace(" ", " ").ToLower()+ "1_4\">"+ Paragraph1_Title_Pagefour.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph1_Content_Pagefour.Replace(" ", " ").ToLower() +"</p>",
"              <h5 id=\""+ Paragraph2_Title_Pagefour.Replace(" ", " ").ToLower()+ "2_4\">"+ Paragraph2_Title_Pagefour.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph2_Content_Pagefour.Replace(" ", " ") +"</p>",
"              <h5 id=\""+ Paragraph3_Title_Pagefour.Replace(" ", " ").ToLower()+ "3_4\">"+ Paragraph3_Title_Pagefour.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph3_Content_Pagefour.Replace(" ", " ") +"</p>",
"              <h5 id=\""+ Paragraph4_Title_Pagefour.Replace(" ", " ").ToLower()+ "3_4\">"+ Paragraph4_Title_Pagefour.Replace(" ", " ") + "</h5>",
"<p>" +Paragraph4_Content_Pagefour.Replace(" ", " ") +"</p>",
"            </div>",
"          </section>",
"        </div>",
};
                string[] DefaultPage = {
"        <div class=\"mdl-layout__tab-panel is-active\" id=\"default_page\">",
"          <section class=\"section--center mdl-grid mdl-grid--no-spacing mdl-shadow--2dp\">",
"            <header class=\"section__play-btn mdl-cell mdl-cell--3-col-desktop mdl-cell--2-col-tablet mdl-cell--4-col-phone mdl-color--teal-100 mdl-color-text--white\">",
"              <i class=\"material-icons\">play_circle_filled</i>",
"                </header>",
"                <div class=\"mdl-card mdl-cell mdl-cell--9-col-desktop mdl-cell--6-col-tablet mdl-cell--4-col-phone\">",
"                  <div class=\"mdl-card-supporting-text\">",
"                    <h4>Features</h4>",
"                Dolore ex deserunt aute fugiat aute nulla ea sunt aliqua nisi cupidatat eu. Nostrud in laboris labore nisi amet do dolor eu fugiat consectetur elit cillum esse.",
"             </div>",
"              <div class=\"mdl-card__actions\">",
"                <a href = \"#\" class=\"mdl-button\">Read our features</a>",
"              </div>",
"            </div>",
"            <button class=\"mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--icon\" id=\"btn1\">",
"              <i class=\"material-icons\">more_vert</i>",
"            </button>",
"            <ul class=\"mdl-menu mdl-js-menu mdl-menu--bottom-right\" for=\"btn1\">",
"              <li class=\"mdl-menu__item\">Lorem</li>",
"              <li class=\"mdl-menu__item\" disabled>Ipsum</li>",
"              <li class=\"mdl-menu__item\">Dolor</li>",
"            </ul>",
"          </section>",
"          <section class=\"section--center mdl-grid mdl-grid--no-spacing mdl-shadow--2dp\">",
"            <div class=\"mdl-card mdl-cell mdl-cell--12-col\">",
"              <div class=\"mdl-card__supporting-text mdl-grid mdl-grid--no-spacing\">",
"                <h4 class=\"mdl-cell mdl-cell--12-col\">Details</h4>",
"                <div class=\"section__circle-container mdl-cell mdl-cell--2-col mdl-cell--1-col-phone\">",
"                  <div class=\"section__circle-container__circle mdl-color--primary\"></div>",
"                </div>",
"                <div class=\"section__text mdl-cell mdl-cell--10-col-desktop mdl-cell--6-col-tablet mdl-cell--3-col-phone\">",
"                  <h5>Lorem ipsum dolor sit amet</h5>",
"                  Dolore ex deserunt aute fugiat aute nulla ea sunt aliqua nisi cupidatat eu.Duis nulla tempor do aute et eiusmod velit exercitation nostrud quis<a href=\"#\">proident minim</a>.",
"                </div>",
"                <div class=\"section__circle-container mdl-cell mdl-cell--2-col mdl-cell--1-col-phone\">",
"                  <div class=\"section__circle-container__circle mdl-color--primary\"></div>",
"                </div>",
"                <div class=\"section__text mdl-cell mdl-cell--10-col-desktop mdl-cell--6-col-tablet mdl-cell--3-col-phone\">",
"                  <h5>Lorem ipsum dolor sit amet</h5>",
"                  Dolore ex deserunt aute fugiat aute nulla ea sunt aliqua nisi cupidatat eu.Duis nulla tempor do aute et eiusmod velit exercitation nostrud quis<a href=\"#\">proident minim</a>.",
"                </div>",
"                <div class=\"section__circle-container mdl-cell mdl-cell--2-col mdl-cell--1-col-phone\">",
"                  <div class=\"section__circle-container__circle mdl-color--primary\"></div>",
"                </div>",
"                <div class=\"section__text mdl-cell mdl-cell--10-col-desktop mdl-cell--6-col-tablet mdl-cell--3-col-phone\">",
"                 <h5>Lorem ipsum dolor sit amet</h5>",
"                  Dolore ex deserunt aute fugiat aute nulla ea sunt aliqua nisi cupidatat eu.Duis nulla tempor do aute et eiusmod velit exercitation nostrud quis<a href=\"#\"> proident minim</a>.",
"                </div>",
"             </div>",
"              <div class=\"mdl-card__actions\">",
"                <a href=\"#\" class=\"mdl-button\">Read our features</a>",
"              </div>",
"            </div>",
"            <button class=\"mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--icon\" id=\"btn2\">",
"              <i class=\"material-icons\">more_vert</i>",
"            </button>",
"            <ul class=\"mdl-menu mdl-js-menu mdl-menu--bottom-right\" for=\"btn2\">",
"              <li class=\"mdl-menu__item\">Lorem</li>",
"              <li class=\"mdl-menu__item\" disabled>Ipsum</li>",
"              <li class=\"mdl-menu__item\">Dolor</li>",
"            </ul>",
"          </section>",
"          <section class=\"section--center mdl-grid mdl-grid--no-spacing mdl-shadow--2dp\">",
"            <div class=\"mdl-card mdl-cell mdl-cell--12-col\">",
"              <div class=\"mdl-card__supporting-text\">",
"                <h4>Technology</h4>",
"                Dolore ex deserunt aute fugiat aute nulla ea sunt aliqua nisi cupidatat eu.Nostrud in laboris labore nisi amet do dolor eu fugiat consectetur elit cillum esse.Pariatur occaecat nisi laboris tempor laboris eiusmod qui id Lorem esse commodo in. Exercitation aute dolore deserunt culpa consequat elit labore incididunt elit anim.",
"              </div>",
"              <div class=\"mdl-card__actions\">",
"                <a href=\"#\" class=\"mdl-button\">Read our features</a>",
"              </div>",
"            </div>",
"            <button class=\"mdl-button mdl-js-button mdl-js-ripple-effect mdl-button--icon\" id=\"btn3\">",
"              <i class=\"material-icons\">more_vert</i>",
"            </button>",
"            <ul class=\"mdl-menu mdl-js-menu mdl-menu--bottom-right\" for=\"btn3\">",
"              <li class=\"mdl-menu__item\">Lorem</li>",
"              <li class=\"mdl-menu__item\" disabled>Ipsum</li>",
"              <li class=\"mdl-menu__item\">Dolor</li>",
"            </ul>",
"          </section>",
"          <section class=\"section--footer mdl-color--white mdl-grid\">",
"            <div class=\"section__circle-container mdl-cell mdl-cell--2-col mdl-cell--1-col-phone\">",
"              <div class=\"section__circle-container__circle mdl-color--accent section__circle--big\"></div>",
"            </div>",
"            <div class=\"section__text mdl-cell mdl-cell--4-col-desktop mdl-cell--6-col-tablet mdl-cell--3-col-phone\">",
"              <h5>Lorem ipsum dolor sit amet</h5>",
"              Qui sint ut et qui nisi cupidatat.Reprehenderit nostrud proident officia exercitation anim et pariatur ex.",
"            </div>",
"            <div class=\"section__circle-container mdl-cell mdl-cell--2-col mdl-cell--1-col-phone\">",
"              <div class=\"section__circle-container__circle mdl-color--accent section__circle--big\"></div>",
"            </div>",
"            <div class=\"section__text mdl-cell mdl-cell--4-col-desktop mdl-cell--6-col-tablet mdl-cell--3-col-phone\">",
"              <h5>Lorem ipsum dolor sit amet</h5>",
"              Qui sint ut et qui nisi cupidatat.Reprehenderit nostrud proident officia exercitation anim et pariatur ex.",
"            </div>",
"          </section>",
"        </div>",
};

                #region pngs
                string android_desktop_loc = android_desktop_open.FileName;
                byte[] android_desktop_png_file = File.ReadAllBytes(android_desktop_loc);

                string favicon_loc = favicon_open.FileName;
                byte[] favicon_png_file = File.ReadAllBytes(favicon_loc);

                string ios_desktop_loc = ios_desktop_open.FileName;
                byte[] ios_desktop_png_file = File.ReadAllBytes(ios_desktop_loc);
                #endregion

                #region NavBar Changes
                //Making the nav bar change on how much pages they are
                if (Pages == 1)
                {
                    WebsiteNav = "<a href =\"#" + PageName1.Replace(" ", "").ToLower() + "_1" + "\" class=\"mdl-layout__tab\">" + PageName1 + "</a>";
                }
                else if (Pages == 2)
                {
                    WebsiteNav = 
                    "<a href =\"#" + PageName1.Replace(" ", "").ToLower() + "_1" + "\" class=\"mdl-layout__tab\">" + PageName1 + "</a>" +
                    "<a href =\"#" + PageName2.Replace(" ", "").ToLower() + "_2" + "\" class=\"mdl-layout__tab\">" + PageName2 + "</a>";
                    Webpage = Webpage2;
                }
                else if (Pages == 3)
                {
                    WebsiteNav = 
                    "<a href =\"#" + PageName1.Replace(" ", "").ToLower() + "_1" + "\" class=\"mdl-layout__tab\">" + PageName1 + "</a>" +
                    "<a href =\"#" + PageName2.Replace(" ", "").ToLower() + "_2" + "\" class=\"mdl-layout__tab\">" + PageName2 + "</a>" +
                    "<a href =\"#" + PageName3.Replace(" ", "").ToLower() + "_3" + "\" class=\"mdl-layout__tab\">" + PageName3 + "</a>";
                    Webpage = Webpage3;
                }
                else if (Pages == 4)
                {
                    WebsiteNav = 
                    "<a href =\"#" + PageName1.Replace(" ", "").ToLower() + "_1" + "\" class=\"mdl-layout__tab\">" + PageName1 + "</a>" +
                    "<a href =\"#" + PageName2.Replace(" ", "").ToLower() + "_2" + "\" class=\"mdl-layout__tab\">" + PageName2 + "</a>" +
                    "<a href =\"#" + PageName3.Replace(" ", "").ToLower() + "_3" + "\" class=\"mdl-layout__tab\">" + PageName3 + "</a>" +
                    "<a href =\"#" + PageName4.Replace(" ", "").ToLower() + "_4" + "\" class=\"mdl-layout__tab\">" + PageName4 + "</a>";
                    Webpage = Webpage4;
                }
                #endregion

                String[] MDI_Text_Only =
                {
"<!doctype html>",
"<!--",
"  Material Design Lite",
"  Copyright 2015 Google Inc. All rights reserved.",
"",
"  Licensed under the Apache License, Version 2.0 (the \"License\");",
"  you may not use this file except in compliance with the License.",
"  You may obtain a copy of the License at",
"",
"       https://www.apache.org/licenses/LICENSE-2.0",
"",
"  Unless required by applicable law or agreed to in writing, software",
"  distributed under the License is distributed on an \"AS IS\" BASIS,",
"  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.",
"  See the License for the specific language governing permissions and",
"  limitations under the License",
"-->",
"<html lang=\"en\">",
"  <head>",
"    <meta charset=\"utf-8\">",
"    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">",
"    <meta name=\"description\" content="+Description+">",
"    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, minimum-scale=1.0\">",
"    <title>"+Title+"</title>",
"",
"    <!-- Add to homescreen for Chrome on Android -->",
"    <meta name=\"mobile-web-app-capable\" content=\"yes\">",
"    <link rel=\"icon\" sizes=\"192x192\" href=\"images/android-desktop.png\">",
"",
"    <!-- Add to homescreen for Safari on iOS -->",
"    <meta name=\"apple-mobile-web-app-capable\" content=\"yes\">",
"    <meta name=\"apple-mobile-web-app-status-bar-style\" content=\"black\">",
"    <meta name=\"apple-mobile-web-app-title\" content=\""+Title+"\">",
"    <link rel=\"apple-touch-icon-precomposed\" href=\"images/ios-desktop.png\">",
"",
"   <!-- Tile icon for Win8 (144x144 + tile color) -->",
"    <meta name=\"msapplication-TileImage\" content=\"images/touch/ms-touch-icon-144x144-precomposed.png\">",
"    <meta name=\"msapplication-TileColor\" content=\""+TileColour+"\">",
"",
"    <link rel=\"shortcut icon\" href=\"images/favicon.png\">",
"",
"    <!-- SEO: If your mobile URL is different from the desktop URL, add a canonical link to the desktop page https://developers.google.com/webmasters/smartphone-sites/feature-phones -->",
"    <!--",
"    <link rel=\"canonical\" href=\"http://www.example.com/\">",
"    -->",
"",
"    <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Roboto:regular,bold,italic,thin,light,bolditalic,black,medium&amp;lang=en\">",
"    <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/icon?family=Material+Icons\">",
"    <link rel=\"stylesheet\" href=\"https://code.getmdl.io/1.3.0/material.deep_purple-pink.min.css\">",
"    <link rel=\"stylesheet\" href=\"styles.css\">",
"    <style>",
"    #view-source {",
"      position: fixed;",
"      display: block;",
"      right: 0;",
"      bottom: 0;",
"      margin-right: 40px;",
"      margin-bottom: 40px;",
"      z-index: 900;",
"    }",
//This lets me change the colour of the top and nav bar
"	.mdl-color--primary-dark",
"    {",
//Top
"    background-color: rgb("+(R-30)+","+(G-30)+","+(B-30)+") !important;",
"    }",
"	.mdl-color--primary",
"    {",
//Bar
"      background-color: rgb("+R+","+G+","+B+") !important;",
"    }",
//This lets me change the colour of the top and nav bar
"    </style>",
"      </head>",
"  <body class=\"mdl-demo mdl-color--grey-100 mdl-color-text--grey-700 mdl-base\">",
"    <div class=\"mdl-layout mdl-js-layout mdl-layout--fixed-header\">",
"      <header class=\"mdl-layout__header mdl-layout__header--scroll mdl-color--primary\">",
"        <div class=\"mdl-layout--large-screen-only mdl-layout__header-row\">",
"        </div>",
"       <div class=\"mdl-layout--large-screen-only mdl-layout__header-row\">",
"          <h3>"+Title+"</h3>",
"        </div>",
"        <div class=\"mdl-layout--large-screen-only mdl-layout__header-row\">",
"        </div>",
"        <div class=\"mdl-layout__tab-bar mdl-js-ripple-effect mdl-color--primary-dark\">",
         WebsiteNav, //Website Nav
"          <button class=\"mdl-button mdl-js-button mdl-button--fab mdl-js-ripple-effect mdl-button--colored mdl-shadow--4dp mdl-color--accent\" id=\"add\">",
"            <i class=\"material-icons\" role=\"presentation\">add</i>",
"            <span class=\"visuallyhidden\">Add</span>",
"         </button>",
"    </div>",
"    </header>",
"      <main class=\"mdl-layout__content\">",
string.Join("",Webpage),
string.Join("",DefaultPage),
"        <footer class=\"mdl-mega-footer\">",
"          <div class=\"mdl-mega-footer--middle-section\">",
"            <div class=\"mdl-mega-footer--drop-down-section\">",
"              <input class=\"mdl-mega-footer--heading-checkbox\" type=\"checkbox\" checked>",
"              <h1 class=\"mdl-mega-footer--heading\">Features</h1>",
"          <ul class=\"mdl-mega-footer--link-list\">",
"            <li><a href=\"#\">About</a></li>",
"            <li><a href=\"#\">Terms</a></li>",
"            <li><a href=\"#\">Partners</a></li>",
"            <li><a href=\"#\">Updates</a></li>",
"          </ul>",
"        </div>",
"        <div class=\"mdl-mega-footer--drop-down-section\">",
"          <input class=\"mdl-mega-footer--heading-checkbox\" type=\"checkbox\" checked>",
"          <h6 class=\"mdl-mega-footer--heading\">Details</h6>",
"          <ul class=\"mdl-mega-footer--link-list\">",
"            <li><a href=\"#\">Spec</a></li>",
"            <li><a href=\"#\">Tools</a></li>",
"            <li><a href=\"#\"> Resources</a></li>",
"          </ul>",
"        </div>",
"        <div class=\"mdl-mega-footer--drop-down-section\">",
"          <input class=\"mdl-mega-footer--heading-checkbox\" type=\"checkbox\" checked>",
"          <h6 class=\"mdl-mega-footer--heading\">Technology</h6>",
"          <ul class=\"mdl-mega-footer--link-list\">",
"            <li><a href=\"#\">How it works</a></li>",
"            <li><a href=\"#\">Patterns</a></li>",
"                <li><a href=\"#\">Usage</a></li>",
"                <li><a href=\"#\">Products</a></li>",
"                <li><a href=\"#\">Contracts</a></li>",
"              </ul>",
"            </div>",
"            <div class=\"mdl-mega-footer--drop-down-section\">",
"          <input class=\"mdl-mega-footer--heading-checkbox\" type=\"checkbox\" checked>",
"          <h6 class=\"mdl-mega-footer--heading\">FAQ</h6>",
"          <ul class=\"mdl-mega-footer--link-list\">",
"            <li><a href=\"#\">Questions</a></li>",
"            <li><a href=\"#\">Answers</a></li>",
"            <li><a href=\"#\">Contact us</a></li>",
"          </ul>",
"        </div>",
"      </div>",
"          <div class=\"mdl-mega-footer--bottom-section\">",
"            <div class=\"mdl-logo\">",
"              More Information",
"            </div>",
"            <ul class=\"mdl-mega-footer--link-list\">",
"              <li><a href=\"https://developers.google.com/web/starter-kit/ \">Web Starter Kit</a></li>",
"              <li><a href=\"https://github.com/google/material-design-lite/blob/mdl-1.x/templates/text-only/ \">View Source Code</a></li>",
"              <li><a href=\"#\">Help</a></li>",
"              <li><a href=\"#\">Privacy and Terms</a></li>",
"            </ul>",
"          </div>",
"        </footer>",
"      </main>",
"    </div>",
"    <script src=\"https://code.getmdl.io/1.3.0/material.min.js \"></script>",
"      </body>",
"    </html>",
};
                String[] MDI_Text_Only_CSS =
                {
"/**",
"* Copyright 2015 Google Inc. All Rights Reserved.",
"*",
"* Licensed under the Apache License, Version 2.0 (the \"License\");",
"* you may not use this file except in compliance with the License.",
"* You may obtain a copy of the License at",
"*",
"*      http://www.apache.org/licenses/LICENSE-2.0",
"*",
"* Unless required by applicable law or agreed to in writing, software",
"* distributed under the License is distributed on an \"AS IS\" BASIS,",
"* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.",
"* See the License for the specific language governing permissions and",
"* limitations under the License.",
"*/",
"",
"html, body {",
"  font-family: 'Roboto', 'Helvetica', sans-serif;",
"  margin: 0;",
"  padding: 0;",
"}",
".mdl-demo .mdl-layout__header-row {",
"  padding-left: 40px;",
"}",
".mdl-demo .mdl-layout.is-small-screen .mdl-layout__header-row h3 {",
"  font-size: inherit;",
"}",
".mdl-demo .mdl-layout__tab-bar-button {",
"  display: none;",
"}",
".mdl-demo .mdl-layout.is-small-screen .mdl-layout__tab-bar .mdl-button {",
"  display: none;",
"}",
".mdl-demo .mdl-layout:not(.is-small-screen) .mdl-layout__tab-bar,",
".mdl-demo .mdl-layout:not(.is-small-screen) .mdl-layout__tab-bar-container {",
"  overflow: visible;",
"}",
".mdl-demo .mdl-layout__tab-bar-container {",
"  height: 64px;",
"}",
".mdl-demo .mdl-layout__tab-bar {",
"  padding: 0;",
"  padding-left: 16px;",
"  box-sizing: border-box;",
"  height: 100%;",
"  width: 100%;",
"}",
".mdl-demo .mdl-layout__tab-bar .mdl-layout__tab {",
"  height: 64px;",
"  line-height: 64px;",
"}",
".mdl-demo .mdl-layout__tab-bar .mdl-layout__tab.is-active::after {",
"  background-color: white;",
"  height: 4px;",
"}",
".mdl-demo main > .mdl-layout__tab-panel {",
"  padding: 8px;",
"  padding-top: 48px;",
"}",
".mdl-demo .mdl-card {",
"  height: auto;",
"  display: -webkit-flex;",
"  display: -ms-flexbox;",
"  display: flex;",
"  -webkit-flex-direction: column;",
"  -ms-flex-direction: column;",
"  flex-direction: column;",
"}",
".mdl-demo .mdl-card > * {",
"  height: auto;",
"}",
".mdl-demo .mdl-card .mdl-card__supporting-text {",
"  margin: 40px;",
"  -webkit-flex-grow: 1;",
"  -ms-flex-positive: 1;",
"  flex-grow: 1;",
"  padding: 0;",
"  color: inherit;",
"  width: calc(100% - 80px);",
"}",
".mdl-demo.mdl-demo .mdl-card__supporting-text h4 {",
"  margin-top: 0;",
"  margin-bottom: 20px;",
"}",
".mdl-demo .mdl-card__actions {",
"  margin: 0;",
"  padding: 4px 40px;",
"  color: inherit;",
"}",
".mdl-demo .mdl-card__actions a {",
"  color: #00BCD4;",
"  margin: 0;",
"}",
".mdl-demo .mdl-card__actions a:hover,",
".mdl-demo .mdl-card__actions a:active {",
"  color: inherit;",
"  background-color: transparent;",
"}",
".mdl-demo .mdl-card__supporting-text + .mdl-card__actions {",
"  border-top: 1px solid rgba(0, 0, 0, 0.12);",
"}",
".mdl-demo #add {",
"  position: absolute;",
"  right: 40px;",
"  top: 36px;",
"  z-index: 999;",
"}",
"",
".mdl-demo .mdl-layout__content section:not(:last-of-type) {",
"  position: relative;",
"  margin-bottom: 48px;",
"}",
".mdl-demo section.section--center {",
"  max-width: 860px;",
"}",
".mdl-demo #features section.section--center {",
"  max-width: 620px;",
"}",
".mdl-demo section > header{",
"  display: -webkit-flex;",
"  display: -ms-flexbox;",
"  display: flex;",
"  -webkit-align-items: center;",
"  -ms-flex-align: center;",
"  align-items: center;",
"  -webkit-justify-content: center;",
"  -ms-flex-pack: center;",
"  justify-content: center;",
"}",
".mdl-demo section > .section__play-btn {",
"  min-height: 200px;",
"}",
".mdl-demo section > header > .material-icons {",
"  font-size: 3rem;",
"}",
".mdl-demo section > button {",
"  position: absolute;",
"  z-index: 99;",
"  top: 8px;",
"  right: 8px;",
"}",
".mdl-demo section .section__circle {",
"  display: -webkit-flex;",
"  display: -ms-flexbox;",
"  display: flex;",
"  -webkit-align-items: center;",
"  -ms-flex-align: center;",
"  align-items: center;",
"  -webkit-justify-content: flex-start;",
"  -ms-flex-pack: start;",
"  justify-content: flex-start;",
"  -webkit-flex-grow: 0;",
"  -ms-flex-positive: 0;",
"  flex-grow: 0;",
"  -webkit-flex-shrink: 1;",
"  -ms-flex-negative: 1;",
"  flex-shrink: 1;",
"}",
".mdl-demo section .section__text {",
"  -webkit-flex-grow: 1;",
"  -ms-flex-positive: 1;",
"  flex-grow: 1;",
"  -webkit-flex-shrink: 0;",
"  -ms-flex-negative: 0;",
"  flex-shrink: 0;",
"  padding-top: 8px;",
"}",
".mdl-demo section .section__text h5 {",
"  font-size: inherit;",
"  margin: 0;",
"  margin-bottom: 0.5em;",
"}",
".mdl-demo section .section__text a {",
"  text-decoration: none;",
"}",
".mdl-demo section .section__circle-container > .section__circle-container__circle {",
"  width: 64px;",
"  height: 64px;",
"  border-radius: 32px;",
"  margin: 8px 0;",
"}",
".mdl-demo section.section--footer .section__circle--big {",
"  width: 100px;",
"  height: 100px;",
"  border-radius: 50px;",
"  margin: 8px 32px;",
"}",
".mdl-demo .is-small-screen section.section--footer .section__circle--big {",
"  width: 50px;",
"  height: 50px;",
"  border-radius: 25px;",
"  margin: 8px 16px;",
"}",
".mdl-demo section.section--footer {",
"  padding: 64px 0;",
"  margin: 0 -8px -8px -8px;",
"}",
".mdl-demo section.section--center .section__text:not(:last-child) {",
"  border-bottom: 1px solid rgba(0,0,0,y.13);",
"}",
".mdl-demo .mdl-card .mdl-card__supporting-text > h3:first-child {",
"  margin-bottom: 24px;",
"}",
".mdl-demo .mdl-layout__tab-panel:not(#overview) {",
"  background-color: white;",
"}",
".mdl-demo #features section {",
"  margin-bottom: 72px;",
"}",
".mdl-demo #features h4, #features h5 {",
"  margin-bottom: 16px;",
"}",
".mdl-demo .toc {",
"  border-left: 4px solid #C1EEF4;",
"  margin: 24px;",
"  padding: 0;",
"  padding-left: 8px;",
"  display: -webkit-flex;",
"  display: -ms-flexbox;",
"  display: flex;",
"  -webkit-flex-direction: column;",
"  -ms-flex-direction: column;",
"  flex-direction: column;",
"}",
".mdl-demo .toc h4 {",
"  font-size: 0.9rem;",
"  margin-top: 0;",
"}",
".mdl-demo .toc a {",
"  color: #4DD0E1;",
"  text-decoration: none;",
"  font-size: 16px;",
"  line-height: 28px;",
"  display: block;",
"}",
".mdl-demo .mdl-menu__container {",
"  z-index: 99;",
"}",
};

                //Asking user where it what to be saved to
                Save_Website_Dialog.ShowDialog();
                if (Save_Website_Dialog.SelectedPath.Length >= 1)
                {
                    if (Directory.Exists(Save_Website_Dialog.SelectedPath))
                    {
                        File.WriteAllLines(Save_Website_Dialog.SelectedPath + @"\" + "index.html", MDI_Text_Only);
                        File.WriteAllLines(Save_Website_Dialog.SelectedPath + @"\" + "styles.css", MDI_Text_Only_CSS);
                        Directory.CreateDirectory(Save_Website_Dialog.SelectedPath + @"\images");
                        File.WriteAllBytes(Save_Website_Dialog.SelectedPath + @"\images\android_desktop.png", android_desktop_png_file);
                        File.WriteAllBytes(Save_Website_Dialog.SelectedPath + @"\images\ios_desktop.png", ios_desktop_png_file);
                        File.WriteAllBytes(Save_Website_Dialog.SelectedPath + @"\images\favicon.png", favicon_png_file);
                        MessageBox.Show($"Finished. Go to ({Save_Website_Dialog.SelectedPath}) to see your website (click on index.html not style.css)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Directory.CreateDirectory(Save_Website_Dialog.SelectedPath);
                        File.WriteAllLines(Save_Website_Dialog.SelectedPath + @"\" + "index.html", MDI_Text_Only);
                        File.WriteAllLines(Save_Website_Dialog.SelectedPath + @"\" + "styles.css", MDI_Text_Only_CSS);
                        Directory.CreateDirectory(Save_Website_Dialog.SelectedPath + "images");
                        Directory.CreateDirectory(Save_Website_Dialog.SelectedPath + @"\images");
                        File.WriteAllBytes(Save_Website_Dialog.SelectedPath + @"\images\android_desktop.png", android_desktop_png_file);
                        File.WriteAllBytes(Save_Website_Dialog.SelectedPath + @"\images\ios_desktop.png", ios_desktop_png_file);
                        File.WriteAllBytes(Save_Website_Dialog.SelectedPath + @"\images\favicon.png", favicon_png_file);
                        MessageBox.Show($"Finished. Go to ({Save_Website_Dialog.SelectedPath}) to see your website (click on index.html not style.css)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Couldn't make the Website (Did you not press a folder for it to go into?)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ios_png_ask.Visible && android_png_ask.Visible && favicon_png_ask.Visible == true)
            {
                if (got_file_ios.Visible && got_file_android.Visible && got_file_favicon.Visible == true)
                {
                    AllFilledIn = 1;
                    Next_Button.PerformClick();
                }
                else if (got_file_favicon.Visible && got_file_android.Visible == true)
                {
                    MessageBox.Show("put in a png for ios", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (got_file_favicon.Visible && got_file_ios.Visible == true)
                {
                    MessageBox.Show("put in a png for android", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (got_file_ios.Visible && got_file_android.Visible == true)
                {
                    MessageBox.Show("put in a png for PC", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (got_file_android.Visible == true)
                {
                    MessageBox.Show("put in a png for ios and PC", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (got_file_ios.Visible == true)
                {
                    MessageBox.Show("put in a png for PC and android", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (got_file_favicon.Visible == true)
                {
                    MessageBox.Show("put in a png for ios and android", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("put in a png for ios, android and PC", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Page1_Name_TextBox.Visible == true && Page2_Name_TextBox.Visible == false && Page1_Name_TextBox.Text.Length == 0)
            {
                MessageBox.Show("You need to put in a name for your first page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Page1_Name_TextBox.Visible == true && Page2_Name_TextBox.Visible == true && Page3_Name_TextBox.Visible == false && Page4_Name_TextBox.Visible == false)
            {
                if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your first page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for your second page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for your first and second page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Page1_Name_TextBox.Visible == true && Page2_Name_TextBox.Visible == true && Page3_Name_TextBox.Visible == true && Page4_Name_TextBox.Visible == false)
            {
                if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your first and second page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for your second and third page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for your first and third page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your second page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your first page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for your third page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for all your pages", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (Page1_Name_TextBox.Visible == true && Page2_Name_TextBox.Visible == true && Page3_Name_TextBox.Visible == true && Page4_Name_TextBox.Visible == true)
            {
                if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your first and second page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your second and third page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your first and third page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your second page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your first page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for your third page", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for all your pages", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for page two, three and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for page one, three and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for page one, two and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for page three and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for page two and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for page one, two and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBox.Show("You need to put in a name for page two and three", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for page one and four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBox.Show("You need to put in a name for page four", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void comboBox_Select_Template_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Select_Template.SelectedItem == "MDI Text Only")
            {
                this.Size = new Size(580, 290);
                Top_preview.BackColor = Color.FromArgb(R,G,B);
                NavBar_preview.BackColor = Color.FromArgb(R - 20, G - 20, B - 20);
                NavBar_preview.Visible = true;
                Top_preview.Visible = true;
                navbar_colour_Button.Visible = true;

                Website_Picture.BackgroundImage = global::Click_To_Website.Properties.Resources.MDI_Text_Only_Pic;
                Website_Picture.BorderStyle = BorderStyle.None;
            }
            //Add else if when adding new Template here
            else
            {
                NavBar_preview.Visible = false;
                Top_preview.Visible = false;
                navbar_colour_Button.Visible = false;

                Website_Picture.BackgroundImage = null;
                Website_Picture.BorderStyle = BorderStyle.FixedSingle;
                this.Size = new Size(300, 290);
            }
        }

        private void Materialize_Setup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ios_png_button_Click(object sender, EventArgs e)
        {
            ios_desktop_open.ShowDialog();
            if(ios_desktop_open.FileName.Length >= 1)
            {
                got_file_ios.Visible = true;
            }
            else
            {
                MessageBox.Show("Didn't get the image try again", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void android_png_button_Click(object sender, EventArgs e)
        {
            android_desktop_open.ShowDialog();
            if (android_desktop_open.FileName.Length >= 1)
            {
                got_file_android.Visible = true;
            }
            else
            {
                MessageBox.Show("Didn't get the image try again", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void favicon_png_button_Click(object sender, EventArgs e)
        {
            favicon_open.ShowDialog();
            if (favicon_open.FileName.Length >= 1)
            {
                got_file_favicon.Visible = true;
            }
            else
            {
                MessageBox.Show("Didn't get the image try again", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void navbar_colour_Button_Click(object sender, EventArgs e)
        {
            if (Navbar_colorDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    R = Navbar_colorDialog.Color.R;
                    G = Navbar_colorDialog.Color.G;
                    B = Navbar_colorDialog.Color.B;
                    //Where it can fail
                    NavBar_preview.BackColor = Color.FromArgb(R - 20, G - 20, B - 20);
                    //Where it can fail
                    Top_preview.BackColor = Color.FromArgb(R,G,B);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Colour too dark to use (red, blue and green at the bottom right need to be 20 and up)","Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}