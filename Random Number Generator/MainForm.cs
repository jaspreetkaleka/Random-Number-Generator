using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RandomNumberGenerator.Classes;

namespace RandomNumberGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var start = (int) Math.Floor(rsNnumericUpDown.Value);
                var end = (int) Math.Floor(reNnumericUpDown.Value);

                if (start >= end)
                {
                    throw new Exception("Range start value must be less than the end value.");
                }

                var rows = (int) Math.Floor(rowsNumericUpDown.Value);
                var cols = (int) Math.Floor(colsNumericUpDown.Value);
                var samples = rows * cols;

                var randomIntegerValues = new List<int>();
                var randomDecimalValues = new List<double>();

                switch (algoComboBox.SelectedIndex)
                {
                    case 0: // Simple

                        var r = new Random();

                        if (integersRadioButton.Checked)
                        {
                            for (var i = 0; i < samples; i++)
                            {
                                randomIntegerValues.Add(r.Next(start, end));
                            }
                        }
                        else
                        {
                            for (var i = 0; i < samples; i++)
                            {
                                randomDecimalValues.Add(start + end * r.NextDouble());
                            }
                        }

                        break;

                    case 1: // Gaussian

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end *
                                                    Rng.GetNormal((double) value1NnumericUpDown.Value,
                                                        (double) value2NnumericUpDown.Value));
                        }

                        break;

                    case 2: // Exponential

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end * Rng.GetExponential((double) value1NnumericUpDown.Value));
                        }

                        break;

                    case 3: // Gamma

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end *
                                                    Rng.GetGamma((double) value1NnumericUpDown.Value,
                                                        (double) value2NnumericUpDown.Value));
                        }

                        break;

                    case 4: // Inverse Gamma

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end *
                                                    Rng.GetInverseGamma((double) value1NnumericUpDown.Value,
                                                        (double) value2NnumericUpDown.Value));
                        }

                        break;

                    case 5: // Weibull

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end *
                                                    Rng.GetWeibull((double) value1NnumericUpDown.Value,
                                                        (double) value2NnumericUpDown.Value));
                        }

                        break;

                    case 6: // Cauchy

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end *
                                                    Rng.GetCauchy((double) value1NnumericUpDown.Value,
                                                        (double) value2NnumericUpDown.Value));
                        }

                        break;

                    case 7: // Laplace

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end *
                                                    Rng.GetLaplace((double) value1NnumericUpDown.Value,
                                                        (double) value2NnumericUpDown.Value));
                        }

                        break;

                    case 8: // Log Normal

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end *
                                                    Rng.GetLogNormal((double) value1NnumericUpDown.Value,
                                                        (double) value2NnumericUpDown.Value));
                        }

                        break;

                    case 9: // Beta

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end *
                                                    Rng.GetBeta((double) value1NnumericUpDown.Value,
                                                        (double) value2NnumericUpDown.Value));
                        }

                        break;

                    case 10: // Chi Square

                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start +
                                                    end * Rng.GetChiSquare((double) value1NnumericUpDown.Value));
                        }

                        break;

                    case 11: // Student's t
                        for (var i = 0; i < samples; i++)
                        {
                            randomDecimalValues.Add(start + end * Rng.GetStudentT((double) value1NnumericUpDown.Value));
                        }

                        break;

                    default:
                        throw new Exception("Unknown Algorithm");
                }

                var rStr = new StringBuilder();

                if (integersRadioButton.Checked)
                {
                    if (algoComboBox.SelectedIndex == 0)
                    {
                        var count = 0;
                        for (var r = 0; r < rows; r++)
                        {
                            for (var c = 0; c < cols; c++)
                            {
                                rStr.Append(randomIntegerValues[count] + "\t");
                                count++;
                            }

                            rStr.AppendLine();
                        }
                    }
                    else
                    {
                        var count = 0;
                        for (var r = 0; r < rows; r++)
                        {
                            for (var c = 0; c < cols; c++)
                            {
                                rStr.Append(Math.Round(randomDecimalValues[count]).ToString("0") + "\t");
                                count++;
                            }

                            rStr.AppendLine();
                        }
                    }
                }
                else
                {
                    var count = 0;
                    for (var r = 0; r < rows; r++)
                    {
                        for (var c = 0; c < cols; c++)
                        {
                            rStr.Append(randomDecimalValues[count].ToString("0.00") + "\t");
                            count++;
                        }

                        rStr.AppendLine();
                    }
                }

                Clipboard.SetText(rStr.ToString());
                MessageBox.Show(@"Data copied to Clipboard", @"Done!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message, @"Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void algoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (algoComboBox.SelectedIndex)
            {
                case 0: // Simple
                    value1NnumericUpDown.Enabled = false;
                    value2NnumericUpDown.Enabled = false;
                    value1Label.Text = @"NA";
                    value2Label.Text = @"NA";
                    break;

                case 1: // Gaussian
                case 8: // Log Normal
                    value1NnumericUpDown.Enabled = true;
                    value2NnumericUpDown.Enabled = true;
                    value1NnumericUpDown.Value = 0;
                    value2NnumericUpDown.Value = 1;
                    value1Label.Text = @"Mean";
                    value2Label.Text = @"Std. Dev.";
                    break;

                case 2: // Exponential
                    value1NnumericUpDown.Enabled = true;
                    value2NnumericUpDown.Enabled = false;
                    value1NnumericUpDown.Value = 1;
                    value1Label.Text = @"Mean";
                    value2Label.Text = @"NA";
                    break;

                case 3: // Gamma
                case 4: // Inverse Gamma
                case 5: // Weibull
                    value1NnumericUpDown.Enabled = true;
                    value2NnumericUpDown.Enabled = true;
                    value1Label.Text = @"Shape";
                    value2Label.Text = @"Scale";
                    break;

                case 6: // Cauchy
                    value1NnumericUpDown.Enabled = true;
                    value2NnumericUpDown.Enabled = true;
                    value1Label.Text = @"Median";
                    value2Label.Text = @"Scale";
                    break;

                case 7: // Laplace
                    value1NnumericUpDown.Enabled = true;
                    value2NnumericUpDown.Enabled = true;
                    value1Label.Text = @"Mean";
                    value2Label.Text = @"Scale";
                    break;

                case 9: // Beta
                    value1NnumericUpDown.Enabled = true;
                    value2NnumericUpDown.Enabled = true;
                    value1Label.Text = @"a";
                    value2Label.Text = @"b";
                    break;

                case 10: // Chi Square
                case 11: // Student's t
                    value1NnumericUpDown.Enabled = true;
                    value2NnumericUpDown.Enabled = false;
                    value1Label.Text = @"Deg. of Freedom";
                    value2Label.Text = @"NA";
                    break;

                default:
                    value1NnumericUpDown.Enabled = false;
                    value2NnumericUpDown.Enabled = false;
                    value1Label.Text = @"NA";
                    value2Label.Text = @"NA";
                    break;
            }
        }
    }
}