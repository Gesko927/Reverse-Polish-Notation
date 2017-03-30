using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandInputFunction
{
    

    class Function
    {
        string str;
        double result;
        string polish;

        private SortedSet<string> operators;
        private SortedSet<string> functions;

        private Stack<double> calculation;
        private Stack<string> expression;

        private List<string> values;

        public Function()
        {
            str = String.Empty;
            result = -1;
            polish = String.Empty;

            operators = new SortedSet<string>();
            functions = new SortedSet<string>();

            calculation = new Stack<double>();
            expression = new Stack<string>();

            values = new List<string>();

            operators.Add("+");
            operators.Add("-");
            operators.Add("*");
            operators.Add("/");
            operators.Add("^");

        }

        /**Редагування у польський запис
         * ------------------------------------------------------
         * аргументи: вхідна стрічка(вираз)
         * результат: вираз в польському записі
         * ------------------------------------------------------
         * 
         */
        public string ToPolish(string ex)
        {
            polish = null;

            string[] str = ex.Split(' ');

            foreach(string temp in str)
            {
                bool isCanBeValue = true;
                bool isValue = false;

                #region Змінні
                foreach (char ch in temp)
                {
                    if (Char.IsDigit(ch))
                    {
                        polish += ch;

                        isCanBeValue = false;
                    }

                    if (Char.IsLetter(ch))
                    {
                        try
                        {
                            if (isCanBeValue)
                            {
                                polish += ch;
                                isValue = true;
                            }
                            else
                            {
                                throw new Exception($"{temp} is invalid operand");
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                    }
                }

                polish += " ";

                if (isValue)
                {
                    values.Add(temp);
                }

                #endregion

                if(temp == "(")
                {
                    expression.Push(temp);

                    polish += " ";
                }

                if(temp == ")")
                {
                        while(true)
                        {
                            try
                            {
                                string c = expression.Pop();
                        
                                if (c == "(")
                                {
                                    break;
                                }
                                else
                                {
                                    polish += c + " ";
                                }
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.ToString());
                                Environment.Exit(0);
                            }
                        }
                }

                if(operators.Contains(temp))
                {
                    try
                    {
                        while (expression.Count != 0 && operatorsPrior(temp) <= operatorsPrior(expression.Peek()))
                        {
                            polish += expression.Pop() + " ";
                        }

                        expression.Push(temp);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                        Environment.Exit(0);
                    }
                }
            }

            while(expression.Count != 0)
            {
                try
                {
                    string c = expression.Pop();

                    if (operators.Contains(c))
                    {
                        polish += c + " ";
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    Environment.Exit(0);
                }
            }
            return polish;
        }

        /**Результат обчислення
         * ------------------------------------------------------
         * аргументи: стрічка з польським записом
         * результат: число обчислення
         * ------------------------------------------------------
         * 
         */
        public double Result(string inputString)
        {

            for (int i = 0; i < inputString.Length; ++i)
            {
                if (Char.IsDigit(inputString[i]))
                {
                    calculation.Push(int.Parse(inputString[i].ToString()));
                }

                if (operators.Contains(inputString[i].ToString()))
                {
                    double a = calculation.Pop();
                    double b = calculation.Pop();

                    switch (inputString[i])
                    {
                        case '+':
                            {
                                calculation.Push(b + a);
                            }
                            break;

                        case '-':
                            {
                                calculation.Push(b - a);
                            }
                            break;

                        case '*':
                            {
                                calculation.Push(b * a);
                            }
                            break;
                        case '/':
                            {
                                try
                                {
                                    if (a == 0.0)
                                    {
                                        throw new DivideByZeroException();
                                    }
                                    else
                                    {
                                        calculation.Push(b / a);
                                    }
                                }
                                catch(DivideByZeroException e)
                                {
                                    MessageBox.Show(e.ToString());
                                }
                            }
                            break;

                        case '^':
                            {
                                calculation.Push(Math.Pow(b, a));
                            }
                            break;
                    }
                }
            }

            try
            {
                result = calculation.Pop();         
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return result;
        }

        /**Пріоритети операцій
         * ------------------------------------------------------
         * аргументи: стрічка, яка містить в собі операцію
         * результат: пріоритет
         * ------------------------------------------------------
         * Чим більший пріоритет, тим більше число
         */
        private Int32 operatorsPrior(string c)
        {
            int result = 0;

            switch(c)
            {
                case "+": case "-":
                    {
                        result = 1;
                    } break;

                case "*": case "/":
                    {
                        result = 2;
                    } break;

                case "^":
                    {
                        result = 3;
                    } break;

                default:
                    {
                        result = 0;
                    } break;
            }

            return result;
        }

        /**Перевірка коректності вводу виразу
         * Перевіряємо правильність
         * розташування дужок
         * ------------------------------------------------------
         * аргументи: вхідна стрічка, яка містить в собі вираз
         * результат: true - правильно розставленні дужки
         *            false - не правильно розставленні дужки 
         * ------------------------------------------------------
         * 
         */
        public bool IsRightDugki(string s)
        {
            int countOpen = 0;
            bool result = true;

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '(')
                {
                    countOpen++;
                }
                if (s[i] == ')')
                {
                    countOpen--;
                }
            }

            if (countOpen != 0)
            {
                result = false;
            }

            return result;
        }

        /**Розставлення прбілів міжж операціями і операндами
         * для коректного редагування в польський запис двоцифрових чисел
         * і інших додаткових функцій
         * ------------------------------------------------------
         * аргументи: вхідна стрічка, яка містить вираз
         * результат: вираз з розділеними операціями і операндами
         * ------------------------------------------------------
         * 
         */
        public string StrWithWhitespaces(string inputString)
        {
            String outString = String.Empty;

            for (int i = 0; i < inputString.Length; ++i)
            {
                if (Char.IsDigit(inputString[i]) || inputString[i] == '.' || inputString[i] == ',')
                {
                    outString += inputString[i];
                }
                else if (Char.IsLetter(inputString[i]))
                {
                    outString += inputString[i];
                }
                else if (inputString[i] == '(')
                {
                    outString += inputString[i].ToString() + ' ';
                }
                else if (inputString[i] == ')')
                {
                    outString += ' ' + inputString[i].ToString();
                }
                else
                {
                    outString += ' ' + inputString[i].ToString() + ' ';
                }
            }

            return outString;
        }


    }
}

