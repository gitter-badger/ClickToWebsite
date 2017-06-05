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

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1_1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2_1\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "              <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_1\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

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

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
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

                        Content_List_Pageone =
"                <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

                        PagesDone++;
                        Next_Button.PerformClick();
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

                MDI_Text_Only[21] = MDI_Text_Only[21].Replace("<ADDDescription>", Description); 
                MDI_Text_Only[23] = MDI_Text_Only[23].Replace("<ADDTitle>", Title); 
                MDI_Text_Only[32] = MDI_Text_Only[32].Replace("<ADDTitle>", Title); 
                MDI_Text_Only[37] = MDI_Text_Only[37].Replace("<ADDTileColour>", TileColour); 

                MDI_Text_Only[62] = MDI_Text_Only[62].Replace("<ADDR-30>", Convert.ToString(R - 30)); 
                MDI_Text_Only[62] = MDI_Text_Only[62].Replace("<ADDG-30>", Convert.ToString(G - 30)); 
                MDI_Text_Only[62] = MDI_Text_Only[62].Replace("<ADDB-30>", Convert.ToString(B - 30)); 
                MDI_Text_Only[66] = MDI_Text_Only[66].Replace("<ADDR>", R.ToString()); 
                MDI_Text_Only[66] = MDI_Text_Only[66].Replace("<ADDG>", G.ToString());
                MDI_Text_Only[66] = MDI_Text_Only[66].Replace("<ADDB>", B.ToString());  
                MDI_Text_Only[76] = MDI_Text_Only[76].Replace("<ADDTitle>", Title); 
                MDI_Text_Only[89] = MDI_Text_Only[89].Replace("<ADDWebpage>", string.Join("",Webpage)); 
                MDI_Text_Only[90] = MDI_Text_Only[90].Replace("<ADDDefaultPage>", string.Join("",DefaultPage)); 

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
                    MDI_Text_Only[81] = MDI_Text_Only[81].Replace("<ADDWebsiteNav>", "<a href =\"#" + PageName1.Replace(" ", "").ToLower() + "_1" + "\" class=\"mdl-layout__tab\">" + PageName1 + "</a>");
                }
                else if (Pages == 2)
                {
                    MDI_Text_Only[81] = MDI_Text_Only[81].Replace("<ADDWebsiteNav>", "<a href =\"#" + PageName1.Replace(" ", "").ToLower() + "_1" + "\" class=\"mdl-layout__tab\">" + PageName1 + "</a>" +
                    "<a href =\"#" + PageName2.Replace(" ", "").ToLower() + "_2" + "\" class=\"mdl-layout__tab\">" + PageName2 + "</a>");
                    Webpage = Webpage2;
                }
                else if (Pages == 3)
                {
                    MDI_Text_Only[81] = MDI_Text_Only[81].Replace("<ADDWebsiteNav>",
                    "<a href =\"#" + PageName1.Replace(" ", "").ToLower() + "_1" + "\" class=\"mdl-layout__tab\">" + PageName1 + "</a>" +
                    "<a href =\"#" + PageName2.Replace(" ", "").ToLower() + "_2" + "\" class=\"mdl-layout__tab\">" + PageName2 + "</a>" +
                    "<a href =\"#" + PageName3.Replace(" ", "").ToLower() + "_3" + "\" class=\"mdl-layout__tab\">" + PageName3 + "</a>");
                    Webpage = Webpage3;
                }
                else if (Pages == 4)
                {
                    MDI_Text_Only[81] = MDI_Text_Only[81].Replace("<ADDWebsiteNav>",
                    "<a href =\"#" + PageName1.Replace(" ", "").ToLower() + "_1" + "\" class=\"mdl-layout__tab\">" + PageName1 + "</a>" +
                    "<a href =\"#" + PageName2.Replace(" ", "").ToLower() + "_2" + "\" class=\"mdl-layout__tab\">" + PageName2 + "</a>" +
                    "<a href =\"#" + PageName3.Replace(" ", "").ToLower() + "_3" + "\" class=\"mdl-layout__tab\">" + PageName3 + "</a>" +
                    "<a href =\"#" + PageName4.Replace(" ", "").ToLower() + "_4" + "\" class=\"mdl-layout__tab\">" + PageName4 + "</a>");
                    Webpage = Webpage4;
                }
                #endregion

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

        private void Materialize_Setup_SizeChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}