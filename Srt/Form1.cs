using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Srt
{
    enum EventSource
    {
        List, Button
    }
    public partial class srtMakerForm : Form
    {
        public string desktopPath = "E:\\Sealkeen\\Desktop\\";
        private EventSource eventSource;
        private bool isStarted;
        private int stringCounter;
        private int currentCaption;
        private List<Caption> CaptionCollection;
        
        public srtMakerForm()
        {
            InitializeComponent();
            CaptionCollection = new List<Caption>();
            isStarted = false;
            stringCounter = 0;
            Caption cpt = new Caption();
            initializeFields(ref cpt);
            CaptionCollection.Add(cpt);
            currentCaption = -1;
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
                btnAddCaption.Enabled = true;
            else
                btnAddCaption.Enabled = false;
        }

        private void btnAddCaption_Click(object sender, EventArgs e)
        {
            #region MyRegion
            //char ch;
            //for (int i = 0; i < 60; i++)
            //{
            //    ch = (char)i;
            //    label1.Text += "(" + i + ") " + ch + " ";
            //    if (i % 5 == 0)
            //        label1.Text += "\n";
            //} 
            #endregion
            if(isStarted)
                ++stringCounter;
            else
                isStarted = true;
            label1.Text = ( "[" +stringCounter.ToString() + "]" );

            if (stringCounter > 0)
            {
                Caption cpt = new Caption();
                initializeFields(ref cpt);
                fillOutTheFields(ref cpt);
                CaptionCollection.Insert(stringCounter, cpt);
            }

            if (CaptionCollection != null)
            {
                Caption Cpt = new Caption();
                Cpt = CaptionCollection[stringCounter];
                Cpt.Third = txtString.Text;
                buildSecondLine(Cpt);
            }
            else
                MessageBox.Show("CaptionCollection[int] == null");
            if(currentCaption != stringCounter)
                btnShowCaption.PerformClick();
            if (CaptionCollection.Count > 0)
            {
                if(isSequencial.CheckState == CheckState.Checked)
                {
                    txtFromHours.Text = txtToHours.Text;
                    txtFromMinutes.Text = txtToMinutes.Text;
                    txtFromSeconds.Text = txtToSeconds.Text;
                }
            }
            btnShowList.PerformClick();
        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {
            forsymbol(sender);
            maxValue(sender);
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            forsymbol(sender);
            maxValue(sender);
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            forsymbol(sender);
            maxValueHours(sender);
        }

        private void forsymbol(object sender)
        {
            string s = (sender as TextBox).Text;
            foreach (char item in s)
            {
                if ((int)item > 58 || (int)item < 48)
                    (sender as TextBox).Text = "00";
            }
        }

        private void maxValue(object sender)
        {
            string s = (sender as TextBox).Text;
            if (s.Length > 1)
            {
                char one = s[0];
                char two = s[1];
                if ((int)one >= 54 && two>=48)
                {
                    one = (char)54;
                    two = (char)48;
                }
                (sender as TextBox).Text = "" + one + two;
            }
            if (s.Length == 1)
            {
                char ch = s[0];
                (sender as TextBox).Text = ((char)48).ToString() + ch;
            }

        }

        private void maxValueHours(object sender)
        {
            string s = (sender as TextBox).Text;
            if (s.Length > 1)
            {
                char one = s[0];
                char two = s[1];
                if ((int)one >= 50 && two >= 52)
                {
                    one = (char)50;
                    two = (char)52;
                }
                (sender as TextBox).Text = "" + one + two;
            }
            if (s.Length == 1)
            {
                char ch = s[0];
                (sender as TextBox).Text = '0'.ToString() + ch;
            }
        }

        private void maxValueMilliseconds(object sender)
        {
            string s = (sender as TextBox).Text;
            if (s.Length == 1)
            {
                char ch = s[0];
                (sender as TextBox).Text = ("00" + ch);
            }
            if (s.Length == 2)
            {
                char ch1 = s[0];
                char ch2 = s[1];
                (sender as TextBox).Text = ('0'.ToString() + ch1 + ch2);
            }
        }

        private void btnAltE_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnAltR_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnCtrlW_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnCtrlQ_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnCtrlQ_Click(object sender, EventArgs e)
        {
            int i = 0;

            
            i = captionParse(txtFromMinutes.Text);
            CaptionCollection[stringCounter].isFilled = true;
            

            if (i<60)
                i++;
            txtFromMinutes.Text = i.ToString();
            CaptionCollection[stringCounter].FromMinutes = i;

            if(eventSource == EventSource.Button)
                btnAddCaption.Focus();
        }

        private void ifAddButtonEnabled()
        {
            if(true)
            {
                ;
            }
        }

        private void btnCtrlW_Click(object sender, EventArgs e)
        {
            int i = 0;

            
            i = captionParse(txtFromSeconds.Text);
            CaptionCollection[stringCounter].isFilled = true;
            

            if (i < 60)
                i++;
            txtFromSeconds.Text = i.ToString();
            CaptionCollection[stringCounter].FromSeconds = i;

            if (eventSource == EventSource.Button)
                btnAddCaption.Focus();
        }

        private void btnAltE_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (CaptionCollection[stringCounter].isFilled)
            {
                i = CaptionCollection[stringCounter].ToMinutes;
            }
            else
            {
                i = captionParse(txtToMinutes.Text);
                CaptionCollection[stringCounter].isFilled = true;
            }

            if (i < 60)
                i++;
            txtToMinutes.Text = i.ToString();
            CaptionCollection[stringCounter].ToMinutes = i;

            if (eventSource == EventSource.Button)
                btnAddCaption.Focus();
        }

        private void btnAltR_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (CaptionCollection[stringCounter].isFilled)
            {
                i = CaptionCollection[stringCounter].ToSeconds;
            }
            else
            {
                i = captionParse(txtToSeconds.Text);
                CaptionCollection[stringCounter].isFilled = true;
            }

            if (i < 60)
                i++;
            txtToSeconds.Text = i.ToString();
            CaptionCollection[stringCounter].ToSeconds = i;

            if (eventSource == EventSource.Button)
                btnAddCaption.Focus();
        }

        private void srtMakerForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void srtMakerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            progSave.Value = 0;
            isStarted = false;
            stringCounter = 0;
            label1.Text = ( "[" +stringCounter.ToString() + "]" );
            lstCaptions.Items.Clear();
            CaptionCollection.Clear(); 
            Caption cpt = new Caption();
            initializeFields(ref cpt);
            CaptionCollection.Add(cpt);
            txtString.Text = "";
            txtShown.Text = "";
            txtString.Focus();
            fillOutTheBoxes(cpt);
        }

        private void btnAddCaption_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    btnCtrlQ.PerformClick();
                    break;
                case Keys.W:
                    btnCtrlW.PerformClick();
                    break;
                case Keys.E:
                    btnAltE.PerformClick();
                    break;
                case Keys.R:
                    btnAltR.PerformClick();
                    break;
                case Keys.A:
                    btnCtrlA.PerformClick();
                    break;
                case Keys.S:
                    btnCtrlS.PerformClick();
                    break;
                case Keys.D:
                    btnAltD.PerformClick();
                    break;
                case Keys.F:
                    btnAltF.PerformClick();
                    break;
                case Keys.Space:
                    txtString.Focus();
                    break;
                case Keys.Enter:
                    if(btnAddCaption.Focused)
                        txtString.Focus();
                    break;
                case Keys.Oemtilde:
                    lstCaptions.Focus();
                    if(lstCaptions.Items.Count >= 1)
                        lstCaptions.SelectedIndex = 0;
                    break;
                case Keys.Delete:
                    txtFromMinutes.Text = "00";
                    txtFromSeconds.Text = "00";
                    txtToMinutes.Text = "00";
                    txtToSeconds.Text = "00";
                    break;

            }

        }

        private void txtString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddCaption.Focus();
            }
        }

        private void txtMilliseconds_TextChanged(object sender, EventArgs e)
        {
            forsymbol(sender);
            maxValueMilliseconds(sender);
        }

        private void btnCtrlA_Click(object sender, EventArgs e)
        {
            int i = 0;

            
            i = captionParse(txtFromMinutes.Text);
            CaptionCollection[stringCounter].isFilled = true;
            

            if (i > 0)
                i--;
            txtFromMinutes.Text = i.ToString();
            CaptionCollection[stringCounter].FromMinutes = i;

            if (eventSource == EventSource.Button)
                btnAddCaption.Focus();
            else
                return;
        }

        private void btnCtrlS_Click(object sender, EventArgs e)
        {
            int i = 0;

            
            i = captionParse(txtFromSeconds.Text);
            CaptionCollection[stringCounter].isFilled = true;
            

            if (i > 0)
                i--;
            txtFromSeconds.Text = i.ToString();
            CaptionCollection[stringCounter].FromSeconds = i;

            if (eventSource == EventSource.Button)
                btnAddCaption.Focus();
            else
                return;
        }

        private void btnAltD_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (CaptionCollection[stringCounter].isFilled)
            {
                i = CaptionCollection[stringCounter].ToMinutes;
            }
            else
            {
                i = captionParse(txtToMinutes.Text);
                CaptionCollection[stringCounter].isFilled = true;
            }

            if (i > 0)
                i--;
            txtToMinutes.Text = i.ToString();
            CaptionCollection[stringCounter].ToMinutes = i;

            if (eventSource == EventSource.Button)
                btnAddCaption.Focus();
            else
                return;
        }
            
        private void btnAltF_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (CaptionCollection[stringCounter].isFilled)
            {
                i = CaptionCollection[stringCounter].ToSeconds;
            }
            else
            {
                i = captionParse(txtToSeconds.Text);
                CaptionCollection[stringCounter].isFilled = true;
            }

            if (i > 0)
                i--;
            txtToSeconds.Text = i.ToString();
            CaptionCollection[stringCounter].ToSeconds = i;

            if (eventSource == EventSource.Button)
                btnAddCaption.Focus();
            else
                return;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreate.PerformClick();
        }

        public void initializeFields(ref Caption Cpt)
        {
            Cpt.FromHours = 0; Cpt.FromMinutes = 0;
            Cpt.FromSeconds = 0; Cpt.FromMilliseconds = 0;
            Cpt.ToHours = 0; Cpt.ToMinutes = 0;
            Cpt.ToSeconds = 0; Cpt.ToMilliseconds = 0;
            Cpt.Second = ""; Cpt.Third = "";
        }

        private void fillOutTheFields(ref Caption Cpt)
        {
            Cpt.FromHours = captionParse(txtFromHours.Text);
            Cpt.FromMinutes = captionParse(txtFromMinutes.Text);
            Cpt.FromSeconds = captionParse(txtFromSeconds.Text);
            Cpt.FromMilliseconds = captionMSParse(txtFromMilliseconds.Text);

            Cpt.ToHours = captionParse(txtToHours.Text);
            Cpt.ToMinutes = captionParse(txtToMinutes.Text);
            Cpt.ToSeconds = captionParse(txtToSeconds.Text);
            Cpt.FromMilliseconds = captionMSParse(txtToMilliseconds.Text);

            Cpt.isFilled = true;
        }

        private void fillOutTheBoxes(Caption Cpt)
        {
            txtFromHours.Text = Cpt.FromHours.ToString();
            txtFromMinutes.Text = Cpt.FromMinutes.ToString();
            txtFromSeconds.Text = Cpt.FromSeconds.ToString();
            txtFromMilliseconds.Text = Cpt.FromMilliseconds.ToString();

            txtToHours.Text = Cpt.ToHours.ToString();
            txtToMinutes.Text = Cpt.ToMinutes.ToString();
            txtToSeconds.Text = Cpt.ToSeconds.ToString();
            txtToMilliseconds.Text = Cpt.FromMilliseconds.ToString();
        }

        private void btnReturnBack_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "btnNext" && (stringCounter + 1) != lstCaptions.Items.Count && (stringCounter < lstCaptions.Items.Count))
            {
                ++stringCounter;
            }
            else
            {
                if ((isStarted && stringCounter > 0) && (sender as Button).Name == "btnPrevious")
                    --stringCounter;
            }
            label1.Text = ( "[" +stringCounter.ToString() + "]" );
            if (lstCaptions.Items.Count != 0 && lstCaptions.SelectedIndex >= 0)
            {
                lstCaptions.SelectedIndex = stringCounter;
            }
            else
            {
                txtShown.Text = "Nowhere to Move";
                if(lstCaptions.Items.Count>0)
                    lstCaptions.SelectedIndex = stringCounter;
            }
            btnAddCaption.Focus();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstCaptions.Items.Clear();
            string str;
            int i = 0;
            progSave.Value = 0;
            progSave.Maximum = CaptionCollection.Count;
            foreach(Caption item in CaptionCollection)
            {
                str = (++i).ToString() + ". " + item.Second + " " + item.Third;
                lstCaptions.Items.Add(str);
                progSave.Value++;
            }
            if(lstCaptions.Items.Count!=0 && lstCaptions.SelectedIndex >=0)
                lstCaptions.SelectedIndex = stringCounter;
        }

        private void lstCaptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CaptionCollection.Count == lstCaptions.Items.Count)
            {
                stringCounter = (sender as ListBox).SelectedIndex;
            }
            else
            {
                MessageBox.Show("String Counter / ListBox Index Error");
            }
            label1.Text = ("[" + stringCounter.ToString() + "]");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (lstCaptions.Items.Count != 0 && lstCaptions.SelectedIndex >=0)
            {
                currentCaption = -1; //У нас новый кэпшен показывается через Show() только если не совпадает со старым. Тут мы искусственно его делаем не совпавшим.
                Caption cpt = new Caption();
                if (CaptionCollection[stringCounter] != null)
                    cpt = CaptionCollection[stringCounter];
                else
                {
                    txtShown.Text = "Select an Item from the List";
                    return;
                }

                cpt.FromHours = captionParse(txtFromHours.Text);
                cpt.FromMinutes = captionParse(txtFromMinutes.Text);
                cpt.FromSeconds = captionParse(txtFromSeconds.Text);
                cpt.FromMilliseconds = captionMSParse(txtFromMilliseconds.Text);

                cpt.ToHours = captionParse(txtToHours.Text);
                cpt.ToMinutes = captionParse(txtToMinutes.Text);
                cpt.ToSeconds = captionParse(txtToSeconds.Text);
                cpt.ToMilliseconds = captionMSParse(txtToMilliseconds.Text);

                buildSecondLine(cpt);

                cpt.Third = txtString.Text;

                btnShowCaption.PerformClick();
                btnShowList.PerformClick();

                CaptionCollection[stringCounter] = cpt;
            }
            else
                txtShown.Text = "Select an Item to Replace";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCaptions.Items.Count != 0 && lstCaptions.SelectedIndex >= 0)
            {
                lstCaptions.Items.Remove(stringCounter);
                CaptionCollection.Remove(CaptionCollection[stringCounter]);
                if (CaptionCollection.Count >= 1)
                    stringCounter--;
                btnShowList.PerformClick();
                if (CaptionCollection.Count == 0 || lstCaptions.Items.Count == 0)
                {
                    btnCreate.PerformClick();
                }

            }
            else
                txtShown.Text = "None to Remove";
        }

        private void lstCaptions_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    btnDelete.PerformClick();
                    break;
                case Keys.Enter:
                    btnReplace.PerformClick();
                    break;
                case Keys.Up:
                    break;
                case Keys.Down:
                    break;
                default:
                    btnAddCaption.Focus();
                    break;
            }
        }

        private void btnShowCaption_Click(object sender, EventArgs e)
        {
            if(lstCaptions.SelectedIndex >= 0)
            {
                Caption cpt = new Caption();
                initializeFields(ref cpt);
                cpt = CaptionCollection[lstCaptions.SelectedIndex];

                txtShown.Text = "";
                txtShown.Text += (CaptionCollection.IndexOf(cpt)+1 + Environment.NewLine);

                fillOutTheBoxes(cpt);

                txtShown.Text += (Environment.NewLine + cpt.Second);
                txtShown.Text += (Environment.NewLine + cpt.Third);
                currentCaption = lstCaptions.SelectedIndex;
            }

            else
            {
                txtShown.Text = "Choose an Item To Show";
                return;
            }
        }

        private void saveTo_Click(object sender, EventArgs e)
        {
            try
            {
                if (CaptionCollection[0].isFilled)
                {
                    fbDialog.ShowDialog(this);
                    //fbDialog.ShowDialog();
                    //if (fbDialog.SelectedPath == "")
                    //{
                    //    txtShown.Text = "An incorrect path has been entered.";
                    //    return;
                    //}
                    progSave.Value = 0;
                    string fileName = fbDialog.SelectedPath + txtFileName.Text + ".srt";
                    FileStream stdio = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                    StreamWriter sw = new StreamWriter(stdio);

                    progSave.Maximum = CaptionCollection.Count;

                    foreach (Caption Structure in CaptionCollection)
                    {
                        sw.WriteLine(CaptionCollection.IndexOf(Structure) + 1);
                        sw.Write(Structure.Second);
                        sw.WriteLine(Structure.Third);
                        sw.WriteLine();
                        progSave.Value++;
                    }
                    sw.Close();

                    MessageBox.Show("Complete");
                }
                else
                {
                    txtShown.Text = ("You should fill a caption with values at first.");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong...");
                return;
            }
        }

        private void buildSecondLine(Caption Cpt)
        {
            Cpt.Second = "";
            Cpt.Second +=
               (txtFromHours.Text + ":" +
                txtFromMinutes.Text + ":" +
                txtFromSeconds.Text + "," +
                txtFromMilliseconds.Text + " --> " +

                txtToHours.Text + ":" +
                txtToMinutes.Text + ":" +
                txtToSeconds.Text + "," +
                txtToMilliseconds.Text + Environment.NewLine);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtShown.Text = CaptionCollection[stringCounter].Second;
            txtShown.Text += Convert.ToInt32("12").ToString();
            txtShown.Text += fbDialog.SelectedPath;
        }

        private bool isTheTimeOfTheFollowingCaptionIncorrect(Caption caption)
        {
            if (CaptionCollection.IndexOf(caption) >= 0)
                ;
            return new bool();
        }

        private void btnAddCaption_KeyPress(object sender, KeyPressEventArgs e)
        {
            //switch (e.KeyChar)
            //{
                    
            //    case Keys.Q:
            //        btnCtrlQ.PerformClick();
            //        break;
            //    case Keys.W:
            //        btnCtrlW.PerformClick();
            //        break;
            //    case Keys.E:
            //        btnAltE.PerformClick();
            //        break;
            //    case 'r':
            //        btnAltR.PerformClick();
            //        break;
            //    case 'a':
            //        btnCtrlA.PerformClick();
            //        break;
            //    case 's':
            //        btnCtrlS.PerformClick();
            //        break;
            //    case Keys.D:
            //        btnAltD.PerformClick();
            //        break;
            //    case Keys.F:
            //        btnAltF.PerformClick();
            //        break;
            //    case Keys.Space:
            //        txtString.Focus();
            //        break;
            //    case Keys.Enter:
            //        txtString.Focus();
            //        break;

            //}
        }

        private void lstCaptions_Validated(object sender, EventArgs e)
        {
            eventSource = EventSource.List;
        }

        private void btnAddCaption_Validated(object sender, EventArgs e)
        {
            eventSource = EventSource.Button;
        }
        private int captionParse(string s)
        {
            int i = 0;
            int c = 0;
            i = ((int)s[0]) - 48;
            c = ((int)s[1]) - 48;
            i = i * 10 + c;
            return i;
        }
        private int captionMSParse(string s)
        {
            int i = 0;
            int c = 0;
            int j = 0;
            i = ((int)s[0]) - 48;
            c = ((int)s[1]) - 48;
            j = ((int)s[j]) - 48;

            i = i * 100 + c * 10 + j;
            return i;
        }

        private void btnPrevious_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddCaption.Focus();
        }

        private void btnNext_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddCaption.Focus();
        }

        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddCaption.Focus();
        }

        private void btnReplace_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddCaption.Focus();
        }

        private void btnShowCaption_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddCaption.Focus();
        }

        private void btnShowList_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddCaption.Focus();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTo.PerformClick();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreate.PerformClick();
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                fbDialog.ShowDialog();
                lstCaptions.Items.Clear();
                CaptionCollection = new List<Caption>();
                string path = fbDialog.SelectedPath + txtFileName.Text + ".srt";
                FileStream seeIn = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader cin = new StreamReader(seeIn);

                List<string> lines = new List<string>();
                lines.Add(cin.ReadLine());
                if (lines[0] == null)
                    return;
                while (lines[lines.Count-1] != null)
                {
                    lines.Add(cin.ReadLine());
                }
                txtShown.Text = "";

                progSave.Maximum = lines.Count;
                progSave.Value = 0;
                foreach(string line in lines)
                {
                    try
                    {
                        if (lines.IndexOf(line) + 2 <= lines.Count)
                        {
                            Convert.ToInt32(line);
                            Caption cpt = new Caption();

                            cpt.Second = lines[lines.IndexOf(line) + 1];
                            cpt.Third = lines[lines.IndexOf(line) + 2];

                            secondToInt(ref cpt);
                            cpt.isFilled = true;

                            CaptionCollection.Add(cpt);
                        }
                        else
                            break;
                    }
                    catch (FormatException)
                    {
                        
                    }
                    progSave.Value++;
                }
                
                btnShowList.PerformClick();
            }
            catch
            {
                MessageBox.Show("Load file error. Check if everything is OK");
            }
        }
        private bool isNumber(char c)
        {
            if (c >= 48 && c <= 57)
                return true;
            else
                return false;
        }

        private bool isNotEmpty(string c)
        {
            if (c != "")
                return true;
            else
                return false;
        }

        private void secondToInt(ref Caption cpt)
        {
            cpt.FromHours = captionParse( cpt.Second.Substring(0, 2) );
            cpt.FromMinutes = captionParse( cpt.Second.Substring(3, 2) );
            cpt.FromSeconds = captionParse(cpt.Second.Substring(6, 2));
            cpt.FromMilliseconds = captionMSParse(cpt.Second.Substring(6, 3));

            cpt.ToHours = captionParse(cpt.Second.Substring(17, 2));
            cpt.ToMinutes = captionParse(cpt.Second.Substring(20, 2));
            cpt.ToSeconds = captionParse(cpt.Second.Substring(23, 2));
            cpt.ToMilliseconds = captionMSParse(cpt.Second.Substring(26, 3));
        }
    }
}
