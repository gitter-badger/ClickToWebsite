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
        public int PagesDone = 0;
        static DialogResult resultExclamation;
        static DialogResult resultError;
        updatechecker check = new updatechecker();

        public Materialize_Setup()
        {
            InitializeComponent();
        }

        public static void MessageBoxExclamation(string Text, MessageBoxButtons MessageButton, bool DialogResultNeeded)
        {
            if (DialogResultNeeded == true)
            {
                resultExclamation = MessageBox.Show($"{Text}", "Click To Website", MessageButton, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show($"{Text}", "Click To Website", MessageButton, MessageBoxIcon.Exclamation);
            }
        }

        public static void MessageBoxError(string Text, MessageBoxButtons MessageButton, bool DialogResultNeeded)
        {
            if (DialogResultNeeded == true)
            {
                resultError = MessageBox.Show($"{Text}", "Click To Website", MessageButton, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"{Text}", "Click To Website", MessageButton, MessageBoxIcon.Error);
            }
        }

        void Paragragh2Void(string Page)
        {
            this.Size = new Size(570, 290);
            Paragraph2_Title_TextBox.Visible = true;
            Paragraph2_Content_TextBox.Visible = true;
            Paragraph2_Title_Ask.Visible = true;
            Paragraph2_Content_Ask.Visible = true;
            TextBar_2.Visible = true;
            TextBar_2.Location = new Point(280, 38);
            MessageBox.Show($"Now input the content for the {Page} page", "Click To Website");
            PagesDone++;
        }

        void Paragraph1and2Void(string Page)
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
            MessageBox.Show($"Now input the content for the {Page} page", "Click To Website");
            PagesDone++;
        }

        void Paragraph3Void(string Page)
        {
            this.Size = new Size(840, 290);
            Paragraph3_Title_TextBox.Visible = true;
            Paragraph3_Content_TextBox.Visible = true;
            Paragraph3_Title_Ask.Visible = true;
            Paragraph3_Content_Ask.Visible = true;
            TextBar_3.Visible = true;
            TextBar_3.Location = new Point(550, 38);
            MessageBox.Show($"Now input the content for the {Page} page", "Click To Website");
            PagesDone++;
        }

        void Paragraph2ReVoid(string Page)
        {
            this.Size = new Size(300, 290);
            Paragraph2_Title_TextBox.Visible = false;
            Paragraph2_Content_TextBox.Visible = false;
            Paragraph2_Title_Ask.Visible = false;
            Paragraph2_Content_Ask.Visible = false;
            TextBar_2.Visible = false;
            MessageBox.Show($"Now input the content for the {Page} page", "Click To Website");
            PagesDone++;
        }

        void Paragraph3ReVoid(string Page)
        {
            this.Size = new Size(570, 290);
            Paragraph3_Title_TextBox.Visible = false;
            Paragraph3_Content_TextBox.Visible = false;
            Paragraph3_Title_Ask.Visible = false;
            Paragraph3_Content_Ask.Visible = false;
            TextBar_3.Visible = false;
            MessageBox.Show($"Now input the content for the {Page} page", "Click To Website");
            PagesDone++;
        }

        void Paragraph2and3ReVoid(string Page)
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
            MessageBox.Show($"Now input the content for the {Page} page", "Click To Website");
            PagesDone++;
        }

        void StartParagraph1Info()
        {
            this.Size = new Size(300, 290);
            Next_Button.Location = new Point(12, 217);
            Next_Button.Size = new Size(260, 23);
            Paragraph1_Title_Ask.Visible = true;
            Paragraph1_Title_TextBox.Visible = true;
            Paragraph1_Content_Ask.Visible = true;
            Paragraph1_Content_TextBox.Visible = true;
        }

        void StartParagraph2Info()
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

        void StartParagraph3Info()
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

        void ChangeFormLookToPNGAsk()
        {
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
                    MessageBoxExclamation("You need to choose a design that your website will end up looking like", MessageBoxButtons.OK, false);
                }
            }
            else if (Description_Ask.Visible && Description_TextBox.Visible == true)
            {
                if (Description_TextBox.Text.Length == 0 && Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Put in a name for your Website and a description", MessageBoxButtons.OK, false);
                }
                else if (Description_TextBox.Text.Length == 0 && Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Put in a description", MessageBoxButtons.OK, false);
                }
                else if (Title_TextBox.Text.Length == 0 && Description_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Put in a name for your Website", MessageBoxButtons.OK, false);
                }
                //Making Number input into a int so it can be used by the program
                try
                {
                    if (Pages_TextBox.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to put in how much pages you what (as long it less then 4 pages)", MessageBoxButtons.OK, false);
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
                    MessageBoxError("Put in a (number) for how much pages you what", MessageBoxButtons.OK, false);
                    PagesFail = 1;
                }
                catch (OverflowException)
                {
                    MessageBoxError("THAT IS WAYYYYYYY TO MUCH PAGES!", MessageBoxButtons.OK, false);
                    PagesFail = 1;
                }

                if (PagesFail == 0)
                {
                    if (Pages >= 5)
                    {
                        MessageBoxExclamation("You can only do 4 pages (For now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Pages == 0 && Pages_TextBox.Text.Length >= 1)
                    {
                        MessageBoxError("You can't have no pages!", MessageBoxButtons.OK, false);
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
            else if (Page1_Name_TextBox.Visible == true && Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Visible == false&& Page3_Name_TextBox.Visible == false&& Page4_Name_TextBox.Visible == false)
            {
                Page1_Name_Ask.Visible = false;
                Page1_Name_TextBox.Visible = false;
                Paragraph_Ask_Firstpage.Visible = true;
                Paragraph_TextBox_Firstpage.Visible = true;
            }
            else if (Page1_Name_TextBox.Visible == true && Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Visible == true && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Visible == false&& Page4_Name_TextBox.Visible == false)
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
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph1 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph1 == 0)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
                    }
                    else
                    {
                        Paragraph_Ask_Firstpage.Visible = false;
                        Paragraph_TextBox_Firstpage.Visible = false;
                        if (Paragraph1 == 1)
                        {
                            StartParagraph1Info();
                        }
                        if (Paragraph1 == 2)
                        {
                            StartParagraph2Info();
                        }
                        if (Paragraph1 == 3)
                        {
                            StartParagraph3Info();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBoxError("Put in a (number)", MessageBoxButtons.OK, false);
                }
                catch (OverflowException)
                {
                    MessageBoxError("THAT IS WAYYYYYYY TO MUCH PARAGRAPHS!", MessageBoxButtons.OK, false);
                }
            }
            else if (Paragraph_Ask_Firstpage.Visible == true && Paragraph_TextBox_Firstpage.Visible == true && Paragraph_Ask_Secondpage.Visible == true && Paragraph_TextBox_Thirdpage.Visible == false)
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
                    if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page two", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one and two", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph1 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph2 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph1 == 0)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph2 == 0)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
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
                            StartParagraph1Info();
                        }
                        if (Paragraph1 == 2)
                        {
                            StartParagraph2Info();
                        }
                        if (Paragraph1 == 3)
                        {
                            StartParagraph3Info();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBoxError("Put in a number", MessageBoxButtons.OK, false);
                }
                catch (OverflowException)
                {
                    MessageBoxError("THAT IS WAYYYYYYY TO MUCH PARAGRAPHS!", MessageBoxButtons.OK, false);
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
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page two", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one and three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page second and three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one and two", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one, two and three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph1 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph2 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph3 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph1 == 0 && Paragraph_TextBox_Firstpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph2 == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph3 == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
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
                            StartParagraph1Info();
                        }
                        if (Paragraph1 == 2)
                        {
                            StartParagraph2Info();
                        }
                        if (Paragraph1 == 3)
                        {
                            StartParagraph3Info();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBoxError("Put in a number", MessageBoxButtons.OK, false);
                }
                catch (OverflowException)
                {
                    MessageBoxError("THAT IS WAYYYYYYY TO MUCH PARAGRAPHS!", MessageBoxButtons.OK, false);
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
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page two", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one and three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page second and three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one and two", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one, two and three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one, two, three and four", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page three and four", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one and four", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page two and four", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page two, three and four", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one, three and four", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one ,two and four", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length == 0 && Paragraph_TextBox_Secondpage.Text.Length == 0 && Paragraph_TextBox_Thirdpage.Text.Length == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page one ,two and three", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph_TextBox_Firstpage.Text.Length >= 1 && Paragraph_TextBox_Secondpage.Text.Length >= 1 && Paragraph_TextBox_Thirdpage.Text.Length >= 1 && Paragraph_TextBox_Fourthpage.Text.Length == 0)
                    {
                        MessageBoxExclamation("You need to tell be how much paragraphs you what in page four", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph1 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph2 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph3 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph4 >= 4)
                    {
                        MessageBoxExclamation("You can't do more then 3 paragraphs (for now...)", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph1 == 0 && Paragraph_TextBox_Firstpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph2 == 0 && Paragraph_TextBox_Secondpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph3 == 0 && Paragraph_TextBox_Thirdpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
                    }
                    else if (Paragraph4 == 0 && Paragraph_TextBox_Fourthpage.Text.Length >= 1)
                    {
                        MessageBoxExclamation("You can't no paragraphs!", MessageBoxButtons.OK, false);
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
                            StartParagraph1Info();
                        }
                        if (Paragraph1 == 2)
                        {
                            StartParagraph2Info();
                        }
                        if (Paragraph1 == 3)
                        {
                            StartParagraph3Info();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBoxError("Put in a number", MessageBoxButtons.OK, false);
                }
                catch (OverflowException)
                {
                    MessageBoxError("THAT IS WAYYYYYYY TO MUCH PARAGRAPHS!", MessageBoxButtons.OK, false);
                }
            }
            else if (Paragraph1_Content_Ask.Visible == true && Paragraph1_Content_TextBox.Visible == true && Paragraph2_Content_Ask.Visible == false)
            {
                if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the first paragraph", MessageBoxButtons.OK, false);
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
                            Paragraph1and2Void("second");
                        }
                        else if (Paragraph2 == 2)
                        {
                            Paragragh2Void("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Click To Website");
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
"                    <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

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
                            Paragraph1and2Void("second");
                        }
                        else if (Paragraph2 == 2)
                        {
                            Paragragh2Void("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Click To Website");
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
                            Paragraph1and2Void("third");
                        }
                        else if (Paragraph3 == 2)
                        {
                            Paragragh2Void("third");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page", "Click To Website");
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
                            Paragraph1and2Void("second");
                        }
                        else if (Paragraph2 == 2)
                        {
                            Paragragh2Void("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Click To Website");
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
                            Paragraph1and2Void("third");
                        }
                        else if (Paragraph3 == 2)
                        {
                            Paragragh2Void("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page", "Click To Website");
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
                            Paragraph1and2Void("fourth");
                        }
                        else if (Paragraph4 == 2)
                        {
                            Paragragh2Void("fourth");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the fourth page", "Click To Website");
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

                        ChangeFormLookToPNGAsk();
                    }
                }
            }
            else if (Paragraph1_Content_Ask.Visible == true && Paragraph1_Content_TextBox.Visible == true && Paragraph2_Content_Ask.Visible == true && Paragraph2_Title_Ask.Visible == true && Paragraph3_Content_Ask.Visible == false)
            {
                if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first and second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and the content of the second paragraph and the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first paragraph and the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and the content for the second paragraph and the title for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first paragraph and the title for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the first paragraph and the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the second paragraph and the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the first and second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the first and second paragraph", MessageBoxButtons.OK, false);
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
                            Paragraph3Void("second");
                        }
                        else if (Paragraph2 == 1)
                        {
                            Paragraph2ReVoid("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Click To Website");
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
"                    <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

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
                            Paragraph3Void("second");
                        }
                        else if (Paragraph2 == 1)
                        {
                            Paragraph2ReVoid("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Click To Website");
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
                            Paragraph3Void("third");
                        }
                        else if (Paragraph3 == 1)
                        {
                            Paragraph2ReVoid("third");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page", "Click To Website");
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
"                    <a href =\"#" + Paragraph1_Title_Pagetwo.Replace(" ", " ").ToLower() + "1_2\">" + Paragraph1_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagetwo.Replace(" ", " ").ToLower() + "2_2\">" + Paragraph2_Title_Pagetwo.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pagetwo.Replace(" ", " ").ToLower() + "3_2\">" + Paragraph3_Title_Pagetwo.Replace(" ", " ") + "</a>";

                        Content_List_Pagethree =
"                    <a href =\"#" + Paragraph1_Title_Pagethree.Replace(" ", " ").ToLower() + "1_3\">" + Paragraph1_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pagethree.Replace(" ", " ").ToLower() + "2_3\">" + Paragraph2_Title_Pagethree.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3_3\">" + Paragraph3_Title_Pagethree.Replace(" ", " ") + "</a>";

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
                            Paragraph3Void("second");
                        }
                        else if (Paragraph2 == 1)
                        {
                            Paragraph2ReVoid("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Clcik To Website");
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
                            Paragraph3Void("third");
                        }
                        else if (Paragraph3 == 1)
                        {
                            Paragraph2ReVoid("third");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page", "Click To Website");
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
                            Paragraph3Void("fourth");
                        }
                        else if (Paragraph4 == 1)
                        {
                            Paragraph2ReVoid("fourth");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the fourth page", "Click To Website");
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

                        ChangeFormLookToPNGAsk();
                    }
                }
            }
            else if (Paragraph1_Content_Ask.Visible == true && Paragraph1_Content_TextBox.Visible == true && Paragraph2_Content_Ask.Visible == true && Paragraph2_Title_Ask.Visible == true && Paragraph3_Content_Ask.Visible == true && Paragraph3_Title_Ask.Visible == true)
            {
                if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first and second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the second paragraph and the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first paragraph and the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the second paragraph and the title for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and the content for the first paragraph and the title for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the first paragraph and the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the second paragraph and the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the first and second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the first and second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content and title for the first, second and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content and title for the second and third paragraph and fill in the content for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content and title for the second and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content and title for the third paragraph and just the content of the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content and title for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the first and third paragraph and the title for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content for the second paragraph and the title for the first and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content for the first and second paragraph and the title for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content for the first paragraph and the title for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the first and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content for the first paragraph and the title and content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and content for the third paragraph and fill in the content for the first and second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the first, second and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content for the first paragraph, fill in the title for the second paragraph and fill the title and content third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the second paragraph and fill in the title and content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the second paragraph and fill in the content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the first paragraph and fill in the title and content for the second and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the second paragraph and fill in the title and content for the first and third paragraph",MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content for the second paragraph and fill in the title and content for the first and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the third paragraph and fill in the title and content for the first and second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the third paragraph and fill in the title and content for the first and second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the third paragraph, fill in the content for the first paragraph and fill in the title and content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the first and third paragraph and fill in the title and content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the first and second paragraph and fill in the title and content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the first paragraph ,fill in the content for the second paragraph and fill in the title and content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the first and third paragraph and fill in the title and content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title for the first paragraph ,fill in the title and content for the second paragraph and fill in the content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the third paragraph ,fill in the title and content for the first paragraph and fill in the content for the second paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and content for the first and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and content for the first paragraph and fill in the content for the second and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and content for the first paragraph and fill in the title for the second and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and content for the first paragraph ,fill in the title for the second paragraph and fill in the content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the title and content for the second paragraph and fill in the content for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and content for the second paragraph and fill in the title for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length == 0 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content for the second paragraph and fill in the title for the second and third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title and content for the third paragraph and fill in the title for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the second and third paragraph and fill in the title for the first paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length == 0 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length == 0 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for all the paragraphs", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length >= 1 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the title for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length >= 1 && Paragraph3_Title_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("Fill in the content for the second paragraph and fill in the title for the third paragraph", MessageBoxButtons.OK, false);
                }
                else if (Paragraph1_Content_TextBox.Text.Length >= 1 && Paragraph1_Title_TextBox.Text.Length >= 1 && Paragraph2_Content_TextBox.Text.Length == 0 && Paragraph2_Title_TextBox.Text.Length >= 1 && Paragraph3_Content_TextBox.Text.Length == 0 && Paragraph3_Title_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("Fill in the content for the second and third paragraph", MessageBoxButtons.OK, false);
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
                            Paragraph3ReVoid("second");
                        }
                        else if (Paragraph2 == 1)
                        {
                            Paragraph2and3ReVoid("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Click To Website");
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
                            Paragraph3ReVoid("second");
                        }
                        else if (Paragraph2 == 1)
                        {
                            Paragraph2and3ReVoid("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Click To Website");
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
                            Paragraph3ReVoid("third");
                        }
                        else if (Paragraph3 == 1)
                        {
                            Paragraph2and3ReVoid("third");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page", "Click To Website");
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
                            Paragraph3ReVoid("second");
                        }
                        else if (Paragraph2 == 1)
                        {
                            Paragraph2and3ReVoid("second");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the second page", "Click To Website");
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
                            Paragraph3ReVoid("third");
                        }
                        else if (Paragraph3 == 1)
                        {
                            Paragraph2and3ReVoid("third");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the third page", "Click To Website");
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
                            Paragraph3ReVoid("fourth");
                        }
                        else if (Paragraph4 == 1)
                        {
                            Paragraph2and3ReVoid("fourth");
                        }
                        else
                        {
                            MessageBox.Show("Now input the content for the fourth page", "Click To Website");
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
"                    <a href =\"#" + Paragraph1_Title_Pageone.Replace(" ", " ").ToLower() + "1\">" + Paragraph1_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph2_Title_Pageone.Replace(" ", " ").ToLower() + "2\">" + Paragraph2_Title_Pageone.Replace(" ", " ") + "</a>" + "                <a href =\"#" + Paragraph3_Title_Pageone.Replace(" ", " ").ToLower() + "3\">" + Paragraph3_Title_Pageone.Replace(" ", " ") + "</a>";

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

                        ChangeFormLookToPNGAsk();
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
                MDI_Text_Only[89] = MDI_Text_Only[89].Replace("<ADDWebpage>", string.Join("", Webpage));
                MDI_Text_Only[90] = MDI_Text_Only[90].Replace("<ADDDefaultPage>", string.Join("", DefaultPage));

                #region pngs
                string android_desktop_loc = android_desktop_open.FileName;
                byte[] android_desktop_png_file = File.ReadAllBytes(android_desktop_loc);

                string favicon_loc = favicon_open.FileName;
                byte[] favicon_png_file = File.ReadAllBytes(favicon_loc);

                string ios_desktop_loc = ios_desktop_open.FileName;
                byte[] ios_desktop_png_file = File.ReadAllBytes(ios_desktop_loc);
                #endregion

                //Asking user where it what to be saved to
                DialogResult Save_Result;

                Save_Result = Save_Website_Dialog.ShowDialog();

                if (Save_Result == DialogResult.Cancel)
                {
                    MessageBoxExclamation("Choose a folder", MessageBoxButtons.OK, false);
                }
                else
                {
                    if (Save_Website_Dialog.SelectedPath.Length >= 1)
                    {
                        try
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
                        catch (DirectoryNotFoundException)
                        {
                            MessageBoxError("The folder you choose can't be found (Did you delete it?)", MessageBoxButtons.OK, false);
                        }
                        catch (PathTooLongException)
                        {
                            MessageBoxError("The path to this folder is too long, use another folder", MessageBoxButtons.OK, false);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            MessageBoxError("Can't write too this folder (Do you have access to this folder?)", MessageBoxButtons.OK, false);
                        }
                    }
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
                    MessageBoxExclamation("Put in a png for ios", MessageBoxButtons.OK, false);
                }
                else if (got_file_favicon.Visible && got_file_ios.Visible == true)
                {
                    MessageBoxExclamation("Put in a png for android", MessageBoxButtons.OK, false);
                }
                else if (got_file_ios.Visible && got_file_android.Visible == true)
                {
                    MessageBoxExclamation("Put in a png for PC", MessageBoxButtons.OK, false);
                }
                else if (got_file_android.Visible == true)
                {
                    MessageBoxExclamation("Put in a png for ios and PC", MessageBoxButtons.OK, false);
                }
                else if (got_file_ios.Visible == true)
                {
                    MessageBoxExclamation("Put in a png for PC and android", MessageBoxButtons.OK, false);
                }
                else if (got_file_favicon.Visible == true)
                {
                    MessageBoxExclamation("Put in a png for ios and android", MessageBoxButtons.OK, false);
                }
                else
                {
                    MessageBoxExclamation("Put in a png for ios, android and PC", MessageBoxButtons.OK, false);
                }
            }
            else if (Page1_Name_TextBox.Visible == true && Page2_Name_TextBox.Visible == false&& Page1_Name_TextBox.Text.Length == 0)
            {
                MessageBoxExclamation("You need to put in a name for your first page", MessageBoxButtons.OK, false);
            }
            else if (Page1_Name_TextBox.Visible == true && Page2_Name_TextBox.Visible == true && Page3_Name_TextBox.Visible == false&& Page4_Name_TextBox.Visible == false)
            {
                if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your first page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for your second page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for your first and second page", MessageBoxButtons.OK, false);
                }
            }
            else if (Page1_Name_TextBox.Visible == true && Page2_Name_TextBox.Visible == true && Page3_Name_TextBox.Visible == true && Page4_Name_TextBox.Visible == false)
            {
                if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your first and second page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for your second and third page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for your first and third page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your second page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your first page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for your third page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for all your pages", MessageBoxButtons.OK, false);
                }
            }
            else if (Page1_Name_TextBox.Visible == true && Page2_Name_TextBox.Visible == true && Page3_Name_TextBox.Visible == true && Page4_Name_TextBox.Visible == true)
            {
                if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your first and second page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your second and third page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your first and third page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your second page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your first page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for your third page", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for all your pages", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for page two, three and four", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for page one, three and four", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for page one, two and four", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for page three and four", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for page two and four", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for page one, two and three", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length == 0 && Page3_Name_TextBox.Text.Length == 0 && Page4_Name_TextBox.Text.Length >= 1)
                {
                    MessageBoxExclamation("You need to put in a name for page two and three", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length == 0 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for page one and four", MessageBoxButtons.OK, false);
                }
                else if (Page1_Name_TextBox.Text.Length >= 1 && Page2_Name_TextBox.Text.Length >= 1 && Page3_Name_TextBox.Text.Length >= 1 && Page4_Name_TextBox.Text.Length == 0)
                {
                    MessageBoxExclamation("You need to put in a name for page four", MessageBoxButtons.OK, false);
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
                MessageBoxExclamation("Didn't get the image try again", MessageBoxButtons.OK, false);
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
                MessageBoxExclamation("Didn't get the image try again", MessageBoxButtons.OK, false);
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
                MessageBoxExclamation("Didn't get the image try again", MessageBoxButtons.OK, false);
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
                    MessageBoxError("Colour too dark to use (red, blue and green at the bottom right need to be 20 and up)", MessageBoxButtons.OK, false);
                }
            }
        }

        private void Materialize_Setup_SizeChanged(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private async void Materialize_Setup_Load(object sender, EventArgs e)
        {
            await check.CheckForUpdates(UpdateLabel);
        }

        private void UpdateLabel_Click(object sender, EventArgs e)
        {
            check.UpdateMessageBox();
        }
    }
}