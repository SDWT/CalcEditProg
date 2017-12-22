using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Resources;

namespace Calculator_prog
{
    public partial class MainForm : Form
    {
        private Button[] ButtonCalcs;
        private int cntButtonWidth = 4;
        private int cntButtonHeight = 5;


        public MainForm()
        {
            InitializeComponent();
            //var bmpCsharp = new Bitmap(Image.FromFile(@"C:\Users\Дмитрий\Desktop\geekbrains\LOGO\C#_LOGO_1.png"));
            //var bmpCsharp = new Bitmap(Image.FromFile(@"C#_LOGO_1.png"));
            //PictureBox pic = new PictureBox();
            //pic.Load(@"C:\Users\Дмитрий\Desktop\geekbrains\LOGO\C#_LOGO_1.png");
            //Icon x = new Icon();
            //this.Icon = Icon.ExtractAssociatedIcon(@"C:\Users\Дмитрий\Desktop\geekbrains\LOGO\C#_LOGO_1.png");

            //AutorPict.
            //AutorPict.Image = Image.FromFile(@"..\..\SD_250x250.png");
            
            AboutProgramRTF.LoadFile(@"..\..\Resources\About.xtf");
            var bmpSD = new Bitmap(Image.FromFile(@"..\..\SD_250x250.png"));
            this.Icon = Icon.FromHandle(bmpSD.GetHicon());

            //string str = "(;);?;^;C;<-;%;/;7;8;9;*;4;5;6;-;1;2;3;+;.;0;=;±"; //first variant 4x6
            string str = "C;(;);<-;7;8;9;/;4;5;6;*;1;2;3;-;.;0;=;+"; //second variant 4x5
            string[] ButtonCalcsNames;
            ButtonCalcsNames = str.Split(';');
            ButtonCalcs = new Button[ButtonCalcsNames.Length];

            int KoefH = (CalculatorPage.Height - CalculatorTextBox.Top -
                CalculatorTextBox.Height) / cntButtonHeight,
                KoefW = CalculatorPage.Width / cntButtonWidth;

            for (int i = 0; i < ButtonCalcs.Length; i++)
            {
                ButtonCalcs[i] = new Button()
                {
                    //Width = 30,
                    //Left = (i % 4) * 30,
                    //Height = 30,
                    //Top = (i / cntButtonWidth) * 30 + CalculatorTextBox.Top + CalculatorTextBox.Height,

                    Height = KoefH,
                    Top = (i / cntButtonWidth) * KoefH +
                    CalculatorTextBox.Top + CalculatorTextBox.Height,

                    Width = KoefW,
                    Left = KoefW * (i % cntButtonWidth),
                    
                    Text = ButtonCalcsNames[i],
                    Name = "button" + $"i",
                };

                ButtonCalcs[i].Click += Btn_Calc_Click;
            //    ButtonCalcs[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            //| System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            //ButtonCalcs[i].UseVisualStyleBackColor = true;
                ButtonCalcs[i].Show();
                CalculatorPage.Controls.Add(ButtonCalcs[i]);

            }
            this.ResizeEnd += Clc_Resize;
            CalculatorTextBox.KeyUp += Clc_txtBox_KeyUp;
            //Switcher.Hide();
            //CalculatorTextBox.Hide();
            //Editor.Hide();
            EditorSaveFileDialog.RestoreDirectory = true;
        }

        private void ErrorsMessage(string txt)
        {
            MessageBox.Show(txt, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        int RangOperand(string op)
        {
            switch (op)
            {
                case "(":
                    return 0;
                case ")":
                    return 1;
                case "+":
                case "-":
                    return 2;
                case "*":
                case "/":
                case "%":
                    return 3;
                default:
                    return -1;
            }
        }

        private string CalculateModule(string txt)
        {
            bool isNum = false, isOp = false, isFl = false;
            double num = 0, delit = 1, pow = 1;
            string answer = string.Empty, errAns = "ERROR";
            Stack<double> StNums = new Stack<double>();
            Stack<string> StOper = new Stack<string>();

            for (int i = 0; i < txt.Length; i++)
            {
                switch (txt[i])
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        isOp = false;
                        if (isNum && num == 0 && !isFl && txt[i - 1] == 0)
                        {
                            ErrorsMessage("Запись числа: число начинается " +
                                "с 0.\nПрограмма продолжит выполнение.");
                        }
                        if (isFl)
                            delit *= 10;
                        num = num * 10 + txt[i] - '0';
                        isNum = true;
                        isOp = false;
                        break;
                    case '.':
                    case ',':
                        if (!isFl && isNum)
                            isFl = true;
                        else
                        {
                            ErrorsMessage("Неправильная запись числа с" +
                                "плавающей точкой.");
                            return errAns;
                        }
                        break;
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '%':
                    case ')':
                        int rg = RangOperand(txt[i].ToString());
                        
                        if (isOp)
                        {
                            if (txt[i] == '-')
                            {
                                pow = -1;
                                break;
                            }
                            else if (txt[i] != ')')
                            {
                                ErrorsMessage("Выражение должно начинаться с числа.");
                                return errAns;
                            }
                        }

                        if (isNum)
                        {
                            num = num * pow / delit;
                            StNums.Push(num);
                            isNum = false;
                            isFl = false;
                        }

                        try
                        {
                            int rgPrevOper = RangOperand(StOper.Peek());

                            while (rgPrevOper >= rg)
                            {
                                try
                                {
                                    delit = StNums.Pop();
                                    num = StNums.Pop();
                                }
                                catch (InvalidOperationException)
                                {
                                    ErrorsMessage("Нет чисел.");
                                    return errAns;
                                }

                                switch (StOper.Pop())
                                {
                                    case "+":
                                        StNums.Push(num + delit);
                                        break;
                                    case "-":
                                        StNums.Push(num - delit);
                                        break;
                                    case "*":
                                        StNums.Push(num * delit);
                                        break;
                                    case "/":
                                        if (delit == 0)
                                        {
                                            ErrorsMessage("Деление на 0.");
                                            return errAns;
                                        }
                                        StNums.Push(num / delit);
                                        break;
                                    case "%":
                                        if (delit == 0)
                                        {
                                            ErrorsMessage("Остаток от деления на 0.");
                                            return errAns;
                                        }
                                        StNums.Push(num % delit);
                                        break;
                                    default:
                                        ErrorsMessage("Введено не число, не знак и не скобки.");
                                        return errAns;
                                }
                                rgPrevOper = RangOperand(StOper.Peek());
                            }
                        }
                        catch (InvalidOperationException)
                        {
                        }
                        
                        num = 0;
                        pow = 1;
                        delit = 1;

                        if (txt[i] != ')')
                        {
                            StOper.Push(txt[i].ToString());
                            isOp = true;
                        }
                        else
                            try
                            {
                                string ops = StOper.Pop();
                                if (ops != "(")
                                {
                                    ErrorsMessage("Нарушение алгоритма.");
                                    return errAns;
                                }
                            }
                            catch (InvalidOperationException)
                            {
                                ErrorsMessage("')' раньше '('.");
                                return errAns;
                            }
                            
                        break;
                    case '(':
                        StOper.Push("(");
                        break;
                    case ' ':
                        /*
                        isFl = false;
                        isNum = false;
                        isOp = false;
                        num = 0;
                        delit = 1;
                        pow = 1;
                        */
                        break;
                    default:
                        ErrorsMessage("Введено не число, не знак и не скобки.");
                        return errAns;
                }
            }
            try
            {
                answer = StNums.Pop().ToString();
            }
            catch (InvalidOperationException)
            {
                ErrorsMessage("Нет чисел.");
                return errAns;
            }


            try
            {
                answer = StNums.Pop().ToString();
                ErrorsMessage("Между числами не хватает операций.");
                return errAns;
            }
            catch (InvalidOperationException)
            {
            }


            StOper.Clear();
            StNums.Clear();
            return answer;
        }

        private void Clc_txtBox_KeyUp(object sender, KeyEventArgs e)
        {
            //throw new NotImplementedException();
            return;
            switch ((char)e.KeyValue)
            {
                case 'C':
                    CalculatorTextBox.Text = string.Empty;
                    break;
                case (char)8:
                    if (CalculatorTextBox.Text.Length > 0)
                        CalculatorTextBox.Text = CalculatorTextBox.Text.Substring(0,
                            CalculatorTextBox.Text.Length - 1);
                    break;
                case '?':
                    ErrorsMessage("Данная функция ещё не реализована.");
                    //throw new NotImplementedException();
                    break;
                case (char)13:
                case '=':
                    //ErrorsMessage("Данная функция ещё не реализована.");
                    //throw new NotImplementedException();
                    CalculatorTextBox.Text = CalculateModule($"({CalculatorTextBox.Text})").ToString();
                    break;

                //default:
                //    CalculatorTextBox.Text += (int)e.KeyValue;
                //    break;
            }
            if (!(('0' <= (char)e.KeyValue && (char)e.KeyValue <= '9')/*|| ( && '0' <= (char)e.KeyValue && (char)e.KeyValue <= '9')*/))
            {
                if (CalculatorTextBox.Text.Length > 0)
                    CalculatorTextBox.Text = CalculatorTextBox.Text.Substring(0,
                        CalculatorTextBox.Text.Length - 1);
            }
            
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Button btn = (sender as Button);

            switch (btn.Text)
            {
                case "C":
                    CalculatorTextBox.Text = string.Empty;
                    break;
                case "<-":
                    if (CalculatorTextBox.Text.Length > 0)
                        CalculatorTextBox.Text = CalculatorTextBox.Text.Substring(0,
                            CalculatorTextBox.Text.Length - 1);
                    break;
                case "?":
                    ErrorsMessage("Данная функция ещё не реализована.");
                    //throw new NotImplementedException();
                    break;
                case "=":
                    //ErrorsMessage("Данная функция ещё не реализована.");
                    //throw new NotImplementedException();
                    CalculatorTextBox.Text = CalculateModule($"({CalculatorTextBox.Text})").ToString();
                    //CalculatorTextBox.Text = CalculateModule($"(10 * (1 + 2) / 0)").ToString();

                    break;
                default:
                    CalculatorTextBox.Text += btn.Text[0];
                    break;
            }
        }
        
        /// <summary>
        /// Обработчик события растяжения окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clc_Resize(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            int KoefH = (CalculatorPage.Height - CalculatorTextBox.Top -
                CalculatorTextBox.Height) / cntButtonHeight,
                KoefW = CalculatorPage.Width / cntButtonWidth;

            for (int i = 0; i < ButtonCalcs.Length; i++)
            {
                ButtonCalcs[i].SetBounds(KoefW * (i % cntButtonWidth),
                    (i / cntButtonWidth) * KoefH +
                    CalculatorTextBox.Top + CalculatorTextBox.Height,
                    KoefW, KoefH);
            }

        }

        #region Обработчики EditorToolStrip
 
        /// <summary>
        /// Обработчик события "О программе" в выпадающем меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfToolStrip_Click(object sender, EventArgs e)
        {
            Switcher.SelectTab(Switcher.TabCount - 1);
        }

        /// <summary>
        /// Обработчик события "Сохранить" в выпадающем меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveStripMenu_Click(object sender, EventArgs e)
        {
            try
            {
                EditorSaveFileDialog.Filter = "Текстовые документы | *.txt";
                EditorSaveFileDialog.ShowDialog();
                var FlNm = EditorSaveFileDialog.FileName;
                var x = new StreamWriter(EditorSaveFileDialog.OpenFile());

                x.Write(Editor.Text);
                x.Close();
            }
            catch (Exception)
            {
                
            }
            //var FlPth = EditorSaveFileDialog.;
            //var Fl = EditorSaveFileDialog.;

        }

        /// <summary>
        /// Обработчик события "Открыть" в выпадающем меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenStripMenu_Click(object sender, EventArgs e)
        {
            try
            {
                EditorOpenFileDialog.Filter = "Текстовые документы | *.txt";
                EditorOpenFileDialog.FileName = string.Empty;
                EditorOpenFileDialog.ShowDialog();
                var x = new StreamReader(EditorOpenFileDialog.OpenFile());

                Editor.Text = x.ReadToEnd();
                x.Close();
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Обработчик события "Выход" в выпадающем меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseStripMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
