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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        static float[,] matrix;
        static int m, n;
        static int endX, endY;

        public string fileName { get; set; }
        public int cleatTexts { get; set; }
        public Form1()
        {
            InitializeComponent();
            cleatTexts = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "txt File |*.txt";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    fileName = fd.FileName;
                    locationName.Text = fileName;
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleatTexts++;
            if (cleatTexts > 1)
            {
                richMatrix.Clear();
                richGraph.Clear();
            }
            try
            {
                // Giving Value for Start Index
                string startIndexString = StartIndex.Text;
                string[] words = startIndexString.Split(',');
                int startX = int.Parse(words[0]);
                int startY = int.Parse(words[1]);

                //Giving Value for End Index
                string endIndexString = EndIndex.Text;
                string[] words2 = endIndexString.Split(',');
                endX = int.Parse(words2[0]);
                endY = int.Parse(words2[1]);



                // Reading Matrix from TXT file
                string content = File.ReadAllText(fileName);

                string[] listarray = content.Split(';');

                m = listarray.Length - 1;
                n = listarray[0].Split(' ').Length;

                matrix = new float[m, n];


                for (int i = 0; i < m; i++)
                {
                    string[] list = listarray[i].Trim().Split();
                    int l = list.Length;
                    for (int j = 0; j < l; j++)
                    {
                        matrix[i, j] = float.Parse(list[j]);
                    }
                }

                // Showing Matrix
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        richMatrix.AppendText(" " + matrix[i, j]);
                    }
                    richMatrix.Text += Environment.NewLine + "";
                }

                int[,] register = make_zero_register_matrix(m, n);
                position end = move(startX, startY, register);

                // Cheapest Path
                for (int k = 0; k < m; k++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (end.register[k, l] == 0) richGraph.AppendText("- ");
                        else richGraph.AppendText("+ ");
                    }
                    richGraph.Text += Environment.NewLine + "";
                }

                double result = end.subtotal - end.last_item - matrix[0, 0];    // Here is showing Result of Total Matrix
                // total
                total.Text = "Total is : " + result;
            }
            catch (ArgumentNullException e1)
            {
                MessageBox.Show("Please choose Matrix file ");
            }
            catch (FormatException e2)
            {
                MessageBox.Show("Please write START INDEX MATRIX and END INDEX MATRIX");
            }
            catch (IndexOutOfRangeException e3)
            {
                MessageBox.Show("Please write START INDEX MATRIX & END INDEX MATRIX Correctly");
            }
            catch
            {
                MessageBox.Show("Please write START INDEX MATRIX & END INDEX MATRIX Correctly");
            }


        }


        public static int[,] make_zero_register_matrix(int i, int j)
        {
            int[,] register = new int[i, j];
            for (int k = 0; k < i; k++)
            {
                for (int l = 0; l < j; l++)
                {
                    register[k, l] = 0;
                }
            }
            return register;
        }

        static position move(int i, int j, int[,] register)
        {
            position pos = null;
            int[,] reg;
            position[] movement;
            int movNumber;

            if (register[i - 1, j - 1] == 1) return null;
            if (i == endX && j == endY)
            {
                pos = new position();
                pos.subtotal = matrix[i - 1, j - 1];
                pos.register = make_zero_register_matrix(m, n);
                pos.register[i - 1, j - 1] = 1;
                pos.last_item = pos.subtotal;
                return pos;
            }


            reg = new int[m, n];
            Array.Copy(register, 0, reg, 0, register.Length);
            reg[i - 1, j - 1] = 1;

            if (i == 1 && j == 1)
            {
                movement = new position[3];
                movement[0] = move(i, j + 1, reg);
                movement[1] = move(i + 1, j + 1, reg);
                movement[2] = move(i + 1, j, reg);
                movNumber = 3;
            }
            else
                if (i == 1 && j == n)
                {
                    movement = new position[3];
                    movNumber = 3;
                    movement[0] = move(i + 1, j, reg);
                    movement[1] = move(i + 1, j - 1, reg);
                    movement[2] = move(i, j - 1, reg);
                }
                else
                    if (i == m && j == n)
                    {
                        movement = new position[3];
                        movement[0] = move(i, j - 1, reg);
                        movement[1] = move(i - 1, j - 1, reg);
                        movement[2] = move(i - 1, j, reg);
                        movNumber = 3;
                    }
                    else
                        if (i == m && j == 1)
                        {
                            movement = new position[3];
                            movNumber = 3;
                            movement[0] = move(i, j + 1, reg);
                            movement[1] = move(i - 1, j + 1, reg);
                            movement[2] = move(i - 1, j, reg);
                        }
                        else
                            if (i == 1)
                            {
                                movement = new position[5];
                                movement[0] = move(i, j + 1, reg);
                                movement[1] = move(i + 1, j + 1, reg);
                                movement[2] = move(i + 1, j, reg);
                                movement[3] = move(i + 1, j - 1, reg);
                                movement[4] = move(i, j - 1, reg);
                                movNumber = 5;
                            }
                            else
                                if (i == m)
                                {
                                    movement = new position[5];
                                    movement[0] = move(i - 1, j - 1, reg);
                                    movement[1] = move(i - 1, j, reg);
                                    movement[2] = move(i - 1, j + 1, reg);
                                    movement[3] = move(i, j + 1, reg);
                                    movement[4] = move(i, j - 1, reg);
                                    movNumber = 5;
                                }
                                else
                                    if (j == 1)
                                    {
                                        movement = new position[5];
                                        movement[0] = move(i - 1, j, reg);
                                        movement[1] = move(i - 1, j + 1, reg);
                                        movement[2] = move(i, j + 1, reg);
                                        movement[3] = move(i + 1, j + 1, reg);
                                        movement[4] = move(i + 1, j, reg);
                                        movNumber = 5;
                                    }
                                    else
                                        if (j == n)
                                        {
                                            movement = new position[5];
                                            movement[0] = move(i - 1, j - 1, reg);
                                            movement[1] = move(i - 1, j, reg);
                                            movement[2] = move(i + 1, j, reg);
                                            movement[3] = move(i + 1, j - 1, reg);
                                            movement[4] = move(i, j - 1, reg);
                                            movNumber = 5;
                                        }
                                        else
                                        {
                                            movement = new position[8];
                                            movement[0] = move(i - 1, j - 1, reg);
                                            movement[1] = move(i - 1, j, reg);
                                            movement[2] = move(i - 1, j + 1, reg);
                                            movement[3] = move(i, j + 1, reg);
                                            movement[4] = move(i + 1, j + 1, reg);
                                            movement[5] = move(i + 1, j, reg);
                                            movement[6] = move(i + 1, j - 1, reg);
                                            movement[7] = move(i, j - 1, reg);
                                            movNumber = 8;
                                        }


            for (int k = 0; k < movNumber; k++)
            {
                if (movement[k] != null)
                {
                    if (pos == null)
                    {
                        pos = new position();
                        pos = movement[k];
                    }
                    else
                    {
                        if (pos.subtotal > movement[k].subtotal)
                            pos = movement[k];
                    }
                }
            }

            if (pos != null)
            {
                pos.subtotal += matrix[i - 1, j - 1];
                pos.register[i - 1, j - 1] = 1;
            }
            return pos;
        }
        

      
    }

    class position
    {
        public int[,] register;
        public float subtotal = 0;
        public float last_item;
    }  
}
